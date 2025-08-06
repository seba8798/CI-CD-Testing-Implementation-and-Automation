using Xunit;
using MainApp.Logic;

namespace MainApp.Logic.Tests;

public class Class1Tests
{
    [Fact]
    public void Add_ReturnsCorrectSumNew()
    {
        // Arrange
        var logic = new Class1();
        // Act
        var result = logic.Add(1, 3);
        // Assert
        Assert.Equal(4, result);
    }
}
