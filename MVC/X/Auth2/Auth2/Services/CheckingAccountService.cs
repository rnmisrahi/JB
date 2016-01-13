using Auth2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auth2.Services
{
    public class CheckingAccountService
    {
        private ApplicationDbContext db;
        public CheckingAccountService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreateCheckingAccount(string firstName, string lastname, string userId, decimal initialBalance)
        {

        }
    }
}