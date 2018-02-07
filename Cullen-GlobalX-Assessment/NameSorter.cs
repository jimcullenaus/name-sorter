﻿using System;

namespace CullenGlobalXAssessment {
    class NameSorter {
        static void Main(string[] args) {
            // Ensure exactly one argument is given
            if (args.Length != 1) {
                Console.Error.WriteLine("Incorrect number of arguments entered.");
                return;
            }
            Sorter.sort(args[0]);
        }
    }
}