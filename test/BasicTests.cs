using System;
using System.ComponentModel;
using Xunit;

namespace CoreCodeCamp.Test
{
    public class BasicTests
    {
        [Fact]
        public void EqualVals_AreEqual()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void NotEqualVals_NotEqual()
        {
            Assert.NotEqual(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]

        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}
