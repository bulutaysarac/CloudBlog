using CloudBlog.Lib.Business.Abstract;
using CloudBlog.Lib.DataAccess.Abstract;
using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Business.Concrete
{
    public class TagManager : ITagService
    {
        private ITagDal _tagDal;

        public TagManager(ITagDal tagDal)
        {
            _tagDal = tagDal;
        }

        public void Add(Tag tag)
        {
            _tagDal.Add(tag);
        }

        public void Delete(int tagId)
        {
            var tag = _tagDal.Get(i => i.Id == tagId);
            _tagDal.Delete(tag);
        }

        public void Update(Tag tag)
        {
            _tagDal.Update(tag);
        }
    }
}
