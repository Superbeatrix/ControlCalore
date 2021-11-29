using System.Data.SQLite;
using Dapper;

namespace TCC.DAL
{
    public class Usuario
    {
        private static SQLiteConnection sqliteConnection;

        private SQLiteConnection GetConnection()
        {
            sqliteConnection = new SQLiteConnection(DAL.Connection.Settings.StringConnection);
            sqliteConnection.Open();
            return sqliteConnection;
        }


        public long Cadastrar(Models.InputModel.Usuario usuario)
        {
            string query = $@"Insert into Usuario (Nome, DataNascimento, Email, Senha, QtdCaloriasDiarias, QtdCaloriasSemanais) 
                                values ('{usuario.Nome}', '{usuario.DataNascimento.ToString("yyyy-MM-dd")}', '{usuario.Email}', '{usuario.Senha}', {usuario.QtdCaloriasDiarias}, {usuario.QtdCaloriasSemanais});
                                SELECT last_insert_rowid(); --Para SQLite
                                ";

            using (var connection = GetConnection())
            {
                return connection.ExecuteScalar<long>(query);
            }
        }

        public Models.InputModel.Usuario ValidarUsuario(string email, string senha)
        {
            string query = $@"Select * from Usuario where Email = '{email}' and senha = '{senha}' and ativo = 1; SELECT last_insert_rowid(); --Para SQLite";

            using (var connection = GetConnection())
            {
                return connection.QueryFirstOrDefault<Models.InputModel.Usuario>(query);
            }
        }

        public Models.InputModel.Usuario BuscarPerfilUsuario(long usuarioId)
        {
            string query = $@"Select * from Usuario u where u.UsuarioId = {usuarioId} and u.ativo = 1";

            using (var connection = GetConnection())
            {
                return connection.QueryFirstOrDefault<Models.InputModel.Usuario>(query);
            }
        }

        public bool AtualizaDadosUsuario(Models.InputModel.Usuario usuario)
        {
            string query = $@"update Usuario set 
                                    Email = '{usuario.Email}', 
                                    Senha = '{usuario.Senha}', 
                                    QtdCaloriasDiarias = {usuario.QtdCaloriasDiarias}, 
                                    QtdCaloriasSemanais = {usuario.QtdCaloriasSemanais}  
                                where UsuarioId = {usuario.UsuarioId}";

            using (var connection = GetConnection())
            {
                return connection.Execute(query) > 0;
            }
        }

        public string GetNomeUsuario(long usuarioId)
        {
            string query = $@"Select u.Nome from usuario u where u.usuarioId = {usuarioId}";

            using (var connection = GetConnection())
            {
                return connection.QueryFirstOrDefault<string>(query);
            }
        }
    }
}
