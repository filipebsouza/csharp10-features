using Xunit;

namespace CSharp10Classlib.ConstStringInterpolation;

public class ConstStringInterpolationTests
{
    private const string ConstantOne = "Constant One";
    private const string ConstantTwo = "Constant Two";

    [Fact]
    public void Should_Return_Constants_Interpolation()
    {
        const string Const = $"{ConstantOne} - {ConstantTwo}";
        
        Assert.Equal("Constant One - Constant Two", Const);
    }
}