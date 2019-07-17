using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NBAAPP.DAL;
using NBAAPP.Models;

namespace NBAAPP.Controllers
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
            return View();
        }

        public IActionResult ViewBoard()
        {
            IList<Prospect> prospect = prospectDAO.GetProspect();
            return View(prospect);
        }




























        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
