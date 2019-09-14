using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductMicroservice.DBContexts;
using ProductMicroservice.Models;



namespace ProductMicroservice.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AccountContext _dbContext;

        public AccountRepository(AccountContext dbContext)
        {
            _dbContext = dbContext;
        }
        

        public Account GetAccountByID(int accountId)
        {
            return _dbContext.Accounts.Find(accountId);
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _dbContext.Accounts.ToList();
        }

        public void InsertAccount(Account account)
        {
            _dbContext.Add(account);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateAccount(Account account)
        {
            _dbContext.Entry(account).State = EntityState.Modified;
            Save();
        }
    }
}
