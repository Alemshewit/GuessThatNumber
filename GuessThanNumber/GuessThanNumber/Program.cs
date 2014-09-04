using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the guessthatnumber function
            GuessThatNumber();
            //keep console open
            Console.ReadKey();
        }
        //create a function GuessThatNumber that allows the user to enter a number
        //guess correctly a randomly generated number 
        static void GuessThatNumber()
        {
            //declare a variable that store the number of tries it takes to guess correctly
            int numTries = 0;
            //declare a variable that stores the user enter number
            int input = 0;
            //call tje random number constructor to 
            Random rng = new Random();
            //declare a variable that stores the randomly generated number
            int randomNumber = rng.Next(1, 101);

            //print to console instructing the user to play and enter a number
            //between 1 and 100
            Console.WriteLine("Want to play guess the computer's pick?" +
                "\nEnter a number between 1 and 100." +
                "\nYou get seven tries to guess it right!");

            //create a while loop that loops through a few conditions that test 
            //whether the number entered by user is higher, lower or right
            while (input != randomNumber)          
            {
                //print to console instructing the user to enter a number
                Console.WriteLine("Enter your guess: ");
                //take the user input, convert to integer and store in the input variable
                input = Convert.ToInt32(Console.ReadLine());

                //test and if/else if condition to see where the user's guess is in relation
                //to the randomly generated number
                //check if the input number is greater than the random number
                    if (input > randomNumber)
                    {
                        //print to console telling user the guess is too high
                        Console.WriteLine(input + " is high! Try and guess again.");
                        //subtract the random number from the input number and store 
                        //the difference in the variable higherDiff
                        int higherDiff = input - randomNumber; 
                        //test to see if the user input is with in 5 numbers of the random number
                        //and if it is print to console "getting warm", and if 10 number or higher
                        //print "getting cold"
                        if(higherDiff < 5 )
                        {
                            Console.WriteLine("But it's getting warm! You're close");
                        }
                        else if(higherDiff > 10)
                        {
                            Console.WriteLine("But it's getting very cold");
                        }
                        //increment numTries every time the user tries to guess
                        numTries += 1;
                    }
                        //Second condition will test to see if input is less than the randomly picked
                        //number.
                    else if (input < randomNumber)
                    {
                        //subtract the user input from the randomly selected number to see how 
                        //far the user's guess is. 
                        int lowerDiff = randomNumber - input;
                        //print to console that the guess is too low and for the user to try again.
                        Console.WriteLine(input + " is low! Try and guess again.");
                        //test a new condition to check how far the guess is from the random
                        //print "getting cold"
                        if (lowerDiff < 5)
                        {
                            //if it is with in 5 print to console "getting warm", 
                             Console.WriteLine("But it's getting warm! You're close");
                        }
                        //and if it is 10 number or higher
                        else if(lowerDiff > 10)
                        {
                            //print to console it is getting very cold
                            Console.WriteLine("But it's getting very cold");
                        }
                        //increment the number of tries by 1
                        numTries += 1;
                    }
                        //if is neither lower or higher, it is the exact number
                    else 
                    {
                        //print to console that the user got the guess right
                        Console.WriteLine("You got it! " + input + " is the right guess!");
                    }
            }
            //print to console congratulating the user that the guess was right and how many tries it took to get it. 
            Console.WriteLine("Congratulation! It took you " + numTries + " tries, but you did get right!");       
        }
      
    }
   
}

