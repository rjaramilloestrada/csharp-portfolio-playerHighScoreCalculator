using System;

namespace ChallengeIfStatements2
{
    internal class Program
    {
        static string playerName;
        static string highScorer = "Meliodas97";
        static string playerInput;
        static int highScore = 35000;
        static int playerScore;
        static void Main(string[] args)
        {
            HighScore();
            Console.Read();
        }

        public static void HighScore()
        {
            Console.WriteLine("Please enter your name: ");
            playerName = Console.ReadLine();
            Console.WriteLine("Now, please enter your score: ");
            playerInput= Console.ReadLine();
            bool playerInputScore = Int32.TryParse(playerInput, out playerScore);

            if (playerScore > highScore)
            {
                Console.WriteLine("New high score is " + playerInput + ".");
                Console.WriteLine("New high score holder is " + playerName + ".");
                Console.Read();
            }
            else if (playerScore < highScore) 
            {
                Console.WriteLine("The old highscore is " + highScore + " and could not be broken. It is still held by " + highScorer + ".");
                Console.Read();
            }
            else
            {
                playerInputScore = false;
                Console.WriteLine("You did not entered a score. Please restart the program");
            }

        }
    }
}
