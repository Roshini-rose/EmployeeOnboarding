using FluentMigrator;

namespace EmployeeOnboarding.Migrations
{
    [Migration(202308021643)]
    public class AddApprovalStatus_202308021643:Migration
    {
        public override void Down()
        {
            Delete.ForeignKey().FromTable("Status").ForeignColumn("EmpGen_Id").ToTable("EmployeeGeneralDetails").PrimaryColumn("Id");
            Delete.ForeignKey().FromTable("Status").ForeignColumn("Login_Id").ToTable("Login").PrimaryColumn("Id");
            Delete.Table("ApprovalStatus");
        }

        public override void Up()
        {
            Create.Table("ApprovalStatus")
               .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
               .WithColumn("Login_Id").AsInt32().NotNullable().ForeignKey("Login","Id")
               .WithColumn("EmpGen_Id").AsInt32().NotNullable().ForeignKey("EmployeeGeneralDetails", "Id")
               .WithColumn("Current_Status").AsInt32().NotNullable()
               .WithColumn("Comments").AsString(150).Nullable()
               .WithColumn("Date_Created").AsDateTime().NotNullable()
               .WithColumn("Date_Modified").AsDateTime().Nullable()
               .WithColumn("Created_by").AsString(100).NotNullable()
               .WithColumn("Modified_by").AsString(100).Nullable()
               .WithColumn("Status").AsString(30).NotNullable();
        }
    }
}
