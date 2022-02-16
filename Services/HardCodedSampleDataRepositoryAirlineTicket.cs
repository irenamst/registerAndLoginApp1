using RegisterAndLoginApp.Models;
using System.Globalization;
namespace RegisterAndLoginApp.Services
{
    public class HardCodedSampleDataRepositoryAirlineTicket : IAirlineTicketDataService
    {
        static List<AirlineTicketModel> airlineTicketList = new List<AirlineTicketModel>();
        public int Delete(AirlineTicketModel airlineTicket)
        {
            throw new NotImplementedException();
        }
        public AirlineTicketModel GetAirlineTicketById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<AirlineTicketModel> GetAllAirlineTickets()
        {
            if (airlineTicketList.Count == 0) 
            {
                long ticks1 = new DateTime(2022, 01, 29, 08, 06, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                long ticks2 = new DateTime(2022, 01, 29, 08, 56, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                long ticks3 = new DateTime(2022, 01, 29, 08, 31, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                long ticks4 = new DateTime(2022, 01, 29, 10, 50, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                long ticks5 = new DateTime(2022, 01, 29, 09, 10, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                long ticks6 = new DateTime(2022, 01, 29, 00, 00, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                long ticks7 = new DateTime(2022, 01, 29, 09, 26, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                long ticks8 = new DateTime(2022, 01, 29, 10, 51, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                DateTime dt1 = new DateTime(ticks1);
                DateTime dt2 = new DateTime(ticks2);
                DateTime dt3 = new DateTime(ticks3);
                DateTime dt4 = new DateTime(ticks4);
                DateTime dt5 = new DateTime(ticks5);
                DateTime dt6 = new DateTime(ticks6);
                DateTime dt7 = new DateTime(ticks7);
                DateTime dt8 = new DateTime(ticks8);
                airlineTicketList.Add(new AirlineTicketModel
                {
                    Id = 1,
                    Flight = "MUC100",
                    Departure = "Munich Airport (EDDM)",
                    Arrival = "Frankfurt am Main Airport (EDDF)",
                    Pilot = "MUC003",
                    Aircraft = "A320",
                    Status = "ARRIVED",
                    DepartureTime = dt1,
                    ArrivalTime = dt2,
                    Description = "Super"
                });
                airlineTicketList.Add(new AirlineTicketModel
                {
                    Id = 2,
                    Flight = "MUC126",
                    Departure = "Munich Airport (EDDM)",
                    Arrival = "Edinburgh Airport (EGPH)",
                    Pilot = "MUC041",
                    Aircraft = "A319",
                    Status = "ARRIVED",
                    DepartureTime = dt3,
                    ArrivalTime = dt4,
                    Description = "Fantastic"
                });
                airlineTicketList.Add(new AirlineTicketModel
                {
                    Id = 3,
                    Flight = "MUC510",
                    Departure = "Munich Airport (EDDM)",
                    Arrival = "Licenciado Benito Juarez International Airport (MMMX)",
                    Pilot = "MUC255",
                    Aircraft = "B77L",
                    Status = "CRUISE",
                    DepartureTime = dt5,
                    ArrivalTime = dt6,
                    Description = "Great"
                });
                airlineTicketList.Add(new AirlineTicketModel
                {
                    Id = 4,
                    Flight = "MUC9901",
                    Departure = "Frankfurt am Main Airport (EDDF)",
                    Arrival = "Nice-Côte d'Azur Airport (LFMN)",
                    Pilot = "MUC003",
                    Aircraft = "A320",
                    Status = "ARRIVED",
                    DepartureTime = dt7,
                    ArrivalTime = dt8,
                    Description = "Excellent"
                });
            }
            return airlineTicketList;
            
        }

        public int Insert(AirlineTicketModel airlineTicket)
        {
            throw new NotImplementedException();
        }

        public List<AirlineTicketModel> SearchAirlineTickets(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(AirlineTicketModel airlineTicket)
        {
            throw new NotImplementedException();
        }
    }
}
