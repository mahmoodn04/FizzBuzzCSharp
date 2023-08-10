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
            //when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "Fizz");
        }
        [Fact]
        public void Gives4Given4()
        {
            //GIVEN
            int given = 4;
            FizzBuzz one = new FizzBuzz();
            //when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "4");
        }
        [Fact]
        public void Gives5GivenBuzz()
        {
            //GIVEN
            int given = 5;
            FizzBuzz one = new FizzBuzz();
            //when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "Buzz");
        }
        [Fact]
        public void Gives6GivenFizz()
        {
            //GIVEN
            int given = 6;
            FizzBuzz one = new FizzBuzz();
            //when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "Fizz");
        }
        [Fact]
        public void Gives7Given7()
        {
            //GIVEN
            int given = 7;
            FizzBuzz one = new FizzBuzz();
            //when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "7");
        }
        [Fact]
        public void Gives8Given8()
        {
            //GIVEN
            int given = 8;
            FizzBuzz one = new FizzBuzz();
            //when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "8");
        }
        [Fact]
        public void Gives9GivenFizz()
        {
            //GIVEN
            int given = 9;
            FizzBuzz one = new FizzBuzz();
            //when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "Fizz");
        }
        [Fact]
        public void Gives10GivenBuzz()
        {
            //GIVEN
            int given = 10;
            FizzBuzz one = new FizzBuzz();
            //when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "Buzz");
        }
        [Fact]
        public void Gives12GivenFizz()
        {
            //GIVEN
            int given = 12;
            FizzBuzz one = new FizzBuzz();
            //when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "Fizz");
        }
         [Fact]
        public void Gives15GivenFizzBuzz()
        {
            //GIVEN
            int given = 15;
            FizzBuzz one = new FizzBuzz();
            //when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "FizzBuzz");
        }
         [Fact]
        public void Gives30GivenFizzBuzz()
        {
            //GIVEN
            int given = 30;
            FizzBuzz one = new FizzBuzz();
            //when
            string gives = one.given(given);
            //THEN
            Assert.Equal(gives, "FizzBuzz");
        }
    }
}