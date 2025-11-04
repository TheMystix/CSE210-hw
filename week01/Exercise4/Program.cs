using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();


        int userNumbers = -1;
        while (userNumbers != 0)

        {
            Console.WriteLine("Enter a list of numbers, type 0 when done:  ");
            userNumbers = int.Parse(Console.ReadLine());

            if (userNumbers != 0)
            {
                numbers.Add(userNumbers);
            }
        }
    
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        float average = (float)sum / numbers.Count;

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"the total of your numbers is: {sum}");
        Console.WriteLine($"The average of your numbers is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }

}
