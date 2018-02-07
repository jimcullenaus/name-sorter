using Xunit;

namespace NameSorterTester {
    public class UnitTest1 {
        [Fact]
        public void AddTest() {
            Sorter sorter = new Sorter();
            Assert.True(sorter.add(5, 2), 7);
            Assert.True(sorter.add(2, 2), 4);
        }
    }
}
