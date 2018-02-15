using System.Collections.Generic;
using System;

namespace RockPaperScissors.Models
{

  public class Player
  {
    private int _id;
    private static List<Player> _instances = new List<Player> {};
    private string _name;
    private string _currentMove;

    public Player(string name)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string name)
    {
      _name = name;
    }

    public string GetCurrentMove()
    {
      return _currentMove;
    }

    public void SetCurrentMove(string move)
    {
      _currentMove = move;
    }

    public static List<Player> GetAll()
    {
      return _instances;
    }

    public int GetId()
    {
      return _id;
    }

    public static Player Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static string WhoWins(string PlayerOne, string PlayerTwo)
    {
      if (PlayerOne == "Rock")
      {
        if (PlayerTwo == "Rock")
        {
          return ("Draw");
        } else if (PlayerTwo == "Paper")
        {
          return ("Player Two");
        } else
        {
          return ("Player One");
        }
      }
      else if (PlayerOne == "Paper")
      {
        if (PlayerTwo == "Rock")
        {
          return ("Player One");
        } else if (PlayerTwo == "Paper")
        {
          return ("Draw");
        } else
        {
          return ("Player Two");
        }
      } else // (PlayerOne == "Scissors")
      {
        if (PlayerTwo == "Rock")
        {
          return ("Player Two");
        } else if (PlayerTwo == "Paper")
        {
          return ("Player One");
        } else
        {
          return ("Draw");
        }
      }
    }
  }
}
