using Microsoft.EntityFrameworkCore;
using MovieWeb_BO;
using MovieWeb_BO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWeb_DAO
{
    public class MovieDAO
    {
        private readonly PePrnFall22B1Context _context;
        private static MovieDAO instance = null;

        private MovieDAO()
        {
            _context = new PePrnFall22B1Context();
        }

        public static MovieDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    return new MovieDAO();
                }
                return Instance;
            }
        }

        public async Task<List<Movie>> GetListMovie()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<List<Movie>> GetListMovieByDirector(int DirectorID)
        {
            return await _context.Movies.Where(e => e.DirectorId == DirectorID).ToListAsync();
        }
    }
}
