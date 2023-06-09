﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLeasing.Common;
using MyLeasing.Web.Data.Entities;
using System.Data.Common;

namespace MyLeasing.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Owner> Owners { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}

