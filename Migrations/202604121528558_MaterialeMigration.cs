namespace inventory_tool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaterialeMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.materiale",
                c => new
                    {
                        mat_id = c.Int(nullable: false, identity: true),
                        mat_descrizione = c.String(),
                        mat_quantita = c.Int(nullable: false),
                        mat_id_amministratore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.mat_id)
                .ForeignKey("dbo.amministratori", t => t.mat_id_amministratore, cascadeDelete: true)
                .Index(t => t.mat_id_amministratore);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.materiale", "mat_id_amministratore", "dbo.amministratori");
            DropIndex("dbo.materiale", new[] { "mat_id_amministratore" });
            DropTable("dbo.materiale");
        }
    }
}
