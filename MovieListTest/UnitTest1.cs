using System;
using Ch04MovieList.Models;


namespace MovieListTest
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            // Arrange
            int FirstNum = 1;
            int SecondNum = 2;

            int Expected = 3;
            int Actual;

            // Act
            Actual = MovieContext.AddStuff(FirstNum, SecondNum);

            // Assert

            Assert.Equal(Expected, Actual);

        }

        [Fact]
        public void FailingTest()
        {
            // Arrange
            int FirstNum = 1;
            int SecondNum = 2;

            int Expected = 400;
            int Actual;

            // Act
            Actual = MovieContext.AddStuff(FirstNum, SecondNum);

            // Assert

            Assert.Equal(Expected, Actual);

        }
    }
}