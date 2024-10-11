using System;

class Program
{
    static void InitializeProgram(List<Video> videoList)
    {
         Comment comment1;Comment comment2;Comment comment3;
        Video videos; 
        List<Comment> commentList;



        comment1 = new Comment ("Estefania","oliver wants to know if you play the guitar");
        comment2 = new Comment ("Paola","what is the video for");
        comment3 = new Comment ("SERVANT","my shirt is beautiful "); //all of the comments came from a kid

        commentList = new List <Comment> {comment1, comment2, comment3};
        videos = new Video ("Oliver","How to entertain a kid",900,commentList);
        videoList.Add (videos); 


        comment1 = new Comment ("andres","its making to much sun ");
        comment2 = new Comment ("camilo","raimbow is about to comeout");
        comment3 = new Comment ("SERVANT","monday i'll drive my car "); //all of the comments came from a kid

        commentList = new List <Comment> {comment1, comment2, comment3};
        videos = new Video ("tiago","it takes two ",350,commentList);
        videoList.Add (videos); 

        comment1 = new Comment ("jovita ","hello world");
        comment2 = new Comment ("hector","cats and dogs are raining on tv");
        comment3 = new Comment ("braxton","there's a dog "); //all of the comments came from a kid

        commentList = new List <Comment> {comment1, comment2, comment3};
        videos = new Video ("servant","we bought a sofa and how to take care of it",200,commentList);
        videoList.Add (videos); 
    }
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>{};
        InitializeProgram(videoList);
        foreach(Video video in videoList)
        {
            video.Display();
            Console.WriteLine();
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}
