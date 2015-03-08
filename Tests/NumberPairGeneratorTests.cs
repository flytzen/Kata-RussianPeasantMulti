
using System;
using System.Linq.Expressions;
using RussianPeasant;
using Xunit;
using Xunit.Extensions;

namespace Tests
{
    public class NumberPairGeneratorTests
    {
        NextNumberPairGenerator numberGenerator = new NextNumberPairGenerator();

        [Theory]
        [InlineData(2, 2, 1, 4)]
        [InlineData(18, 23, 9, 46)]
        [InlineData(9, 46, 4, 92)]
        [InlineData(4, 92, 2, 184)]
        [InlineData(2, 184, 1, 368)]
        public void PassingTest(int inputLeft, int inputRight, int outputLeft, int outputRight)
        {
            var input = new Tuple<int, int>(inputLeft, inputRight);
            var expectedOutput = new Tuple<int, int>(outputLeft, outputRight);
            var actualOutput = numberGenerator.Create(input);
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void ReturnNullWhenLeftInputIsNull()
        {
            var input = new Tuple<int, int>(1, 100);
            var output = numberGenerator.Create(input);
            Assert.Null(output);
        }

    }
}