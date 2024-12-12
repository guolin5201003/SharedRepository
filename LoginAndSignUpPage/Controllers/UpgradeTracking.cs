using LoginFormASPCore6.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginFormASPCore6.Controllers
{
    public class UpgradeTracking : Controller
    {
        private MyDbContext _context;

        public UpgradeTracking(MyDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var upgrades = _context.LocalUpgradeInfo.ToList();
            return View(upgrades);
        }
    }
}
