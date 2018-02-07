using System;
using Xunit;
using CullenGlobalXAssessment;
using System.Collections.Generic;

namespace CullenGlobalXAssessmentTests {
    public class ImportTester {
        [Fact]
        public void basicReadTest() {
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
            var people = new List<Person>{};
            for (int i = 0; i < firstNames.Count; ++i) {
                people.Add(new Person(firstNames[i], lastNames[i]));
            }
            var testNames = NamesImporter.importNames("./test-samples/simple-names.txt");
            Assert.Equal(testNames, people);
        }

        [Fact]
        public void emptyFileTest() {
            Assert.Throws<InvalidNamesFileException>(() => NamesImporter.importNames("./test-samples/blank.txt"));
        }

        [Fact]
        public void invalidNameTest() {
            Assert.Throws<InvalidNamesFileException>(() => NamesImporter.importNames("./test-samples/no-first.txt"));
        }

        [Fact]
        public void noPermissionTest() {
            Assert.Throws<InvalidNamesFileException>(() => NamesImporter.importNames("./test-samples/no-permission.txt"));
        }
    }
}
