using Battleships.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Battleships.Services;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace Battleships.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // create new GameManager object and initialize the game
            BattleshipBot bot1 = new BattleshipBot();
            BattleshipBot bot2 = new BattleshipBot();
            BattleshipGameManager gameManager = new BattleshipGameManager(bot1, bot2);
            // serialize and save gameManager object in session
            HttpContext.Session.SetString("GameManager", JsonSerializer.Serialize(gameManager));
            return View(gameManager);
        }

        public IActionResult NextRound()
        {
            // get saved gameManager object from session
            var manager = HttpContext.Session.GetString("GameManager");
            BattleshipGameManager gameManager = JsonSerializer.Deserialize<BattleshipGameManager>(manager);
            // save result of next round
            GameRoundResult result = gameManager.nextRound();
            // serialize gameManager object and save in session
            string serializedManager = JsonSerializer.Serialize(gameManager);
            HttpContext.Session.SetString("GameManager", serializedManager);
            // return round result
            return Ok(JsonSerializer.Serialize(result));
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
