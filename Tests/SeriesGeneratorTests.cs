using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Moq;
using RussianPeasant;
using Xunit;

namespace Tests
{
    public class SeriesGeneratorTests
    {
        [Fact]
        public void CanReturnSeries()
        {
            Mock<NextNumberPairGenerator> mock = new Mock<NextNumberPairGenerator>();
            mock.SetupSequence(g => g.Create(It.IsAny<Tuple<int, int>>()))
                .Returns(new Tuple<int, int>(1,1))
                .Returns(new Tuple<int, int>(2,2))
                .Returns(null);

            var seriesGenerator = new NumberSeriesCreator(mock.Object);

            var result = seriesGenerator.Create(new Tuple<int, int>(0, 0)).ToList();

            Assert.Equal(new Tuple<int, int>(0, 0), result.First());
            Assert.Equal(new Tuple<int, int>(2, 2), result.Last());
            Assert.Equal(3, result.Count());
        }


        
    }
}
