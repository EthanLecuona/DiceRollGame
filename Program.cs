using DiceRollGame.Game;

var guessGame = new GuessingGame(new Dice());
GameResult gameResult = guessGame.Play();
GuessingGame.PrintResult(gameResult);
Console.ReadKey();