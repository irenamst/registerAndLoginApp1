using RegisterAndLoginApp.Models;
using System.Globalization;
namespace RegisterAndLoginApp.Services
{
    public class HardCodedSampleDataRepositoryCar : ICarDataService
    {
        static List<CarModel> carList = new List<CarModel>();
        public int Delete(CarModel car)
        {
            throw new NotImplementedException();
        }

        public List<CarModel> GetAllCars()
        {
            if (carList.Count == 0)
            {
                long ticks1 = new DateTime(2021, 09, 1, 12, 30, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                long ticks2 = new DateTime(2021, 09, 2, 12, 30, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                long ticks3 = new DateTime(2021, 09, 3, 12, 30, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                long ticks4 = new DateTime(2021, 09, 4, 12, 30, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                DateTime dt1 = new DateTime(ticks1);
                DateTime dt2 = new DateTime(ticks2);
                DateTime dt3 = new DateTime(ticks3);
                DateTime dt4 = new DateTime(ticks4);

                carList.Add(new CarModel
                {
                    Id = 1,
                    Number = "M QB 1180",
                    Name = "BMW Z4 M40i бензин",
                    Model = "Model Advantage",
                    Power = 250,
                    Acceleration = 4.5m,
                    FuelConsumption = 7.9m,
                    CarbonЕmissions = 181,
                    DateOfPurchase = dt1,
                    Price = 92730,
                    MonthlyPayment = 1470,
                    Description = "BMW Z4 M40i Roadster не познава граници. Многобройни " +
                    "детайли, вдъхновени от автомобилния спорт, създават поразително " +
                    "впечатление и осигуряват изключително ниво на динамика. " +
                    "Това е спортен автомобил, който превръща желанието за свобода в бързо ускорение."
                });
                carList.Add(new CarModel
                {
                    Id = 2,
                    Number = "M NK 8010",
                    Name = "BMW Z4 M40i бензин",
                    Model = "Базов модел",
                    Power = 250,
                    Acceleration = 4.5m,
                    FuelConsumption = 7.9m,
                    CarbonЕmissions = 181,
                    DateOfPurchase = dt2,
                    Price = 90001,
                    MonthlyPayment = 1426,
                    Description = ""
                });
                carList.Add(new CarModel
                {
                    Id = 3,
                    Number = "M NK 8118",
                    Name = "BMW Z4 M40i бензин",
                    Model = "Model Sport Line",
                    Power = 250,
                    Acceleration = 4.5m,
                    FuelConsumption = 7.9m,
                    CarbonЕmissions = 181,
                    DateOfPurchase = dt3,
                    Price = 97683,
                    MonthlyPayment = 1548,
                    Description = "Моделът Sport Line впечатлява с динамичното си " +
                    "излъчване. Впечатляващите екстериорни и интериорни детайли в " +
                    "черен гланц или матиран алуминий подчертават спортния характер. " +
                    "Оборудването като предните М Спортни седалки с черна кожена тапицерия" +
                    " 'Vernasca' и 2-зоновата автоматична климатична инсталация повишават комфорта."
                });
                carList.Add(new CarModel
                {
                    Id = 4,
                    Number = "M NK 8811",
                    Name = "BMW Z4 M40i бензин",
                    Model = "",
                    Power = 250,
                    Acceleration = 4.5m,
                    FuelConsumption = 7.9m,
                    CarbonЕmissions = 181,
                    DateOfPurchase = dt4,
                    Price = 125400,
                    MonthlyPayment = 1987,
                    Description = "BMW Z4 M40i Roadster не познава граници.Многобройни детайли," +
                    "вдъхновени от автомобилния спорт, създават поразително впечатление" +
                    "и осигуряват изключително ниво на динамика. Това е спортен автомобил," +
                    "който превръща желанието за свобода в бързо ускорение."
                });
            }
            return carList;
        }

        public CarModel GetCarById(int Id)
        {
            throw new NotImplementedException();
        }

        public int Insert(CarModel car)
        {
            throw new NotImplementedException();
        }

        public List<CarModel> SearchCars(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(CarModel car)
        {
            throw new NotImplementedException();
        }
    }
}
