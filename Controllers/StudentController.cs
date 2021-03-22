using AspCoreApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreApp.Controllers
{
    public class StudentController : Controller
    {
         StudentDetails details = new StudentDetails();
        // GET: StudentController
        public static List<StudentDetails> students = StudentDetails.GetStudentDetails();
        public ActionResult Studentinfo()
        {
            
            return View(students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
          
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentDetails studentDetails)
        {
            try
            {
                details.AddDetails(studentDetails);                //student.AddDetails(student);

                return RedirectToAction("Studentinfo");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            StudentDetails data = students.FirstOrDefault(x => x.Sid == id);
            return View(data);
           // return View();

            
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, StudentDetails studentDetails)
        {
            try
            {
                StudentDetails data = students.FirstOrDefault(x => x.Sid == id);
                /*if (studentDetails != null)
                {*/
                data.Sid= studentDetails.Sid;
                data.SName = studentDetails.SName;
                data.Address = studentDetails.Address;

                
                    
                    return RedirectToAction("Studentinfo");
                    
               //}
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            StudentDetails data = students.FirstOrDefault(x => x.Sid == id);
            details.DeleteDetails(data);
            return RedirectToAction("Studentinfo");

            //return View();
        }

        // POST: StudentController/Delete/5
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, StudentDetails studentDetails)
        {
            try
            {
                StudentDetails data = students.FirstOrDefault(x => x.Sid == id);
                details.DeleteDetails(studentDetails);
                return RedirectToAction("Studentinfo");
            }
            catch
            {
                return View();
            }
        }*/
    }
}
