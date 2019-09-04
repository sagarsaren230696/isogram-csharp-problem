using Xunit;
using System;
using isogram_csharp_problem;

namespace Isogram.Tests
{
    public class IsogramTests
    {
        [Fact]
        public void TestWordIsogram()
        {
            bool expected = true;
            bool actual = IsogramClass.Isogram("isogram");
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void TestWordeleven()
        {
            bool expected = false;
            bool actual = IsogramClass.Isogram("eleven");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestWordSubdermatoglyphicm()
        {
            bool expected = true;
            bool actual = IsogramClass.Isogram("subdermatoglyphic");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestWordAlphabet()
        {
            bool expected = true;
            bool actual = IsogramClass.Isogram("Alphabet");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestWordThumbscrew_japingly()
        {
            bool expected = true;
            bool actual = IsogramClass.Isogram("thumbscrew-japingly");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestWordsix_year_old()
        {
            bool expected = true;
            bool actual = IsogramClass.Isogram("six-year-old");
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestWordsWithSpaces()
        {
            bool expected = true;
            bool actual = IsogramClass.Isogram("Dipu great");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestEmptyString()
        {
            bool expected = true;
            bool actual = IsogramClass.Isogram("");
            Assert.Equal(expected, actual);
        }
    }
}
