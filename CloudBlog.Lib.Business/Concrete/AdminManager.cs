using CloudBlog.Lib.Business.Abstract;
using CloudBlog.Lib.DataAccess.Abstract;
using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Business.Concrete
{
    public class AdminManager : IAdminService
    {
        private IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Add(Admin admin)
        {
            _adminDal.Add(admin);
        }

        public void Delete(int adminId)
        {
            var admin = _adminDal.Get(i => i.Id == adminId);
            _adminDal.Delete(admin);
        }

        public Admin Login(Admin admin)
        {
            return _adminDal.Get(a => a.Username == admin.Username && a.Password == admin.Password);
        }

        public void Update(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
