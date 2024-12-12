using LoginFormASPCore6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace LoginFormASPCore6.Controllers
{
    public class IssuesTrackingController : Controller

    {
        private readonly MyDbContext _context;

        public IssuesTrackingController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var issues = _context.LocalIssueTracking.ToList();
            return View(issues);
        }


        public IActionResult Download(string fileName)
        {
            var fullName = Path.Combine("D:\\OneDrive - TouchPointMed\\6-Work Backup\\2-MyStudying\\1-Repos\\SharedRepository\\LoginAndSignUpPage\\wwwroot", fileName);
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return NotFound(); 
            }
            byte[] bytes = Encoding.UTF8.GetBytes(fullName);
            return File(bytes, "text/plain", fileName.Replace("\\","_")+".txt");
        }
    }
}
