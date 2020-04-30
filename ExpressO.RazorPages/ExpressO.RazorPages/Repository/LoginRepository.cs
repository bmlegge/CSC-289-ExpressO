using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressO.RazorPages.Models;
using Dapper;
using System.Data.SQLite;
using Microsoft.Extensions.Configuration;

namespace ExpressO.RazorPages.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private IConfiguration _configuration;

        public LoginRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public List<Login> GetList()
        {
            List<Login> logins = new List<Login>();

            using (var cnn = new SQLiteConnection(_configuration.GetConnectionString("Default")))
            {
                try
                {
                    cnn.Open();
                    var query = "SELECT * FROM Login";
                    logins = cnn.Query<Login>(query).ToList();
                }
                catch(Exception ex)
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
