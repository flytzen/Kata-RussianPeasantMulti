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
                currentValue = currentValue.Item1 <= 1 
                    ? null 
                    : new Tuple<int, int>(currentValue.Item1 / 2, currentValue.Item2 * 2);
            }
        }
    }
}
