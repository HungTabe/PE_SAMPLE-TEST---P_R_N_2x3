using MovieWeb_BO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWeb_Repo
{
    public interface IMovieRepo
    {
        Task<List<Movie>> GetListMovieFunc();
        Task<List<Movie>> GetListMovieByDirectorFunc(int DirectorID);
    }
}
