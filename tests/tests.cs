using square_library;
using Xunit;

public class ShapeLibraryTests
{
    [Fact]
    public void CircleAreaCalculation()
    {
        Circle circle = new Circle(5);
        Assert.Equal(Math.PI * 25, circle.CalculateArea(), 3);
    }

    [Fact]
    public void TriangleAreaCalculation()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.CalculateArea(), 3);
    }

    [Fact]
    public void RightAngledTriangleCheck()
    {
        Assert.True(Triangle.IsRightAngledTriangle(3, 4, 5));
        Assert.False(Triangle.IsRightAngledTriangle(3, 4, 6));
    }
}
