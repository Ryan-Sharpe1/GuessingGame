using System;

namespace GuessingGame
{
    class Program
    {




        static void Main(string[] args)
        {
            string secretWord = "Penguin";

            int guessLimit = 3;
            int guessCount = 0;
            int remainingGuesses = guessLimit - guessCount;

            int questionLimit = 3;
            int questionCount = 0;
            int remainingQuestions = questionLimit - questionCount;


            if (guessCount == 0 && questionCount == 0)
            {
                Console.WriteLine("Welcome to Ryans Animal Guessing Game! \n");

            }


            while (guessCount < guessLimit && questionCount < questionLimit)
            {
                Console.WriteLine(" You have " + remainingGuesses + " Guesses and " + remainingQuestions + " Questions remaining. \n");
                Console.WriteLine("Would you like to ask a Question or Guess an Answer? \n");
                string guessorQuestion = Console.ReadLine();
                Console.WriteLine("");

                if (guessorQuestion == "guess" | guessorQuestion == "Guess")
                {
                    guessCount++;
                    GuessingGames(secretWord);
                }
                if (guessorQuestion == "Question" | guessorQuestion == "question")
                {
                    questionCount++;
                    QuestionTime(secretWord);
                }
                else
                {
                    Console.WriteLine("Invalid Option\n");
                }
            }

            while (guessCount < guessLimit && questionCount >= questionLimit)
            {
                Console.WriteLine("No more questions, just guess: ");
                GuessingGames(secretWord);
            }

            if (guessCount >= guessLimit)
            {
                Console.WriteLine("You Lose!");
            }

        }


        static void GuessingGames(string secretWord)
        {
            string answer = secretWord;

            Console.WriteLine("\nEnter Guess: \n");
            string guess = Console.ReadLine();


            if (answer == guess)
            {
                Console.WriteLine("\nYou Win!\n");
            }
            else
            {
                Console.WriteLine("\nTry Again!\n");
            }
        }

        static void QuestionTime(string secretWord)
        {

            string answer = secretWord;

            string[] biggerThanFridge = { "Elephant", "Giraffe", "Lion", "Tiger", "Bear", "Crocodile" };
            bool isBigAnimal = false;


            Console.WriteLine("\nQuestion Options : " + "\n 1: Is it bigger than a fridge?\n");

            int questionOption = int.Parse(Console.ReadLine());


            if (questionOption == 1)
            {
                foreach (var bigAnimal in biggerThanFridge)
                {
                    if (answer == bigAnimal)
                    {
                        isBigAnimal = true;
                        break;
                    }
                    else
                    {
                        isBigAnimal = false;
                    }
                }
                    Console.WriteLine(isBigAnimal);
            }



        }
    }
}
