namespace SistemaPedidosRestaurante.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Posicion = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        MenuId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pedido_PedidoId = c.Int(),
                    })
                .PrimaryKey(t => t.MenuId)
                .ForeignKey("dbo.Pedidoes", t => t.Pedido_PedidoId)
                .Index(t => t.Pedido_PedidoId);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        PedidoId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        FormaPago = c.String(),
                        Estado = c.String(),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Comentarios = c.String(),
                    })
                .PrimaryKey(t => t.PedidoId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Menus", "Pedido_PedidoId", "dbo.Pedidoes");
            DropForeignKey("dbo.Pedidoes", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Pedidoes", new[] { "ClienteId" });
            DropIndex("dbo.Menus", new[] { "Pedido_PedidoId" });
            DropTable("dbo.Pedidoes");
            DropTable("dbo.Menus");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Clientes");
        }
    }
}
