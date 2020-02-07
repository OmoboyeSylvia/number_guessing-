using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a variable to store the random generated value
            // ask the user to (Guess a number from 1-10)
            // create a variable to hold the guessed value
            // make a while loop to compare the random number and the guessed number
            // if the guessed number is incorrect print (wrong guess, guess again)
            // else print (You got it)
            Random rndnum = new Random();
            int numrnd = rndnum.Next(1, 11);
            Console.WriteLine("guess any number between 1 and 10");
            Console.Write("=> ");
            int count = 0;
            int guessedNum = Convert.ToInt32(Console.ReadLine());
            while (guessedNum != numrnd)
            {
                count++;
                Console.WriteLine("Wrong guess try again");
                Console.Write("=> ");
                guessedNum = Convert.ToInt32(Console.ReadLine());
                if (guessedNum == numrnd)
                {
                    Console.WriteLine("Yay... you got it." + " The random number is " + numrnd); Console.ReadLine();
                    return;
                }
                else if (count == 2)
                {
                    Console.WriteLine("max limit of guess reached");
                    break;
                }
            }
            Console.WriteLine("Do you wish to continue? yes or no?");
            Console.Write("=> ");
            string Response = Convert.ToString(Console.ReadLine());
            while (Response == "no")
            {

                Console.WriteLine("OK,Bye"); Console.ReadLine();
                return;
            }

            do
            {
                Random roundnum = new Random();
                int numround = roundnum.Next(1, 11);
                Console.WriteLine("guess any number between 1 and 10");
                Console.Write("=> ");
                int guessedNumber = Convert.ToInt32(Console.ReadLine());
                while (guessedNum != numrnd)
                {
                    count++;
                    Console.WriteLine("Wrong guess try again");
                    Console.Write("=> ");
                    guessedNum = Convert.ToInt32(Console.ReadLine());
                    if (guessedNum == numrnd)
                    {
                        Console.WriteLine("Yay... you got it." + " The random number is " + numrnd); Console.ReadLine();
                    
                        break;
                        
                    }
                
                }
            }
            while (Response == "yes");
            break;
            continue;


            Console.WriteLine("do you want to start guessing again? yes or no");
            Console.Write("=>");
            string reply = Convert.ToString(Console.ReadLine());

            //if (reply == "no")
            //{
            //    Console.WriteLine("Ok takea....have a nice day"); Console.ReadLine();
            //    return;
            //}
            //else if (reply == "yes")
            //{
            //    Random roundnum = new Random();
            //    int numround = roundnum.Next(1, 11);
            //    Console.WriteLine("guess any number between 1 and 10");
            //    Console.Write("=> ");
            //    int guessedNumber = Convert.ToInt32(Console.ReadLine());
            //    while (guessedNum != numrnd)
            //    {
            //        count++;
            //        Console.WriteLine("Wrong guess try again");
            //        Console.Write("=> ");
            //        guessedNum = Convert.ToInt32(Console.ReadLine());
            //        if (guessedNum == numrnd)
            //        {
            //            Console.WriteLine("Yay... you got it." + " The random number is " + numrnd); Console.ReadLine();
            //            break;
            //        }
            //    }





            //}
            Console.ReadLine();
        }
      
    }
                                                                    
}

                                                       