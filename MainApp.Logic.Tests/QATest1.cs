using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Logic.Tests
{
    public class QATest1
    {
        [Fact]
        public void Add_ReturnsCorrectSumNewQA0()
        {
            // Arrange
            var logic = new Class1();
            // Act
            var result = logic.Add(1, 6);
            // Assert
            Assert.Equal(7, result);
        }
    }
}
