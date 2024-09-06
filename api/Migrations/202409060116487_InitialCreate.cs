namespace api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advogadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Senioridade = c.Int(nullable: false),
                        Logradouro = c.String(),
                        Bairro = c.String(),
                        Estado = c.String(),
                        CEP = c.String(),
                        Numero = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Advogadoes");
        }
    }
}
