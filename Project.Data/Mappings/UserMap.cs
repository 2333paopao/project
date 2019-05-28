using System.Data.Entity.ModelConfiguration;
using Project.Entities;

namespace Project.Data.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.PasswordHash)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("User");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.PasswordHash).HasColumnName("PasswordHash");
            Property(t => t.LastLoginDate).HasColumnName("LastLoginDate");
            Property(t => t.AuthenticationToken).HasColumnName("AuthenticationToken");
            Property(t => t.AuthenticationTokenValidTo).HasColumnName("AuthenticationTokenValidTo");

        }
    }
}
