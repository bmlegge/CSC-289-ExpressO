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

        public CoffeeShop GetShop(int id)
        {
            CoffeeShop coffeeShop = new CoffeeShop();

            using (var cnn = new SQLiteConnection(_configuration.GetConnectionString("Default")))
            {
                try
                {
                    cnn.Open();
                    var query = "SELECT * FROM CoffeeShops WHERE Id =" + id;
                    coffeeShop = cnn.Query<CoffeeShop>(query).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cnn.Close();
                }

                return coffeeShop;
            }
        }

        public List<CoffeeShop> Search(string searchTerm)
        {
            List<CoffeeShop> coffeeShops = new List<CoffeeShop>();

            using (var cnn = new SQLiteConnection(_configuration.GetConnectionString("Default")))
            {
                try
                {
                    if (string.IsNullOrEmpty(searchTerm))
                    {
                        return GetList();
                    }

                    cnn.Open();
                    var query = "SELECT * FROM CoffeeShops WHERE Zip =" + searchTerm;
                    coffeeShops = cnn.Query<CoffeeShop>(query).ToList();
                }
                catch (Exception ex)
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
