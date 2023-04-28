using System;

class Program
{

    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Samsung";
        job2._jobTitle = "Janitor";
        job2._startYear = 2019;
        job2._endYear = 2023;

        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);
    }

}