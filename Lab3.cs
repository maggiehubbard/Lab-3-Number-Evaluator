using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void callMe(int a)
        {
            int ans = a % 2;
            string evenOrOdd;

            if (ans == 0)
            {
                evenOrOdd = "even";
            }
            else
                evenOrOdd = "odd";

            while (evenOrOdd != "odd")
                    {
                        if (a > 2 && a < 25)
                        {
                            Console.WriteLine("Even and less than 25");
                        }
                        else if (a > 25 && a < 61)
                        {
                            Console.WriteLine("Even");
                        }
                        else
                            Console.WriteLine(a + " and even");
                break;
                    }
            while (evenOrOdd == "odd")
            {
                
                Console.WriteLine(a + " and odd");
                break;
            }
        }
    



    static void Main(string[] args)
    {
        //declaring variables
        int number;
        string name;
        string option = "y";
            string userAnswer;
        

            //user prompt for name
               Console.Write("Enter your name: ");
               name = Console.ReadLine();

            //while statement that allows user to continue using program
            while (option == "y")
            {
                //user prompt that asks user to enter a number
                Console.Write("Hello " + name + "! Enter a number between 1 and 100: ");
                userAnswer = Console.ReadLine();

                bool isItANumber = int.TryParse(userAnswer, out number);
                while (!isItANumber)
                {
                    Console.WriteLine("Error: " + name + " the number you entered is not valid. Please try again. ");
                    Console.Write("Enter a number between 1 and 100: ");
                    userAnswer = Console.ReadLine();
                    isItANumber = int.TryParse(userAnswer, out number);
                }
                //if statement to make sure number is between 1 and 100
                if (number < 0 || number > 100)
                {
                    Console.WriteLine("Sorry " + name + "The number you entered is not valid");
                    Console.Write("Enter a number between 1 and 100: ");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                

                //calling function to choose even or odd and display results
                callMe(number);

                //asks user do they want to continue
                Console.Write("Would you like to continue(y/n): ");
                option = Console.ReadLine();


            }

            //Pause before application code
            Console.WriteLine("\n Goodbye " + name + "!\nEnter any key to exit. .");
        Console.ReadKey();
    }
    }
}

