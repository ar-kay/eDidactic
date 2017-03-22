﻿using System.Data.Entity;
using eDidactic.Domain.Entities;

namespace eDidactic.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
    }
}