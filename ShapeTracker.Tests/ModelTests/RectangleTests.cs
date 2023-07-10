using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
  // [TestClass]
  // public class RectangleTests : IDisposable
  // {
  //   public void Dispose()
  //   {
  //     Rectangle.ClearAll()
  //   }
  // }

  //get a side
  [TestClass]
  public class RectangleTests
  {
    [TestMethod]
    public void RectangleContructor_MakeARectangle_Rectangle()
    {

      Rectangle testRectangle = new Rectangle(2, 3);
      // expect(side1).ToEqual(testRectangle.Side1);
      Assert.AreEqual(typeof(Rectangle), testRectangle.GetType());
    }

    [TestMethod]
    public void Side1_GetAndSetSide_Int()
    {
      int side1 = 3;
      int side2 = 4;
      Rectangle newRectangle = new Rectangle(side1, side2);
      Assert.AreEqual(side1, newRectangle.Side1);
    }

    [TestMethod]
    public void Side2_GetAndSetSide_Int()
    {
      int side1 = 3;
      int side2 = 4;
      Rectangle newRectangle = new Rectangle(side1, side2);
      Assert.AreEqual(side2, newRectangle.Side2);
    }
    [TestMethod]
    public void GetArea_CalculateArea_Int()
    {
      // Arrange
      int area = 20;
      Rectangle newRectangle = new Rectangle(4, 5);
      // Act
      int result = newRectangle.GetArea();
      // Assert
      Assert.AreEqual(area, result);
    }
  }
}