using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRUDWithEF.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CRUDWithEF.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        ProductCRUD crud;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
            crud=new ProductCRUD(_context);
        }


        // GET: ProductController
        public ActionResult Index()
        {
            return View(crud.GetAllProducts());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var result = crud.GetProductById(id);
            return View(result);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                int result = crud.AddProduct(product);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return BadRequest();
            }
            catch
            {
                return BadRequest();
            }

        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = crud.GetProductById(id);
            return View(model);
     
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            try
            {
                int result = crud.UpdateProduct(product);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return BadRequest();
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = crud.GetProductById(id);
            return View(model);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result = crud.DeleteProduct(id);
                if (result == 1)
                    return RedirectToAction(nameof(Index));
                else
                    return BadRequest();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
