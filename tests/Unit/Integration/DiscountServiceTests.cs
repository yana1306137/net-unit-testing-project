using System;
using FluentAssertions;
using Moq;
using Xunit;
using DiscountSolution.Services;

namespace DiscountSolution.Tests.Unit
{
    public class DiscountServiceTests
    {
        private readonly DiscountService _sut;

        public DiscountServiceTests()
        {
            _sut = new DiscountService();
        }

        [Fact]
        public void Should_ReturnDiscountedPrice_When_UserIsPremium()
        {
            // Arrange
            int price = 100;
            bool isPremium = true;

            // Act
            int result = _sut.ApplyDiscount(price, isPremium);

            // Assert
            result.Should().Be(80);
        }

        [Fact]
        public void Should_ReturnOriginalPrice_When_UserIsNotPremium()
        {
            // Arrange
            int price = 100;
            bool isPremium = false;

            // Act
            int result = _sut.ApplyDiscount(price, isPremium);

            // Assert
            result.Should().Be(100);
        }

        [Fact]
        public void Should_RoundToInteger_When_DiscountResultsInDecimal()
        {
            // Arrange
            int price = 99;
            bool isPremium = true;

            // Act
            int result = _sut.ApplyDiscount(price, isPremium);

            // Assert
            result.Should().Be(79);
        }

        [Fact]
        public void Should_ReturnZero_When_PriceIsZero()
        {
            // Arrange
            int price = 0;
            bool isPremium = true;

            // Act
            int result = _sut.ApplyDiscount(price, isPremium);

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void Should_ThrowArgumentException_When_PriceIsNegative()
        {
            // Arrange
            int price = -10;
            bool isPremium = true;

            // Act
            Action act = () => _sut.ApplyDiscount(price, isPremium);

            // Assert
            act.Should().Throw<ArgumentException>().WithParameterName("price");
        }
    }
}
