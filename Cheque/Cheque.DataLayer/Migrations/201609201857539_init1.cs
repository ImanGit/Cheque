namespace Cheque.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CM_Banks", "Bank_CreatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CM_Cheques", "Cheque_CreatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CM_Cities", "City_CreatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CM_Status", "Status_CreatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CM_Status", "Status_CreatedOn", c => c.DateTime());
            AlterColumn("dbo.CM_Cities", "City_CreatedOn", c => c.DateTime());
            AlterColumn("dbo.CM_Cheques", "Cheque_CreatedOn", c => c.DateTime());
            AlterColumn("dbo.CM_Banks", "Bank_CreatedOn", c => c.DateTime());
        }
    }
}
