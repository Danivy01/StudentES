using StudentES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentES.Services.Interfaces
{
    public interface ICoursesRepo
    {
        List<Courses> getAll();
        int create(Courses obj);
        int update(Courses obj);
        void delete(int Id);
        Courses find(int Id);
    }
}
