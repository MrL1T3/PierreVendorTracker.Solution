using Microsoft.AspNetCore.Mvc;
using PierreVendorTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    public ActionResult Index()
    {
      return View(PierreVendorTracker.Models.Vendor.VendorList());
    }

    [Route("Vendor/{id?}")]
    public ActionResult Vendor(int id) {
      Vendor v = PierreVendorTracker.Models.Vendor.FindVendorByID(id);
      if(v == null) {
        return NotFound();
      }
      return View(v);
    }

    public ActionResult AddVendor()
    {
      return View(new Vendor("", ""));
    }
    [HttpPost]
    public ActionResult AddVendorForm(Vendor model)
    {
      PierreVendorTracker.Models.Vendor.AddVendor(model);
      return RedirectToAction("Index", "Home");
    }
  }
}