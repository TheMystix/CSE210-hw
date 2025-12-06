public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List as many things as you can that you are grateful for.",
        "List the people who have positively influenced your life.",
        "List the personal strengths you possess.",
        "List the activities that bring you joy."
    };

    public ListingActivity()
        : base("Listing Activity",
               "Take this time to help you focus on the positive partss of your life by listing them.")
    {
    }

    public override void PerformActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine($"\nYou will have {Duration} seconds to list as many items as you can.");
        Console.WriteLine("Start listing when the countdown ends!");
        PauseWithCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"\nTime's up! You listed {itemCount} items.");
    }
}
