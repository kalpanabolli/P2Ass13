using Ass13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ass13.Controllers
{
    public class PlayerController : Controller
    {
        List<Team> listTeam = new List<Team>()
        {
            new Team(){TeamId = 1,TeamName="India",NOWC=2},
            new Team(){TeamId = 2,TeamName="Australia",NOWC=4},
            new Team(){TeamId = 3,TeamName="West Indies",NOWC=2},
            new Team(){TeamId = 4,TeamName="England",NOWC=1}
        };
        // GET: Player
        public ActionResult Index()
        {
            return View(listTeam);
        }
    }
}