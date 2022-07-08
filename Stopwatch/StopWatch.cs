using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class Stop_Watch
    {

        public DateTime Time { get; set; }
        public DateTime CurrentTime { get; set; }

        public Stop_Watch(DateTime time, DateTime currentTime)
        {
            Time = time;
            CurrentTime = currentTime;
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Hi there! Welcome to my stopwatch.");
            Console.WriteLine();
            Console.WriteLine("How much time do you want to count: hours, minutes or seconds? Write the chosen number (:");
            Console.WriteLine("#0: exit");
            Console.WriteLine("#1: hours");
            Console.WriteLine("#2: minutes");
            Console.WriteLine("#3: seconds");

            Console.WriteLine();
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1:
                    {
                        Console.WriteLine("How many hours would you like to count? Example: 1");
                        int hours = int.Parse(Console.ReadLine());
                        Start(DateTime.MinValue.AddHours(hours), DateTime.MinValue);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("How many minutes would you like to count? Example: 1");
                        int minutes = int.Parse(Console.ReadLine());
                        Start(DateTime.MinValue.AddMinutes(minutes), DateTime.MinValue);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("How many seconds would you like to count? Example: 1");
                        int seconds = int.Parse(Console.ReadLine());
                        Start(DateTime.MinValue.AddSeconds(seconds), DateTime.MinValue);
                        break;
                    }

                default: Console.WriteLine("Sorry, we don't have that option."); break;

            }

        }
        public static void Start(DateTime time, DateTime currentTime)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(1000);

            while (currentTime < time)
            {
                Console.Clear();
                currentTime = currentTime.AddSeconds(1);
                Console.WriteLine(currentTime.ToString("HH:mm:ss"));
                Thread.Sleep(1000);
            }

            Console.WriteLine();
            Console.WriteLine("End of stopwatch. Thank you for using!");
            Thread.Sleep(5000);
            Menu();
        }
    }
}
