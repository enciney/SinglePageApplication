using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
	public class CartController : Controller
	{
		public string Index()
		{
			return "CartController";
		}
		// TOdo return Action or task for support http error code
		public JsonResult GetCartById(int? cartId)
		{
			if(cartId == null)
			{
				return null;
			}
			CartRepository cartRepo = new CartRepository();
			return Json(cartRepo.GetCartById((int)cartId));
		}

	}
	
	
}
