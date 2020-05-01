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
        private string sError;
        public string ConnectionString { get; set; } = "Default";

        public SqlDataAccess(IConfiguration config)
        {
            try
            {
                _config = config;
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
            }

        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            try
            {
                string connectionstring = _config.GetConnectionString(ConnectionString);

                using (IDbConnection connection = new SqlConnection(connectionstring))
                {
                    var data = await connection.QueryAsync<T>(sql, parameters);

                    return data.ToList();
                }
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }

        public async Task SaveData<T>(string sql, T parameters)
        {
            try
            {
                string connectionstring = _config.GetConnectionString(ConnectionString);

                using (IDbConnection connection = new SqlConnection(connectionstring))
                {
                    await connection.ExecuteAsync(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
            }
        }

        public T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            try
            {
                IDbConnection _db = new SqlConnection(_config.GetConnectionString("Default"));
                if (_db.State == ConnectionState.Closed)
                {
                    _db.Open();
                }

                return _db.Query<T>(sp, parms, commandType: commandType).FirstOrDefault();
            }
            catch (Exception ex)
            {
                sError = ex.ToString();
                return default(T);
            }
        }

        public List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            try
            {
                IDbConnection _db = new SqlConnection(_config.GetConnectionString("Default"));
                if (_db.State == ConnectionState.Closed)
                {
                    _db.Open();
                }
                return _db.Query<T>(sp, parms, commandType: commandType).ToList();
            }

            catch (Exception ex)
            {
                sError = ex.ToString();
                return null;
            }
        }
    }
}
