using Xunit;

namespace CSharp10Classlib.GlobalUsing;

public class GlobalUsingTests
{
    [Theory]
    [InlineData(4, 16)]
    [InlineData(5, 25)]
    [InlineData(2, 4)]
    public void Should_squared_the_value(int num, double squared)
    {
        var result = Math.Pow(num, 2); // Math global using is on GlobalUsing.cs 
        
        Assert.Equal(squared, result);
    }
}