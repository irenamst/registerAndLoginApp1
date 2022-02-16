using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace RegisterAndLoginApp.Models
{
    public class ProductModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [DisplayName("Cost to customer")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DisplayName("What do get.......")]
        public string Description{ get; set; }
    }
}
