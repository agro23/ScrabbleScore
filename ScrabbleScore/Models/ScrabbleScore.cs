using System.Collections.Generic;
using System;

namespace ScrabbleScore.Models
{

  public class Word
  {
    private string _name;
    private static List<Word> _instances = new List<Word> {};
    private int _id;
    private static Dictionary<string, int> _wordPoints = new Dictionary<string, int>()
    {
      {"A", 1}, {"B", 3}, {"C", 3}, {"D", 2}, {"E", 1},
      {"F", 4}, {"G", 2}, {"H", 4}, {"I", 1}, {"J", 8},
      {"K", 5}, {"L", 1}, {"M", 3}, {"N", 1}, {"O", 1},
      {"P", 3}, {"Q", 10}, {"R", 1}, {"S", 1}, {"T", 1},
      {"U", 1}, {"V", 4}, {"W", 4}, {"X", 8},	{"Y", 4},
      {"Z", 10}
    };
    //
    // A, E, I, O, U, L, N, R, S, T       1
    // B, C, M, P                         3
      // F, H, V, W, Y                      4
      // K                                  5
      // J, X                               8
      // Q, Z                               10
    //

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
    public static int GetPoint(string letter)
    {
      return(_wordPoints[letter]);
    }
    public static List<Word> GetAll()
    {
      return _instances; //
    }
    public int GetId()
    {
      return _id;
    }
    public static Word Find(int searchId)
    {
      return _instances[searchId-1]; //
    }
    public void Save()
    {
    _instances.Add(this);
    }
    public static void ClearAll()
    {
    _instances.Clear(); //
    }
  }

  //
  //
  // public class Word
  // {
  //   private int _id;
  //   private static List<Word> _instances = new List<Word> {};
  //   private string _name;
  //   private string _currentScore;
  //
  //   public Word(string name)
  //   {
  //     _name = name;
  //     _instances.Add(this);
  //     _id = _instances.Count;
  //   }
  //
  //   public string GetName()
  //   {
  //     return _name;
  //   }
  //
  //   public void SetName(string name)
  //   {
  //     _name = name;
  //   }
  //
  //   public string GetCurrentScore()
  //   {
  //     return _currentScore;
  //   }
  //
  //   public void SetCurrentScore(int score)
  //   {
  //     _currentScore = score;
  //   }
  //
  //   public static List<Word> GetAll()
  //   {
  //     return _instances;
  //   }
  //
  //   public int GetId()
  //   {
  //     return _id;
  //   }
  //
  //   public static Word Find(int searchId)
  //   {
  //     return _instances[searchId-1];
  //   }
  //
  //   public void Save()
  //   {
  //     _instances.Add(this);
  //   }
  //
  //   public static void ClearAll()
  //   {
  //     _instances.Clear();
  //   }

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
