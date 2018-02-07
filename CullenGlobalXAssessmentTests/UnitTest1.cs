using System;
using Xunit;
using CullenGlobalXAssessment;

namespace CullenGlobalXAssessmentTests {
    public class UnitTest1 {
        [Fact]
        public void Test1() {
            Sorter sorter = new Sorter(1);
            Assert.Equal(sorter.add(2), 3);
        }
    }
}
