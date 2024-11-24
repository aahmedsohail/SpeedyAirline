public class FlightDetail
{
    public Airplane airplane { get; set; }
    public Airport originAirport {get; set;}
    public Airport destinationAirport { get; set; }

    public List<Order> orders { get; set; }
    public int loadCapacity { get; set; }
    public int dayCount { get; set; }

    public FlightDetail()
    {
        originAirport = new Airport();
        destinationAirport = new Airport();
        orders = new List<Order>();
        loadCapacity = 0;
        dayCount = 0;
        airplane= new Airplane();
    }

    public FlightDetail(Airport originAirport, Airport destinationAirport, int loadCapacity, int dayCount)
    {
        this.originAirport = originAirport;
        this.destinationAirport = destinationAirport;
        this.loadCapacity = loadCapacity;
        this.dayCount = dayCount;
        orders = new List<Order>();
        airplane = new Airplane();
    }
    public FlightDetail(Airport originAirport, Airport destinationAirport, int loadCapacity, List<Order> orders)
    {
        this.originAirport = originAirport;
        this.destinationAirport = destinationAirport;
        this.loadCapacity = loadCapacity;
        this.orders = orders;
        airplane = new Airplane();
    }
}

