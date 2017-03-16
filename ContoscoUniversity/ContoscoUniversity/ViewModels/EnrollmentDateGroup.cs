using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ContoscoUniversity.ViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.DateTime)]
        public DateTime ? EnrollmentDate { get; set; }
        public int StudentCount { get; set; }
         
    }
}