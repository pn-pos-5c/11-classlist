using ClasslistDb;
using System.Collections.Generic;
using System.Linq;

namespace Classlist.Services
{
    public class StudentsService
    {
        private readonly ClasslistContext db;

        public StudentsService(ClasslistContext db)
        {
            this.db = db;
        }

        public List<Student> GetStudentsForClazz(int clazzId)
        {
            return db.Students.Where(student => student.ClazzId == clazzId).ToList();
        }

        public Student SetAge(int studentId, int age)
        {
            var student = db.Students.FirstOrDefault(student => student.Id == studentId);
            if (student != null)
            {
                student.Age = age;
                db.SaveChanges();
            }

            return student;
        }

        public Student SetClazz(int studentId, int clazzId)
        {
            var student = db.Students.FirstOrDefault(student => student.Id == studentId);
            if (student != null)
            {
                student.ClazzId = clazzId;
                db.SaveChanges();
            }

            return student;
        }

        public Student SetRegistered(int studentId, bool registered)
        {
            var student = db.Students.FirstOrDefault(student => student.Id == studentId);
            if (student != null)
            {
                student.Registered = registered;
                db.SaveChanges();
            }

            return student;
        }
    }
}
