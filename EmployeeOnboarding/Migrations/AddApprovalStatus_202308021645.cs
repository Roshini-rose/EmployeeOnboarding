using FluentMigrator;

namespace EmployeeOnboarding.Migrations
{
    //[Migration(202308021645)]
    public class AddApprovalStatus_202308021645:Migration
    {
        public override void Down()
        {
            Delete.ForeignKey().FromTable("City").ForeignColumn("State_Id").ToTable("State").PrimaryColumn("Id");
            Delete.Table("City");
        }

        public override void Up()
        {
            Create.Table("ApprovalStatus").WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("EmpGen_Id").AsInt32().NotNullable().ForeignKey("EmployeeGeneralDetails", "Id")
                .WithColumn("City_Name").AsString(100).NotNullable()
                .WithColumn("Date_Created").AsDate().NotNullable()
                .WithColumn("Date_Modified").AsDate().NotNullable();
        }
    }
}
