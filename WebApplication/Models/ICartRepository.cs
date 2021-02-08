using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
	public interface ICartRepository
	{
		Cart CreateCart();
		Cart GetCarts();
		Cart GetCartById(int cartId);
		Cart AddProduct(int cartId, Product product);
		bool EmptyCart(int cartId);
		bool RemoveProductById(int cartId, int productId);
		Cart[] LoadCartFromJson(string json);


	}
}
