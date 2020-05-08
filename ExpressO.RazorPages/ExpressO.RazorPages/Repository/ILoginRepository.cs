using ExpressO.RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressO.RazorPages.Repository
{
    public interface ILoginRepository
    {
        Login Validate(string userName, string password);
        int Add(Signup login);
        List<Signup> GetList();
    }
}
