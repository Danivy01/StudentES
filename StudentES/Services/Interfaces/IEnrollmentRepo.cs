using StudentES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentES.Services.Interfaces
{
    public interface IEnrollmentRepo
    {
        List<Enrollment> getAll();
        int create(Enrollment obj);
        int update(Enrollment obj);
        void delete(int Id);
        Enrollment find(int Id);
    }
}
