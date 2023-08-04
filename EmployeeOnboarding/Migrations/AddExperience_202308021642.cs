using FluentMigrator;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Migrations
{
    [Migration(202308021642)]
    public class AddExperience_202308021642 : Migration
    {
        public override void Down()
        {
            Delete.ForeignKey().FromTable("EmployeeExperienceDetails").ForeignColumn("EmpGen_Id").ToTable("EmployeeGeneralDetails").PrimaryColumn("Id");
            Delete.Table("EmployeeExperienceDetails");
        }

        public override void Up()
        {
            Create.Table("EmployeeExperienceDetails").WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
               .WithColumn("EmpGen_Id").AsInt32().NotNullable().ForeignKey("EmployeeGeneralDetails", "Id")
               .WithColumn("Company_name").AsString(100).Nullable()
               .WithColumn("Designation").AsString(100).Nullable()
               .WithColumn("Reason").AsString(100).Nullable()
               .WithColumn("StartDate").AsDate().Nullable()
               .WithColumn("EndDate").AsDate().Nullable()
               .WithColumn("Exp_Certificate").AsString(100).Nullable()
               .WithColumn("Date_Created").AsDateTime().NotNullable()
               .WithColumn("Date_Modified").AsDateTime().NotNullable()
               .WithColumn("Created_by").AsString(100).NotNullable()
               .WithColumn("Modified_by").AsString(100).NotNullable()
               .WithColumn("Status").AsString(30).NotNullable();

        }
    }
}
