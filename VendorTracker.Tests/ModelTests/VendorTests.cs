using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Name", "Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      string name = "Sally's";
      Vendor newVendor = new Vendor(name, "Description");

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescriptionOfVendor_String()
    {
      string description = "Sally's Coffee Shop, a bi-weekly Order";
      Vendor newVendor = new Vendor("Sally's", description);

      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    
  }
}