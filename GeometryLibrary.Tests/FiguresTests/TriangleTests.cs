using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary.Figures;

namespace GeometryLibrary.Tests.FiguresTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CalculateArea_WithSides3And4And5_ReturnsCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            var expectedArea = 6; 

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, area, 0.001, "Calculated area should be close to the expected value.");
        }

        [TestMethod]
        public void IsRightAngled_WithSides3And4And5_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsTrue(isRightAngled, "Triangle with sides 3, 4, 5 should be right-angled.");
        }

        // Тест на невалидные стороны, которые не могут формировать треугольник
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Triangle_InvalidSides_ThrowsArgumentException()
        {
            var triangle = new Triangle(1, 2, 3);
        }
    }
}
