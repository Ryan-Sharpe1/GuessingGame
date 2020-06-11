using System;

namespace GuessingGame
{
    class Program
    {




        static void Main(string[] args)
        {
            string[] animals = { "Penguin", "Elephant", "Giraffe", "Lion", "Tiger", "Bear", "Crocodile", "Dolphin", "Shark", "Eagle", "Ostrich", "LLama" };

            Random r = new Random();

            string secretWord = animals[r.Next(0, animals.Length)];

            int guessLimit = 3;
            int guessCount = 0;
            int remainingGuesses = guessLimit;

            int questionLimit = 3;
            int questionCount = 0;
            int remainingQuestions = questionLimit;


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
                    GuessingGames(secretWord);
                    guessCount++;
                    remainingGuesses--;
                }
                if (guessorQuestion == "Question" | guessorQuestion == "question")
                {
                    QuestionTime(secretWord);
                    questionCount++;
                    remainingQuestions--;
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
                Console.WriteLine("You Lose!\n The Answer was " + secretWord);
                Environment.Exit(0);

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
                Environment.Exit(0);
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
            string[] animalHasLegs = {"Elephant", "Giraffe", "Lion", "Tiger", "Bear", "Crocodile", "Penguin", "LLama", "Ostrich", "Eagle" };
            string[] animalHasWings = {"Ostrich", "Eagle" };
            string[] animalCanSwim = {"Shark", "Dolphin" };
            string[] animalHasLongNeck = {"Giraffe", "LLama" };
            bool isBigAnimal = false;
            bool hasLegs = false;
            bool hasWings = false;
            bool canSwim = false;
            bool hasLongNeck = false;



            Console.WriteLine("\nQuestion Options : \n " +
                "1: Is it bigger than a fridge?\n " +
                "2: Does it have Legs?\n " +
                "3: Does it have wings?\n " +
                "4: Can it Swim?\n " +
                "5: Does it have a long neck?\n ");

            int questionOption = int.Parse(Console.ReadLine());
            Console.WriteLine("");


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
                Console.WriteLine("1: Is it bigger than a fridge? " + isBigAnimal);
                Console.WriteLine("");
            }
            if (questionOption == 2)
            {
                foreach (var animalLegs in animalHasLegs)
                {
                    if (answer == animalLegs)
                    {
                        hasLegs = true;
                        break;
                    }
                    else
                    {
                        hasLegs = false;
                    }
                }
                Console.WriteLine("2: Does it have Legs? " + hasLegs);
                Console.WriteLine("");
            }
            if (questionOption == 3)
            {
                foreach (var animalWings in animalHasWings)
                {
                    if (answer == animalWings)
                    {
                        hasWings = true;
                        break;
                    }
                    else
                    {
                        hasWings = false;
                    }
                }
                Console.WriteLine("3: Does it have wings? " + hasWings);
                Console.WriteLine("");
            }
            if (questionOption == 4)
            {
                foreach (var animalSwim in animalCanSwim)
                {
                    if (answer == animalSwim)
                    {
                        canSwim = true;
                        break;
                    }
                    else
                    {
                        canSwim = false;
                    }
                }
                Console.WriteLine("4: Can it Swim? " + canSwim);
                Console.WriteLine("");
            }
            if (questionOption == 5)
            {
                foreach (var animalNeck in animalHasLongNeck)
                {
                    if (answer == animalNeck)
                    {
                        hasLongNeck = true;
                        break;
                    }
                    else
                    {
                        hasLongNeck = false;
                    }
                }
                Console.WriteLine("5: Does it have a long neck? " + hasLongNeck);
                Console.WriteLine("");
            }

        }
    }
}
