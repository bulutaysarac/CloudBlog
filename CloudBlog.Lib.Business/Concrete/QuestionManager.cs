using CloudBlog.Lib.Business.Abstract;
using CloudBlog.Lib.DataAccess.Abstract;
using CloudBlog.Lib.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        private IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public void Add(Question question)
        {
            _questionDal.Add(question);
        }

        public void Delete(int questionId)
        {
            var question = _questionDal.Get(i => i.Id == questionId);
            _questionDal.Delete(question);
        }

        public void Update(Question question)
        {
            _questionDal.Update(question);
        }
    }
}
