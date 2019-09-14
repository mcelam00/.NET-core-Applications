using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.Models;
using ProductMicroservice.Repository;
using System.Transactions;


namespace ProductMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var account = _accountRepository.GetAccountByID(id);
            return new OkObjectResult(account);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Account account)
        {
            using (var scope = new TransactionScope())
            {
                _accountRepository.InsertAccount(account);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = account.Id }, account);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Account account)
        {
            if (account != null)
            {
                using (var scope = new TransactionScope())
                {
                    _accountRepository.UpdateAccount(account);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

    }
}
