using Xunit;
using KataPractice;
namespace Tests;
public class PhoneNumberTwoTests
{
    [Theory]
    [InlineData("526", "JAM")]
    [InlineData("777733663444664", "SENDING")]
    [InlineData("2202022999", "BABY")]
    [InlineData("443355505556660096667775553", "HELLO WORLD")]
    [InlineData("44335550555666111", "HELLO!")]
    [InlineData("44335550555666110056660661", "HELLO, JON.")]
    [InlineData("663390074466606633110094466600344477771111", "NEW PHONE, WHO DIS?")]
    public void PhoneNumberTwoTests1(string number, string expected)
    {
        //Act
        string actual = PhoneNumbersTwo.Translate(number);
        //Assert
        Assert.Equal(expected, actual);
    }
}