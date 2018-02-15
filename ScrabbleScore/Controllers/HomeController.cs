using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ScrabbleScore.Models;

namespace ScrabbleScore.Controllers
{
  public class HomeController : Controller
  {



    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>(); // create dictionary to pass as Model
      model.Add("msg", "Scrabble Score"); // create blank message to pass at load time
      return View("Index", model);
    }

    // [HttpPost("/")]
    // public ActionResult Result()
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>(); // create dictionary to pass as Model
    //   model.Add("msg", ""); // create blank message to pass at load time
    //   Player PlayerOne = new Player ("Player One");
    //   Player PlayerTwo = new Player ("Player Two");
    //   string x =  Request.Form["PlayerOne"];
    //   // Console.WriteLine("Player One chose: " + x);
    //   string y =  Request.Form["PlayerTwo"];
    //   // Console.WriteLine("Player Two chose: " + y);
    //   PlayerOne.SetCurrentMove(x);
    //   PlayerTwo.SetCurrentMove(y);
    //   if (x !="Rock" && x !="Paper" && x !="Scissors" && y !="Rock" && y !="Paper" && y !="Scissors")
    //   {
    //     model["msg"] ="Invalid Input. Try Again!";
    //     return View ("Index", model);
    //   }
    //   else
    //   {
    //     // Console.WriteLine("And the winner is: " + Player.WhoWins(x, y));
    //     string result ="";
    //     if (Player.WhoWins(x,y) == "Draw")
    //     {
    //       result="The game is a draw!";
    //     }
    //     else
    //     {
    //       result=Player.WhoWins(x,y)+" has won the game!";
    //     }
    //     model["msg"] = result;
    //     // return View("Index", model);
    //     return View (model);
    //   }
    // }


  }
}
