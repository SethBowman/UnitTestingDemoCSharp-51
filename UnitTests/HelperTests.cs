using MainProject;

namespace UnitTests;

public class HelperTests
{
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(5, 5, 10)]
    public void AddTest(int numOne, int numTwo, int expected)
    {
        //Arrange
        var helper = new Helper();

        //Act
        var actual = helper.Add(numOne, numTwo);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Seth", "Hello, Seth!")]
    [InlineData("Tyson", "Hello, Tyson!")]
    [InlineData("Miah", "Hello, Miah!")]
    [InlineData(null, "Hello!")]
    [InlineData("", "Hello!")]
    public void GreetTest(string name, string expected)
    {
        //Arrange
        var helper = new Helper();
        
        //Act
        var actual = helper.Greet(name);
        
        //Assert
        Assert.Equal(expected, actual);
    }
}