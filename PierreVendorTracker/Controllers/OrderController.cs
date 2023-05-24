using Microsoft.AspNetCore.Mvc;
using PierreVendorTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
    public ActionResult AddOrder(int id)
    {
      ViewData["id"] = id;
      Order order = new Order("", "", "", "", 0);

      return View(order);
    }
    [HttpPost]
    public ActionResult AddOrderForm(int id, Order model)
    {
      model.VendorID = id;
      PierreVendorTracker.Models.Vendor.AddOrder(model);
      return RedirectToAction("Vendor", "Vendors", new{id = model.VendorID});
    }
  }
}