using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace FIT5032_Code_First.Models
{
    public class FIT5032_code_first_Model : DbContext
    {
        // Your context has been configured to use a 'FIT5032_code_first_Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'FIT5032_Code_First.Models.FIT5032_code_first_Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'FIT5032_code_first_Model' 
        // connection string in the application configuration file.
        public FIT5032_code_first_Model()
            : base("name=FIT5032_code_first_Model")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        // The generated DB name is Singular (Student instead of Students)
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    public class Student
    {
        public int ID { get; set; }// ID can be 'ID' or 'Class name + ID' as PK
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

    }

    public class Course
    {
        /*
         * None = no generate ID
         * Identity = when a row inserted, self increased
         * Computed = when a row inserted or updated,
         *      this generated from other column
         *      
         * Why set this is beacause we want to set 5042 instead of 1,2,3
        */
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}