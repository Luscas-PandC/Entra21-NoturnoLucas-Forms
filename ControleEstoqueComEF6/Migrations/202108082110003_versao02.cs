namespace ControleEstoqueComEF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao02 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Produtoes",
                c => new
                    {
                        IdProduto = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Estoque = c.Int(nullable: false),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.IdProduto);
            
        }
        
        public override void Down()
        {
            DropTable("public.Produtoes");
        }
    }
}
