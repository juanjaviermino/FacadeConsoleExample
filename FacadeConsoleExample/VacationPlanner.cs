using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VacationPlanner
{
    private FlightBookingSystem flightBookingSystem;
    private AccommodationBookingSystem accommodationBookingSystem;
    private TransportationBookingSystem transportationBookingSystem;

    public VacationPlanner()
    {
        flightBookingSystem = new FlightBookingSystem();
        accommodationBookingSystem = new AccommodationBookingSystem();
        transportationBookingSystem = new TransportationBookingSystem();
    }

    public void PlanVacation(string destination, string accommodationLocation, int duration)
    {
        Console.WriteLine($"Vacation Planner: Planeando vacación para {destination}");
        flightBookingSystem.BookFlight(destination);
        accommodationBookingSystem.BookAccommodation(accommodationLocation, duration);
        transportationBookingSystem.ArrangeTransportation(accommodationLocation);
        Console.WriteLine("Vacation Planner: Vacación planeada con éxito!");
    }
}
