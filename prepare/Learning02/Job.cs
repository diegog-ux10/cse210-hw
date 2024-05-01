using System;

namespace jobs {
    public class Job(string company, string jobTitle, int startYear, int endYear)
    {
        // Member variables
        private readonly string _company = company;
        private readonly string _jobTitle = jobTitle;
        private readonly int _startYear = startYear;
        private readonly int _endYear = endYear;

        // Method to display job information
        public void DisplayJobInfo()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }
}
