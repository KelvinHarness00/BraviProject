using Bravi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravi.Data.Context.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                new User { Id = Guid.Parse("a379c950-a74a-425c-a78c-ffd1f73dce03"), Name = "User Default", Email = "userdefault@bravi.com", Telefone = "81999999999" });
            return builder;
        }
    }
}
