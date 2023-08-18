using Xunit;
using KataPractice;
namespace Tests;
public class SmoothieTest
{
    [Theory]
    [InlineData(new string[] { "Banana", "Soy" }, 0.50)]
    [InlineData(new string[] { "Raspberries", "Strawberries", "Blueberries" }, 3.50)]
    [InlineData(new string[] { "Blueberries", "Banana","Oat" }, 1.50)]
    public void SmoothieTest1(string[] ingredients, double expected)
    {
        Smoothie testSmothie = new Smoothie(ingredients);
        //Act
        double actual = testSmothie.GetCost();
        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new string[] { "Banana", "Soy" }, 1.25)]
    [InlineData(new string[] { "Raspberries", "Strawberries", "Blueberries" }, 8.75)]
    [InlineData(new string[] { "Blueberries", "Banana","Oat" }, 3.75)]
    public void SmoothieTest2(string[] ingredients, double expected)
    {
        Smoothie testSmothie = new Smoothie(ingredients);
        //Act
        double actual = testSmothie.GetPrice();
        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new string[] { "Banana", "Soy" }, "Banana Smoothie (VGN)")]
    [InlineData(new string[] { "Raspberries", "Strawberries", "Blueberries", "Cow" }, "Blueberry Raspberry Strawberry Fusion")]
    [InlineData(new string[] { "Blueberries", "Banana","Oat" }, "Banana Blueberry Fusion (VGN)")]
    public void SmoothieTest3(string[] ingredients, string expected)
    {
        Smoothie testSmothie = new Smoothie(ingredients);
        //Act
        string actual = testSmothie.GetName();
        //Assert
        Assert.Equal(expected, actual);
    }

}