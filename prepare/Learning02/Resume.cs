using System;
using System.Collections.Generic;

namespace resumes {
    public class Resume(string personName)
    {
        // Member variables
        private readonly string _personName = personName;
        private readonly List<jobs.Job> _jobs = [];

        // Method to add a job to the resume
        public void AddJob(jobs.Job job)
        {
            _jobs.Add(job);
        }

        // Method to display the resume
        public void DisplayResume()
        {
            Console.WriteLine($"Resume of {_personName}:");
            foreach (jobs.Job job in _jobs)
            {
                job.DisplayJobInfo();
            }
        }
    }

}
