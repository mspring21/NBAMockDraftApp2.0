using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockDraftAppMVC.DAL;
using MockDraftAppMVC.Models;

namespace MockDraftAppMVC.Controllers
{
    public class HomeController : Controller
    {

        private IProspectsDAO prospectDAO;
        public HomeController(IProspectsDAO prospectDAO)
        {
            this.prospectDAO = prospectDAO;
        }



        public IActionResult Index()
        {
            IList<Prospect> prospect = prospectDAO.GetProspect();
            return View(prospect);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
