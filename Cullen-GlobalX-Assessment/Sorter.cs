using System;
using System.Collections.Generic;
using System.Linq;

namespace CullenGlobalXAssessment {
    public class Sorter {
        /**
         * Takes an input filename, reads that file,
         * sorts the names contained in it alphabetically, first by last name,
         * and then writes those names back to both console and disk.
         */
        public static void sort(string filename) {
            var unsorted = NamesImporter.importNames(filename);
            var sorted = unsorted.OrderBy(person => person.lastName)
                                 .ThenBy(person => person.firstNames)
                                 .ToList();
            NamesExporter.exportNames(sorted);
        }
    }
}
