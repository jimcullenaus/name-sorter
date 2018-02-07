using System;
using System.IO;
using System.Collections.Generic;

namespace CullenGlobalXAssessment {
    public class NamesExporter {
        public static void exportNames(List<Person> people) {
            try {
                using (System.IO.StreamWriter file = new StreamWriter("sorted-names-list.txt")) {
                    foreach (Person person in people) {
                        file.WriteLine(person);
                        Console.WriteLine(person);
                    }
                }
            } catch (IOException e) {
                Console.Error.WriteLine("Was unable to write to the file.");
            }
        }
    }
}