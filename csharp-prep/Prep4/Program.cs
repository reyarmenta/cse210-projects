using System;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
            
        }

        int sum = numbers.AsQueryable().Sum();
        Console.WriteLine("The sum is: {0}", sum);
    
        double avg = Queryable.Average(numbers.AsQueryable());
        Console.WriteLine("The average is: " + avg);

        Console.WriteLine("The larges number is: " + numbers.Max());

    }
}