
namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public string Date { get; set; }

    // private static List<Order> _instances = new List<Order> {};

    public Order(string orderTitle, string orderDescription, float orderPrice, string orderDate)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = orderPrice;
      Date = orderDate;
    }
  }
}