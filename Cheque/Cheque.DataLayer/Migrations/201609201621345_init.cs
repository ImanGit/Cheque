namespace Cheque.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CM_Banks",
                c => new
                    {
                        Bank_Id = c.Guid(nullable: false),
                        Bank_Title = c.String(),
                        Bank_CustomeCode = c.String(),
                        Bank_RowVersion = c.Binary(),
                        Bank_CreatedOn = c.DateTime(),
                        Bank_ModifiedOn = c.DateTime(),
                        Bank_CreatorIp = c.String(),
                        Bank_ModifierIp = c.String(),
                        Bank_ModifyLocked = c.Boolean(nullable: false),
                        Bank_IsDeleted = c.Boolean(nullable: false),
                        Bank_ModifierAgent = c.String(),
                        Bank_CreatorAgent = c.String(),
                        Bank_Version = c.Int(nullable: false),
                        Bank_Action = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Bank_Id);
            
            CreateTable(
                "dbo.CM_Cheques",
                c => new
                    {
                        Cheque_Id = c.Guid(nullable: false),
                        Cheque_BranchCode = c.Int(nullable: false),
                        Cheque_AccountNumber = c.String(),
                        Cheque_AccountOwner = c.String(),
                        Cheque_ReceivedOn = c.DateTime(nullable: false),
                        Cheque_CostValue = c.Int(nullable: false),
                        Cheque_CodeNumber = c.String(),
                        Cheque_SerialNumber = c.String(),
                        Cheque_CustomerName = c.String(),
                        Cheque_TrackingNumber = c.String(),
                        Cheque_AssignmentedOn = c.DateTime(nullable: false),
                        Cheque_AssignorName = c.String(),
                        Cheque_ReceiptedOn = c.DateTime(nullable: false),
                        Cheque_DeliveredOn = c.DateTime(nullable: false),
                        Cheque_ReturnedOn = c.DateTime(nullable: false),
                        Cheque_SettlementedOn = c.DateTime(nullable: false),
                        Cheque_SettlementDay = c.DateTime(nullable: false),
                        Cheque_SpentTo = c.String(),
                        Cheque_BankId = c.Guid(nullable: false),
                        Cheque_CityId = c.Guid(nullable: false),
                        Cheque_StatusId = c.Guid(nullable: false),
                        Cheque_RowVersion = c.Binary(),
                        Cheque_CreatedOn = c.DateTime(),
                        Cheque_ModifiedOn = c.DateTime(),
                        Cheque_CreatorIp = c.String(),
                        Cheque_ModifierIp = c.String(),
                        Cheque_ModifyLocked = c.Boolean(nullable: false),
                        Cheque_IsDeleted = c.Boolean(nullable: false),
                        Cheque_ModifierAgent = c.String(),
                        Cheque_CreatorAgent = c.String(),
                        Cheque_Version = c.Int(nullable: false),
                        Cheque_Action = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Cheque_Id)
                .ForeignKey("dbo.CM_Banks", t => t.Cheque_BankId, cascadeDelete: true)
                .ForeignKey("dbo.CM_Cities", t => t.Cheque_CityId, cascadeDelete: true)
                .ForeignKey("dbo.CM_Status", t => t.Cheque_StatusId, cascadeDelete: true)
                .Index(t => t.Cheque_BankId)
                .Index(t => t.Cheque_CityId)
                .Index(t => t.Cheque_StatusId);
            
            CreateTable(
                "dbo.CM_Cities",
                c => new
                    {
                        City_Id = c.Guid(nullable: false),
                        City_Title = c.String(),
                        City_CustomeCode = c.String(),
                        City_RowVersion = c.Binary(),
                        City_CreatedOn = c.DateTime(),
                        City_ModifiedOn = c.DateTime(),
                        City_CreatorIp = c.String(),
                        City_ModifierIp = c.String(),
                        City_ModifyLocked = c.Boolean(nullable: false),
                        City_IsDeleted = c.Boolean(nullable: false),
                        City_ModifierAgent = c.String(),
                        City_CreatorAgent = c.String(),
                        City_Version = c.Int(nullable: false),
                        City_Action = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.City_Id);
            
            CreateTable(
                "dbo.CM_Status",
                c => new
                    {
                        Status_Id = c.Guid(nullable: false),
                        Status_Title = c.String(),
                        Status_CustomCode = c.String(),
                        Status_RowVersion = c.Binary(),
                        Status_CreatedOn = c.DateTime(),
                        Status_ModifiedOn = c.DateTime(),
                        Status_CreatorIp = c.String(),
                        Status_ModifierIp = c.String(),
                        Status_ModifyLocked = c.Boolean(nullable: false),
                        Status_IsDeleted = c.Boolean(nullable: false),
                        Status_ModifierAgent = c.String(),
                        Status_CreatorAgent = c.String(),
                        Status_Version = c.Int(nullable: false),
                        Status_Action = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Status_Id);
            
        }
        public override void Down()
        {
            DropForeignKey("dbo.CM_Cheques", "Cheque_StatusId", "dbo.CM_Status");
            DropForeignKey("dbo.CM_Cheques", "Cheque_CityId", "dbo.CM_Cities");
            DropForeignKey("dbo.CM_Cheques", "Cheque_BankId", "dbo.CM_Banks");
            DropIndex("dbo.CM_Cheques", new[] { "Cheque_StatusId" });
            DropIndex("dbo.CM_Cheques", new[] { "Cheque_CityId" });
            DropIndex("dbo.CM_Cheques", new[] { "Cheque_BankId" });
            DropTable("dbo.CM_Status");
            DropTable("dbo.CM_Cities");
            DropTable("dbo.CM_Cheques");
            DropTable("dbo.CM_Banks");
        }
    }
}
