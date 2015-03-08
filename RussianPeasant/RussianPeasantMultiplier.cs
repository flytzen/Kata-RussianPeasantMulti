using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianPeasant
{
    public class RussianPeasantMultiplier
    {
        public int Multiply(int left, int right)
        {
            var seriesCreator = new NumberSeriesCreator(new NextNumberPairGenerator());
            var series = seriesCreator.Create(new Tuple<int, int>(left, right));

            var s2 = seriesCreator.Create(new Tuple<int, int>(left, right)).ToList();
            var t1 = s2.Where(t => t.Item1%2 == 1).ToList();
            var t2 = t1.Sum(t => t.Item2);

            return series.Where(t => t.Item1%2 == 1).Sum(t => t.Item2);
        }
    }
}
