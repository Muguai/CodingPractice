using Xunit;
using KataPractice;
namespace Tests;
public class FreddyFridayTest{
    [Theory]
    [InlineData(2021, 1)]
    [InlineData(2020, 2)]
    [InlineData(2026, 3)]
    [InlineData(2016, 1)]
    public void FreddyFridayTest1(int year, int expected){
        //Act
        int actual = FreddyFriday.Friday(year);
        //Assert
        Assert.Equal(expected, actual);
    }
}