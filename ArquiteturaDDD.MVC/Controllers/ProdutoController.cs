using ArquiteturaDDD.MVC.Controllers.ControllerBase;
using Microsoft.AspNetCore.Mvc;

namespace ArquiteturaDDD.MVC.Controllers
{
    public class ProdutoController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}