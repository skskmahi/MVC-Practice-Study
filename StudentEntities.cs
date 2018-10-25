using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentRegistration.Models
{
    public class StudentEntities:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}