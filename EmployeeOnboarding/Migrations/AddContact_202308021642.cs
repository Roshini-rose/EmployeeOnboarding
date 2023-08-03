using FluentMigrator;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Migrations
{

    [Migration(202308021642)]
    public class AddContact_202308021642 : Migration
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
               .WithColumn("Date_Created").AsDate().Nullable()
               .WithColumn("Date_Modified").AsDate().NotNullable()
               .WithColumn("Created_by").AsString().NotNullable()
               .WithColumn("Modified_by").AsString().Nullable()
               .WithColumn("Status").AsString().NotNullable();

        }
    }
}
 public int Id { get; set; }
[ForeignKey("EmpGen_Id")]
public int EmpGen_Id { get; set; }
public string Personal_Emailid { get; set; }
public double Contact_no { get; set; }
public string? Emgy_Contactperson { get; set; }
public int? Emgy_Contactrelation { get; set; }
public double? Emgy_Contactno { get; set; }
public DateTime Date_Created { get; set; }
public DateTime? Date_Modified { get; set; }
public string Created_by { get; set; }
public string? Modified_by { get; set; }
public string Status { get; set; }