using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Gives1Given1()
        {
            //GIVEN
            int given = 1;
            FizzBuzz one = new FizzBuzz();
            //!!!!when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "1");
        }

        [Fact]
        public void Gives2Given2()
        {
            //GIVEN
            int given = 2;
            FizzBuzz one = new FizzBuzz();
            //!!!!when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "2");
        }
        [Fact]
        public void Gives3GivenFizz()
        {
            //GIVEN
            int given = 3;
            FizzBuzz one = new FizzBuzz();
            //!!!!when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "Fizz");
        }
    }
}