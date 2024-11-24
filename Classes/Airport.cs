public class Airport
{
    public string airportCode { get; set; }
    public bool isReturningAirport { get; set; }
    public Airport()
    {
        airportCode = string.Empty;
        isReturningAirport = false;
    }
    public Airport(string cityCode, bool isReturningAirport)
    {
        airportCode = cityCode;
        this.isReturningAirport = isReturningAirport;
    }
}

