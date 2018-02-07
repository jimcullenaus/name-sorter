using System;
namespace CullenGlobalXAssessment {
    public class Sorter {
        private int number;
        public Sorter(int number) => this.number = number;
        public int add(int x) {
            return x + number;
        }
    }
}
