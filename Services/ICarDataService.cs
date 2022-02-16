using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services
{
    public interface ICarDataService
    {
        List<CarModel> GetAllCars();
        List<CarModel> SearchCars(string searchTerm);
        CarModel GetCarById(int Id);
        int Insert(CarModel car);
        int Delete(CarModel car);
        int Update(CarModel car);

    }
}
