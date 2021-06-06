namespace NguyenThanhCong_03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 20, unicode: false),
                        HoTen = c.String(),
                        MaPhongBan = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNhanVien)
                .ForeignKey("dbo.PhongBans", t => t.MaPhongBan, cascadeDelete: true)
                .Index(t => t.MaPhongBan);
            
            CreateTable(
                "dbo.PhongBans",
                c => new
                    {
                        MaPhongBan = c.Int(nullable: false, identity: true),
                        TenPhongBan = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaPhongBan);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanViens", "MaPhongBan", "dbo.PhongBans");
            DropIndex("dbo.NhanViens", new[] { "MaPhongBan" });
            DropTable("dbo.PhongBans");
            DropTable("dbo.NhanViens");
        }
    }
}
