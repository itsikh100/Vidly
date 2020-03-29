namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'41e81bf6-4f37-4b01-975f-74da1273f8fa', N'guest@vidly.com', 0, N'AM+G0iCetsscuW2safj6WdQ55tld2rXG+gGV+Qpr4pSUcb+v9NqJ04LAt81i3S5wkQ==', N'35a1f9d9-7902-41c4-8584-8e8087f7191a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ec8d8313-1ed1-4823-a6f4-0aacfdff3234', N'admin@vidly.com', 0, N'ADvycr+VF70heRkCej8gU5F55QIxGdpZUJiQ8ToLfMqiwun+qGFuOngsyFI+34GAAA==', N'24282aed-44db-4826-858c-9240802e9410', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'87468d1a-5ccc-4da0-b315-0b79329f07b4', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ec8d8313-1ed1-4823-a6f4-0aacfdff3234', N'87468d1a-5ccc-4da0-b315-0b79329f07b4')
");
        }
        
        public override void Down()
        {
        }
    }
}
