using FluentMigrator;

namespace EmployeeOnboarding.Migrations
{
    //[Migration(202308021645)]
    public class AddApprovalStatus_202308021645:Migration
    {
        public override void Down()
        {
            Delete.ForeignKey().FromTable("ApprovalStatus").ForeignColumn("EmpGen_Id").ToTable("EmployeeGeneralDetails").PrimaryColumn("Id");
            Delete.Table("ApprovalStatus");
        }

        public override void Up()
        {
            Create.Table("ApprovalStatus")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("EmpGen_Id").AsInt32().NotNullable().ForeignKey("EmployeeGeneralDetails", "Id")
                .WithColumn("Current_Status").AsInt32().NotNullable()
                .WithColumn("Comments").AsString(150)
               .WithColumn("Date_Created").AsDate().NotNullable()
               .WithColumn("Date_Modified").AsDate()
               .WithColumn("Created_By").AsString(100).NotNullable()
               .WithColumn("Modified_By").AsString(100)
               .WithColumn("Status").AsBoolean().NotNullable();
        }
    }
}
