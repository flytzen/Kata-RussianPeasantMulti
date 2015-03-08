using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianPeasant
{
    public static class RussianPeasantMultiplier
    {
        public static int Multiply(int left, int right)
        {
            return BuildSeries(new Tuple<int, int>(left, right))
                .Where(t => t.Item1 % 2 == 1)
                .Sum(t => t.Item2);
        }

        private static IEnumerable<Tuple<int, int>> BuildSeries(Tuple<int, int> firstValue)
        {
            var currentValue = firstValue;
            while (currentValue != null)
            {
                yield return currentValue;
                currentValue = CalculateNextPair(currentValue);
            }
        }

        private static Tuple<int, int> CalculateNextPair(Tuple<int, int> input)
        {
            if (input.Item1 <= 1) return null;
            var outputLeft = input.Item1 / 2;
            var outputRight = input.Item2 * 2;
            return new Tuple<int, int>(outputLeft, outputRight);
        }
    }
}
