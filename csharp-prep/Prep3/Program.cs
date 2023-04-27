using System;

class Program
{
    static void Main(string[] args)
    {
        //This was to assign the magic number
        //Console.Write("What is the magic number? ");
        //string magic = Console.ReadLine();

        //int num = int.Parse(magic);

        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1,101);

        int guess = -1;


        while (guess != num)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        
            
            if (guess > num)
            {
                Console.WriteLine("Lower");                
            }
        
            else if (guess < num)
            {
                Console.WriteLine("Higher");                
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
    

    }
}