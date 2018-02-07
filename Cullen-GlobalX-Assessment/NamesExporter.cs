using System;
using System.IO;
using System.Collections.Generic;

namespace CullenGlobalXAssessment {
    /**
     * Writes a list of names to sorted-names-list and to console.
     */
    public class NamesExporter {
        public static void exportNames(List<Person> people) {
            try {
                // Write to sorted-names-list.txt in the working directory
                using (System.IO.StreamWriter file = new StreamWriter("sorted-names-list.txt")) {
                    foreach (Person person in people) {
                        file.WriteLine(person);
                        Console.WriteLine(person);
                    }
                }
            } catch (IOException) {
                Console.Error.WriteLine("Was unable to write to the file.");
            }
        }
    }
}