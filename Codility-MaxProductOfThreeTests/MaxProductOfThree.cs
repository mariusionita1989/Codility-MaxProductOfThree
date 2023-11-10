using Codility_MaxProductOfThree;

namespace Codility_MaxProductOfThreeTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestExampleArray()
        {
            // Arrange
            int[] exampleArray = { -3, 1, 2, -2, 5, 6 };
            Solution solution = new Solution();

            // Act
            int result = solution.solution(exampleArray);

            // Assert
            Assert.Equal(60, result);
        }

        [Fact]
        public void TestArrayWithNegativeValues()
        {
            // Arrange
            int[] array = { -10, -5, -2, -1, 1, 3, 7 };
            Solution solution = new Solution();

            // Act
            int result = solution.solution(array);

            // Assert
            Assert.Equal(350, result);
        }

        [Fact]
        public void TestArrayWithAllNegativeValues()
        {
            // Arrange
            int[] array = { -7, -5, -2, -1, -3 };
            Solution solution = new Solution();

            // Act
            int result = solution.solution(array);

            // Assert
            Assert.Equal(-6, result);
        }

        [Fact]
        public void TestArrayWithAllPositiveValues()
        {
            // Arrange
            int[] array = { 2, 5, 8, 10, 12 };
            Solution solution = new Solution();

            // Act
            int result = solution.solution(array);

            // Assert
            Assert.Equal(960, result);
        }

        [Fact]
        public void TestArrayWithSingleValue()
        {
            // Arrange
            int[] array = { 5 };
            Solution solution = new Solution();

            // Act
            int result = solution.solution(array);

            // Assert
            Assert.Equal(int.MinValue, result);
        }
    }
}