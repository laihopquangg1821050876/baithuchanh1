namespace LaiHopQuang_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lophoc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lophoc",
                c => new
                    {
                        Malop = c.Int(nullable: false, identity: true),
                        Tenlop = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Malop);
            
            CreateTable(
                "dbo.SinhVien",
                c => new
                    {
                        Masinhvien = c.Int(nullable: false, identity: true),
                        Hovaten = c.String(nullable: false, maxLength: 50),
                        Malop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Masinhvien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SinhVien");
            DropTable("dbo.Lophoc");
        }
    }
}
