using System;
using System.Data.Entity.Migrations;
using System.Linq;
using Project.Entities;
using Project.Entities.Enums;

namespace Project.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //用户
            if (!context.Users.Any(x => x.Email == "admin@account.com"))
            {
                var user = User.Create("Admin", "Password1", "admin@account.com",
                    UserStatus.Enable);
                user.ForceId(new Guid("0882ef4c-9367-4781-a686-7a0d40b32ac2"));
                context.Users.AddOrUpdate(user);
            }
        }
    }
}
