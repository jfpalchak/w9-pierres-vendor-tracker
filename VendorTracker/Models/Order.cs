using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public string Date { get; set; }

    private static List<Order> _instances = new List<Order> {};
    
    public int Id { get; }

    public Order(string orderTitle, string orderDescription, float orderPrice, string orderDate)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = orderPrice;
      Date = orderDate;

      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}