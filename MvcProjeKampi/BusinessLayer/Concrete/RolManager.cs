using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class RolManager : IRolService
    {
        IRolDal _rolDal;
        public RolManager(IRolDal rolDal)
        {
            _rolDal = rolDal;
        }
        public string[] GetRolesForUser(string username)
        {
            throw new NotImplementedException();
        }
    }
}
