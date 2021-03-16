using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Business.Abstract
{
    public interface IAdminService
    {
        void Add(Admin admin);
        void Delete(int adminId);
        void Update(Admin admin);
        Admin Login(Admin admin);
    }
}
