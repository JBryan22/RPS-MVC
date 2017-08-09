using System;
using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class RockPaperScissor
  {
    private string _player1;
    private string _player2;

    public RockPaperScissor(string player1, string player2)
    {
      _player1 = player1;
      _player2 = player2;
    }

    public string EvaluatePlay()
    {
      if (_player1 == _player2)
      {
        return "draw";
      }

      else if (_player1 == "rock")
      {
          if(_player2 == "scissors")
          {
            return "Player 1 wins";
          }
          else
          {
            return "Player 2 wins";
          }
      }

      else if (_player1 == "scissors")
      {
        if (_player2 == "paper")
        {
          return "Player 1 wins";
        }
        else
        {
          return "Player 2 wins";
        }
      }

      else
      {
        if (_player2 == "rock")
        {
          return "Player 1 wins";
        }
        else
        {
          return "Player 2 wins";
        }
      }
    }
  }
}
