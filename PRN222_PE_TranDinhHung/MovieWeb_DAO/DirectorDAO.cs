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
    public class DirectorDAO
    {
        private readonly PePrnFall22B1Context _context;
        private static DirectorDAO instance = null;

        private DirectorDAO()
        {
            _context = new PePrnFall22B1Context();
        }

        public static DirectorDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    return new DirectorDAO();
                }
                return Instance;
            }
        }

        public async Task<List<Director>> GetListDirector()
        {
            return await _context.Directors.ToListAsync();
        }
    }
}
