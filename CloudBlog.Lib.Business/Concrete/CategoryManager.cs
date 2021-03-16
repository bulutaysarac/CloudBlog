using CloudBlog.Lib.Business.Abstract;
using CloudBlog.Lib.DataAccess.Abstract;
using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(int categoryId)
        {
            var category = _categoryDal.Get(i => i.Id == categoryId);
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
