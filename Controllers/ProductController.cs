
using System;
using Microsoft.AspNetCore.Mvc;
using Crud_C_.Dao;

namespace Crud_C_.Controllers
{
    public class ProductController : Controller
    {
        // private string conn;

        public ProductController()
        {
            // conn = string.Format("server={0};database={1};user={2};password={3}", "server", "database", "uid", "password");
        }

        public IActionResult Index()
        {
            ProdutcDao dao = new ProdutcDao();
            string[][] products = new string[][]{new string[]{"1", "teste1"}, new string[]{"2", "teste2"}, new string[]{"3", "teste3"}};
            // string[] products = new string[3];
            // products[0] = "Teste 1";


            // foreach (string[] product in products) {
            //     Console.WriteLine(product[0]);
            //     Console.WriteLine(product[1]);
            // }

            ViewBag.products = products;

            return View(products);
        }

        public IActionResult Add()
        {
            ProdutcDao dao = new ProdutcDao();
            dao.add();

            return RedirectToAction();
        }

        public IActionResult edit()
        {
            ProdutcDao dao = new ProdutcDao();
            dao.edit();

            return RedirectToAction();
        }

        public IActionResult delete()
        {
            ProdutcDao dao = new ProdutcDao();
            dao.delete();

            return RedirectToAction();
        }
    }
}
