using System;
using Domain.Models;
using Service.Service;

namespace DLL_Abstarction.Hometask.Controllers
{
    public class AccountController
    {
        private readonly AccountService _accountService;
        public AccountController()
        {
            _accountService = new AccountService();
        }

        public void GetLogin()
        {
            Console.WriteLine("Please add your email:");
            string email = Console.ReadLine();
            Console.WriteLine("Please add your password:");
            string password = Console.ReadLine();

            var user = _accountService.Login(email,password);

            Console.WriteLine(user);
        }
    }  

}
