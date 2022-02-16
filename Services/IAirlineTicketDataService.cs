using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services
{
    public interface IAirlineTicketDataService
    {
        List<AirlineTicketModel> GetAllAirlineTickets();

        List<AirlineTicketModel> SearchAirlineTickets(string searchTerm);
        AirlineTicketModel GetAirlineTicketById(int Id);
        int Insert(AirlineTicketModel airlineTicket);
        int Delete(AirlineTicketModel airlineTicket);
        int Update(AirlineTicketModel airlineTicket);
    }
}
