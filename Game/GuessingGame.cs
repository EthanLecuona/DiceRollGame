using DiceRollGame.UserCommunication;

namespace DiceRollGame.Game
{
    public class GuessingGame
    {
        private readonly Dice _dice;
        private readonly int RollsToWin = 3;
        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine($"Dice rolled. Guess what number it shows in {RollsToWin} tries.");

            var triesLeft = RollsToWin;
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number:");
                if (guess == diceRollResult)
                {
                    return GameResult.Won;
                }
                --triesLeft;
            }
            return GameResult.Lost;
        }

        public static void PrintResult(GameResult result)
        {
            string message = result == GameResult.Won ? "You win!" : "You lost!";

            Console.WriteLine(message);
        }

    }

}
