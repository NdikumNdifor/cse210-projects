using System;

class Program
{
    static void Main(string[] args)
    {
        // This part of the program is to set the magic number

 /*     Console.Write("What is the magic number? ");
        string myMagicNumber = Console.ReadLine();
        int theNumber = int.Parse(myMagicNumber);

        // Initializes the guess number to -1
        int guess = -1;

        // Keeps on looping while the guess is not equale to the set value(the magic number)
        // and guide the user on his next choice
        while (guess != theNumber)
            {
                Console.Write("What is your guess number? ");
                myMagicNumber = Console.ReadLine();
                guess = int.Parse(myMagicNumber);
                if (guess == theNumber)
                {
                    Console.WriteLine("You have guessed it correctly");
                }
                else if (guess > theNumber)
                {
                    Console.WriteLine("You guessed High, guess lower"); 
                }
                else if (guess < theNumber)
                {
                    Console.WriteLine("You guessed Low, guess higher");
                }
            }           */


        // Generate a random nuber between 1-100
        Random randomGenerator = new Random();
        int theNumber = randomGenerator.Next(1, 100);

        // Initializes the guess number to -1
        int guess = -1;

        // Keeps on looping while the guess is not equale to the set value(the magic number)
        // and guide the user on his next choice
        while (guess != theNumber)
            {
                Console.Write("What is your guess number? ");
                string myMagicNumber = Console.ReadLine();
                guess = int.Parse(myMagicNumber);
                if (guess == theNumber)
                {
                    Console.WriteLine("You have guessed it correctly");
                }
                else if (guess > theNumber)
                {
                    Console.WriteLine("You guessed High, guess lower"); 
                }
                else if (guess < theNumber)
                {
                    Console.WriteLine("You guessed Low, guess higher");
                }
            }
    }                
}