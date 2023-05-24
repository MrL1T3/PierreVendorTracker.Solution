using System.Collections.Generic;
using System;

namespace PierreVendorTracker.Models
{
  public class Vendor
  {
    private static int sNextID = 0;
    public int VendorID{get; set;}
    public string VendorName{get; set;}
    public string VendorDesc{get; set;}
    public List<Order> speOrders = new List<Order>();
    public void AddNewOrder(Order o) {
      speOrders.Add(o);
    }

    public Vendor()
    {
      VendorID = 0;
      VendorName = "";
      VendorDesc = "";
    }
    public Vendor(string NewVendor, string NewDesc)
    {
      VendorID = 0;
      VendorName = NewVendor;
      VendorDesc = NewDesc;
    }
    public static List<Vendor> sVendors = new List<Vendor>();
    public static void AddVendor(Vendor v) {
      v.VendorID = ++sNextID;
      sVendors.Add(v);
      Console.WriteLine("Added vendor with ID" + v.VendorID);
    }
    public static List<Vendor> VendorList() {
      return sVendors;
    }
    public static Vendor FindVendorByID(int id) {
      foreach(Vendor v in sVendors) {
        if(v.VendorID == id) {
          return v;
        }
      }
      return null;
    }
    public static void AddOrder(Order o) {
      Vendor v = Vendor.FindVendorByID(o.VendorID);
      if (v == null) {
        throw new Exception("Vendor not found");
      } else {
        v.AddNewOrder(o);
      }
    }
  }
}