using System.ComponentModel.DataAnnotations.Schema;
using FluentMigrator;

namespace EmployeeOnboarding.Migrations
{
    [Migration(202308021639)]
    public class AddAddress_202308021639 : Migration
    {

        public override void Down()
        {
            Delete.ForeignKey().FromTable("EmployeeAddressDetails").ForeignColumn("EmpGen_Id").ToTable("EmployeeGeneralDetails").PrimaryColumn("Id");
            Delete.Table("EmployeeAddressDetails");
        }

        public override void Up()
        {
            Create.Table("EmployeeAddressDetails").WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
               .WithColumn("EmpGen_Id").AsInt32().NotNullable().ForeignKey("EmployeeGeneralDetails","Id")
               .WithColumn("Address_Type").AsString().NotNullable()
               .WithColumn("Address").AsString().NotNullable()
               .WithColumn("Country_Id").AsInt32().NotNullable()
               .WithColumn("State_Id").AsInt32().NotNullable()
               .WithColumn("City_Id").AsInt32().NotNullable()
               .WithColumn("Pincode").AsString().NotNullable()
               .WithColumn("Date_Created").AsDateTime().Nullable()
               .WithColumn("Date_Modified").AsDateTime().NotNullable()
               .WithColumn("Created_by").AsString(100).NotNullable()
               .WithColumn("Modified_by").AsString(100).Nullable()
               .WithColumn("Status").AsString(30).NotNullable();
        }

    }
}

