using System;
using System.IO;
using System.Collections.Generic;

namespace CullenGlobalXAssessment {
    public class NamesImporter {
        public static List<Person> importNames(string filename) {
            string invalidNamesFileMessage = "The given names file was invalid.";
            // Read the file into an array of full names
            string[] readNames;
            try {
                readNames = File.ReadAllLines(filename);
            } catch (Exception e) {
                throw new InvalidNamesFileException(invalidNamesFileMessage, e);
            }
            // Parse the full names into people
            var people = new List<Person> { };
            for (int i = 0; i < readNames.Length; ++i) {
                var name = readNames[i];
                // If the current name is simply a trailing whitespace at the end of the file, disregard
                if (name.Trim() == "" && i == readNames.Length - 1) {
                    break;
                }
                // Split the string into first and last names at the last space character
                int lastSpace = name.LastIndexOf(' ');
                if (lastSpace < 1) {
                    throw new InvalidNamesFileException(invalidNamesFileMessage);
                }
                var firstNames = name.Substring(0, lastSpace);
                var lastName = name.Substring(lastSpace + 1);

                people.Add(new Person(firstNames, lastName));
            }
            return people;
        }
    }
}
