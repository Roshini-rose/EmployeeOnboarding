﻿using FluentMigrator;
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
               .WithColumn("EmpGen_Id").AsInt32().NotNullable().ForeignKey("EmployeeGeneralDetails","Id")
               .WithColumn("Personal_Emailid").AsString().NotNullable()
               .WithColumn("Contact_no").AsDouble().NotNullable()
               .WithColumn("Emgy_Contactperson").AsString().Nullable()
               .WithColumn("Emgy_Contactrelation").AsInt32().Nullable()
               .WithColumn("Emgy_Contactno").AsDouble().Nullable()
               .WithColumn("Date_Created").AsDateTime().NotNullable()
               .WithColumn("Date_Modified").AsDateTime().NotNullable()
               .WithColumn("Created_by").AsString(100).NotNullable()
               .WithColumn("Modified_by").AsString(100).NotNullable()
               .WithColumn("Status").AsString(30).NotNullable();

        }
    }
}