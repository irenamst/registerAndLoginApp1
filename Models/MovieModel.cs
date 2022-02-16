using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegisterAndLoginApp.Models
{
    public class MovieModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Movie Name")]
        public string Name { get; set; }
        [DisplayName("On which date and in what time ...")]
        
        public DateTime dateTime { get; set; }
        [DisplayName("Cost to customer")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DisplayName("What are you going to watch....")]
        public string Description { get; set; }
        
    }
}
