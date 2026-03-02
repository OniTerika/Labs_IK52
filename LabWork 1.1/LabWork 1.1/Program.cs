using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //Init
        List<int> numbers = new List<int>();
        Random rnd = new Random();
        int listSize = 10;

        Console.WriteLine("Список:");
        for (int i = 0; i < listSize; i++)
        {
            int num = rnd.Next(0, 1+1);
            numbers.Add(num);
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int maxLength = 0;
        int maxStartIndex = -1;
        int maxEndIndex = -1;

        int currentLength = 0;
        int currentStartIndex = -1;
        
        //Find streak
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 1)
            {
                if (currentLength == 0)
                {
                    currentStartIndex = i;
                }
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxStartIndex = currentStartIndex;
                    maxEndIndex = i - 1;
                }

                currentLength = 0;
            }
        }

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            maxStartIndex = currentStartIndex;
            maxEndIndex = numbers.Count - 1;
        }

        //Output (if list contains 1)
        if (numbers.Contains(1))
        {
            Console.WriteLine($"Найдовша серія одиниць: {maxLength}");
            Console.WriteLine($"Початковий індекс: {maxStartIndex}");
            Console.WriteLine($"Кінцевий індекс: {maxEndIndex}");

        }
        else
        {
            Console.WriteLine("Одиниць у списку не знайдено.");
        }
    }
}