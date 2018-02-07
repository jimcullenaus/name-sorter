using System;
using System.Collections.Generic;

namespace CullenGlobalXAssessment {
    public class Sorter {
        /**
         * Takes an input filename, reads that file,
         * sorts the names contained in it alphabetically, first by last name,
         * and then writes those names back to both console and disk.
         */
        public static void sort(string filename) {
            
        }

        private List<string> fileImporter(string filename) {
            var names = new List<String> {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer",
                "Shelby Nathan Yoder",
                "Marin Alvarez",
                "London Lindsey",
                "Beau Tristan Bentley",
                "Leo Gardner",
                "Hunter Uriah Mathew Clarke",
                "Mikayla Lopez",
                "Frankie Conner Ritter"
            };
            return names;
        }
    }
}
