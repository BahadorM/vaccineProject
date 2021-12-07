using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork:IDisposable
    {
        VaccineContext _db = new VaccineContext();

        private IUserRepository _userRepository { get; set; }
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_db);
                }
                return _userRepository;
            }
        }

        IStatesRepository _statesRepository { get; set; }
        public IStatesRepository StatesRepository
        {
            get
            {
                if (_statesRepository == null)
                {
                    _statesRepository = new StatesRepository(_db);
                }
                return _statesRepository;
            }
        }
        public void Save()
        {
            _db.SaveChanges();
        }
        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
