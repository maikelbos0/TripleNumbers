using TripleNumbers.Services;

namespace TripleNumbers.Tests.Services {
    public class NumberServiceTests {
        [Theory]
        [InlineData("", false, null)]
        [InlineData("[]", false, null)]
        [InlineData("[112, he3,2,1,9,9,8]", false, null)]
        [InlineData("[1,2,3,4,5,1,1]", true, "[1]")]
        [InlineData("[9,3,3,2,1,1,1,2,9,9,9]", true, "[9,1]")]
        [InlineData("[1,1,1,1,3,3,3,3,2,1,2,9,9,9]", true, "[9,3,1]")]
        [InlineData("[1,2,3,2,1,9,9,8]", true, "[]")]
        public void TryGetTripleIntegers(string input, bool expectedIsValid, string? expectedOutput) {
            var subject = new NumberService();

            Assert.Equal(expectedIsValid, subject.TryGetTripleIntegers(input, out var output));
            Assert.Equal(expectedOutput, output);
        }
    }
}
