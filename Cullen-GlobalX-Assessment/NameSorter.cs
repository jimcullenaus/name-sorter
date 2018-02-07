using System;

namespace CullenGlobalXAssessment {
    /**
     * A programme that takes an argument of a path to a file
     * containing a list of names
     * and sorts those names alphabetically, first by last name, then by first names.
     * Outputs the sorted list to console and to a file in the working directory.
     */
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
