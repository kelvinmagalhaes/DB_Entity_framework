using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace BD
{
    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BD.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Student> Students { get; set; }
         public virtual DbSet<Course> Courses { get; set; }
    }

    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}