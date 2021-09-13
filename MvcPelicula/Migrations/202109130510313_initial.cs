namespace MvcPelicula.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Peliculas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(maxLength: 60),
                        FechaLanzamiento = c.DateTime(nullable: false),
                        Genero = c.String(nullable: false, maxLength: 30),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Calificacion = c.String(maxLength: 5),
                        Productor = c.String(maxLength: 60),
                        DirectorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Directors", t => t.DirectorId, cascadeDelete: true)
                .Index(t => t.DirectorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Peliculas", "DirectorId", "dbo.Directors");
            DropIndex("dbo.Peliculas", new[] { "DirectorId" });
            DropTable("dbo.Peliculas");
            DropTable("dbo.Directors");
        }
    }
}
