namespace FizzBuzzTests;

public class FizzBuzzTests
{
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    [InlineData(12)]
    public void CalculateShouldReturnFizzWhenDivisibleByThree(int numeral)
    {
        var actual = FizzBuzz.FizzBuzz.Calculate(numeral);
        Assert.Equal("Fizz", actual);
    }
    
    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    [InlineData(25)]
    public void CalculateShouldReturnBuzzWhenDivisibleByFive(int numeral)
    {
        var actual = FizzBuzz.FizzBuzz.Calculate(numeral);
        Assert.Equal("Buzz", actual);
    }
    
    [Fact]
    public void CalculateShouldReturnEmptyWhenDivisibleByNeitherThreeOrFive()
    {
        var actual = FizzBuzz.FizzBuzz.Calculate(2);
        Assert.Equal("", actual);
    }
    
    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    [InlineData(60)]
    public void CalculateShouldReturnFizzBuzzWhenDivisibleByBothThreeOrFive(int numeral)
    {
        var actual = FizzBuzz.FizzBuzz.Calculate(numeral);
        Assert.Equal("FizzBuzz", actual);
    }
    
    [Fact]
    public void CalculateShouldReturnEmptyStringWhenZero()
    {
        var actual = FizzBuzz.FizzBuzz.Calculate(0);
        Assert.Equal("", actual);
    }
}