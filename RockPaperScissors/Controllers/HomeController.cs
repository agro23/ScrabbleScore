using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers
{
  public class HomeController : Controller
  {



    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>(); // create dictionary to pass as Model
      model.Add("msg", ""); // create blank message to pass at load time
      return View("Index", model);
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      Dictionary<string, object> model = new Dictionary<string, object>(); // create dictionary to pass as Model
        model.Add("msg", ""); // create blank message to pass at load time
      Player PlayerOne = new Player ("Player One");
      Player PlayerTwo = new Player ("Player Two");
      string x =  Request.Form["PlayerOne"];
      // Console.WriteLine("Player One chose: " + x);
      string y =  Request.Form["PlayerTwo"];
      // Console.WriteLine("Player Two chose: " + y);
      PlayerOne.SetCurrentMove(x);
      PlayerTwo.SetCurrentMove(y);
      // Console.WriteLine("And the winner is: " + Player.WhoWins(x, y));
      string result ="";
      if (Player.WhoWins(x,y) == "Draw")
      {
        result="The game is a draw!";
      }
      else
      {
        result=Player.WhoWins(x,y)+" has won the game!";
      }
      model["msg"] = result;
      // return View("Index", model);
      return View(model);
    }

//********************************************************************



    //   string msg = "";
    //   int qx = Int32.Parse(Request.Form["qx"]);
    //   int qy = Int32.Parse(Request.Form["qy"]);
    //   int vx = Int32.Parse(Request.Form["vx"]);
    //   int vy = Int32.Parse(Request.Form["vy"]);
    //   if (qx < 1 || qx > 8 || qy < 1 || qy > 8)
    //   {
    //     msg = "Queen cannot be at those Coordinates";
    //   }
    //   else if(vx < 1 || vx > 8 || vy < 1 || vy > 8)
    //   {
    //     msg = "Victim cannot be at those Coordinates";
    //   }
    //   else if(qx == vx && qy == vy)
    //   {
    //     msg = "Queen and Victim cannot share Coordinates";
    //   }
    //   else
    //   {
    //     Queen queen = new Queen(qx, qy);
    //     if (queen.CanAttack(vx, vy))
    //     {
    //       msg = "Queen Takes Piece!!!";
    //     }
    //     else
    //     {
    //       msg = "Queen cannot attack piece :(";
    //     }
    //   }
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   model.Add("msg", msg);
    //   model.Add("qx", qx);
    //   model.Add("qy", qy);
    //   model.Add("vx", vx);
    //   model.Add("vy", vy);
    //
    //
    //   return View("Index", model);
    // }
  }
}
