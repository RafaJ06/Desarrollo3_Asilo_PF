using System;
using System.Collections.Generic; // Necesario para IEnumerable
using System.Data.SqlClient;
using Asilo.Core.Entities;
using Asilo.Core.Interfaces;

namespace Asilo.Integracion_Servidor.Repositories
{
    public class SqlUsuarioRepository : IUsuarioRepository
    {
        private readonly string _connectionString;

        public SqlUsuarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // --- LOGIN / BUSCAR POR USUARIO ---
        public Usuario GetByUsername(string username)
        {
            Usuario usuarioEncontrado = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // Asegúrate que en SQL las columnas coincidan. Asumo RolId es INT.
                string query = "SELECT IdUsuario, NombreUsuario, Clave, RolId FROM Usuarios WHERE NombreUsuario = @user";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user", username);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioEncontrado = new Usuario
                            {
                                Id = Convert.ToInt32(reader["IdUsuario"]),
                                Username = reader["NombreUsuario"].ToString(),
                                PasswordHash = reader["Clave"].ToString(),
                                RolId = Convert.ToInt32(reader["RolId"])
                            };
                        }
                    }
                }
            }
            return usuarioEncontrado;
        }

        // --- MÉTODOS OBLIGATORIOS ---

        public void Add(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario entity)
        {
            throw new NotImplementedException();
        }

        // AQUÍ ESTABA EL ERROR: Cambiamos List<Usuario> por IEnumerable<Usuario>
        public IEnumerable<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}