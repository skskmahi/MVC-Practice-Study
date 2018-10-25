using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentRegistration.Models
{

    public class LoadData : DropCreateDatabaseIfModelChanges<StudentEntities>
    {
        protected override void Seed(StudentEntities context)
        {
            IList<Student> DefaultDepartment = new List<Student>();

            DefaultDepartment.Add(new Student() { StudentId = 1, UserName = "Nithiya", FirstName = "Nithiya", LastName = "", EmailId = "Nithiya@gmail.com", Address = "Chennai", AreasOfInterest = "Physics", Gender = "Female", Password = "test", ConfirmPassword = "test", DateOfBirth = Convert.ToDateTime("12/03/1985") });
            DefaultDepartment.Add(new Student() { StudentId = 2, UserName = "Shyamala", FirstName = "Shyamala", LastName = "", EmailId = "Shyamala@gmail.com", Address = "Bangalore", AreasOfInterest = "Chemistry",  Gender = "Female", Password = "test", ConfirmPassword = "test", DateOfBirth = Convert.ToDateTime("12/03/1985") });
           
            foreach (Student dpt in DefaultDepartment)
            context.Students.Add(dpt);

            base.Seed(context);
        }
    }

}