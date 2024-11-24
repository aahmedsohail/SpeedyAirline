
public class Variables : IVariables
{
    public ConfigureVariables _configureVariables { get; set; }
    public JsonReader _reader { get; set; }
    public FlightScheduler _flightScheduler { get; set; }


    public Variables()
    {
        _reader = new JsonReader();
        _configureVariables = new ConfigureVariables();
        _flightScheduler = new FlightScheduler(_configureVariables);
        
    }
    public void PopulateClassObjects(Input input)
    {
        _configureVariables.InputVariables(input);
        _configureVariables.saleOrders = _reader.ReadJSON(input);
    }
   
}

