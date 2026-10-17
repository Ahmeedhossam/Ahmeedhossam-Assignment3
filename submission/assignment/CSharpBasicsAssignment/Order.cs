namespace CSharpBasicsAssignment;

public class Order
{
    public int OrderId;
    public string CustomerName;
    public int Quantity;
    public decimal UnitPrice;
    public decimal TotalPrice;
    public bool IsPaid;
    public double DiscountPercent;
    public string ShippingCity;
    public char Priority;
    public long ItemCode;

    private bool TestFieldScope = true;

    public void CalculateTotal()
    {
        this.TotalPrice = this.Quantity * this.UnitPrice * (decimal)(1 - this.DiscountPercent / 100);
        Console.WriteLine($"total price is {this.TotalPrice}");
        Console.WriteLine($"here we can access {this.TestFieldScope}");
        int TestLocalVariable = 1;
    }

    public void PrintSummary()
    {
        Console.WriteLine($"OrderId: {this.OrderId}, CustomerName: {this.CustomerName}, TotalPrice: {this.TotalPrice}, IsPaid: {this.IsPaid}");
        Console.WriteLine($"here we can access {this.TestFieldScope}");
        // Console.WriteLine($"here we can not access {this.TestLocalVariable}");
    }
}