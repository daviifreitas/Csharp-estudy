using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CleanArchMvc.WebUI.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IWebHostEnvironment _enviromment; 

        public ProductsController(IProductService service, ICategoryService category, IWebHostEnvironment enviromment)
        {
            _productService = service;
            _categoryService = category;
            _enviromment = enviromment;
        }

        public async Task<IActionResult> Index()
        {
            var products = await  _productService.GetProducts();
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.CategoryId =
                new SelectList(await _categoryService.GetCategories(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductDTO product)
        {
            if (ModelState.IsValid)
            {
                await _productService.Add(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound("The id of product not found !!!");

            var productToEdit = _productService.GetById(id).Result;

            if (productToEdit == null) return NotFound("Product not found for edit ");

            return View(productToEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductDTO product)
        {
            if (ModelState.IsValid)
            {
                await _productService.Update(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Detele(int? id)
        {
            if (id == null) return NotFound("The id is null");

            var productToDelete = await  _productService.GetById(id.Value);

            if (productToDelete == null) return NotFound("The product not exist in data base");

            return View(productToDelete);

        }

        [HttpPost(), ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            {
                await _productService.Remove(id.Value);
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound("The id is null");

            var productToSee = await _productService.GetById(id.Value);

            if (productToSee == null) return NotFound("Product not found in database");

            var wwwroot = _enviromment.WebRootPath; 
            var image = Path.Combine(wwwroot, "images\\" + productToSee.Image);
            var exists = System.IO.File.Exists(image);
            ViewBag.ImageExist = exists;

            return View(productToSee);
        }
    }
}
