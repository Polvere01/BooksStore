namespace BooksStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Livros", "Categorias_Id", "dbo.Categorias");
            DropForeignKey("dbo.LivrosAutores", "Autores_Id", "dbo.Autores");
            DropForeignKey("dbo.LivrosAutores", "Livros_Id", "dbo.Livros");
            DropIndex("dbo.Livros", new[] { "Categorias_Id" });
            DropIndex("dbo.LivrosAutores", new[] { "Autores_Id" });
            DropIndex("dbo.LivrosAutores", new[] { "Livros_Id" });
            CreateTable(
                "dbo.Autor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                        ISBN = c.String(nullable: false, maxLength: 30),
                        Datalancamento = c.DateTime(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categoria", t => t.CategoriaId, cascadeDelete: true)
                .Index(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LivroAutor",
                c => new
                    {
                        Autor_Id = c.Int(nullable: false),
                        Livro_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Autor_Id, t.Livro_Id })
                .ForeignKey("dbo.Autor", t => t.Autor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Livro", t => t.Livro_Id, cascadeDelete: true)
                .Index(t => t.Autor_Id)
                .Index(t => t.Livro_Id);
            
            DropTable("dbo.Autores");
            DropTable("dbo.Livros");
            DropTable("dbo.Categorias");
            DropTable("dbo.LivrosAutores");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LivrosAutores",
                c => new
                    {
                        Autores_Id = c.Int(nullable: false),
                        Livros_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Autores_Id, t.Livros_Id });
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                        ISBN = c.String(nullable: false, maxLength: 30),
                        Datalancamento = c.DateTime(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                        Categorias_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Autores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.LivroAutor", "Livro_Id", "dbo.Livro");
            DropForeignKey("dbo.LivroAutor", "Autor_Id", "dbo.Autor");
            DropForeignKey("dbo.Livro", "CategoriaId", "dbo.Categoria");
            DropIndex("dbo.LivroAutor", new[] { "Livro_Id" });
            DropIndex("dbo.LivroAutor", new[] { "Autor_Id" });
            DropIndex("dbo.Livro", new[] { "CategoriaId" });
            DropTable("dbo.LivroAutor");
            DropTable("dbo.Categoria");
            DropTable("dbo.Livro");
            DropTable("dbo.Autor");
            CreateIndex("dbo.LivrosAutores", "Livros_Id");
            CreateIndex("dbo.LivrosAutores", "Autores_Id");
            CreateIndex("dbo.Livros", "Categorias_Id");
            AddForeignKey("dbo.LivrosAutores", "Livros_Id", "dbo.Livros", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LivrosAutores", "Autores_Id", "dbo.Autores", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Livros", "Categorias_Id", "dbo.Categorias", "Id", cascadeDelete: true);
        }
    }
}
