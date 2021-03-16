using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryId);
        List<Category> GetAll(); 
    }
}
