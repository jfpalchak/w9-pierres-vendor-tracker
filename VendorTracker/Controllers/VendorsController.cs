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
    
    // Upon submitting the form, Create the new Vendor and redirect to root path
    // (CR asks for user to be routed back to the "homepage" - which homepage? Assuming Vendor homepage.)
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

  }
}