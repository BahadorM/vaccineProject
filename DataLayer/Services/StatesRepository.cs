using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataLayer
{
    public class StatesRepository : IStatesRepository
    {
        private readonly VaccineContext _db;

        public StatesRepository(VaccineContext db)
        {
            this._db = db;
        }

        public bool Delete(States state)
        {
            try
            {
                _db.States.Remove(state);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                Delete(GetStateByID(id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<States> GetStates()
        {
            return _db.States.ToList();
        }

        public States GetStateByID(int id)
        {
            return _db.States.Find(id);
        }

        public bool Insert(States state)
        {
            try
            {
                _db.States.Add(state);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(States state)
        {
            try
            {
                _db.States.Attach(state);

                _db.Entry(state).State= EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<string> GetAllStates()
        {
            return _db.States.Select(c => c.CityName).ToList();
        }
    }
}
