using FluentMigrator;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Migrations
{
    [Migration(202308021640)]
    public class AddAdditional_202308021640 : Migration
    {
        public override void Down()
        {
            Delete.ForeignKey().FromTable("EmployeeAdditionalInfo").ForeignColumn("EmpGen_Id").ToTable("EmployeeGeneralDetails").PrimaryColumn("Id");
            Delete.Table("EmployeeAdditionalInfo");
        }

        public override void Up()
        {
            Create.Table("EmployeeAdditionalInfo").WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
               .WithColumn("EmpGen_Id").AsInt32().NotNullable().ForeignKey("EmployeeGeneralDetails","Id")
               .WithColumn("Disability").AsBoolean().Nullable()
               .WithColumn("Disablility_type").AsString(100).Nullable()
               .WithColumn("Covid_VaccSts").AsString(100).NotNullable()
               .WithColumn("Vacc_Certificate").AsString(100).Nullable()
               .WithColumn("Date_Created").AsDateTime().NotNullable()
               .WithColumn("Date_Modified").AsDateTime().NotNullable()
               .WithColumn("Created_By").AsString(100).NotNullable()
               .WithColumn("Modified_By").AsString(100).NotNullable()
               .WithColumn("Status").AsString(30).NotNullable();

        }
    }
}
