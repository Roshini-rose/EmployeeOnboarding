using FluentMigrator;

namespace EmployeeOnboarding.Migrations
{
    //[Migration(20230802100100)]
    public class AddCountry_20230802100100 : Migration
    {
        public override void Down()
        {
            Delete.Table("Country");
        }

        public override void Up()
        {
            Create.Table("EmployeeEducationDetails").WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
               .WithColumn("Country_Name").AsString(100).NotNullable()
               .WithColumn("Date_Created").AsDate().NotNullable()
               .WithColumn("Date_Modified").AsDate().NotNullable();
        }
    }
}
