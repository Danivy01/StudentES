using StudentES.Models;
using StudentES.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentES.Services
{
    public class StudentService
    {
        IStudentRepo repo;
        public StudentService(IStudentRepo repo)
        {
            this.repo = repo;
        }

        public List<Students> getAll() => repo.getAll();
        public Students find(int Id) => repo.find(Id);
        public int create(Students obj) => repo.create(obj);
        public int update(Students obj) => repo.update(obj);
        public void delete(int Id) => repo.delete(Id);
       
    }
}