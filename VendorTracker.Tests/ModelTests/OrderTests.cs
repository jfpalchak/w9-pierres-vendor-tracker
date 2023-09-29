using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Bread Order", "10 Orders at $5 each.", 50, "9/29/2023");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string title = "Bread Order";
      Order newOrder = new Order(title, "10 Orders at $5 each.", 50, "9/29/2023");

      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string description = "10 Orders at $5 each.";
      Order newOrder = new Order("Bread Order", description, 50, "9/29/2023");

      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfOrder_Float()
    {
      float price = 50.50f;
      Order newOrder = new Order("Bread Order", "10 Orders.", price, "9/29/2023");

      float result = newOrder.Price;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDateOfOrder_String()
    {
      string date = "9/29/2023";
      Order newOrder = new Order("Bread Order", "10 Orders.", 50, date);

      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsListOfOrders_OrderList()
    {
      Order newOrder1 = new Order("Title", "Description", 10, "Date");
      Order newOrder2 = new Order("Title", "Description", 20, "Date");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_ClearsListOfAllOrders_Void()
    {
      List<Order> newList = new List<Order> { };
      Order newOrder1 = new Order("Title", "Description", 10, "Date");
      Order newOrder2 = new Order("Title", "Description", 20, "Date");
      Order.ClearAll();

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersAreInstantiatedWithAnIdAndGetterReturnsId_Int()
    {
      Order newOrder = new Order("Title", "Description", 10, "Date");

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }
  }
}