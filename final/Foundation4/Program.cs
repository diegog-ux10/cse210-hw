class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now.AddDays(-1), 30, 3), // 3 miles in 30 minutes
            new Cycling(DateTime.Now.AddDays(-2), 45, 12), // 12 mph for 45 minutes
            new Swimming(DateTime.Now.AddDays(-3), 60, 40) // 40 laps in 60 minutes
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
