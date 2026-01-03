using Microsoft.AspNetCore.Mvc;
using Asilo.Core.Entities;
using Asilo.Core.Interfaces;

namespace Asilo.Integracion_Servidor.Controllers
{
    [Route("api/[controller]")] // URL será: api/transacciones
    [ApiController]
    public class TransaccionesController : ControllerBase
    {
        private readonly IMovimientoRepository _movimientoRepo;
        private readonly ICuentaRepository _cuentaRepo;
        private readonly IAuditRepository _auditRepo;

        // El servidor nos pasa los repositorios automáticamente
        public TransaccionesController(IMovimientoRepository movRepo, ICuentaRepository ctaRepo, IAuditRepository auditRepo)
        {
            _movimientoRepo = movRepo;
            _cuentaRepo = ctaRepo;
            _auditRepo = auditRepo;
        }

        // POST: api/transacciones/cobrar
        // La Caja llamará aquí enviando el movimiento
        [HttpPost("cobrar")]
        public IActionResult Cobrar([FromBody] Movimiento movimiento)
        {
            try
            {
                // 1. Validar que la cuenta existe
                var cuenta = _cuentaRepo.GetById(movimiento.CuentaId);
                if (cuenta == null) return BadRequest($"La cuenta ID {movimiento.CuentaId} no existe.");

                // 2. Guardar el movimiento
                _movimientoRepo.Add(movimiento);

                // 3. Actualizar el saldo de la cuenta
                if (movimiento.Tipo == "PAGO")
                    cuenta.Balance -= movimiento.Monto; // Si paga, debe menos
                else
                    cuenta.Balance += movimiento.Monto; // Si consume, debe más

                _cuentaRepo.Update(cuenta);

                // 4. Auditoría (Requisito PDF)
                _auditRepo.Log(new AuditRecord
                {
                    Usuario = "CajeroAPI", // Aquí podrías recibir el usuario real si quisieras
                    Accion = "Transacción",
                    Detalles = $"Monto: {movimiento.Monto}, Tipo: {movimiento.Tipo}",
                    Timestamp = DateTime.UtcNow
                });

                return Ok(new { mensaje = "Transacción exitosa", nuevoSaldo = cuenta.Balance });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }
    }
}