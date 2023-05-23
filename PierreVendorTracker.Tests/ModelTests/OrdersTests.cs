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
    [TestMethod]
    public void VendorID_Equals_One_True()
    {
      Order newOrder = new Order("", "Example", "", "", 1);
      Assert.AreEqual(1, newOrder.VendorID);
    }
    [TestMethod]
    public void AddOrder_Wood_NoDesc_NoDate_ThirteenDollars()
    {
      Order newOrder = new Order("Wood", "", "", "13 dollars", 0);
      Vendor newVendor = new Vendor("Johnny", "Sells Chairs");
      PierreVendorTracker.Models.Order.AddOrder(newOrder);
      Console.WriteLine(newVendor.speOrders);
      Assert.AreEqual("Wood", newVendor.speOrders[1].Title);
      Assert.AreEqual("13 dollars", newVendor.speOrders[1].Price);
    }
  }
}