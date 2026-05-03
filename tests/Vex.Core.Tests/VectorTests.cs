using Vex.Core.Vectors;
using Vex.Core.Abstractions.Exceptions;

namespace Vex.Core.Tests;

public class VectorTests
{
    [Fact]
    public void Magnitude_ShouldReturnCorrectValue()
    {
        var vector = new Vector([3, 4]);

        var magnitude = vector.Magnitude();

        Assert.Equal(5, magnitude);
    }

    [Fact]
    public void DotProduct_ShouldReturnCorrectValue()
    {
        var vector1 = new Vector([1, 2, 3]);
        var vector2 = new Vector([4, 5, 6]);

        var dotProduct = vector1.DotProduct(vector2);

        Assert.Equal(32, dotProduct);
    }

    [Fact]
    public void DotProduct_ShouldThrowExceptionForDifferentDimensions()
    {
        var vector1 = new Vector([1, 2]);
        var vector2 = new Vector([3, 4, 5]);

        Assert.Throws<DomainException>(() => vector1.DotProduct(vector2));
    }
}
