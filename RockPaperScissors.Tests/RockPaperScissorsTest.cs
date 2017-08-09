using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RockPaperScissorTest
  {
    [TestMethod]
    public void EvaluatePlay_PlayersEnterSameThing_True()
    {
      RockPaperScissor newGame = new RockPaperScissor("rock", "rock");
      string expected = "draw";
      string actual = newGame.EvaluatePlay();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void EvaluatePlay_Player1RockPlayer2Scissors_True()
    {
      RockPaperScissor newGame = new RockPaperScissor("rock", "scissors");
      string expected = "Player 1 wins";
      string actual = newGame.EvaluatePlay();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void EvaluatePlay_Player1ScissorsPlayer2Paper_True()
    {
      RockPaperScissor newGame = new RockPaperScissor("scissors", "paper");
      string expected = "Player 1 wins";
      string actual = newGame.EvaluatePlay();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void EvaluatePlay_Player1PaperPlayer2Rock_True()
    {
      RockPaperScissor newGame = new RockPaperScissor("paper", "rock");
      string expected = "Player 1 wins";
      string actual = newGame.EvaluatePlay();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void EvaluatePlay_Player1RockPlayer2Paper_True()
    {
      RockPaperScissor newGame = new RockPaperScissor("rock", "paper");
      string expected = "Player 2 wins";
      string actual = newGame.EvaluatePlay();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void EvaluatePlay_Player1ScissorsPlayer2Rock_True()
    {
      RockPaperScissor newGame = new RockPaperScissor("scissors", "rock");
      string expected = "Player 2 wins";
      string actual = newGame.EvaluatePlay();
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void EvaluatePlay_Player1PaperPlayer2Scissors_True()
    {
      RockPaperScissor newGame = new RockPaperScissor("paper", "scissors");
      string expected = "Player 2 wins";
      string actual = newGame.EvaluatePlay();
      Assert.AreEqual(expected, actual);
    }


  }
}
