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
               .WithColumn("Per_Address").AsString().NotNullable()
               .WithColumn("Per_Country_Id").AsInt32().NotNullable()
               .WithColumn("Per_State_Id").AsInt32().NotNullable()
               .WithColumn("Per_City_Id").AsInt32().NotNullable()
               .WithColumn("Per_Pincode").AsString().NotNullable()
               .WithColumn("Temp_Address").AsString().NotNullable()
               .WithColumn("Temp_Country_Id").AsInt32().NotNullable()
               .WithColumn("Temp_State_Id").AsInt32().NotNullable()
               .WithColumn("Temp_City_Id").AsInt32().NotNullable()
               .WithColumn("Temp_Pincode").AsString().NotNullable()
               .WithColumn("Date_Created").AsDateTime().Nullable()
               .WithColumn("Date_Modified").AsDateTime().NotNullable()
               .WithColumn("Created_by").AsString(100).NotNullable()
               .WithColumn("Modified_by").AsString(100).Nullable()
               .WithColumn("Status").AsString(30).NotNullable();
        }

    }
}

