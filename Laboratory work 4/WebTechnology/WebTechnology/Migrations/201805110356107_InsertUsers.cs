namespace WebTechnology.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertUsers : DbMigration
    {
        public override void Up()
        {


            Sql(@"


INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b450802e-c439-4d47-9ddc-ea08151b7595', N'Vlad#121abC@gmail.com', 0, N'AEJKA5lEkdgC4FZSqBncpQHR/xzq5hnmJYdyfOzGIA+Q2AunsGhpuriIo4Vs5Q0aXA==', N'64581546-becc-4d4e-b53e-e6e6372eff3f', NULL, 0, 0, NULL, 1, 0, N'Vlad#121abC@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f2b44727-00c3-4209-ab33-85db06140ac5', N'Denis#123abC@gmail.com', 0, N'AKVX/NK3uiY4E7BK1VVXVGyW7LpWySp5T7MfAaD60NBaayc2/lFKNvaZ+CNtl3pgqQ==', N'd3a49d0c-a1e8-4097-aa6f-75c79dd82944', NULL, 0, 0, NULL, 1, 0, N'Denis#123abC@gmail.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c8b1255e-82d0-4213-ad2b-f392ded00824', N'Admin')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b450802e-c439-4d47-9ddc-ea08151b7595', N'c8b1255e-82d0-4213-ad2b-f392ded00824')

");


        }
        
        public override void Down()
        {
        }
    }
}
