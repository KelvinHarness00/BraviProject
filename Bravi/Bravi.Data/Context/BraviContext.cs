﻿using Bravi.Data.Mappings;
using Bravi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;
using Bravi.Data.Context.Extensions;

namespace Bravi.Data.Context
{
    public class BraviContext : DbContext 
    {
        public BraviContext(DbContextOptions<BraviContext> option)
            :base(option) { }

        #region DBSet
        public DbSet<User> Users { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
