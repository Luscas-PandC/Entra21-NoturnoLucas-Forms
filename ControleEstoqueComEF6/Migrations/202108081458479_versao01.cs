namespace ControleEstoqueComEF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Categorias",
                c => new
                    {
                        IdCategoria = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.IdCategoria);
            
        }
        
        public override void Down()
        {
            DropTable("public.Categorias");
        }
    }
}
