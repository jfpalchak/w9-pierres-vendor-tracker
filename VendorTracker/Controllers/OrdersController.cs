using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {
    // Get and Show the specified Order's details, for a specified Vendor
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

    // Get the form for a New Order
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor foundVendor = Vendor.Find(vendorId);

      return View(foundVendor);
    }

    // Get the form to Update a specified Order
    [HttpGet("/vendors/{vendorId}/orders/{orderId}/edit")]
    public ActionResult Edit(int vendorId, int orderId)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      Order foundOrder = Order.Find(orderId);

      Dictionary<string, object> model = new Dictionary<string, object> {};
      
      model.Add("vendor", foundVendor);
      model.Add("order", foundOrder);

      return View(model);
    }

    // Upon submitting Edit form, update the specified Order's details and display that order's page
    [HttpPost("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Update(int vendorId, int orderId, string newTitle, string newDescription, float newPrice, string newDate)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      Order foundOrder = Order.Find(orderId);

      foundOrder.Title = newTitle;
      foundOrder.Description = newDescription;
      foundOrder.Price = newPrice;
      foundOrder.Date = newDate;

      Dictionary<string, object> model = new Dictionary<string, object> {};
      
      model.Add("vendor", foundVendor);
      model.Add("order", foundOrder);

      return View("Show", model);
    }
  }
}