using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendorTracker.Models;
using System;

namespace PierreVendorTracker.Tests
{
  [TestClass]
  public class OrdersTests
  {
    [TestMethod]
    public void OrderText_Equals_Example_True()
    {
      Order newOrder = new Order("", "Example", "", "", 1);
      Assert.AreEqual("Example", newOrder.Text);
    }
  }
}