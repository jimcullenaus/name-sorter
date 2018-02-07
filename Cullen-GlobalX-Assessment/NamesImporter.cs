using System;
using System.Collections.Generic;

namespace CullenGlobalXAssessment {
    public class NamesImporter {
        public static List<Person> importNames(string filename) {
            var firstNames = new List<String> {
                "Janet",
                "Vaughn",
                "Adonis Julius",
                "Shelby Nathan",
                "Marin",
                "London",
                "Beau Tristan",
                "Leo",
                "Hunter Uriah Mathew",
                "Mikayla",
                "Frankie Conner"
            };
            var lastNames = new List<String> {
                "Parsons",
                "Lewis",
                "Archer",
                "Yoder",
                "Alvarez",
                "Lindsey",
                "Bentley",
                "Gardner",
                "Clarke",
                "Lopez",
                "Ritter"
            };
            var people = new List<Person> { };
            for (int i = 0; i < firstNames.Count; ++i)
            {
                people.Add(new Person(firstNames[i], lastNames[i]));
            }
            return people;
        }
    }
}
