﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _003.Trainegram
{
    class Trainegram
    {
        static void Main(string[] args)
        {
            Regex train = new Regex(@"^(<\[[^a-zA-Z0-9]*\]\.)+(\.\[([a-zA-Z0-9])*\]\.)*$");
            List<string> validTrains = new List<string>();

            String input = Console.ReadLine();
            while (input != "Traincode!")
            {
                if (train.IsMatch(input))
                {
                    validTrains.Add(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", validTrains));
        }
    }
}
