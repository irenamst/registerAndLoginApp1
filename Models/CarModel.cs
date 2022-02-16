using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegisterAndLoginApp.Models
{
    public class CarModel
    {
        [DisplayName("Id номер")]
        public int Id { get; set; }

        [DisplayName("Номер")]
        public string Number { get; set; }

        [DisplayName("Име")]
        public string Name { get; set; }

        [DisplayName("Модел")]
        public string Model { get; set; }

        [DisplayName("Мощност (kW)")]
        public int Power { get; set; }

        [DisplayName("Ускорение (s/100km)")]
        public decimal Acceleration { get; set; }

        [DisplayName("Разход на гориво (l/100km)")]
        public decimal FuelConsumption {get; set;}

        [DisplayName("Въглеродни емисии (g/km)")]
        public int CarbonЕmissions { get; set; }

        [DisplayName("Дата на закупуване")]
        public DateTime DateOfPurchase{ get; set; }

        [DisplayName("Цена")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [DisplayName("Месечна вноска лв. на месец")]
        [DataType(DataType.Currency)]
        public int MonthlyPayment { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }
    }
}
