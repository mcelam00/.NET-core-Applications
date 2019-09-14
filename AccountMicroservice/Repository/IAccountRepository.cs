using ProductMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroservice.Repository
{
    public interface IAccountRepository
    {
        Account GetAccountByID(int account);
        void InsertAccount(Account account);
        void UpdateAccount(Account account);
        void Save();
    }
}
