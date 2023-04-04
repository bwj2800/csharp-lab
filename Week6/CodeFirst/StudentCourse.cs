using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using System.Diagnostics;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Migrations.Model;

namespace CodeFirst
{
    public class StudentCourse : EntityTypeConfiguration<Student>
    {
        public StudentCourse()
        {
            HasKey(s => s.StudentId);

            HasRequired(s => s.Course)
            .WithMany(c => c.Students)
            .HasForeignKey(s => s.RegisteredOn);

            //Ignore(s => s.Course);

        }
    }
}
