using System;
using System.IO;

namespace TextFileParsingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int currentYear = 2023;
                // Read in the data from a file
                string[] lines = File.ReadAllLines("Input.txt");

                var phrasesToRemove = new List<string>(){"Pay over time", "TRAVEL CREDIT", "Pay over time", "AUTOMATIC PAYMENT - THANK", "-$", "Payment Thank You"};
                foreach (var phraseToRemove in phrasesToRemove)
                {
                    lines = Array.FindAll(lines, line => !line.Contains(phraseToRemove));
                }

                lines = lines.Select(line => line
                                            .Replace($", {currentYear}", $" {currentYear}")
                                            .Replace("$", "")).ToArray();

                // Remove empty lines
                lines = Array.FindAll(lines, line => line.Trim().Length > 0);

                // Print table header
                Console.WriteLine("Date\t\tAmount\t\tMerchant");

                // Print table rows
                for (int i = 0; i < lines.Count(); i = i + 2)
                {
                    string[] fields = lines[i].Split(new string[] { " " + currentYear.ToString() + " " }, StringSplitOptions.RemoveEmptyEntries);
                    Console.WriteLine($"{fields[0].Trim()}\t\t{lines[i+1].Trim()}\t\t{fields[1].Trim()}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}