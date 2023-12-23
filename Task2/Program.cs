Post post1 = new Post();
post1.Title = "C#";
post1.Description = "Good";
post1._LikeCount();

Post post2 = new Post();
post2.Title = "Js";
post2.Description = "Bad";
post2._LikeCount();

Post post3 = new Post();
post3.Title = "C++";
post3.Description = "Hello";
post3._LikeCount();

Post post4 = new Post();
post4.Title = ".Net";
post4.Description = "Akk";
post4._LikeCount();

Post post5 = new Post();
post5.Title = "Goland";
post5.Description = "Noo";
post5._LikeCount();

List<Post> _posts = new List<Post>();
 


foreach (var item in _posts )
{
    System.Console.WriteLine();
}



public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int LikeCount { get; set; }

    public List<Post> posts = new List<Post>();
    public List<Post> Comments  { get; set; }
    public bool IsPublished { get; set; }

    public void Publish()
    {
        System.Console.WriteLine("The post is published.");
        IsPublished = true;
    }
    public int _LikeCount()
    {
         return LikeCount + 1;
    }
    public void Comment( Post messege)
    {
         posts.Add(messege);
    }
}