using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ResponseServices;

namespace DapperServices
{
    public class DBHelper
    {
        private static string _connectionString = @"Server = .\SQLExpress; Database = test; User Id = sa; Password = 123123;Encrypt=True;TrustServerCertificate=True; Min Pool Size=5;Max Pool Size=100;Connection Timeout=30";

        /// <summary>
        /// Hàm select dữ liệu
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlQuery"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static async Task<Response<T>> Query<T>(string sqlQuery, object? param = null)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    var data = await db.QueryAsync<T>(sqlQuery, param);
                    return new Response<T>(status: 1, message: "OK", data: data.ToArray());
                }
            }
            catch (Exception ex)
            {
                return new Response<T>(status: 0, message: ex.Message, data: null);
            }
        }

        /// <summary>
        /// Create, Update, Delete
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static async Task<Response> Execute(string sqlQuery, object? param = null)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(_connectionString))
                {
                    var affectedRows = await db.ExecuteAsync(sqlQuery, param);
                    return new Response(
                        status: affectedRows > 0 ? 1 : 0,
                        message: $"Affected {affectedRows} row(s)"
                    );
                }
            }
            catch (Exception ex)
            {
                return new Response(status: 0, message: ex.Message);
            }
        }

    }
}
