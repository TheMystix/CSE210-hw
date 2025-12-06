public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you overcame a significant challenge.",
        "Recall a moment when you felt truly at peace.",
        "Reflect on an experience that taught you an important lesson.",
        "Remember a time when you made a positive impact on someone else's life."
    };

    private List<string> _questions = new List<string>
    {
        "What did you learn from this experience?",
        "How did this experience change your perspective?",
        "What strengths did you discover about yourself?",
        "How can you apply what you learned in the future?"
    };

    public ReflectingActivity()
        : base("Reflecting Activity",
               "This activity will help you reflect on meaningful experiences in your life.")
    {
    }

    public override void PerformActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on the following questions:");
        PauseWithSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"> {_questions[index]}");
            PauseWithSpinner(10);  // Reflection time per question

            index = (index + 1) % _questions.Count; // Loop through questions
        }

        Console.WriteLine("\nYou have finished your reflection session.");
    }
}
