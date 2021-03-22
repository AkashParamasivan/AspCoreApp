using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreApp.Models
{
    public class StudentDetails
    {
        public int Sid { get; set; }
        public string SName { get; set; }
        public string Address { get; set; }

        public StudentDetails()
        {

        }

        public StudentDetails(int sid, string sname, string addr)
        {
            Sid = sid;
            SName = sname;
            Address = addr;
        }

      public static  List<StudentDetails> students = new List<StudentDetails>();
        public static List<StudentDetails> GetStudentDetails()
        {
           // students.Clear();
            students.Add(new StudentDetails(101, "Akash", "xxxxx"));
            students.Add(new StudentDetails(102, "Ajay", "yyyyy"));
            students.Add(new StudentDetails(103, "Raj", "zzzzzz"));
            students.Add(new StudentDetails(104, "Hari", "vvvvvv"));
            students.Add(new StudentDetails(105, "Jack", "tttttt"));
            return students;

        }

     

        public void AddDetails(StudentDetails student)
        {
            students.Add(student);
        }

        public void DeleteDetails(StudentDetails student)
        {
            students.Remove(student);
        }
    }

    
}

