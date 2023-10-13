using System;
using Domain.Models;

namespace Service.Services
{
	public class ProductService
	{
		private Product[] GetAll()
		{
			return new Product[]
			{
				new Product{Id = 1, Name = "Iphone 14" ,Price = 3000, Color = "White",Count = 10},
                new Product{Id = 2, Name = "Iphone 12" ,Price = 2000, Color = "Black",Count = 20},
                new Product{Id = 3, Name = "Iphone 11" ,Price = 1000, Color = "Silver",Count = 5},
                new Product{Id = 4, Name = "Iphone 15" ,Price = 4000, Color = "White",Count = 10},
            };
		}



		public Product[] GetAllByCount(int count)
		{
			Product[] products = GetAll();

			return products.Where(m => m.Count > count).ToArray();
		}
	}
}

