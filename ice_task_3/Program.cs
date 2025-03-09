using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ice_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an ArrayList to store the questions
            ArrayList questions = new ArrayList();

            //Prompt the user to enter the number of questions
            Console.WriteLine("Enter the number of questions: ");
            int numOfQuestions = int.Parse(Console.ReadLine());

            //For loop to input each quetion
            for (int i = 0; i < numOfQuestions; i++)
            {
                Console.WriteLine($"Enter question {i + 1}:");
                string question = Console.ReadLine();
                questions.Add(question);
            }

            //Diplay the entered questions
            Console.WriteLine("\nEntered Questions:");
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}:" + questions[i]);
            }
        }
    }
}
