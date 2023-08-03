using FluentMigrator;

namespace EmployeeOnboarding.Migrations
{
    [Migration(202308021638)]
    public class AddCitySeeding_202308021638 : Migration
    {
        public override void Down()
        {
            Delete.FromTable("State").Row(new { State_Id = 23 });
        }

        public override void Up()
        {
            Insert.IntoTable("City").Row(new { Id = "1", City_Name = ("Alandur"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "2", City_Name = ("Ambattur"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "3", City_Name = ("Ambur"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "4", City_Name = ("Avadi"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "5", City_Name = ("Chennai"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "6", City_Name = ("Coimbatore"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "7", City_Name = ("Cuddalore"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "8", City_Name = ("Dindigul"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "9", City_Name = ("Erode"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "10", City_Name = ("Hosur"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "11", City_Name = ("Kancheepuram"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "12", City_Name = ("Karaikkudi"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "13", City_Name = ("Kumbakonam"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "14", City_Name = ("Kurichi"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "15", City_Name = ("Madavaram"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "16", City_Name = ("Madurai"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "17", City_Name = ("Nagapattinam"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "18", City_Name = ("Nagercoil"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "19", City_Name = ("Neyveli"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "20", City_Name = ("Pallavaram"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "21", City_Name = ("Pudukkottai"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "22", City_Name = ("Rajapalayam"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "23", City_Name = ("Salem"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "24", City_Name = ("Tambaram"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "25", City_Name = ("Thanjavur"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "26", City_Name = ("Thoothukkudi"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "27", City_Name = ("Tiruchirappalli"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "28", City_Name = ("Tirunelveli"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "29", City_Name = ("Tiruppur"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "30", City_Name = ("Tiruvannamalai"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "31", City_Name = ("Tiruvottiyur"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
            Insert.IntoTable("City").Row(new { Id = "32", City_Name = ("Vellore"), Date_Created = (DateTime.UtcNow), Date_Modified = (DateTime.UtcNow), State_Id = ("23") });
        }
    }
}
