using CloudBlog.Core.DataAccess;
using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {

    }
}
