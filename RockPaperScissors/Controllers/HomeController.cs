using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;
using System.Collections.Generic;
using System;

namespace RockPaperScissors.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/player2")]
    public ActionResult Player2()
    {
      string player1 = Request.Form["selected"];
      RockPaperScissor.SetPlayer1Choice(player1);

      return View();
    }

    [HttpPost("/results")]
    public ActionResult Results()
    {
      string player1Choice = RockPaperScissor.GetPlayer1Choice();
      string player2Choice = Request.Form["selected"];
      RockPaperScissor myGame = new RockPaperScissor(player1Choice, player2Choice);

      return View(myGame);
    }
  }
}
