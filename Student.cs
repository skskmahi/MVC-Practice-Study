using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace StudentRegistration.Models
{     
    public class Student
    {
        [Key]
        [ScaffoldColumn(false)]
        public int StudentId { get; set; }
      
        public string UserName { get; set; }
       
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
      
        public string EmailId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }            
        
        public DateTime DateOfBirth { get; set; }
       
        public string Gender{ get; set; }
       
        public string Address { get; set; }
                       
        public string AreasOfInterest { get; set; }

    }
}