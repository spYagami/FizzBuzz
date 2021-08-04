using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzz_Tests
{
    public class Tests
    {

        [TestCase(1, "1")]
        [TestCase(29, "29")]

        public void GivenOne_Return_OneString(int input, string output)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo(output));
        }

        [TestCase(1, "1")]
        [TestCase(1, "1")]
        [TestCase(27, "Fizz")]
        [TestCase(25, "Buzz")]
        [TestCase(30, "FizzBuzz")]
        public void GivenAnyValue_Return_RightOutput(int x, string expected)
        {
            Assert.That(() => Program.FizzBuzz(x), Is.EqualTo(expected));
        }

        //[TestCase(27)]
        //public void GivenANumberDivisibleByThree_Return_Fizz(int input)
        //{
        //    Assert.That(() => Program.DivisibleByThree(input), Is.EqualTo("Fizz"));
        //}
        //[TestCase(25)]
        //public void GivenANumberDivisibleByFive_Return_Buzz(int input)
        //{
        //    Assert.That(() => Program.DivisibleByFive(input), Is.EqualTo("Buzz"));
        //}
        //[TestCase(225)]
        //public void GivenANumberDivisibleByFifteen_Return_FizzBuzz(int input)
        //{
        //    Assert.That(() => Program.DivisibleByFifteen(input), Is.EqualTo("FizzBuzz"));
        //}




    }
}