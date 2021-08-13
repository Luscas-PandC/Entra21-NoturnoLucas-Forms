namespace AcademiaEF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Pessoa",
                c => new
                    {
                        CPF = c.String(nullable: false, maxLength: 14),
                        Nome = c.String(maxLength: 100),
                        Telefone = c.String(maxLength: 15),
                        Turno = c.String(maxLength: 20),
                        SalarioHora = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Modalidade_IdModalidade = c.Int(),
                    })
                .PrimaryKey(t => t.CPF)
                .ForeignKey("public.Modalidade", t => t.Modalidade_IdModalidade)
                .Index(t => t.Modalidade_IdModalidade);
            
            CreateTable(
                "public.Modalidade",
                c => new
                    {
                        IdModalidade = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        VezesSemana = c.Int(nullable: false),
                        PrecoHora = c.Double(nullable: false),
                        Professor_CPF = c.String(maxLength: 14),
                    })
                .PrimaryKey(t => t.IdModalidade)
                .ForeignKey("public.Pessoa", t => t.Professor_CPF)
                .Index(t => t.Professor_CPF);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Pessoa", "Modalidade_IdModalidade", "public.Modalidade");
            DropForeignKey("public.Modalidade", "Professor_CPF", "public.Pessoa");
            DropIndex("public.Modalidade", new[] { "Professor_CPF" });
            DropIndex("public.Pessoa", new[] { "Modalidade_IdModalidade" });
            DropTable("public.Modalidade");
            DropTable("public.Pessoa");
        }
    }
}
