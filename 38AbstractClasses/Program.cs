



List<IRentable> rents = new List<IRentable>();
Novel novel = new Novel();
StoryBook storyBook = new StoryBook();

rents.Add(novel);
rents.Add(storyBook);


public interface IRentable
{
    void Rent();
}

public abstract class Book 
{
    public string Name { get; set; }

    public int Mrp { get; set; }

}


public class Novel : Book , IRentable
{
    public string Author { get; set; }

    public string Publisher { get; set; }

    public void Rent()
    {
        Console.WriteLine("not rentable");
    }
}

public class StoryBook : Book, IRentable
{
    public void Rent()
    {
        Console.WriteLine("is rentable");
    }
}
