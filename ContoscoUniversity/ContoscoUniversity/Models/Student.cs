using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContoscoUniversity.Models
{
    public class Student
    {

        public int Id { get; set; }

        [Column("Last Name")]
        public string LastName { get; set; }
        [Column("First Name")]
        public string FirstMidName { get; set; }
        [Column("Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        //Navigation Property. Basically when there is a one- many relationship or many to many relationship , use datatype 
        //ICollection for adding,deleting,updating entries in DB and 
        // Virtual keyword we basically use to u know use some EF features like Lazy loadin etc
        public virtual ICollection<Enrollment> Enrollments { get; set; }


    }
}