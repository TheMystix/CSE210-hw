using System;

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture(
            new Reference("Ezekiel", 25, 17),
            "And I will execute great vengeance upon them with furious rebukes; and they shall know that I am the Lord, when I shall lay my vengeance upon them."
        );

        Random rand = new Random();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("Scripture fully hidden!");
                Console.WriteLine("Press ENTER to exit.");
                Console.ReadLine();
                break;
            }

            Console.WriteLine("\nPress ENTER to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            int numToHide = rand.Next(3, 5); // Hide 3–4 random words
            scripture.HideRandomWords(numToHide);
        }
    }
}
