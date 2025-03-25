using StudentES.Models;
using StudentES.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentES.Services
{
    public class CourseService
    {
        ICoursesRepo courseRepo;
        public CourseService(ICoursesRepo courseRepo)
        {
            this.courseRepo = courseRepo;
        }

        public List<Courses> getAll() => courseRepo.getAll();
        public int create(Courses obj) => courseRepo.create(obj);
        public int update(Courses obj) => courseRepo.update(obj);
        public void delete(int Id) => courseRepo.delete(Id);
        public Courses find(int Id) => courseRepo.find(Id);
    }
}