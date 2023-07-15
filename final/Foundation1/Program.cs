using System;
using System.Collections.Generic;

public class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Video1", "Author1", 120);
        Video video2 = new Video("Video2", "Author2", 240);
        Video video3 = new Video("Video3", "Author3", 360);

        // Add comments to videos
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "I love this!"));

        video2.AddComment(new Comment("User3", "Very informative."));
        video2.AddComment(new Comment("User4", "Thanks for sharing."));

        video3.AddComment(new Comment("User5", "Awesome content!"));
        video3.AddComment(new Comment("User6", "Subscribed!"));

        // Add videos to list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.Length} seconds, Number of comments: {video.GetNumberOfComments()}");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Comment by {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
