using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianPeasant
{
    public class NumberSeriesCreator
    {
        private NextNumberPairGenerator nunmberPairGenerator;

        public NumberSeriesCreator(NextNumberPairGenerator nunmberPairGenerator)
        {
            this.nunmberPairGenerator = nunmberPairGenerator;
        }

        public virtual IEnumerable<Tuple<int, int>> Create(Tuple<int, int> firstValue)
        {
            var currentValue = firstValue;
            while (currentValue != null)
            {
                yield return currentValue;
                currentValue = this.nunmberPairGenerator.Create(currentValue);
            }
        }
    }
}
