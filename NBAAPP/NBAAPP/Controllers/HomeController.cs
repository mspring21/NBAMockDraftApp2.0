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
        private ITeamDAO teamDAO;
        private IProspectsDAO prospectDAO;
        public HomeController(IProspectsDAO prospectDAO, ITeamDAO teamDAO)
        {
            this.prospectDAO = prospectDAO;
            this.teamDAO = teamDAO;
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


        public IActionResult ShowDraftOrder()
        {
            IList<Team> teams = teamDAO.GetDraftOrder();
            return View(teams);
        }


        public IActionResult StartMockDraft()
        {
            return View();
        }

        public IActionResult DraftResults()
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
