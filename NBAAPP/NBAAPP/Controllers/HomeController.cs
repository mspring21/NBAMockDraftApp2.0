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
            IList<Prospect> prospect = prospectDAO.GetAllProspects();
            return View(prospect);
        }


        public IActionResult ShowDraftOrder()
        {
            IList<Team> teams = teamDAO.GetDraftOrder();
            return View(teams);
        }


        public IActionResult ShowDraftedPlayers()
        {
            DraftVM vm = new DraftVM();
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }

        
        // Gonna do each team one by one... 
        // Pelicans
        [HttpGet]
        public IActionResult Pelicans()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickOne(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }


        // Grizzlies
        [HttpGet]
        public IActionResult Grizzlies()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickTwo(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }



        //Knicks
        [HttpGet]
        public IActionResult Knicks()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickThree(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //THIS IS WHERE I LEFT OFF!
        //Lakers
        [HttpGet]
        public IActionResult Lakers()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickFour(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Cavaliers
        [HttpGet]
        public IActionResult Cavaliers()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickFive(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Suns
        [HttpGet]
        public IActionResult Suns()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickSix(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Bulls
        [HttpGet]
        public IActionResult Bulls()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickSeven(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Hawks
        [HttpGet]
        public IActionResult Hawks()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickEight(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Wizards
        [HttpGet]
        public IActionResult Wizards()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickNine(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Mavericks
        [HttpGet]
        public IActionResult Mavericks()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickTen(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //TimberWolves
        [HttpGet]
        public IActionResult TimberWolves()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickEleven(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Hornets
        [HttpGet]
        public IActionResult Hornets()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickTwelve(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Heat
        [HttpGet]
        public IActionResult Heat()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickThirteen(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Kings
        [HttpGet]
        public IActionResult Kings()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickFourteen(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Celtics
        [HttpGet]
        public IActionResult Celtics()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickFifteen(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Pistons
        [HttpGet]
        public IActionResult Pistons()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickSixteen(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Magic
        [HttpGet]
        public IActionResult Magic()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickSeventeen(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Nets
        [HttpGet]
        public IActionResult Nets()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickEighteen(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Pacers
        [HttpGet]
        public IActionResult Pacers()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickNineteen(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Spurs
        [HttpGet]
        public IActionResult Spurs()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickTwenty(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Clippers
        [HttpGet]
        public IActionResult Clippers()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickTwentyone(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Thunder
        [HttpGet]
        public IActionResult Thunder()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickTwentytwo(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Jazz
        [HttpGet]
        public IActionResult Jazz()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickTwentythree(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //76ers
        [HttpGet]
        public IActionResult Sixers()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickTwentyfour(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Trailblazers
        [HttpGet]
        public IActionResult Trailblazers()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickTwentyfive(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Rockets
        [HttpGet]
        public IActionResult Rockets()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickTwentysix(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Nuggets
        [HttpGet]
        public IActionResult Nuggets()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickTwentyseven(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Warriors
        [HttpGet]
        public IActionResult Warriors()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickTwentyeight(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Raptors
        [HttpGet]
        public IActionResult Raptors()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickTwentynine(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }

        //Bucks
        [HttpGet]
        public IActionResult Bucks()
        {
            DraftVM vm = new DraftVM();
            vm.Prospects = prospectDAO.GetAllProspects();
            vm.Teams = teamDAO.GetDraftOrder();
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(2);
            vm.TopFiveProspectsAvailable = prospectDAO.GetTopFourProspectsAvailableForDraft(1);
            vm.AvailableProspects = prospectDAO.GetAllProspectsAvailableForDraft(1);
            vm.DraftedProspects = prospectDAO.GetAllDraftedProspects(2);
            return View(vm);
        }


        public IActionResult BreakDownPickThirty(int id)
        {
            DraftVM vm = new DraftVM();
            vm.Prospect = prospectDAO.GetProspectById(id);
            vm.TeamOnTheBoard = teamDAO.GetSingleTeamWithId(1);
            prospectDAO.UpdateStatusOfDraftedPlayer(id, vm.TeamOnTheBoard.TeamName);
            return View(vm);
        }















        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
