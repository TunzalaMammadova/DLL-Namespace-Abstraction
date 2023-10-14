using System;
using Domain.Models;

namespace Service.Service
{
	public class AccountService
	{
		private User[] GetAll()
		{
			return new User[]
			{
				new User{Id = 1, FullName = "Tunzale Memmedova", Age = 24, Email = "tunzale@gmail.com", Password = "12345"},
				new User{Id = 2, FullName = "Semed Huseynov", Age = 26, Email = "semed@gmail.com", Password = "bbbb" },
				new User{Id = 3, FullName = "Nergiz Memmedova", Age = 25, Email = "nergiz@gmail.com", Password = "aaaa"},
				new User{Id = 4, FullName = "Elnur Memmedov", Age = 20, Email = "elnur@gmail.com", Password = "cccc"}

			};
		}

		public string Login (string email,string password)
		{
			var user = GetAll();

			string a = "Success login";
			string b = "Email or password is wrong";

			foreach (var item in user)
			{
				if (email == item.Email && password == item.Password)
				{
					return a;
				}
			}
			return b;
		}
	}

}
