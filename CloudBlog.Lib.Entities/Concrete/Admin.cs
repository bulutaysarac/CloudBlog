using CloudBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Entities.Concrete
{
    public class Admin : IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
    }
}
