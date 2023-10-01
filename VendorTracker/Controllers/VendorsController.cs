using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorTracker.Models;


namespace VendorTracker.Controllers
{
  public class VendorsController : Controller
  {
    // Get list of all Vendors to display
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    // Get the form for a New Vendor
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    
    // Create a new Vendor
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    // Get and Show the specified Vendor's details 
    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Vendor foundVendor = Vendor.Find(vendorId);

      return View(foundVendor);
    }

    // Create a new Order for a specified Vendor, and display Order on Vendor's page
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, float price, string date)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(title, description, price, date);
      foundVendor.AddOrder(newOrder);

      return View("Show", foundVendor);
    }

    // Get the form to Edit a specified Vendor
    [HttpGet("/vendors/{vendorId}/edit")]
    public ActionResult Edit(int vendorId)
    {
      Vendor foundVendor = Vendor.Find(vendorId);

      return View(foundVendor);
    }
    
    // Update the specified Vendor
    [HttpPost("/vendors/{vendorId}")]
    public ActionResult Update(int vendorId, string newName, string newDescription)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      foundVendor.Name = newName;
      foundVendor.Description = newDescription;

      return View("Show", foundVendor);
    }

    // Delete the specified Vendor
    [HttpPost("/vendors/{vendorId}/delete")]
    public ActionResult Delete(int vendorId)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      Vendor.GetAll().Remove(foundVendor);
      
      return RedirectToAction("Index");
    }

    // Delete the specified Order from both the Vendor's list
    [HttpPost("/vendors/{vendorId}/orders/{orderId}/delete")]
    public ActionResult Delete(int vendorId, int orderId)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      Order foundOrder = Order.Find(orderId);

      foundVendor.Orders.Remove(foundOrder);

      return View("Show", foundVendor);
    }
  }
}