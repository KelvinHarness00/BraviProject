using Bravi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravi.Data.Mappings
{
    public class UserMap :IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
                {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);

            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50);

            builder.Property(x => x.Telefone).IsRequired();
            builder.Property(x => x.Telefone).HasMaxLength(11);
        }
    }
}
