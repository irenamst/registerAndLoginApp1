using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services
{
    public interface IMovieDataService
    {
        List<MovieModel> GetAllMovies();
        List<MovieModel> SearchMovies(string searchTerm);
        MovieModel GetMovieById(int Id);
        int Insert(MovieModel movie);
        int Delete(MovieModel movie);
        int Update(MovieModel movie);
    }
}
