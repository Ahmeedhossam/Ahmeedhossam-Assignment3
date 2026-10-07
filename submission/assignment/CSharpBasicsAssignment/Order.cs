namespace CSharpBasicsAssignment;

public class Order
{
    public int OrderId;
    public string CustomerName;
    public int Quantity;
    public decimal UnitPrice;
    public decimal TotalPrice;
    public bool IsPaid;
    public decimal DiscountPercent;
    public string ShippingCity;
    public char Priority;
    public long ItemCode;

    public void CalculateTotal()
    {
        this.TotalPrice = this.Quantity * this.UnitPrice * (1 - this.DiscountPercent / 100);
        Console.WriteLine($"total price is {this.TotalPrice}");
    }

    public void PrintSummary()
    {
        Console.WriteLine($"OrderId: {this.OrderId}, CustomerName: {this.CustomerName}, TotalPrice: {this.TotalPrice}, IsPaid: {this.IsPaid}");
    }
}