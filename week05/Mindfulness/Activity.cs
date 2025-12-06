public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Called at the start of each activity
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like this session to last? ");
    }


    public void DisplayEndMessage()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        PauseWithSpinner(3);
    }


    public abstract void PerformActivity();

    protected void PauseWithSpinner(int seconds)
    {
   
        Console.Write("Processing");
        for (int i = 0; i < seconds; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine();
    }

    protected void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
