using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{
    public class Homework
    {
        [Key]
        public int HomeworkId { get; set; }

        public string Content { get; set; }

        public string ContentType { get; set; }

        public DateTime SubmissionTime { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }
    }
}
