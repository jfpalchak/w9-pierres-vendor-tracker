using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      Order foundOrder = Order.Find(orderId);

      Dictionary<string, object> model = new Dictionary<string, object> {};
      
      model.Add("vendor", foundVendor);
      model.Add("order", foundOrder);
      return View(model);
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor foundVendor = Vendor.Find(vendorId);

      return View(foundVendor);
    }

  }
}