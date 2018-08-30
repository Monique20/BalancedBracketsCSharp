using BalancedBracketsKata;
using NUnit.Framework;

namespace BalancedBracketsKataTests
{
    [TestFixture]
    public class BalancedBracketsTests
    {
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ValidateBrackets_GivenInputWithEmptyOrNullOrWhiteSpace_ShouldReturnOK(string input)
        {
            //Arrange
            var sut = new BalancedBrackets();

            //Act
            var actual = sut.ValidateBrackets(input);

            //Assert
            var expected = "OK";
            Assert.AreEqual(expected, actual);
        }

        [TestCase("][","FAIL")]
        [TestCase("][[","FAIL")]
        [TestCase("][]", "FAIL")]
        public void ValidateBrackets_GivenSetOfUnbalancedBrackets_ShouldReturnFAIL(string input, string expected)
        {
            //Arrange
            var sut = new BalancedBrackets();

            //Act
            var actual = sut.ValidateBrackets(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("[]", "OK")]
        [TestCase("[[][]]", "OK")]
        [TestCase("[[]]", "OK")]
        public void ValidateBrackets_GivenSetOfBalancedBrackets_ShouldReturnOK(string input, string expected)
        {
            //Arrange
            var sut = new BalancedBrackets();

            //Act
            var actual = sut.ValidateBrackets(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
