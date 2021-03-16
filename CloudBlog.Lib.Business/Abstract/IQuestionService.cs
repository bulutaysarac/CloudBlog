using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Business.Abstract
{
    public interface IQuestionService
    {
        void Add(Question question);
        void Delete(int questionId);
        void Update(Question question);
    }
}
