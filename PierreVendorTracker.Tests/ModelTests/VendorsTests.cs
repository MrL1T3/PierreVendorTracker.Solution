using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendorTracker.Models;
using System;

namespace PierreVendorTracker.Tests
{
  [TestClass]
  public class VendorsTests
  {
    [TestMethod]
    public void vendorName_Equals_John_True()
    {
      Vendor first = new Vendor("John", "");
      Assert.AreEqual("John", first.VendorName);
    }
    [TestMethod]
    public void VendorDesc_Equals_SellsGlassware_True()
    {
      Vendor first = new Vendor("John", "John sells glassware products");
      Assert.AreEqual("John sells glassware products", first.VendorDesc);
    }
    [TestMethod]
    public void AddOrder_Wood_NoDesc_NoDate_ThirteenDollars()
    {
      Vendor newVendor = new Vendor("Johnny", "Sells Chairs");
      Vendor.AddVendor(newVendor);

      Console.WriteLine(newVendor.VendorID);
      Order newOrder = new Order("Wood", "", "13 dollars", "", newVendor.VendorID);
      Console.WriteLine(newOrder.VendorID);
      Vendor.AddOrder(newOrder);
      Console.WriteLine(newVendor.speOrders);
      Assert.AreEqual(1, newVendor.speOrders.Count);
      Assert.AreEqual("Wood", newVendor.speOrders[0].Title);
      Assert.AreEqual("13 dollars", newVendor.speOrders[0].Price);
    }
    [TestMethod]
    public void AddVendor_Johnny_SellsChairs()
    {
      Vendor newVendor = new Vendor("Johnny", "Sells Chairs");
      Vendor.AddVendor(newVendor);
      Assert.AreEqual("Johnny", Vendor.sVendors[0].VendorName);
      Assert.AreEqual("Sells Chairs", Vendor.sVendors[0].VendorDesc);
    }
    [TestMethod]
    public void AddNewOrder_Box()
    {
      Vendor newVendor = new Vendor("", "");
      Vendor.AddVendor(newVendor);
      Order newOrder = new Order("Box", "", "", "", newVendor.VendorID);
      newVendor.AddNewOrder(newOrder);
      Assert.AreEqual("Box", newVendor.speOrders[0].Title);
    }
  }
}