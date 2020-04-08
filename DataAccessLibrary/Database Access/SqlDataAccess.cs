using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using System.Linq;

namespace DataAccessLibrary
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public string ConnectionString { get; set; } = "Default";

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            string connectionstring = _config.GetConnectionString(ConnectionString);

            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }
        }

        public async Task SaveData<T>(string sql, T parameters)
        {
            string connectionstring = _config.GetConnectionString(ConnectionString);

            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }

        public T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            IDbConnection _db = new SqlConnection(_config.GetConnectionString("Default"));

            return _db.Query<T>(sp, parms, commandType: commandType).FirstOrDefault();
        }

        public List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            IDbConnection _db = new SqlConnection(_config.GetConnectionString("Default"));

            return _db.Query<T>(sp, parms, commandType: commandType).ToList();
        }

        public T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            IDbConnection _db = new SqlConnection(_config.GetConnectionString("Default"));

            var tran = _db.BeginTransaction();

            result = _db.Query<T>(sp, parms, commandType: commandType, transaction: tran).FirstOrDefault();
            tran.Commit();

            return result;
        }
    }
}
