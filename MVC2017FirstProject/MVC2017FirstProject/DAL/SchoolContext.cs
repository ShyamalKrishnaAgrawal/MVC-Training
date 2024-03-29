﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MVC2017FirstProject.Models;

namespace MVC2017FirstProject.DAL
{
    public class SchoolContext: DbContext
    {
        public SchoolContext(): base("SchoolContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, MVC2017FirstProject.Migrations.Configuration>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}