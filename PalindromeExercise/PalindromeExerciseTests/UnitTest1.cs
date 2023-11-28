using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("radar", true)]
        [InlineData("defined", false)]
        [InlineData("abacab", false)]
        [InlineData("detartrated", true)]
        [InlineData("bob", true)]
        [InlineData("noon", true)]
        [InlineData("sees", true)]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("", false)]
        [InlineData(null, false)]

        public void IsAPalindrome_Test(string word, bool expected)
        {
            var ws = new WordSmith();

            var instance = ws.IsAPalendrome(word);

            Assert.Equal(expected, instance);
        }
    }
}
