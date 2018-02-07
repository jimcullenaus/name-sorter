using System;
namespace CullenGlobalXAssessment {
    public class InvalidNamesFileException : System.Exception {
        public InvalidNamesFileException() : base() { }
        public InvalidNamesFileException(string message) : base(message) { }
        public InvalidNamesFileException(string message, System.Exception inner) : base(message, inner) { }
    }
}
