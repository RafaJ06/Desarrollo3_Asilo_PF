using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Asilo.Core.Entities;
using Asilo.Core.Interfaces;

namespace Asilo.Integracion_Servidor.Repositories
{
    public class SqlMovimientoRepository : IMovimientoRepository
    {
        private readonly string _connectionString;

        public SqlMovimientoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // --- GUARDAR MOVIMIENTO (Corregido según tu Entidad) ---
        public void Add(Movimiento movimiento)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // QUERY AJUSTADO: Usamos CuentaId, Tipo y Detalles
                string query = @"INSERT INTO Movimientos (CuentaId, Monto, Fecha, Tipo, Detalles) 
                                 VALUES (@CuentaId, @Monto, @Fecha, @Tipo, @Detalles)";

                using (var cmd = new SqlCommand(query, conn))
                {
                    // Mapeo exacto de tus propiedades:
                    cmd.Parameters.AddWithValue("@CuentaId", movimiento.CuentaId);
                    cmd.Parameters.AddWithValue("@Monto", movimiento.Monto);
                    cmd.Parameters.AddWithValue("@Fecha", movimiento.Fecha);
                    cmd.Parameters.AddWithValue("@Tipo", movimiento.Tipo); // "CARGO", "PAGO", etc.
                    cmd.Parameters.AddWithValue("@Detalles", movimiento.Detalles ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // --- BUSCAR POR CUENTA (Ahora sí podemos implementarlo real) ---
        public IEnumerable<Movimiento> GetByCuenta(int cuentaId)
        {
            var lista = new List<Movimiento>();

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT Id, CuentaId, Monto, Fecha, Tipo, Detalles FROM Movimientos WHERE CuentaId = @CuentaId";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CuentaId", cuentaId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Movimiento
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                CuentaId = Convert.ToInt32(reader["CuentaId"]),
                                Monto = Convert.ToDecimal(reader["Monto"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Tipo = reader["Tipo"].ToString(),
                                Detalles = reader["Detalles"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }

        // --- STUBS ---
        public void Delete(int id) => throw new NotImplementedException();
        public void Update(Movimiento entity) => throw new NotImplementedException();
        public IEnumerable<Movimiento> GetAll() => throw new NotImplementedException();
        public Movimiento GetById(int id) => throw new NotImplementedException();
    }
}