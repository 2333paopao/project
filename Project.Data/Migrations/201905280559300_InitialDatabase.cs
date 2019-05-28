namespace Project.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(nullable: false, maxLength: 200),
                        IsActive = c.Boolean(nullable: false),
                        PasswordHash = c.String(nullable: false, maxLength: 200),
                        Name = c.String(),
                        LastLoginDate = c.DateTime(),
                        AuthenticationToken = c.String(),
                        AuthenticationTokenValidTo = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
        }
    }
}
