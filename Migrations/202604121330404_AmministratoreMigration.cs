namespace inventory_tool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmministratoreMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.amministratori",
                c => new
                    {
                        amm_id = c.Int(nullable: false, identity: true),
                        amm_nome = c.String(),
                        amm_cognome = c.String(),
                        amm_username = c.String(),
                        amm_password = c.String(),
                    })
                .PrimaryKey(t => t.amm_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.amministratori");
        }
    }
}
