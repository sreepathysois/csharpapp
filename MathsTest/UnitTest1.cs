using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathsLibrary;
namespace MathsTest
{
[TestClass]
public class TestMathsClass
{
    [TestMethod]
    public void TestAdd()
    {
        //Arrange
        CustomMaths maths = new CustomMaths(6, 5);

        //Act
        int result = maths.Add();

        //Assert
        Assert.AreEqual<int>(11, result);
    }

    [TestMethod]
    public void TestSub()
    {
        //Arrange
        CustomMaths maths = new CustomMaths(6, 5);

        //Act
        int result = maths.Sub();

        //Assert
        Assert.AreEqual<int>(12, result);
    }
}
}
