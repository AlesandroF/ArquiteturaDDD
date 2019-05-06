using ArquiteturaDDD.Application.ViewModels.Produto;
using ArquiteturaDDD.ApplicationServices.Interfaces;
using ArquiteturaDDD.MVC.Controllers.ControllerBase;
using Microsoft.AspNetCore.Mvc;

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
            var produtos = _produtoService.GetProdutos();
            return View(produtos);
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
            _produtoService.Insert(productViewModel);

            return View();
        }

        [HttpGet]
        public IActionResult Details(long? id)
        {
            if (id == null) return NotFound();
            var produtoViewModel = _produtoService.GetById(id.Value);
            if (produtoViewModel == null) return NotFound();

            return View(produtoViewModel);
        }

        [HttpGet]
        public IActionResult Edit(long? id)
        {
            if (id == null) return NotFound();
            var produtoViewModel = _produtoService.GetById(id.Value);
            if (produtoViewModel == null) return NotFound();

            return View(produtoViewModel);
        }

        [HttpPost]
        public IActionResult Edit(ProdutoViewModel produtoViewModel)
        {
            if (!ModelState.IsValid) return View(produtoViewModel);
            _produtoService.Update(produtoViewModel);

            return View();
        }

        [HttpGet]
        public IActionResult Delete(long? id)
        {
            if (id == null) return NotFound();
            var produtoViewModel = _produtoService.GetById(id.Value);
            if (produtoViewModel == null) return NotFound();

            return View(produtoViewModel);
        }

        [HttpPost]
        public IActionResult Delete(long id)
        {
            _produtoService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}