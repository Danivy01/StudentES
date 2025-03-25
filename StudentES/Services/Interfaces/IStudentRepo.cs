using StudentES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentES.Services.Interfaces
{
    public interface IStudentRepo
    {

        List<Students> getAll();
        Students find(int Id);
        int create(Students obj);
        int update(Students obj);
        void delete(int Id);
    }
}
