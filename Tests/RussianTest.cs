using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RussianPeasant;
using Xunit;

namespace Tests
{
    public class RussianTest
    {
        [Fact]
        public void TestRussian()
        {
            var result = RussianPeasant.RussianPeasantMultiplier.Multiply(18, 23);
            Assert.Equal(414, result);
        }
    }
}
