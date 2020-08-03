﻿using MVCShoppingCard12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCShoppingCard12.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.findAll();
            return View();
        }
    }
}