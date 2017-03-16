using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContoscoUniversity.Models
{
    public class Enrollment
    {
        public enum Grade
        {
            A,B,C,D,F
        }

        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade ? grade { get; set; }

        //Navigation Properties.

       //Basically when there is a one- many relationship or many to many relationship , use datatype 
        //ICollection for adding,deleting,updating entries in DB and 
        // Virtual keyword we basically use to u know use some EF features like Lazy loadin etc
        public virtual Course course { get; set; }
        public virtual Student student { get; set; }


    }
}