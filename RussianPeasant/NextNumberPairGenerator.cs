using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianPeasant
{
    public class NextNumberPairGenerator
    {
        public virtual Tuple<int, int> Create(Tuple<int, int> input)
        {
            if (input.Item1 <= 1) return null;
            var outputLeft = input.Item1/2;
            var outputRight = input.Item2*2;
            return new Tuple<int, int>(outputLeft, outputRight);
        }
    }
}
