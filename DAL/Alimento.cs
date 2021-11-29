using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace TCC.DAL
{
    public class Alimento
    {
        private static SQLiteConnection sqliteConnection;

        private SQLiteConnection GetConnection()
        {
            sqliteConnection = new SQLiteConnection(DAL.Connection.Settings.StringConnection);
            sqliteConnection.Open();
            return sqliteConnection;
        }


        public List<Models.InputModel.Alimento> BuscarAlimentosPorNome(string nomeAlimento)
        {
            string query = $@"Select * from Alimento a where a.Nome like '%{nomeAlimento}%' and a.ativo = 1";

            using (var connection = GetConnection())
            {
                return connection.Query<Models.InputModel.Alimento>(query).ToList();
            }
        }
    }
}
