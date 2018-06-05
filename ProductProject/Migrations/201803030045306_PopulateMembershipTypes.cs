namespace ProductProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MemberShipTypes(Id,  SignUpFee , DurationInMonths, DiscountRate) VALUES(1,'Eddie',0,0,0)");
            Sql("Insert into MemberShipTypes(Id,  SignUpFee , DurationInMonths, DiscountRate) VALUES(2,'Carl',30,1,10)");
            Sql("Insert into MemberShipTypes(Id,  SignUpFee , DurationInMonths, DiscountRate) VALUES(3,'John',90,3,15)");
            Sql("Insert into MemberShipTypes(Id,  SignUpFee , DurationInMonths, DiscountRate) VALUES(4,'Sweet',300,4,20)");
        }
        
        public override void Down()
        {
        }
    }
}
