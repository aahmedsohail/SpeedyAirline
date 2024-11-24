public class DailyRoute
{

    public List<FlightDetail> flights { get; set; }

    public DailyRoute()
    {
        flights = new List<FlightDetail>();
    }
   


    public void ComputeFlightData(ConfigureVariables objConfigureVariables)
    {

        List<Airport> airports = new List<Airport>();
        airports = objConfigureVariables.airportNames;

        Airport mainAirport = airports.Find(x => x.isReturningAirport == true);

        for(int i=0; i< objConfigureVariables.flights; i++)
        {
            foreach (Airport airportItem in airports.Where(x => x.isReturningAirport == false).ToList())
            {
                FlightDetail objFlightDetail = new FlightDetail(mainAirport, airportItem, objConfigureVariables.airplanes[i].totalLoad, i+1);
                flights.Add(objFlightDetail);
            }
        }

        PrintFlightSchedule();
    }

    public void PrintFlightSchedule()
    {
        int flightNumber = 1;
        foreach (FlightDetail fd in flights)
        {
            Console.WriteLine("Day: " + fd.dayCount + " - Flight No: " + flightNumber + " - Origin Airport: " + fd.originAirport.airportCode + " - Destination Airport: " + fd.destinationAirport.airportCode);
            flightNumber++;
        }

    }
    public void FillOrders(List<Order> orders)
    {
        for(int i=0;i< orders.Count;i++)
        {
            for(int j=0;j< flights.Count;j++)
            {
                if (orders[i].orderDestination.ToLower() == flights[j].destinationAirport.airportCode.ToLower())
                {
                    if(flights[j].airplane.totalLoad < flights[j].loadCapacity)
                    {
                        flights[j].airplane.totalLoad++;
                        flights[j].orders.Add(new Order
                        {
                            orderId = orders[i].orderId,
                            orderDestination = orders[i].orderDestination
                        });
                    }
                }
            }
        }


        int flightNumber = 0;
        foreach (FlightDetail fd in flights)
        {
            flightNumber++;
            foreach (Order o in fd.orders)
            {
                Console.WriteLine("Order: " + o.orderId + " Day: " + fd.dayCount + " - Flight No: " + flightNumber + " - Origin Airport: " + fd.originAirport.airportCode + " - Destination Airport: " + fd.destinationAirport.airportCode);
            }

        }
    }

}

