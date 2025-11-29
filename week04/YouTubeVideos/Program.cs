using System;
using System.Collections.Generic;

public class DisplayApp
{
    public static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Basics of Photography", "Peter Parker", 600);
        Video video2 = new Video("Writing Your First News Article", "Clark Kent", 480);

        video1.AddComment(new Comment("Edward", "Brock", "Not bad, but could be better."));
        video1.AddComment(new Comment("John", "Jameson", "Loved this. Do you know anything about photographing spiders?"));

        video2.AddComment(new Comment("Lois", "Lane", "Great video! You look familiar."));
        video2.AddComment(new Comment("Perry", "White", "I can't wait to share this with my team."));

        videos.Add(video1);
        videos.Add(video2);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");

            var comments = video.GetComments();
            Console.WriteLine($"Comments ({comments.Count}):");

            foreach (var comment in comments)
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}