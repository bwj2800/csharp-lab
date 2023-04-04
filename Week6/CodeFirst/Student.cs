using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace CodeFirst
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public int RegisteredOn { get; set; }
        public virtual Course Course { get; set; }
        public DateTime Birthday { get; set; }
    }
}
