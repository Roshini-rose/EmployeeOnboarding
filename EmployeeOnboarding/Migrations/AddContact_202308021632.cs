using FluentMigrator;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Migrations
{

    [Migration(202308021632)]
    public class AddContact_202308021632 : Migration
    {

        public override void Down()
        {
            Delete.ForeignKey().FromTable("EmployeeContactDetails").ForeignColumn("EmpGen_Id").ToTable("EmployeeGeneralDetails").PrimaryColumn("Id");
            Delete.Table("EmployeeContactDetails");
        }

        public override void Up()
        {
            Create.Table("EmployeeContactDetails").WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
               .WithColumn("EmpGen_Id").AsInt32().NotNullable()
               .WithColumn("Personal_Emailid").AsString().NotNullable()
               .WithColumn("Contact_no").AsDouble().NotNullable()
               .WithColumn("Emgy_Contactperson").AsString().Nullable()
               .WithColumn("Emgy_Contactrelation").AsInt32().Nullable()
               .WithColumn("Emgy_Contactno").AsDouble().Nullable()
               .WithColumn("Date_Created").AsDate().NotNullable()
               .WithColumn("Date_Modified").AsDate().NotNullable()
               .WithColumn("Created_by").AsString().NotNullable()
               .WithColumn("Modified_by").AsString().NotNullable()
               .WithColumn("Status").AsString().NotNullable();

        }
    }
}
