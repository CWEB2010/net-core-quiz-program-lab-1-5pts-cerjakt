using System;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] answerKey = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" }; //Array of answers in order
            string[] userChoice = new string[] { }; //the option the user selected
            string userSelection;
            string[] questions =
            {"1. .NET Core is created and maintained by how many developers?",
             "2. What company develops .NET Core?",
             "3. ",
             "4. ",
             "5. ",
             "6. ",
             "7. ",
             "8. ",
             "9. ",
             "10. "
            };
            string[,] optionChoices = //sets of 4 options for each question
            {
            {
            "A. 5,000",
            "B. 10,000",
            "C. 15,000",
            "D. 20,000"
            },
            {
            "A. ",
            "B. ",
            "C. ",
            "D. "
            },
            {
            "A. ",
            "B. ",
            "C. ",
            "D. "
            },
            {
            "A. ",
            "B. ",
            "C. ",
            "D. "
            },
            {
            "A. ",
            "B. ",
            "C. ",
            "D. "
            },
            {
            "A. ",
            "B. ",
            "C. ",
            "D. "
            },
            {
            "A. ",
            "B. ",
            "C. ",
            "D. "
            },
            {
            "A. ",
            "B. ",
            "C. ",
            "D. "
            },
            {
            "A. ",
            "B. ",
            "C. ",
            "D. "
            },
            {
            "A. ",
            "B. ",
            "C. ",
            "D. "
            }
            };

            String primingValue; //start the program
            String EXIT = "NumPad2"; //numpad 2 input from user
            String EXIT2 = "D2"; //2 input from user
            int x, y;
            int totalCorrect, totalIncorrect;

            totalCorrect = 0;
            totalIncorrect = 0;

            Console.WriteLine("Welcome, this is a quiz on .NET Core. This quiz will consist of 3 questions. You must have 2 out of 3 correct to pass the quiz");
            Console.WriteLine("To get started, please enter any key besides 2.");

            String userInput = Console.ReadKey().Key.ToString();

            while (userInput != EXIT || userInput != EXIT2) //initiates while loop if user used a key besides 2 as their input.
            {
                for (x = 0; x < questions.Length; x++)
                {
                    Console.WriteLine(questions[x]);

                    for (y = 0; x < optionChoices.Length; x++)
                    {
                        Console.WriteLine(optionChoices[x, y]);
                    }

                    Console.WriteLine("Please enter your selection");

                    userSelection = Console.ReadLine().ToUpper();

                    if (userSelection == answerKey[x])
                    {
                        totalCorrect = totalCorrect + 1;
                        Console.WriteLine("Answer is correct");
                    }
                    else
                    {
                        totalIncorrect++;
                        Console.WriteLine("Answer is incorrect");
                    }

                } //End of while loop
                Console.WriteLine("Thank you for taking the quiz");
            }
        }
    }
}
