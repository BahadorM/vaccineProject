using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IUserRepository
    {
        IEnumerable<Users> GetUser();
        Users GetUserByID(int id);
        bool Insert(Users user);
        bool Update(Users user);
        bool Delete(Users user);
        bool Delete(int id);
        
    }
}
