using MovieWeb_BO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWeb_Repo
{
    public interface IDirectorRepo
    {
        Task<List<Director>> GetListDirectorFunc();
    }
}
