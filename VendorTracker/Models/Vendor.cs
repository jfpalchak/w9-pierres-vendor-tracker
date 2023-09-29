using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; }

    private static List<Vendor> _instances = new List<Vendor> {};

    public int Id { get; }

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      Orders = new List<Order> {};

      // _instances.Add(this);
      // Id = _instances.Count;
    }

    public void AddOrder(Order newOrder)
    {
      Orders.Add(newOrder);
    }
  }
}