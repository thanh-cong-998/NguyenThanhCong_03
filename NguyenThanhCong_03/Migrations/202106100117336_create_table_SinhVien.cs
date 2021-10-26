namespace NguyenThanhCong_03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_SinhVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MSV = c.String(nullable: false, maxLength: 128),
                        TenSV = c.String(),
                        NS = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MSV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SinhViens");
        }
    }
}
