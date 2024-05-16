using NuGet.Frameworks;
using System;
using Xunit;
using Xunit.Sdk;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)] //Add test data <-------
        [InlineData(5,5,5,15)] 
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            //Assert.Equal(expected, actual);
             Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {

            //Arrange
            var tester = new UnitTestMethods();
            //Act
            var actual = tester.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,25)]//Add test data <-------
        [InlineData(5,10,50)]//Add test data <-------
        
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(25,5,5)]//Add test data <-------
        [InlineData(16,8,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new UnitTestMethods();
            //Act
            var actual = tester.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
