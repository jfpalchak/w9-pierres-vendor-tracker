using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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
    public void GetOrders_ReturnsEmptyListOfVendorOrders_OrderList()
    {
      Vendor newVendor = new Vendor("Sally's", "Bi-Weekly Order");
      List<Order> newList = new List<Order> { };

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToVendorsListOfOrders_OrderList()
    {
      Vendor newVendor = new Vendor("Sally's", "Bi-Weekly Order");
      Order newOrder = new Order("Bread Order", "2 Orders", 10, "9/29/2023");
      List<Order> newList = new List<Order> { newOrder };

      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsListOfAllInstancesOfVendor_VendorList()
    {
      Vendor newVendor1 = new Vendor("Name", "Description");
      Vendor newVendor2 = new Vendor("Name 2", "Description 2");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_ClearListOfAllVendorInstances_Void()
    {
      Vendor newVendor = new Vendor("Sally's", "Bi-Weekly Order");
      List<Vendor> newList = new List<Vendor> {};

      Vendor.ClearAll();
      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Vendor newVendor = new Vendor("Sally's", "Bi-Weekly Order");

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsSpecificVendorAccordingToId_Vendor()
    {
      Vendor newVendor1 = new Vendor("Name 1", "Description 1");
      Vendor newVendor2 = new Vendor("Name 2", "Description 2");

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }
  }
}