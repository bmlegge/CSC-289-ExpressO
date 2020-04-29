using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using ExpressO.RazorPages.Models;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace ExpressO.RazorPages.Repository
{
    public class LoginRepository : ILoginRepository
    {
        IConfiguration _configuration;

        public LoginRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").GetSection("Default").Value;
            return connection;
        }

        public List<Login> GetList()
        {
            //var connectionString = GetConnection();
            List<Login> logins = new List<Login>();

            using(var cnn = new SQLiteConnection(_configuration.GetConnectionString("Default")))
            {
                try
                {
                    cnn.Open();
                    var query = "SELECT * FROM Login";
                    logins = cnn.Query<Login>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cnn.Close();
                }

                return logins;
            }
        }
    }
}
