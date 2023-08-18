using Xunit;
using KataPractice;
namespace Tests;
public class PhoneNumberTests{
    [Theory]
    [InlineData("123-647-EYES", "123-647-3937")]
    [InlineData("(325)444-TEST", "(325)444-8378")]
    [InlineData("653-TRY-THIS", "653-879-8447")]
    [InlineData("435-224-7613", "435-224-7613")]
    [InlineData("tIn-AnD-gOlD", "846-263-4653" )]
    public void PhoneNumberTests1(string number, string expected){
        //Act
        string actual = PhoneNumbers.Translate(number);
        //Assert
        Assert.Equal(expected, actual);
    }
}