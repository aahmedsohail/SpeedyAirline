using System.Text.Json;

public class JsonReader:IJsonReader
{
    string filePath { get; set; }
    public JsonReader()
    {
        filePath = string.Empty;
    }
    public List<Order> ReadJSON(Input input)
    {
        List <Order> saleOrders = new List<Order>();
        string jsonContent = File.ReadAllText(input.jsonFilePath);
        var ordersDictionary = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(jsonContent);
        foreach (var kvp in ordersDictionary)
        {
            saleOrders.Add(new Order
            {
                orderId = kvp.Key,
                orderDestination = kvp.Value["destination"]
            });
        }

        return saleOrders;
    }
}

