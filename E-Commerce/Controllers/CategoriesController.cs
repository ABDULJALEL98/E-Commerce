using E_Commerce.Data;
using E_Commerce.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryServices _services;
        public CategoriesController(ICategoryServices services)
        {
            _services = services;

        }
        public async Task <IActionResult> Index()
        {
            var Response = await _services.GetALLAsycn();
            return View(Response);
        }
    }
}
