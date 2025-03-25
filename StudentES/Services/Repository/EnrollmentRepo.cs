using StudentES.Data;
using StudentES.Models;
using StudentES.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentES.Services.Repository
{
    public class EnrollmentRepo:IEnrollmentRepo
    {
        DbControl sql = new DbControl();

        public List<Enrollment> getAll()
        {
            return sql.Query<Enrollment>("SELECT * FROM vw_enrollment");
        }

        public int create(Enrollment obj)
        {
            var output = 0;
            output = sql.Insert("tbl_enrollment", new
            {
                studentId = obj.studentId,
                courseId = obj.courseId,
                enrollDate = obj.enrollDate,
                status = obj.status

            });
            return output;
        }

        public int update(Enrollment obj)
        {
            var output = 0;
            output = sql.Update("tbl_enrollment", new { Id = obj.Id}, new
            {
                studentId = obj.studentId,
                courseId = obj.courseId,
                enrollDate = obj.enrollDate,
                status = obj.status

            });
            return output;
        }

        public void delete(int Id)
        {
            sql.Query("DELETE FROM tbl_enrollment WHERE Id = @Id", new
            {
                Id = Id
            });
        }

        public Enrollment find(int Id)
        {
            return sql.QuerySingle<Enrollment>("SELECT * FROM tbl_enrollment WHERE Id = @Id", new
            {
                Id = Id
            });
        }

    }
}