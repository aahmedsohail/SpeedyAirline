
class Program
{
    static void Main()
    {

        //Populate the Aiports
        //1st parameter is the airport code
        //2nd is a bool to check if its a returning airport

        Dictionary<string, bool> airportNames = new Dictionary<string, bool>(4);
        airportNames.Add("YUL", true);
        airportNames.Add("YYZ", false);
        airportNames.Add("YYC", false);
        airportNames.Add("YVR", false);

        //Add all your relevant inpur variables here.
        Input input= new Input();
        input.airportCodes = airportNames;
        input.airplaneLoad = 20;
        input.airportCount = 4;
        input.flightCount = 2;
        input.airplaneCount= 2;
        input.jsonFilePath = "C:\\Users\\Admin\\source\\repos\\Test\\file\\data.json";

        //A class that will set the inital variables
        Variables objVariables = new Variables();


        //Populate Class Objects so that all the relevant classes are initilized with data
        //This function will also capture the JSON data provided
        objVariables.PopulateClassObjects(input);


        // A class that displays the schedule for the sale orders
        FlightScheduler objFlightScheduler = new FlightScheduler(objVariables._configureVariables);
        objFlightScheduler.ComputeFlights();
    }
}




