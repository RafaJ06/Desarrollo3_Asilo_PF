using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Asilo.Core.Entities;
using Asilo.Core.Interfaces;

namespace Asilo.Integracion_Servidor.Repositories
{
    public class SqlCuentaRepository : ICuentaRepository
    {
        private readonly string _connectionString;

        public SqlCuentaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // --- MÉTODO QUE FALTABA (Corregido: GetByResidente) ---
        public Cuenta GetByResidente(int residenteId)
        {
            Cuenta cuenta = null;
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                // Buscamos la cuenta que pertenezca a este residente
                string query = "SELECT Id, ResidenteId, Balance FROM Cuentas WHERE ResidenteId = @ResidenteId";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ResidenteId", residenteId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cuenta = new Cuenta
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                ResidenteId = Convert.ToInt32(reader["ResidenteId"]),
                                Balance = Convert.ToDecimal(reader["Balance"])
                            };
                        }
                    }
                }
            }
            return cuenta;
        }

        // --- MÉTODOS ESTÁNDAR ---

        public void Add(Cuenta entity)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Cuentas (ResidenteId, Balance) VALUES (@ResidenteId, @Balance)";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ResidenteId", entity.ResidenteId);
                    cmd.Parameters.AddWithValue("@Balance", entity.Balance);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Cuenta entity)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "UPDATE Cuentas SET Balance = @Balance WHERE Id = @Id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Balance", entity.Balance);
                    cmd.Parameters.AddWithValue("@Id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Cuenta GetById(int id)
        {
            Cuenta cuenta = null;
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT Id, ResidenteId, Balance FROM Cuentas WHERE Id = @Id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cuenta = new Cuenta
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                ResidenteId = Convert.ToInt32(reader["ResidenteId"]),
                                Balance = Convert.ToDecimal(reader["Balance"])
                            };
                        }
                    }
                }
            }
            return cuenta;
        }

        // --- STUBS ---
        public void Delete(int id) => throw new NotImplementedException();
        public IEnumerable<Cuenta> GetAll() => throw new NotImplementedException();
    }
}