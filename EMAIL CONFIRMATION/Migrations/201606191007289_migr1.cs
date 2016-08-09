namespace EMAIL_CONFIRMATION.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StanNaprawies",
                c => new
                    {
                        stanNaprawyId = c.Int(nullable: false, identity: true),
                        stanNaprawyName = c.String(),
                    })
                .PrimaryKey(t => t.stanNaprawyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StanNaprawies");
        }
    }
}
