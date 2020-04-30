using ExpressO.RazorPages.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;

namespace ExpressO.RazorPages.Repository
{
    public class CoffeeShopRepository : ICoffeeShopRepository
    {
        private IConfiguration _configuration;

        public CoffeeShopRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<CoffeeShop> GetList()
        {
            List<CoffeeShop> coffeeShops = new List<CoffeeShop>();

            using (var cnn = new SQLiteConnection(_configuration.GetConnectionString("Default")))
            {
                try
                {
                    cnn.Open();
                    var query = "SELECT * FROM CoffeeShops";
                    coffeeShops = cnn.Query<CoffeeShop>(query).ToList();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cnn.Close();
                }

                return coffeeShops;
            }
        }
    }
}
