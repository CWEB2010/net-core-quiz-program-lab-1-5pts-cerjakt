using System;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] answerKey = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" }; //Array of answers in order
            string[] userChoice = new string[10]; //the option the user selected
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
            },
            {
            "A. ",
            "B. ",
            "C. ",
            "D. "
            }
            };
        }
    }
}
