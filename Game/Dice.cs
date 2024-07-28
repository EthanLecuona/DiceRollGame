namespace DiceRollGame.Game
{
    public class Dice
    {
        private readonly Random _random;
        private readonly int SidesCount = 6;
        public Dice()
        {
            _random = new Random();
        }

        public int Roll() => _random.Next(1, SidesCount + 1);
    }

}
