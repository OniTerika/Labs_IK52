using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;
using System.IO;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        //Init
        Dictionary<string, int> dict = new Dictionary<string, int>();

        dict["Ілон Маск"] = 10;
        dict["Тім Кук"] = 2;
        dict["Я"] = 12;
        dict["Базака"] = 2;
        dict["Лінус Торвальдс"] = 8;

        Console.WriteLine("Початковий словник:");
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");

        }

        //Find
        int maxValue = int.MinValue;
        int minValue = int.MaxValue;

        foreach (var item in dict) 
        {
            if (item.Value > maxValue)
            {
                maxValue = item.Value;
            }

            if (item.Value < minValue)
            {
                minValue = item.Value;
            }
        }

        int maxCount = 0;
        int minCount = 0;

        foreach (var item in dict)
        {
            if (item.Value == maxValue)
            {
                maxCount++;
            }

            if (item.Value == minValue)
            {
                minCount++;
            }
        }

        List<int> list = new List<int>();

        if (maxCount == 1)
        {
            list.Add(maxValue);
        }

        if (minCount == 1 && maxValue != minValue)
        {
            list.Add(minValue);
        }

        //Output
        if (list.Count > 0)
        {
            Console.WriteLine("Результат:");

            foreach (var val in list)
            {
                Console.WriteLine(val);
            }

            SaveToJSON("result.json", list);
        }

        else
        {
            Console.WriteLine("Список пустий (нема ввідних данних або їх значення повторюються).");
        }
    }

    static void SaveToJSON(string fileName, List<int> list)
    {
        var options = new JsonSerializerOptions()
        {
            WriteIndented = true,
        };

        string jsonstr = JsonSerializer.Serialize(list, options);

        File.WriteAllText(fileName, jsonstr);

        Console.WriteLine($"Дані збережено в {fileName}.");

    }
}