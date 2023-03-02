using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _admin ;

        public AdminManager(IAdminDal ad)
        {
            _admin = ad;
        }
        public void AdminAdd(Admin admin)
        {
            _admin.Insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
            _admin.Delete(admin);
        }

        public void AdminUpdate(Admin admin)
        {
            _admin.Update(admin);
        }

        public Admin GetByID(int id)
        {
            return _admin.Get(x =>x.AdminID == id);
        }

        public List<Admin> GetList()
        {
            return _admin.List();
        }

        public List<Admin> GetList(string p)
        {
            throw new NotImplementedException();
        }
    }
}
