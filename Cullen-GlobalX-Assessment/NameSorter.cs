using System;

namespace CullenGlobalXAssessment {
    class NameSorter {
        static void Main(string[] args) {
            // Ensure exactly one argument is given
            if (args.Length != 1) {
                Console.Error.WriteLine("Incorrect number of arguments entered.");
                return;
            }
            var filename = args[0];
            var unsorted = NamesImporter.importNames(filename);
            var sorted = Sorter.sort(unsorted);
            NamesExporter.exportNames(sorted);
        }
    }
}
