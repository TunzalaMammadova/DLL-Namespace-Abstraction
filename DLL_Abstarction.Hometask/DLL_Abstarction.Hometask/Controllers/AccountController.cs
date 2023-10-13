using System;
using Domain.Models;
using Service.Service;

namespace DLL_Abstarction.Hometask.Controllers
{
    public class AccountController
    {
        private readonly AccountController _accountController;
        public AccountController()
        {
            _accountController = new AccountController();

        }

        public void GetLogin()
        {
            var user = _accountController;

            Console.WriteLine("Please add your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Please add your password:");
            string password = Console.ReadLine();



        }
    }
}
