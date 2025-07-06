using MovieWeb_BO.Entities;
using MovieWeb_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWeb_Repo
{
    public class DirectorRepo : IDirectorRepo
    {
        public Task<List<Director>> GetListDirectorFunc()
        {
            return DirectorDAO.Instance.GetListDirector();
        }
    }
}
