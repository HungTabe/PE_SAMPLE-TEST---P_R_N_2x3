using MovieWeb_BO.Entities;
using MovieWeb_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWeb_Repo
{
    public class MovieRepo : IMovieRepo
    {
        public Task<List<Movie>> GetListMovieByDirectorFunc(int DirectorID)
        {
            return MovieDAO.Instance.GetListMovieByDirector(DirectorID);
        }

        public Task<List<Movie>> GetListMovieFunc()
        {
            return MovieDAO.Instance.GetListMovie();
        }
    }
}
