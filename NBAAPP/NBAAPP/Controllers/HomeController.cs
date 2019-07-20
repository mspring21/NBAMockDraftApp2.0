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


        // Come back to this when you decide how you wanna handle the draft process.. think of something creative!
        [HttpGet]
        public IActionResult MockDraft()
        {
            return View();
        }


        // Change this later once you figure out the get!
        [HttpPost]
        public IActionResult MockDraft(string f)
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
