﻿using LoginFormASPCore6.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
