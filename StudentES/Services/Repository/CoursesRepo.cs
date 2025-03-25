using StudentES.Data;
using StudentES.Models;
using StudentES.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentES.Services.Repository
{
    public class CoursesRepo: ICoursesRepo
    {
        DbControl sql = new DbControl();

        public int create(Courses obj)
        {
            var output = 0;
            output = sql.Insert("tbl_courses", new {
                name = obj.name,
                description = obj.description,
                credits = obj.credits
            });
            return output;
        }

        public List<Courses> getAll()
        {
            return sql.Query<Courses>("SELECT * FROM tbl_courses");
        }

        public int update(Courses obj)
        {
            var output = 0;
            output = sql.Update("tbl_courses", new { Id = obj.Id}, new
            {
                name = obj.name,
                description = obj.description,
                credits = obj.credits
            });
            return output;
        }

        public void delete(int Id)
        {
            sql.Query("DELETE FROM tbl_courses WHERE Id = @Id", new
            {
                Id = Id
            });
        }

        public Courses find(int Id)
        {
            return sql.QuerySingle<Courses>("SELECT * FROM tbl_courses WHERE Id = @Id", new
            {
                Id = Id
            });
        }
    }
}