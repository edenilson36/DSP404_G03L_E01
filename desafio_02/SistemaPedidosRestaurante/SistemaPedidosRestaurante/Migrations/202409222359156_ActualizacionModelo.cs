namespace SistemaPedidosRestaurante.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActualizacionModelo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleadoes", "Puesto", c => c.String());
            AddColumn("dbo.Pedidoes", "EmpleadoId", c => c.Int());
            AddColumn("dbo.Pedidoes", "FechaPedido", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Pedidoes", "EmpleadoId");
            AddForeignKey("dbo.Pedidoes", "EmpleadoId", "dbo.Empleadoes", "EmpleadoId");
            DropColumn("dbo.Empleadoes", "Posicion");
            DropColumn("dbo.Empleadoes", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empleadoes", "Email", c => c.String());
            AddColumn("dbo.Empleadoes", "Posicion", c => c.String());
            DropForeignKey("dbo.Pedidoes", "EmpleadoId", "dbo.Empleadoes");
            DropIndex("dbo.Pedidoes", new[] { "EmpleadoId" });
            DropColumn("dbo.Pedidoes", "FechaPedido");
            DropColumn("dbo.Pedidoes", "EmpleadoId");
            DropColumn("dbo.Empleadoes", "Puesto");
        }
    }
}
