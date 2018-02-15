using System.Collections.Generic;
using System;

namespace ScrabbleScore.Models
{

  public class Word
  {
    private int _id;
    private static List<Word> _instances = new List<Word> {};
    private string _name;
    private string _currentScore;

    public Word(string name)
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

    public string GetCurrentScore()
    {
      return _currentScore;
    }

    public void SetCurrentScore(int score)
    {
      _currentScore = score;
    }

    public static List<Word> GetAll()
    {
      return _instances;
    }

    public int GetId()
    {
      return _id;
    }

    public static Word Find(int searchId)
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

    // METHOD TO CALCULATE WORD SCORE FROM GIVEN WORD
    // VIA LETTER ARRAY or DICTIONARY COMPARISONS, etc.
    // public static string WhoWins(string PlayerOne, string PlayerTwo)
    // {
    //   if (PlayerOne == "Rock")
    //   {
    //     if (PlayerTwo == "Rock")
    //     {
    //       return ("Draw");
    //     } else if (PlayerTwo == "Paper")
    //     {
    //       return ("Player Two");
    //     } else
    //     {
    //       return ("Player One");
    //     }
    //   }
    //   else if (PlayerOne == "Paper")
    //   {
    //     if (PlayerTwo == "Rock")
    //     {
    //       return ("Player One");
    //     } else if (PlayerTwo == "Paper")
    //     {
    //       return ("Draw");
    //     } else
    //     {
    //       return ("Player Two");
    //     }
    //   } else // (PlayerOne == "Scissors")
    //   {
    //     if (PlayerTwo == "Rock")
    //     {
    //       return ("Player Two");
    //     } else if (PlayerTwo == "Paper")
    //     {
    //       return ("Player One");
    //     } else
    //     {
    //       return ("Draw");
    //     }
    //   }
    // }
  }
}
