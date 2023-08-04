﻿using FluentMigrator;

namespace EmployeeOnboarding.Migrations
{
    [Migration(202308021630)]
    public class AddLogin_202308021630: Migration
    {
        public override void Down()
        {
            Delete.Table("Login");
        }
        public override void Up()
        {

            Create.Table("Login")
               .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
               .WithColumn("Name").AsString(100).NotNullable()
               .WithColumn("EmailId").AsString(100).NotNullable()
               .WithColumn("Password").AsString(50)
               .WithColumn("Date_Created").AsDate().NotNullable()
               .WithColumn("Date_Modified").AsDate()
               .WithColumn("Created_By").AsString(100).NotNullable()
               .WithColumn("Modified_By").AsString(100)
               .WithColumn("Status").AsString(30).NotNullable();

        }
    }
}
