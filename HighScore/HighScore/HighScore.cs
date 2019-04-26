using System;

namespace HighScore
{
    public class HighScores
    {
        public int GoldCoins { get; private set; } = 1;
        public int Arrows { get; private set; } = 3;
        public int TurnsTaken { get; private set; } = 0;
        public int Score { get; private set; } = 0;
        public bool IsWumpusDead { get; private set; } = false;

        public HighScores()
        {
            GoldCoins = 3;
            Arrows = 3;
            TurnsTaken = 0;
            Score = 0;
            IsWumpusDead = false;
        }
        public bool ShootArrow()
        {
            if (Arrows > 0)
            {
                Arrows--;
                return true;
            }
            return false;


        }
        public void PurchaseArrow()
        {
            Arrows++;
        }
        public void TakeATurn()
        {
            TurnsTaken++;
            GoldCoins++;
            Arrows = 3;
            IsWumpusDead = false;

        }
        public void SpendCoin()
        {
            GoldCoins--;
        }
    }
}
