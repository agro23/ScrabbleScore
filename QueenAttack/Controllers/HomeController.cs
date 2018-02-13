using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using QueenAttack.Models;

namespace QueenAttack.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("Index", "");
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      string msg = "";
      int qx = Int32.Parse(Request.Form["qx"]);
      int qy = Int32.Parse(Request.Form["qy"]);
      int vx = Int32.Parse(Request.Form["vx"]);
      int vy = Int32.Parse(Request.Form["vy"]);
      if (qx < 1 || qx > 8 || qy < 1 || qy > 8)
      {
        msg = "Queen cannot be at those Coordinates";
      }
      else if(vx < 1 || vx > 8 || vy < 1 || vy > 8)
      {
        msg = "Victim cannot be at those Coordinates";
      }
      else if(qx == vx && qy == vy)
      {
        msg = "Queen and Victim cannot share Coordinates";
      }
      else
      {
        Queen queen = new Queen(qx, qy);
        if (queen.CanAttack(vx, vy))
        {
          msg = "Queen Takes Piece!!!";
        }
        else
        {
          msg = "Queen cannot attack piece :(";
        }
      }


      return View("Index", msg);
    }
  }
}
