using Xunit;
using MainApp.Logic;

namespace MainApp.Logic.Tests;

public class UnitFailTests
{
    [Fact]
    public void Add_ReturnsWrongSum()
    {
        // Arrange
        var logic = new Class1();
        // Act
        var result = logic.Add(8, 3);
        // Assert
        Assert.Equal(4, result);
    }
}
