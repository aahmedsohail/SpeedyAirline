public class FlightScheduler : IFlightScheduler
{
    public ConfigureVariables _configureVariables { get; set; }
    public DailyRoute dailyRoute { get; set; }

    public FlightScheduler()
    {
        _configureVariables = new ConfigureVariables();
        dailyRoute = new DailyRoute();
    }
    public FlightScheduler(ConfigureVariables configureVariables)
    {
        _configureVariables = configureVariables;
        dailyRoute = new DailyRoute();
    }
    public void ComputeFlights()
    {
        dailyRoute.ComputeFlightData(_configureVariables);
        dailyRoute.FillOrders(_configureVariables.saleOrders);
    }
}