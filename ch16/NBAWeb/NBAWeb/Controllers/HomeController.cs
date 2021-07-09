using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NBAWeb.Models;

namespace NBAWeb.Controllers
{
    public class HomeController : Controller // HomeController控制器繼承自Controller
    {
        NBADBEntities db = new NBADBEntities();
        // GET: Home
        public ActionResult Index()
        {
            var nba_players = db.NBA_Player.ToList();
            return View(nba_players);
        }
    }
}