using ArquiteturaDDD.Application.ViewModels.Produto;
using ArquiteturaDDD.ApplicationServices.Interfaces;
using ArquiteturaDDD.MVC.Controllers.ControllerBase;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ArquiteturaDDD.MVC.Controllers
{
    public class ProdutoController : BaseController
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService) : base()
        {
            _produtoService = produtoService;
        }

        [Route("Produto")]
        public IActionResult Index()
        {
            var produto = new List<ProdutoViewModel>();
            produto.Add(new ProdutoViewModel { Id = 1, Marca = "testando", Nome = "testandoDDD", PrecoCusto = 100, PrecoVenda = 200 });
            return View(produto);
        }

        [HttpGet]
        [Route("product-details/{id:guid}")]
        public IActionResult Details(long? id)
        {
            if (id == null)
                return NotFound();

            //var customerViewModel = _customerAppService.GetById(id.Value);

            //if (customerViewModel == null)
            //    return NotFound();

            return View();
        }

        [HttpGet]
        [Route("register-new")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("register-new")]
        public IActionResult Create(ProdutoViewModel productViewModel)
        {
            if (!ModelState.IsValid) return View(productViewModel);

            //_produtoService
            //_customerAppService.Register(productViewModel);

            if (true) // IsValidOperation()
                ViewBag.Sucesso = "Product Registered!";
                
            return View();
        }

        [HttpGet]
        [Route("edit-product/{id:guid}")]
        public IActionResult Edit(long? id)
        {
            if (id == null)
                return NotFound();

            //var customerViewModel = _customerAppService.GetById(id.Value);

            //if (customerViewModel == null)
            //    return NotFound();

            return View();
        }

        [HttpPost]
        [Route("edit-product/{id:guid}")]
        public IActionResult Edit(ProdutoViewModel produtoViewModel)
        {
            if (!ModelState.IsValid) return View(produtoViewModel);

            //_customerAppService.Update(produtoViewModel);

            //if (IsValidOperation())
            //    ViewBag.Sucesso = "Customer Updated!";

            return View();
        }

        [HttpGet]
        [Route("remove-product/{id:guid}")]
        public IActionResult Delete(long? id)
        {
            if (id == null)
                return NotFound();

            //var customerViewModel = _customerAppService.GetById(id.Value);

            //if (customerViewModel == null)
            //    return NotFound();

            return View();
        }

        [HttpPost, ActionName("Delete")]
        [Route("remove-product/{id:guid}")]
        public IActionResult DeleteConfirmed(long id)
        {
            //_customerAppService.Remove(id);

            //if (!IsValidOperation()) return View(_customerAppService.GetById(id));

            ViewBag.Sucesso = "Product Removed!";
            return RedirectToAction("Index");
        }
    }
}