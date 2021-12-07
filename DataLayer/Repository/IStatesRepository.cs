using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IStatesRepository
    {

        IEnumerable<States> GetStates();
        States GetStateByID(int id);
        List<string> GetAllStates();
        bool Insert(States state);
        bool Update(States state);
        bool Delete(States state);
        bool Delete(int id);

    }
}
