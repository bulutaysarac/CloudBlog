using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Business.Abstract
{
    public interface ITagService
    {
        void Add(Tag tag);
        void Update(Tag tag);
        void Delete(int tagId);
    }
}
