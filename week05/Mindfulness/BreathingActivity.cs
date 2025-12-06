public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by guiding you through deep breathing exercises.")
    {
    }

    public override void PerformActivity()
    {
        Console.WriteLine("\nGet ready to begin the breathing exercise.");
        PauseWithSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            PauseWithCountdown(5);

            if (DateTime.Now >= endTime) break;

            Console.WriteLine("Now, breathe out...");
            PauseWithCountdown(5);
        }

        Console.WriteLine("\nGreat job! You have completed the breathing exercise.");
    }
}
