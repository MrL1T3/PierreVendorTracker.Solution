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
  }
}