using CodeWars;
using CodeWars._5kyu;
using Xunit;

namespace CodeWars.Test 
{
    public class KataTest
    {
        [Fact]
        public void Test()
        {
            // Arrange
            int[] input = [1, 2, 0, 1, 0, 1, 0, 3, 0, 1];
            int[] expected = [1, 2, 1, 1, 3, 1, 0, 0, 0, 0];
            
            // Act
            var actual = Kata.MoveZeroes(input);
                        
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}