
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video(
            "Learn C# in 30 Minutes",
            "John Smith",
            1800);

        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very easy to follow."));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing."));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video(
            "Object-Oriented Programming Explained",
            "Jane Doe",
            2400);

        video2.AddComment(new Comment("David", "Excellent explanation."));
        video2.AddComment(new Comment("Emma", "This helped me understand classes."));
        video2.AddComment(new Comment("Frank", "Very informative video."));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video(
            "Database Design Basics",
            "Michael Brown",
            2100);

        video3.AddComment(new Comment("Grace", "Clear examples."));
        video3.AddComment(new Comment("Henry", "I learned a lot."));
        video3.AddComment(new Comment("Isabella", "Please make more videos!"));

        videos.Add(video3);

        // Display all videos
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
