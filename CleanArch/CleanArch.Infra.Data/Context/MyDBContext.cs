using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Models;

namespace CleanArch.Infra.Data.Context
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions options):base(options)
        {               
        }

        public DbSet<Course> courses { get; set; }
    }
}
