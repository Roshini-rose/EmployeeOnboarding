using FluentMigrator;

namespace EmployeeOnboarding.Migrations
{
    [Migration(202308021637)]
    public class AddExperience_202308021637 : Migration
    {
        public override void Down()
        {
            Delete.ForeignKey().FromTable("EmployeeEDetails").ForeignColumn("EmpGen_Id").ToTable("EmployeeGeneralDetails").PrimaryColumn("Id");
            Delete.Table("EmployeeEducationDetails");
        }

        public override void Up()
        {
            Create.Table("EmployeeEducationDetails").WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
               .WithColumn("EmpGen_Id").AsString(100).NotNullable()
               .WithColumn("programme").AsDate().NotNullable()
               .WithColumn("CollegeName").AsDate().NotNullable()
               .WithColumn("Degree").AsDate().NotNullable()
               .WithColumn("specialization").AsDate().NotNullable()
               .WithColumn("Passoutyear").AsDate().NotNullable()
               .WithColumn("Certificate").AsDate().NotNullable()
               .WithColumn("Date_Created").AsDate().NotNullable()
               .WithColumn("Date_Modified").AsDate().NotNullable()
               .WithColumn("Created_by").AsDate().NotNullable()
               .WithColumn("Modified_by").AsDate().NotNullable()
               .WithColumn("Status").AsDate().NotNullable();

        }
    }
}
