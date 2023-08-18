using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataPractice;

namespace Tests{
    [TestClass]
    public class NineToFiveTests{
        [TestMethod]
        public void Test1(){
            //Arrange
            string Expected = "$240";
            double[] testArray = new double[] {9, 17, 30, 1.5};
            //Act
            string actual = WorkingNineToFive.OverTime(testArray);
            //Assert
            Assert.AreEqual(Expected, actual);
            //Assert.AreEqual(Expected, );
        }
        [TestMethod]
        public void Test2(){
        }
        [TestMethod]
        public void Test3(){
        }
    }
}