using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //This code was to print just the company
        //Console.WriteLine($"{job1._company}");
        //Console.WriteLine($"{job2._company}");

        //Display both jobs
        //job1.Display();
        //job2.Display();

        Resume myResume = new Resume();
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //verifying to see if I can display first job Title
        //Console.WriteLine($"{myResume._jobs[0]._jobTitle}");

        myResume.Display();
        
    }
}