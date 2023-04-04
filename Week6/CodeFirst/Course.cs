using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string Name { get; set; }

        public string description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public float Price { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}