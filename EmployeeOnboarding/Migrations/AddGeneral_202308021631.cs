using EmployeeOnboarding.Data.Enum;
using FluentMigrator;
namespace EmployeeOnboarding.Migrations
{
    [Migration(202308021631)]
    public class AddGeneral_202308021631 : Migration
    {

        public override void Down()
        {
            Delete.ForeignKey().FromTable("EmployeeGeneralDetails").ForeignColumn("Login_ID").ToTable("Login").PrimaryColumn("Id");
            Delete.Table("EmployeeGeneralDetails");
        }

        public override void Up()
        {
            Create.Table("EmployeeGeneralDetails").WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
               .WithColumn("Login_ID").AsInt32().Nullable()
               .WithColumn("Empid").AsString().Nullable()
               .WithColumn("EmployeeName").AsString().NotNullable()
               .WithColumn("Official_EmailId").AsString().Nullable()
               .WithColumn("DOB").AsDate().NotNullable()
               .WithColumn(" FatherName").AsString().NotNullable()
               .WithColumn("Gender").AsInt64().NotNullable()
               .WithColumn("MaritalStatus").AsInt32().Nullable()
               .WithColumn("DateOfMarriage").AsDate().Nullable()
               .WithColumn("BloodGrp").AsString().NotNullable()

               .WithColumn("Date_Created").AsDate().NotNullable()
               .WithColumn("Date_Modified").AsDate().NotNullable()
               .WithColumn("Created_by").AsString().NotNullable()
               .WithColumn("Modified_by").AsString().NotNullable()
               .WithColumn("Status").AsString().NotNullable();

        }
    }
    
}
