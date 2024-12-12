using LoginFormASPCore6.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginFormASPCore6.Controllers
{
    public class AssetsTrackingController : Controller

    {
        private readonly MyDbContext _context;

        public AssetsTrackingController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var issues = _context.LocalAssets.ToList();
            return View(issues);
        }
    }
}
