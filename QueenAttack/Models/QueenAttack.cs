using System.Collections.Generic;
using System;

namespace QueenAttack.Models
{
  public class Queen
  {
    private int _x;
    private int _y;

    public Queen(int x, int y)
    {
      _x = x;
      _y = y;
    }

    public bool SameX(int x)
    {
      return x == _x;
    }

    public bool SameY(int y)
    {
      return y == _y;
    }

    public bool SameDiagonal(int x, int y)
    {
      return Math.Abs(_x - x) == Math.Abs(_y - y);
    }

    public bool CanAttack(int x, int y)
    {
      return SameX(x) || SameY(y) || SameDiagonal(x, y);
    }
  }
}
