using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Introduction to C# Programming",
            "Coding Central",
            1200);

        video1.AddComment(new Comment("Elphus", "This lesson was very helpful."));
        video1.AddComment(new Comment("Ryan", "I understand classes much better now."));
        video1.AddComment(new Comment("Dean", "Great explanation and examples."));
        videos.Add(video1);

        Video video2 = new Video(
            "Exploring South African Wildlife",
            "Travel Discovery",
            1500);

        video2.AddComment(new Comment("Nomvuyo", "The scenery was beautiful."));
        video2.AddComment(new Comment("Flourie", "I learned something new today."));
        video2.AddComment(new Comment("Ismail", "Amazing video quality."));
        videos.Add(video2);

        Video video3 = new Video(
            "Easy Home Workout Routine",
            "Fitness Daily",
            900);

        video3.AddComment(new Comment("Sarah", "Perfect for beginners."));
        video3.AddComment(new Comment("Michael", "I'll try this tomorrow."));
        video3.AddComment(new Comment("Lebo", "Great workout plan."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}