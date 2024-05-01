class Program
{
    static void Main()
    {
        // Create a resume for a person
        resumes.Resume myResume = new resumes.Resume("John Doe");

        // Add jobs to the resume
        jobs.Job job1 = new("Microsoft", "Software Engineer", 2019, 2022);
        jobs.Job job2 = new("Google", "Data Analyst", 2016, 2019);

        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display the resume
        myResume.DisplayResume();
    }
}
