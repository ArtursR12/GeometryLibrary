using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary.Figures; 

namespace GeometryLibrary.Tests.FiguresTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CalculateArea_WithRadius5_ReturnsCorrectArea()
        {
            // Arrange
            var circle = new Circle(5);
            var expectedArea = Math.PI * 25; // Площадь круга = πr²

            // Act
            var area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, area, 0.001, "Calculated area should be close to the expected value.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Circle_NegativeRadius_ThrowsArgumentException()
        {
            var circle = new Circle(-5);
        }
    }
}
