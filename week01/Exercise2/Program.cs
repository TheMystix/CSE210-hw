using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What was your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);



        if (grade >= 97)
            Console.WriteLine(" Your grade is A ");

        else if (grade >= 90)
            Console.WriteLine(" Your grade is A- ");

        else if (grade >= 87)
            Console.WriteLine(" Your grade is B+ ");

        else if (grade >= 84)
            Console.WriteLine(" Your grade is B ");

        else if (grade >= 80)
            Console.WriteLine(" Your grade is B- ");

        else if (grade >= 77)
            Console.WriteLine(" Your grade is C+ ");

        else if (grade >= 74)
            Console.WriteLine(" Your grade is C ");

        else if (grade >= 70)
            Console.WriteLine(" Your grade is C- ");

        else if (grade >= 67)
            Console.WriteLine(" Your grade is D+ ");

        else if (grade >= 64)
            Console.WriteLine(" Your grade is D ");

        else if (grade >= 60)
            Console.WriteLine(" Your grade is D- ");

        else
            Console.WriteLine(" Your grade is F");

        
    }
}