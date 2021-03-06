﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;//BA
using System.ComponentModel.DataAnnotations; //BA For setting the key to create the DBContext and controller
using System.ComponentModel.DataAnnotations.Schema;//BA
using System.ComponentModel;

//BA
namespace CommerceApp.Models
{
    
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [DisplayName("First Name")]
        public virtual string firstName { get; set; }

        [DisplayName("Last Name")]
        public virtual string lastName { get; set; }

       
        
        [DisplayName("Job Title")]
        public virtual string jobTitle { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Birth Date")]
        public virtual DateTime birthDate { get; set; }

        [DisplayName("Hire Date")]
        public virtual DateTime hireDate { get; set; }

        [DisplayName("Days First Call")]
        public virtual int daysFirstCall { get; set; }

        [DisplayName("Days Second Call")]
        public virtual int daysSecondCall { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual List<Employee> Employees { get; set; }

    }
}