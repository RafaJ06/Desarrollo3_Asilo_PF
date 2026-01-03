using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Asilo.Core.Entities;
using Asilo.Core.Interfaces;

namespace Asilo.Integracion_Servidor.Repositories
{
    public class SqlResidenteRepository : IResidenteRepository
    {
        private readonly string _connectionString;

        public SqlResidenteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // --- CREAR RESIDENTE (Ingreso) ---
        public void Add(Residente entity)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Residentes (Nombre, Documento, FechaNacimiento, EstadoSalud, HabitacionId) 
                                 VALUES (@Nombre, @Documento, @FechaNacimiento, @EstadoSalud, @HabitacionId)";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Documento", entity.Documento);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", entity.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@EstadoSalud", entity.EstadoSalud ?? (object)DBNull.Value);

                    // Manejo de nulo para HabitacionId
                    cmd.Parameters.AddWithValue("@HabitacionId", entity.HabitacionId ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // --- ACTUALIZAR DATOS (Ej: Cambia estado de salud) ---
        public void Update(Residente entity)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"UPDATE Residentes 
                                 SET Nombre = @Nombre, 
                                     Documento = @Documento, 
                                     FechaNacimiento = @FechaNacimiento, 
                                     EstadoSalud = @EstadoSalud, 
                                     HabitacionId = @HabitacionId 
                                 WHERE Id = @Id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Documento", entity.Documento);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", entity.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@EstadoSalud", entity.EstadoSalud ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@HabitacionId", entity.HabitacionId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id", entity.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // --- BUSCAR POR ID ---
        public Residente GetById(int id)
        {
            Residente residente = null;
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT Id, Nombre, Documento, FechaNacimiento, EstadoSalud, HabitacionId FROM Residentes WHERE Id = @Id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            residente = MapReaderToEntity(reader);
                        }
                    }
                }
            }
            return residente;
        }

        // --- BUSCAR POR DOCUMENTO (Requerimiento PDF Source 44) ---
        // Si tu interfaz IResidenteRepository pide este método, descomenta la línea de la interfaz y usa esto.
        public Residente GetByDocumento(string documento)
        {
            Residente residente = null;
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT Id, Nombre, Documento, FechaNacimiento, EstadoSalud, HabitacionId FROM Residentes WHERE Documento = @Doc";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Doc", documento);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            residente = MapReaderToEntity(reader);
                        }
                    }
                }
            }
            return residente;
        }

        // --- LISTAR TODOS (Para la Web) ---
        public IEnumerable<Residente> GetAll()
        {
            var lista = new List<Residente>();
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT Id, Nombre, Documento, FechaNacimiento, EstadoSalud, HabitacionId FROM Residentes";

                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(MapReaderToEntity(reader));
                        }
                    }
                }
            }
            return lista;
        }

        public void Delete(int id) => throw new NotImplementedException();

        // Helper para no repetir código de mapeo
        private Residente MapReaderToEntity(SqlDataReader reader)
        {
            return new Residente
            {
                Id = Convert.ToInt32(reader["Id"]),
                Nombre = reader["Nombre"].ToString(),
                Documento = reader["Documento"].ToString(),
                FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                EstadoSalud = reader["EstadoSalud"].ToString(),
                // Verificamos si es nulo en la BD
                HabitacionId = reader["HabitacionId"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["HabitacionId"])
            };
        }
    }
}