public class ConfigureVariables : IConfigureVariables
{
    public List<Airport> airportNames {get;set;}
    public List<Airplane> airplanes { get; set; }
    public int flights { get; set; }
    public List<Order> saleOrders { get; set; }
    public ConfigureVariables()
    {
        airportNames = new List<Airport>();
        airplanes = new List<Airplane>();
        flights = 0;
        saleOrders = new List<Order>();
    }
    public void InputVariables(Input input)
    {
        
        foreach (KeyValuePair<string, bool> entry in input.airportCodes)
        {
            airportNames.Add(new Airport(entry.Key, entry.Value));
        }
        
        //Populate Airplanes
       
        for (int i = 0; i < input.airplaneCount; i++)
        {
            airplanes.Add(new Airplane(input.airplaneLoad));
        }

        flights = input.flightCount;

    }

}
