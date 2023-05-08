namespace PierreVendorTracker.Models
{
  public class Order
  {
    public int VendorID{get; set;}
    public string Text{get; set;}
    public string Price{get; set;}
    public string Date{get; set;}
    public string Title{get; set;}
    public Order()
    {
      
    }
    
    public Order(string submittedTitle, string submittedOrder, string submittedPrice, string submittedDate, int newID)
    {
      VendorID = newID;
      Text = submittedOrder;
      Price = submittedPrice;
      Date = submittedDate;
      Title = submittedTitle;
    }

    public static void AddOrder(Order o) {
      Vendor v = Vendor.FindVendorByID(o.VendorID);
      v.AddNewOrder(o);
    }
  }
}