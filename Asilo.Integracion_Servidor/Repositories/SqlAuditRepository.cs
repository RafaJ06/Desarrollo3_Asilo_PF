using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Asilo.Core.Entities;
using Asilo.Core.Interfaces;

namespace Asilo.Integracion_Servidor.Repositories
{
    public class SqlAuditRepository : IAuditRepository
    {
        private readonly string _connectionString;

        public SqlAuditRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // --- CORRECCIÓN: El método se llama "Log", no "Add" ---
        public void Log(AuditRecord entity)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO AuditLogs (Timestamp, Usuario, Accion, Detalles) 
                                 VALUES (@Timestamp, @Usuario, @Accion, @Detalles)";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Timestamp", entity.Timestamp);
                    cmd.Parameters.AddWithValue("@Usuario", entity.Usuario);
                    cmd.Parameters.AddWithValue("@Accion", entity.Accion);
                    cmd.Parameters.AddWithValue("@Detalles", entity.Detalles ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // --- STUBS OBLIGATORIOS (Si la interfaz hereda de IRepository) ---
        // Si tu IAuditRepository hereda de IRepository<AuditRecord>, 
        // te pedirá también estos métodos. 

        public void Add(AuditRecord entity)
        {
            // Si te pide Add, simplemente llamamos a Log para no repetir código
            Log(entity);
        }

        public void Delete(int id) => throw new NotImplementedException();
        public void Update(AuditRecord entity) => throw new NotImplementedException();
        public IEnumerable<AuditRecord> GetAll() => throw new NotImplementedException();
        public AuditRecord GetById(int id) => throw new NotImplementedException();
    }
}