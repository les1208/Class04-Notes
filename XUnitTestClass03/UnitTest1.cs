using System;
using Xunit;
using static PracticeUnitTests.Program;

namespace PracticeUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnZero()
        {
            //Arrange
            string input = "this is a string";

            //Act
            int outputFromMethod = MultiplyInputNumber(input);

            //Assert
            Assert.Equal(0, outputFromMethod); //When you're in the red you have to make it green, =
        }
    }
}
