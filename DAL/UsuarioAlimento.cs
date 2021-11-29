using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace TCC.DAL
{
    public class UsuarioAlimento
    {
        private static SQLiteConnection sqliteConnection;

        private SQLiteConnection GetConnection()
        {
            sqliteConnection = new SQLiteConnection(DAL.Connection.Settings.StringConnection);
            sqliteConnection.Open();
            return sqliteConnection;
        }


        public decimal GetCaloriasDiarias(long usuarioId)
        {
            string query = $@"Select u.QtdCaloriasDiarias as LimiteDiario from Usuario u where u.usuarioId = {usuarioId}";

            using (var connection = GetConnection())
            {
                return connection.QueryFirst<decimal>(query);
            }
        }

        public decimal GetCaloriasSemanais(long usuarioId)
        {
            string query = $@"Select u.QtdCaloriasSemanais as LimiteSemanal from Usuario u where u.usuarioId = {usuarioId}";

            using (var connection = GetConnection())
            {
                return connection.QueryFirst<decimal>(query);
            }
        }

        public decimal GetCaloriasHoje(long usuarioId)
        {
            string query = $@"Select 
	                            IFNULL(SUM(a.Caloria * au.Quantidade), 0)
                            from Alimento a 
                            inner join AlimentoUsuario au on a.AlimentoId = au.AlimentoId
                            where 
	                            au.usuarioId = {usuarioId} and 
	                            au.DataConsumo BETWEEN '{DateTime.Now.ToString("yyyy-MM-dd")} 00:00' and '{DateTime.Now.ToString("yyyy-MM-dd")} 23:00'";

            using (var connection = GetConnection())
            {
                return connection.QueryFirst<decimal>(query);
            }
        }

        public decimal GetCaloriasOntem(long usuarioId)
        {
            string query = $@"Select 
	                            IFNULL(SUM(a.Caloria * au.Quantidade), 0)
                            from Alimento a 
                            inner join AlimentoUsuario au on a.AlimentoId = au.AlimentoId
                            where 
	                            au.usuarioId = {usuarioId} and 
	                            au.DataConsumo BETWEEN '{DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd")} : 00:00' and '{DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd")} 23:00'";

            using (var connection = GetConnection())
            {
                return connection.QueryFirst<decimal>(query);
            }
        }

        public List<Models.ViewModel.AlimentoConsumido> GetAlimentosConsumidosHoje(long usuarioId)
        {
            string query = $@"Select 
	                            au.AlimentoUsuarioId,
	                            a.Imagem,
	                            a.Nome,
	                            a.Tipo, 
	                            a.Caloria,
	                            au.Quantidade,
                                strftime('%d/%m/%Y %H:%M:%S', au.DataConsumo) as DataConsumo
                            from Alimento a 
                            inner join AlimentoUsuario au on a.AlimentoId = au.AlimentoId
                            where 
	                            au.usuarioId = {usuarioId} and au.ativo = 1 and a.ativo = 1 and 
	                            au.DataConsumo BETWEEN '{DateTime.Now.ToString("yyyy-MM-dd")} 00:00' and '{DateTime.Now.ToString("yyyy-MM-dd")} 23:00' 
                                order by au.DataConsumo desc";

            using (var connection = GetConnection())
            {
                return connection.Query<Models.ViewModel.AlimentoConsumido>(query).ToList();
            }
        }

        public long CadastrarAlimentoUsuario(long usuarioId, long alimentoId, int quantidade, string observacao)
        {
            string query = $@"Insert into AlimentoUsuario (UsuarioId, AlimentoId, Observacao, DataConsumo, Quantidade) 
                                values({usuarioId},{alimentoId},'{observacao}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', {quantidade}); 
                                SELECT last_insert_rowid(); --Para SQLite";

            using (var connection = GetConnection())
            {
                return connection.ExecuteScalar<long>(query);
            }
        }

        public bool ExcluirAlimentoUsuario(long alimentoUsuarioId)
        {
            string query = $@"delete from AlimentoUsuario where AlimentoUsuarioId = {alimentoUsuarioId}";

            using (var connection = GetConnection())
            {
                return connection.Execute(query) > 0;
            }
        }
    }
}
