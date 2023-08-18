using Xunit;
using KataPractice;
namespace Tests;
public class HumanTimeTest{
    [Theory]
    [InlineData(0, "00:00:00")]
    [InlineData(5, "00:00:05")]
    [InlineData(60, "00:01:00")]
    [InlineData(86399, "23:59:59")]
    [InlineData(359999, "99:59:59")]
    public void HumanTimeTest1(int time, string expected){
        //Act
        string actual = HumanTime.GetReadableTime(time);
        //Assert
        Assert.Equal(expected, actual);
    }
}