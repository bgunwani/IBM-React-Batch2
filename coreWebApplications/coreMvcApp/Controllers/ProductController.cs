﻿using coreMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcApp.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products =
        [
            new Product { Id = 1, Name = "Wireless Mouse", Price = 200.50F },
            new Product { Id = 2, Name = "Wireless Keyboard", Price = 500.50F },
            new Product { Id = 3, Name = "Monitor Dell", Price = 1200.50F },
            new Product { Id = 4, Name = "Marshell Speaker", Price = 2000.50F },
        ];

        public IActionResult Index()
        {
            ViewBag.Message = "Product Management System";
            ViewBag.ProductCount = products.Count();
            ViewBag.Products = products;
            return View();
        }

        public IActionResult List()
        {
            ViewData["Message"] = "Product Management System";
            ViewData["ProductCount"] = products.Count();
            ViewData["Products"] = products;
            return View();
        }

        public IActionResult Method1()
        {
            TempData["Message"] = "Product Management System";
            TempData["ProductCount"] = products.Count();
            TempData["Products"] = products;
            return View();
        }
        public IActionResult Method2()
        {
            string? message = TempData["Message"] as string;
            if(!string.IsNullOrEmpty(message))
            {
                TempData["Message"] = message;
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
