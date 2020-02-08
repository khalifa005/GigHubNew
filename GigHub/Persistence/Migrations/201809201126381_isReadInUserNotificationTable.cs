namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isReadInUserNotificationTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserNotifications", "IsRead", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserNotifications", "IsRead");
        }
    }
}
