using Mastermind;

namespace Mastermind_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(new[] { "blue", "red" }, "", new[] { 0, 0 })]
        [TestCase(new[] { "blue" }, "6", new[] { 1, 0 })]
        [TestCase(new[] { "red", "yellow"}, "53", new[] { 2, 0 })]
        public void Test1(string[] code, string input, int[] expected)
        {
            var game = new Game();

            var result = game.Check(input, code.ToList());
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}