using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {   
            bool shouldAskQuestions = true;
            while (shouldAskQuestions == true)
            {
                // The program will continue to run if prompted by user
                AskQuestions();
                Console.WriteLine("Would you like to continue y/n");
             
                string answer = Console.ReadLine();
                if (answer != "y")
                {
                    shouldAskQuestions = false;
                }
            }
        }
        static void AskQuestions()
        {  
           //Area of a rectangle: A = length * width
           //Perimeter of a rectangle: P = 2*(length + width)

            Console.WriteLine("Please write the length of your rectangle:");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Please write the width of your rectangle:");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("The Area of your rectangle is: {0}", area);
            Console.WriteLine("The Perimeter of your rectangle is: {0}", perimeter);
        
           
        }
    }
}
