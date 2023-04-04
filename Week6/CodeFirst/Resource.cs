using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string ResourceType { get; set; }

        public int CourseId { get; set; }
    }
}
