﻿using System;
using System.Threading.Tasks;
using PhishReport;

namespace Example
{
    public static class Program
    {
        private static PhishReportClient Client;

        public static async Task Main()
        {
            Console.WriteLine("Enter the PhishReport API Key:");
            Console.WriteLine("Instructions on how to obtain this are in the Github repository.");

            string key = Console.ReadLine();
            Client = new(key);

            Console.WriteLine($"\n> Starting a phishing takedown");
            PhishingTakedown takedown1 = await Client.CreateTakedown("https://156890f.com/Login/index");
            Console.WriteLine($"ID: {takedown1.Id}");
            Console.WriteLine($"URL: {takedown1.Url}");

            Console.WriteLine($"\n> Getting a phishing takedown");
            PhishingTakedown takedown2 = await Client.GetTakedown("case_4ExZCRk3PAh");
            Console.WriteLine($"ID: {takedown2.Id}");
            Console.WriteLine($"URL: {takedown2.Url}");

            Console.WriteLine($"\n> Getting IOK matches of a scan");
            string[] scanMatches = await Client.GetIokMatches("4a0809fd-c30c-4d29-9c72-660980e53860");
            Console.WriteLine($"Scan matches the following indicators ({scanMatches.Length}): {string.Join(", ", scanMatches)}");

            Console.WriteLine("\nDemo finished");
            Console.ReadKey();
        }
    }
}