using System;
using Service.Services;

namespace Namespace_Abstraction.Controllers
{
	public class ProductController
	{
		private readonly ProductService _productService;

		public ProductController()
		{
			_productService = new ProductService();

		}

		public void GetAllByCount()
		{

			foreach (var item in _productService.GetAllByCount(14))
			{
				Console.WriteLine($"{item.Id} - {item.Name} - {item.Price} - {item.Color} - {item.Count}");
			}

		}
	}
}

