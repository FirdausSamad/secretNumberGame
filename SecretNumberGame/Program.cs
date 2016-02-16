using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a guessing game where the user has to guess a secret number. 
            After every guess the program tells the user whether their number was too large or too small.
            At the end the number of tries needed should be printed.
            I counts only as one try if they input the same number multiple times consecutively.*/



            int number=0, answer = 5,i=0;
            

            Console.Write("Player 1 enter number :");
           answer = int.Parse(Console.ReadLine());
            Console.Clear();
            while (number != answer)
            {
                Console.Write("Please guess number : ");
                number = int.Parse(Console.ReadLine());
                if (number > answer && (number-answer)>5)
                {
                    Console.WriteLine("too big\n");
                   
                }
                else if(number<answer && (answer-number)>5)
                {
                    Console.WriteLine("too small\n");
                    
                }
                else if(number != answer)
                {
                    Console.WriteLine("You are close\n");
                   
                }
               
                i++;

              
            }
            Console.WriteLine("\nNICE!\n\nNumber of tries : {0}",i);
            Console.ReadLine();
        }
    }
}   
