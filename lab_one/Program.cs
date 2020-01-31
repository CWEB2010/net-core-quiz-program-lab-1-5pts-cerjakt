//J.Cermak

using System;

namespace lab_one
{
    class Program
    {
        static void Main()
        {
            string[] answerKey = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" }; //Array of answers in order
            string[] userChoice; //list of the choices
            string userSelection; //option user selected
            string[] questions = //list of questions
            {"1. .NET Core is created and maintained by how many developers?",
             "2. What company primarily develops .NET Core?",
             "3. What is the current version of .NET Core?",
             "4. What date was .NET Core released?",
             "5. What is .NET Core written in?",
             "6. What is not an operating system for .NET Core?",
             "7. What is .NET Core released with?",
             "8. What is the package manager for .NET Core?",
             "9. When was version 3.1 of .Net Core released?",
             "10. .NET Core is the successor of what?"
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
            "A. Apple",
            "B. Microsoft",
            "C. Google",
            "D. Samsung"
            },
            {
            "A. 2.2",
            "B. 2.0",
            "C. 3.1",
            "D. 3.0"
            },
            {
            "A. June 27, 2016",
            "B. June 26, 2016",
            "C. June 25, 2016",
            "D. June 24, 2016"
            },
            {
            "A. Swift",
            "B. Java",
            "C. Python",
            "D. C++ & C#"
            },
            {
            "A. Chrome OS",
            "B. Windows",
            "C. Linux",
            "D. macOS"
            },
            {
            "A. Visual Studio",
            "B. Komodo IDE",
            "C. NetBeans",
            "D. Eclipse"
            },
            {
            "A. Snappy",
            "B. yum",
            "C. nuGet",
            "D. Homebrew"
            },
            {
            "A. December 6, 2019",
            "B. December 5, 2019",
            "C. December 4, 2019",
            "D. December 3, 2019"
            },
            {
            "A. .NET Framework",
            "B. Cocoa",
            "C. Cocoa Touch",
            "D. ActiveX"
            }
            };

            String primingValue = "D1"; //1 input from user
            String primingValue2 = "NumPad1"; //numpad 1 input from user
            String EXIT = "NumPad2"; //numpad 2 input from user
            String EXIT2 = "D2"; //2 input from user
            int x, y; //assigning x and y to integers
            int totalCorrect, totalIncorrect; //assigning total correct to integers

            Console.WriteLine("Welcome, this is a quiz on .NET Core. This quiz will consist of 3 questions. You must have 7 out of 10 correct to pass the quiz"); //prompt text
            Console.WriteLine("To get started, please enter any key besides 2."); //prompt text

            String userInput = Console.ReadKey().Key.ToString(); //required user input

            while (userInput != EXIT && userInput != EXIT2) //initiates while loop if user used a key besides 2 as their input.
            {

                totalCorrect = 0; //setting total to 0 for restarting the quiz
                totalIncorrect = 0; //setting total to 0 for restarting quiz

                userChoice = new string[answerKey.Length]; //make it so user choice array is the same length as answer key array

                for (x = 0; x < questions.Length; x++) //for loop that ends when it passes 10 questions
                {
                    Console.WriteLine("\nPlease enter your selection"); //prompt text
                    Console.WriteLine(questions[x]); //writes the question

                    for (y = 0; y < optionChoices.GetLength(1); y++) //loop for options choices
                    {
                        Console.WriteLine(optionChoices[x, y]);
                    }

                    userSelection = Console.ReadLine().ToUpper(); //answer input

                    userChoice[x] = userSelection; //adds answer to array of choices

                    if (userSelection == answerKey[x]) //if statement for verifying if your answer was correct or not
                    {
                        totalCorrect++;
                        Console.WriteLine("You got it right");
                    }
                    else
                    {
                        totalIncorrect++;
                        Console.WriteLine("You got it wrong");
                    }
                } //End of while loop

                Console.WriteLine("\nThe quiz has concluded, your results are listed below");
                Console.WriteLine("\nTotal Correct: " + totalCorrect);
                Console.WriteLine("\nTotal Incorrect: " + totalIncorrect);

                if (totalCorrect >= 7) //mesasures how many were correct
                {
                    Console.WriteLine("\nYou passed the quiz"); //prompt text
                }
                else //if you answers less than 2 correct, then this happens
                {
                    Console.WriteLine("\nSorry you failed, please retake the quiz"); //prompt text
                }

                for (int i = 0; i < 10; i++) //iterates through a list telling you your answers and what's correct
                {
                    int q = i + 1; //int for question number
                    Console.WriteLine("\nYour answer for question " + q);
                    Console.WriteLine(userChoice[i] + ", the correct answer is " + answerKey[i]);
                }

                bool loop = true; //establishes a true boolean value

                Console.Write("To retake the quiz, please enter 1 or enter 2 to exit the quiz."); //prompt text

                while (loop) //while true
                {
                    userInput = Console.ReadKey().Key.ToString(); //input from user
                    Console.Write("");
                    if (userInput == primingValue || userInput == primingValue2 || userInput == EXIT || userInput == EXIT2) //if 1 is entered, the quiz will restart
                    {
                        loop = false; //breaks loop
                    }
                }
            }
            Console.WriteLine("\nThank you for taking the quiz"); //prompt text
        }
    }
}
