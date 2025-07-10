using System;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C#", "CodeGuru", 1200);
        video1.AddComment(new Comment("Alice", "Great tutorial, very clear!"));
        video1.AddComment(new Comment("Bob", "Helped me understand classes better."));
        video1.AddComment(new Comment("Charlie", "Could you do a video on ASP.NET next?"));
        videos.Add(video1);

        Video video2 = new Video("Understanding Polymorphism", "TechExplainer", 900);
        video2.AddComment(new Comment("David", "Polymorphism finally clicked for me!"));
        video2.AddComment(new Comment("Eve", "Excellent explanation, thank you!"));
        video2.AddComment(new Comment("Frank", "A bit fast-paced, but good content."));
        video2.AddComment(new Comment("Grace", "Love the examples used here."));
        videos.Add(video2);

        Video video3 = new Video("Data Structures in C#", "AlgoMaster", 2000);
        video3.AddComment(new Comment("Heidi", "Very comprehensive, useful for interviews."));
        video3.AddComment(new Comment("Ivan", "The section on linked lists was particularly helpful."));
        video3.AddComment(new Comment("Judy", "Can you cover graph algorithms?"));
        videos.Add(video3);

        Video video4 = new Video("Debugging Tips for C#", "DebugPro", 600);
        video4.AddComment(new Comment("Karen", "These tips saved me so much time!"));
        video4.AddComment(new Comment("Liam", "Wish I knew these earlier."));
        video4.AddComment(new Comment("Mia", "Simple yet effective."));
        videos.Add(video4);

// iterate through videos
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.Name}: {comment.Text}");
            }
            Console.WriteLine("----------------------------------------\n");
        }
    }
}