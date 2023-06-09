﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using wingtipToys.Models;

namespace WingtipToys.Models
{
	public class ProductContext : DbContext
	{
		public ProductContext() : base("WingtipToys")
		{
		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }

		public DbSet<CarItem> ShoppingCartItems { get; set; }
	}
}