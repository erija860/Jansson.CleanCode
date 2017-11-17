using System.Collections.Generic;
using FizzBuzz.Domain;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        //private FizzBuzzLogic _fizzBuzzLogic;
        private FizzBuzzRuleRunner _fizzBuzzLogic;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            //_fizzBuzzLogic = new FizzBuzzLogic();
            _fizzBuzzLogic =
                new FizzBuzzRuleRunner(new List<IFizzBuzzRule>
                {
                    new DivisibleByThreeAndFiveRule(),
                    new DivisibleByThreeRule(),
                    new DivisibleByFiveRule(),
                    new ReturnNumberRule()
                });
        }

        [Test]
        public void Should_return_1_when_entering_1()
        {
            var result = _fizzBuzzLogic.GetResultFromNumber(1);
            result.Should().Be("1");
        }

        [Test]
        public void Should_return_2_when_entering_2()
        {
            var result = _fizzBuzzLogic.GetResultFromNumber(2);
            result.Should().Be("2");
        }

        [Test]
        public void Should_return_Buzz_when_divisible_by_5()
        {
            var result = _fizzBuzzLogic.GetResultFromNumber(25);
            result.Should().Be("Buzz");
        }

        [Test]
        public void Should_return_Fizz_when_divisible_by_3()
        {
            var result = _fizzBuzzLogic.GetResultFromNumber(9);
            result.Should().Be("Fizz");
        }

        [Test]
        public void Should_return_Fizz_when_entering_3()
        {
            var result = _fizzBuzzLogic.GetResultFromNumber(3);
            result.Should().Be("Fizz");
        }

        [Test]
        public void Should_return_FizzBuzz_when_divisible_by_both_3_and_5()
        {
            var result = _fizzBuzzLogic.GetResultFromNumber(15);
            result.Should().Be("FizzBuzz");
        }
    }
}