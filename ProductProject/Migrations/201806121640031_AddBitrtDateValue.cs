namespace ProductProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBitrtDateValue : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers SET Birthdate ='" + DateTime.Now +"' Where Id = 2");
            Sql("Update Customers SET Birthdate ='" + DateTime.Now + "' Where Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
