public class Order
{
    public string orderId { get; set; }
    public string orderDestination { get; set; }

    public Order()
    {
        orderId = string.Empty;
        orderDestination = string.Empty;
    }
}

