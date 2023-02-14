public class Singleton
{
    private static int _totalVotes = 0;

    public Singleton()
    {
    }

    public void RegisterVote()
    {
        _totalVotes += 1;
        Console.WriteLine("Registered Vote #" + _totalVotes);
    }

    public static int TotalVotes() //Will count the total number of votes
    {
        {
            return _totalVotes;
        }
    }
}


