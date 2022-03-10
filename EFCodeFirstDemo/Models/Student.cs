using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirstDemo.Models
{
    public class Student
    {
        public int StudentId { get; set; }          //scalar property
        public string StudentName { get; set; }     //scalar property
        public string DateOfBirth { get; set; }     //scalar property
        public Address Address { get; set; }        //navigation property
    }
}