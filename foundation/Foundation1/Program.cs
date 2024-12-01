using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Create videos
        Video video1 = new Video("How to bake a cake", "Chef Emma", 300);
        Video video2 = new Video("Guitar Basics", "MusicMan", 600);
        Video video3 = new Video("Daily Workout", "FitnessPro", 900);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial! It really helped me in a pinch!"));
        video1.AddComment(new Comment("Bob", "I Really Loved this Recipe, Can't wait to share it with the family!"));
        video1.AddComment(new Comment("Charlie", "This video was very helpful!"));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "That was Great!"));
        video2.AddComment(new Comment("Eve", "Thanks for sharing, I enjoyed it!"));
        video2.AddComment(new Comment("Franky", "I learned alot From your vid!"));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "That felt Great!!"));
        video3.AddComment(new Comment("Hank", "Challenging but I had alot of fun!"));
        video3.AddComment(new Comment("Ivery", "Well explained with Excellent tips!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display the videos and their comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} Seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine($"Comments: ");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}