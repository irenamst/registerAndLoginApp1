using RegisterAndLoginApp.Models;
using System.Globalization;

namespace RegisterAndLoginApp.Services
{
    public class HardCodedSampleDataRepositoryMovie : IMovieDataService
    {
        static List<MovieModel> movieList = new List<MovieModel>();
        public int Delete(MovieModel movie)
        {
            throw new NotImplementedException();
        }
        public List<MovieModel> GetAllMovies()
        {
            if(movieList.Count == 0)
            {
                long ticks1 = new DateTime(2022, 02, 1, 21, 30, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                long ticks2 = new DateTime(2022, 02, 2, 21, 30, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                long ticks3 = new DateTime(2022, 02, 3, 21, 30, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                long ticks4 = new DateTime(2022, 02, 4, 21, 30, 00, new CultureInfo("en-US", false).Calendar).Ticks;
                DateTime dt1 = new DateTime(ticks1);
                DateTime dt2 = new DateTime(ticks2);
                DateTime dt3 = new DateTime(ticks3);
                DateTime dt4 = new DateTime(ticks4);
                movieList.Add(new MovieModel
                {
                    Id = 1,
                    Name = "Golden Eye",
                    dateTime = dt1,
                    Price = 25.00m,
                    Description = " When a deadly satellite weapon system falls into the wrong hands, only Agent James Bond 007 (Pierce Brosnan) can save the world from certain disaster."
                });
                movieList.Add(new MovieModel
                {
                    Id = 2,
                    Name = "Tomorrow never dies",
                    dateTime = dt2,
                    Price = 25.00m,
                    Description = "James Bond sets out to stop a media mogul's plan to induce war between China and the UK in order to obtain exclusive global media coverage."
                });
                movieList.Add(new MovieModel
                {
                    Id = 3,
                    Name = "The World Is Not Enough",
                    dateTime = dt3,
                    Price = 25.00m,
                    Description = "James Bond uncovers a nuclear plot while protecting an oil heiress from her former kidnapper, an international terrorist who can't feel pain."
                });
                movieList.Add(new MovieModel
                {
                    Id = 4,
                    Name = "Die Another day",
                    dateTime = dt4,
                    Price = 25.00m,
                    Description = "James Bond is sent to investigate the connection between a North Korean terrorist and a diamond mogul, who is funding the development of an international space weapon."
                });
            }
            return movieList;
        }

        public MovieModel GetMovieById(int Id)
        {
            throw new NotImplementedException();
        }

        public int Insert(MovieModel movie)
        {
            throw new NotImplementedException();
        }

        public List<MovieModel> SearchMovies(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(MovieModel movie)
        {
            throw new NotImplementedException();
        }
    }
}
