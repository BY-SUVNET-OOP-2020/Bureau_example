using System;

class Program
{
    static void Main(string[] args)
    {
        string contents = "";

        System.Console.WriteLine("Öppnar byrålådan...");

        while (true)
        {
            System.Console.Write("Vad vill du lägga i lådan: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q" || input.ToLower() == "inget")
            {
                Console.WriteLine("Stänger byrån...");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (input.ToLower() == "t" || input.ToLower() == "töm")
            {
                System.Console.WriteLine("Tömmer byrån på " + contents);
                contents = "";
            }
            else
            {
                if (contents.Split("och").Length <= 100)
                {
                    if (contents.Length == 0)
                    {
                        contents = input.Trim();
                    }
                    else
                    {
                        contents = contents + " och " + input.Trim();
                    }
                }
                else
                {
                    Console.WriteLine($"you have maximum number of item. remove some item to add more.");
                }
            }

            Console.WriteLine($"Byrån innehåller nu {contents}");
        }
    }
}