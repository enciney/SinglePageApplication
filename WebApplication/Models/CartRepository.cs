using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
	public class CartRepository : ICartRepository
	{

		private Cart[] AllCarts
		{
			get
			{
				return new Cart[]
				{
					new Cart
					{
						Id = 0,
						Proc = new Product[]
						{
							new Product() { Id = 0, Name = "test", Quantity = 1 },
							new Product() { Id = 1, Name = "test2", Quantity = 1 },
							new Product() { Id = 2, Name = "test3", Quantity = 2 },
							new Product() { Id = 3, Name = "test4", Quantity = 1 },
						}
					},

					new Cart
					{
						Id = 1,
						Proc = new Product[]
						{
							new Product() { Id = 4, Name = "test1", Quantity = 1 },
							new Product() { Id = 5, Name = "test12", Quantity = 1 },
							new Product() { Id = 6, Name = "test13", Quantity = 2 },
							new Product() { Id = 7, Name = "test14", Quantity = 1 },
						}
					}
				};
			}
		}

		public Cart AddProduct(int cartId, Product product)
		{
			throw new NotImplementedException();
		}

		public Cart CreateCart()
		{
			return new Cart() { Id = 0, Proc = new Product[] { new Product() { Id = 0, Name = "test", Quantity = 1 } } };
		}

		public bool EmptyCart(int cartId)
		{
			throw new NotImplementedException();
		}

		public Cart GetCartById(int cartId)
		{
			return AllCarts.Where(s => s.Id == cartId).Single();
		}

		public Cart GetCarts()
		{
			throw new NotImplementedException();
		}

		public Cart[] LoadCartFromJson(string json)
		{
			throw new NotImplementedException();
		}

		public bool RemoveProductById(int cartId, int productId)
		{
			throw new NotImplementedException();
		}
	}
}
