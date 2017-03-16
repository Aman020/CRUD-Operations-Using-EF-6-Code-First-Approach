using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContoscoUniversity.Models;


namespace ContoscoUniversity.DAL
{
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {

            List<Student> stud = new List<Student>()
            {
                new Student{FirstMidName="ABC",LastName="XYZ",EnrollmentDate = new DateTime(2012,12,11) },
                new Student{FirstMidName="BSD",LastName="SDF",EnrollmentDate = new DateTime(2011,11,21) },
                new Student{FirstMidName="AMAS",LastName="ddf",EnrollmentDate = new DateTime(1992,10,12) },
                new Student{FirstMidName="HAGS",LastName="dfdf",EnrollmentDate = new DateTime(2000,2,19) },
                new Student{FirstMidName="AJHAhek",LastName="dfd",EnrollmentDate = new DateTime(2001,05,10) },
                new Student{FirstMidName="JHSD",LastName="Diewfwfxit",EnrollmentDate = new DateTime(2002,04,09) },
                new Student{FirstMidName="JAM",LastName="efe",EnrollmentDate = new DateTime(2003,03,30) },
                new Student{FirstMidName="MIKE",LastName="Basfjaj",EnrollmentDate = new DateTime(2004,02,10) },
                new Student{FirstMidName="HOOLA",LastName="efe",EnrollmentDate = new DateTime(2005,01,15) },
                new Student{FirstMidName="ROONY",LastName="MV",EnrollmentDate = new DateTime(2005,02,16) }
            };

            List<Course> course = new List<Course>()
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3,},
                new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
                new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
                new Course{CourseID=1045,Title="Calculus",Credits=4,},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
                new Course{CourseID=2021,Title="Composition",Credits=3,},
                new Course{CourseID=2042,Title="Literature",Credits=4,}
            };

            List<Enrollment> enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1050,grade= Enrollment.Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,grade=Enrollment.Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,grade=Enrollment.Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,grade=Enrollment.Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,grade=Enrollment.Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,grade=Enrollment.Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050,},
                new Enrollment{StudentID=4,CourseID=4022,grade=Enrollment.Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,grade=Enrollment.Grade.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,grade=Enrollment.Grade.A},
             };

            stud.ForEach(student => context.Students.Add(student));
            context.SaveChanges();
            course.ForEach(courseAvailable => context.Courses.Add(courseAvailable));
            context.SaveChanges();
            enrollments.ForEach(enroll => context.Enrollments.Add(enroll));
            context.SaveChanges();


        }

    }
}
