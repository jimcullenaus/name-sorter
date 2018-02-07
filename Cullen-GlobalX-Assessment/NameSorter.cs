using System;

namespace CullenGlobalXAssessment {
    class NameSorter {
        static void Main(string[] args) {
            if (args.Length != 1) {
                Console.Error.WriteLine("Incorrect number of arguments entered.");
                return;
            }
            Console.WriteLine(args[0]);
        }
    }
}
