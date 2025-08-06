using Xunit;
using MainApp.Logic;

namespace MainApp.E2ETests;

public class CalculatorE2ETests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var logic = new Class1();

        // Act
        var result = logic.Add(2, 3);

        // Assert
        Assert.Equal(5, result);
    }
}