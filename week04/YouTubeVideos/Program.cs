using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      
        Video video1 = new Video("C# Basics Tutorial", "Tech Academy", 600);
        Video video2 = new Video("Object-Oriented Programming Explained", "Code Master", 850);
        Video video3 = new Video("Abstraction in C#", "Programming Hub", 720);

        
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thank you."));
        video1.AddComment(new Comment("Carlos", "I finally understand this topic!"));

       
        video2.AddComment(new Comment("Diana", "Clear and concise."));
        video2.AddComment(new Comment("Ethan", "Could you make more videos like this?"));
        video2.AddComment(new Comment("Fiona", "This helped me with my homework."));
        video2.AddComment(new Comment("George", "Awesome content!"));

       
        video3.AddComment(new Comment("Hannah", "Abstraction makes sense now."));
        video3.AddComment(new Comment("Ivan", "Well structured lesson."));
        video3.AddComment(new Comment("Julia", "Thank you for this video."));

      
        List<Video> videos = new List<Video> { video1, video2, video3 };

      
        foreach (Video video in videos)
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLength()}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine("=================================\n");
        }
    }
}
