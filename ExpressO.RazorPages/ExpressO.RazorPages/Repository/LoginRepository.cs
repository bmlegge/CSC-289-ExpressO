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

        public int Add(Login login)
        {   
            using (var cnn = new SQLiteConnection(_configuration.GetConnectionString("Default")))
            {
                try
                {
                    cnn.Open();
                    var q = cnn.Execute( "INSERT INTO Login(UserName, Password, FirstName, LastName, Email) " +
                                "VALUES(@UserName, @Password, @FirstName, @LastName, @Email)", 
                                new
                                {
                                    UserName = login.UserName,
                                    Password = login.Password,
                                    FirstName = login.FirstName,
                                    LastName = login.LastName,
                                    Email = login.Email
                                });
                    return q;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        public List<Login> GetList()
        {
            List<Login> logins = new List<Login>();

            using (var cnn = new SQLiteConnection(_configuration.GetConnectionString("Default")))
            {
                try
                {
                    cnn.Open();
                    logins = cnn.Query<Login>("SELECT * FROM Login").ToList();
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

        public Login Validate(string userName, string password)
        {
            using (var cnn = new SQLiteConnection(_configuration.GetConnectionString("Default")))
            {
                Login login = new Login();

                try
                {
                    cnn.Open();
                    var query = "SELECT * FROM Login Where UserName = @UserName and Password = @Password";
                    login = cnn.Query<Login>(query, new { UserName = userName, Password = password }).FirstOrDefault();

                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cnn.Close();
                }
                return login;
            }
        }
    }
}
