using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using UpSchool_UnitOfWork_BusinessLayer.Abstract;
using UpSchool_UnitOfWork_DataAccessLayer.Concrete;
using UpSchool_UnitOfWork_EntityLayer.Concrete;
using UpSchool_UnitOfWork_PresenatationLayer.Models;

namespace UpSchool_UnitOfWork_PresenatationLayer.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel p)
        {
            var value1 = _accountService.TGetById(p.SenderId);
            var value2 = _accountService.TGetById(p.ReceiverId);

            value1.AccountBalance -= p.Amount;
            value2.AccountBalance += p.Amount;

            List<Account> modifiedAccount = new List<Account>()
            {
                    value1,
                    value2
            };
            _accountService.TMultiUpdate(modifiedAccount);
            return View();
        }
    }
}
