class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));

        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 600);
        video2.AddComment(new Comment("Dave", "Excellent content."));
        video2.AddComment(new Comment("Eve", "Helpful tips."));
        video2.AddComment(new Comment("Frank", "Thanks for sharing."));

        Video video3 = new Video("C# Design Patterns", "Mike Johnson", 450);
        video3.AddComment(new Comment("Grace", "Well explained."));
        video3.AddComment(new Comment("Heidi", "Clear and concise."));
        video3.AddComment(new Comment("Ivan", "Very useful."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.GetVideoDetails();
        }
    }
}
