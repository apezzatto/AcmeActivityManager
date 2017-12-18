using AcmeActivityManager.Domain;
using Events.IO.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcmeActivityManager.Infra.Data.Mapping
{
    public class SignUpMapping : EntityTypeConfiguration<SignUp>
    {
        public override void Map(EntityTypeBuilder<SignUp> builder)
        {
            builder.Entity<SignUpViewModel>()
                .ToTable("Activity");
        }
    }
}
