using System.ComponentModel.DataAnnotations.Schema;
using FluentMigrator;

namespace EmployeeOnboarding.Migrations
{
    [Migration(202308021641)]
    public class AddAddress_202308021641 : Migration
    {

        public override void Down()
        {
            Delete.ForeignKey().FromTable("EmployeeAddressDetails").ForeignColumn("EmpGen_Id").ToTable("EmployeeGeneralDetails").PrimaryColumn("Id");
            Delete.Table("EmployeeAddressDetails");
        }

        public override void Up()
        {
            Create.Table("EmployeeAddressDetails").WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
               .WithColumn("EmpGen_Id").AsInt32().NotNullable()
               .WithColumn("Address_Type").AsString().NotNullable()
               .WithColumn("Address").AsString().NotNullable()
               .WithColumn("Country_Id").AsInt32().NotNullable()
               .WithColumn("State_Id").AsInt32().NotNullable()
               .WithColumn("City_Id").AsInt32().NotNullable()
                .WithColumn("Pincode").AsString().NotNullable()

               .WithColumn("Date_Created").AsDate().Nullable()
               .WithColumn("Date_Modified").AsDate().NotNullable()
               .WithColumn("Created_by").AsString().NotNullable()
               .WithColumn("Modified_by").AsString().Nullable()
               .WithColumn("Status").AsString().NotNullable();
        }

    }
}

