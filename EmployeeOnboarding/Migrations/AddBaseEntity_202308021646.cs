using FluentMigrator;

namespace EmployeeOnboarding.Migrations
{
    [Migration(202308021646)]
    public class AddBaseEntity_202308021646:Migration
    {
        public override void Down()
        {
            Delete.Table("BaseEntity");
        }
        public override void Up()
        {

            Create.Table("BaseEntity")
               .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
               .WithColumn("Date_Created").AsDate().NotNullable()
               .WithColumn("Date_Modified").AsDate()
               .WithColumn("Created_By").AsString(100).NotNullable()
               .WithColumn("Modified_By").AsString(100)
               .WithColumn("Status").AsBoolean().NotNullable();

        }
    }
}
