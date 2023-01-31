using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
//     [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    [TestMethod]
    public void Triangle_CreateTriangle_True()
    {
      Triangle myTriangle = new Triangle(1,2,3);
      Assert.AreEqual(1, myTriangle.Side1);
      Assert.AreEqual(2, myTriangle.Side2);
      Assert.AreEqual(3, myTriangle.Side3);
    }

    [TestMethod]
    public void IsTriangle_CheckIfTriangle_true()
    {
      Triangle myTriangle = new Triangle(3,3,3);
      Assert.AreEqual(true, myTriangle.IsTriangle());
    }

    [TestMethod]
    public void TriangleType_ReturnTriangleType_string()
    {
      Triangle equilateral = new Triangle(3,3,3);
      Assert.AreEqual("equilateral", equilateral.TriangleType());
      Triangle isosceles = new Triangle(3,3,2);
      Assert.AreEqual("isosceles", isosceles.TriangleType());
      Triangle scalene = new Triangle(5,4,3);
      Assert.AreEqual("scalene", scalene.TriangleType());
      Triangle notTriangle = new Triangle(5,4,30);
      Assert.AreEqual("not a triangle", notTriangle.TriangleType());
    }



  }
}
