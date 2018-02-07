using System;
namespace CullenGlobalXAssessment {
    /**
     * An exception that gets thrown if the supplied names file is incorrectly formatted
     * or unable to be read to.
     */
    public class InvalidNamesFileException : System.Exception {
        public InvalidNamesFileException() : base() { }
        public InvalidNamesFileException(string message) : base(message) { }
        public InvalidNamesFileException(string message, System.Exception inner) : base(message, inner) { }
    }
}
