using Microsoft.VisualStudio.TestTools.UnitTesting;
using HighScore;

namespace UnitTestHighScore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HighScore_Arrows_Startswith3()
        {
            var highscores = new HighScores();
            Assert.AreEqual(3, highscores.Arrows);

        }
        public void HighScore_GoldCoins_Startswith3()
        {
            var highscores = new HighScores();
            Assert.AreEqual(3, highscores.GoldCoins);

        }
        public void HighScore_TurnsTaken_Startswith0()
        {
            var highscores = new HighScores();
            Assert.AreEqual(0, highscores.TurnsTaken);

        }
        public void HighScore_Score_Startswith0()
        {
            var highscores = new HighScores();
            Assert.AreEqual(0, highscores.Score);

        }
        public void HighScore_IsWumpusDead_StartswithFalse()
        {
            var highscore = new HighScore();
            Assert.AreEqual(false, highscores.Arrows);

        }
    }
}
