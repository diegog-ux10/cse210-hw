using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Facebook";
        job1._jobTitle = "Fullstack Developer";
        job1._startYear = 2020;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._company = "SpaceX";
        job2._jobTitle = "Front End Developer";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume =  new Resume();
        myResume._name = "Diego Granados";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
