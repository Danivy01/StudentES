using StudentES.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentES.Models;
using StudentES.Data;
using System.Web.Mvc;

namespace StudentES.Services.Repository
{
    public class StudentRepo : IStudentRepo
    {
        DbControl sql = new DbControl();
        public int create(Students obj)
        {
            var output = 0;
            output = sql.Insert("tbl_students", new {
                firstName = obj.firstName,
                lastName = obj.lastName,
                email = obj.email,
                phone = obj.phone,
                birthDate = obj.birthDate,
                gender = obj.gender
            });
            return output;
        }

        public void delete(int Id)
        {
            sql.Query("DELETE FROM tbl_students WHERE Id = @Id", new {
                Id = Id
            });

        }

        public Students find(int Id)
        {
            return sql.QuerySingle<Students>("SELECT * FROM tbl_students WHERE Id = @Id", new
            {
                Id = Id
            });
        }

        public List<Students> getAll()
        {
            return sql.Query<Students>("SELECT * FROM tbl_students");
        }

        public int update(Students obj)
        {
            var output = 0;
            output = sql.Update("tbl_students", new { Id = obj.Id}, new
            {
                firstName = obj.firstName,
                lastName = obj.lastName,
                email = obj.email,
                phone = obj.phone,
                birthDate = obj.birthDate,
                gender = obj.gender
            });
            return output;
        }

        public List<SelectListItem> GenderOption()
        {
            var genderOptions = new List<SelectListItem>();
            genderOptions.Add(new SelectListItem { Text = "Male", Value = "Male" });
            genderOptions.Add(new SelectListItem { Text = "Female", Value = "Female" });
            return genderOptions;
        }
    }
}