﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
	public class Cart
	{
		public int Id { get; set; }
		public Product[] Proc { get; set; }
	}
}
