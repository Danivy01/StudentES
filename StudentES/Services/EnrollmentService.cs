using StudentES.Models;
using StudentES.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentES.Services
{
    public class EnrollmentService
    {
        IEnrollmentRepo enrollmentRepo;

        public EnrollmentService(IEnrollmentRepo enrollmentRepo)
        {
            this.enrollmentRepo = enrollmentRepo;
        }

        public List<Enrollment> getAll() => enrollmentRepo.getAll();
        public int create(Enrollment obj) => enrollmentRepo.create(obj);
        public int update(Enrollment obj) => enrollmentRepo.update(obj);
        public void delete(int Id) => enrollmentRepo.delete(Id);
        public Enrollment find(int Id) => enrollmentRepo.find(Id);
        public List<SelectListItem> statusOptions() => enrollmentRepo.statusOptions();
    }
}