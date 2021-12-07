using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataLayer
{
    public class UserRepository : IUserRepository
    {
        VaccineContext _db;

        public UserRepository(VaccineContext db)
        {
            this._db = db;
        }

        public bool Delete(Users user)
        {
            try
            {
                _db.Users.Remove(user);
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
                Delete(GetUserByID(id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Users> GetUser()
        {
            return _db.Users.ToList();
        }

        public Users GetUserByID(int id)
        {
            return _db.Users.Find(id);
        }

        public bool Insert(Users user)
        {
            try
            {
                _db.Users.Add(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Users user)
        {
            try
            {
                _db.Entry(user).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
