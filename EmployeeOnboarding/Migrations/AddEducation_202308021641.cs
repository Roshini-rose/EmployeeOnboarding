using FluentMigrator;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Migrations
{
    [Migration(202308021641)]
    public class AddEducation_202308021641 : Migration
    {
        public override void Down()
        {
            Delete.ForeignKey().FromTable("EmployeeEducationDetails").ForeignColumn("EmpGen_Id").ToTable("EmployeeGeneralDetails").PrimaryColumn("Id");
            Delete.Table("EmployeeEducationDetails");
        }

        public override void Up()
        {
            Create.Table("EmployeeEducationDetails").WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()

               .WithColumn("EmpGen_Id").AsInt32().NotNullable()
               .WithColumn("programme").AsString(100).NotNullable()
               .WithColumn("CollegeName").AsString(100).NotNullable()
               .WithColumn("Degree").AsString(100).NotNullable()
               .WithColumn("specialization").AsString(100).NotNullable()
               .WithColumn("Passoutyear").AsInt32().NotNullable()
               .WithColumn("Certificate").AsString(100).NotNullable()

               .WithColumn("Date_Created").AsDate().NotNullable()
               .WithColumn("Date_Modified").AsDate()
               .WithColumn("Created_By").AsString(100).NotNullable()
               .WithColumn("Modified_By").AsString(100)
               .WithColumn("Status").AsString(100).NotNullable();

        }
    }
}
