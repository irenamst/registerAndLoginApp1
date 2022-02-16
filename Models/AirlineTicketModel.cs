using System.ComponentModel;

namespace RegisterAndLoginApp.Models
{
    public class AirlineTicketModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }

        [DisplayName("Полет")]
        public string Flight { get; set; }

        [DisplayName("Департамент")]
        public string Departure { get; set; }

        [DisplayName("Пристигане")]
        public string Arrival { get; set; }

        [DisplayName("Пилот")]
        public string Pilot { get; set; }

        [DisplayName("Самолет")]
        public string Aircraft { get; set; }

        [DisplayName("Статус")]
        public string Status { get; set; }

        [DisplayName("Излитане")]
        public DateTime DepartureTime { get; set; }

        [DisplayName("Пристигане")]
        public DateTime ArrivalTime { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }
    }
}
