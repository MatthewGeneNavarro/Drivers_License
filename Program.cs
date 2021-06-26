// Matthew Navarro
//6-23-2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Driver_License
{
    class Program
    {





        static void Main(string[] args)
        {
            // local variables to hold user input and for loop
            char userInput = ' '; // stores user answer choice and will be compared to the answer key
            int numright = 0 ; // tracks the correct amount of questions. 
            int numWrong = 0; // tracks num wrong



            // This list will be compared to the users input.
            List<char> CorrectAnswers = new List<char> { 'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D', 'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A' };

            // This list will contain the user input
            List<char> UserAnswers = new List<char>();

            Console.WriteLine("Please take exam.");



            void TakeExam()
            {
                for (int questionNum = 0; questionNum < 20; questionNum++)
                {
                    
                    Console.WriteLine("Please enter A, B, C or D for question {0} ", questionNum + 1);
                    userInput = Convert.ToChar(Console.ReadLine());

                    if (userInput == 'A' || userInput == 'B' || userInput == 'C' || userInput == 'D')
                    {
                        UserAnswers.Add(userInput);
                    }
                    else
                    {


                        Console.WriteLine("Please enter a valid input.");
                        if (questionNum > 0)
                        {
                            questionNum--;
                        }
                    }
                }
            }

            void GradeExam()
            {

                for (int questionNum = 0; questionNum < 20; questionNum++)
                {
                    if(CorrectAnswers[questionNum] == UserAnswers[questionNum])
                    {
                        numright++;
                    }
                    else
                    {
                        numWrong++;
                    }
                }
                
                Console.WriteLine("you got {0} out of {1} questions right\n", numright, 20);
                Console.WriteLine("You got {0} question wrong\n", numWrong);




            }

            void WrongAnswers()
            {
                for(int questionNum =0; questionNum <20; questionNum++)
                {
                    if (UserAnswers[questionNum] != CorrectAnswers[questionNum])
                    {
                        Console.WriteLine("Question# {0}\ncorrect answer: {1}\nyour answer: {2}\n\n", questionNum+1, CorrectAnswers[questionNum], UserAnswers[questionNum]);
                    }
                }
            }


            TakeExam();
            GradeExam();
            WrongAnswers();



            Console.ReadLine();
        }
    }
}
