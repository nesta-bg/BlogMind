using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogMind.Migrations
{
    public partial class SeedVotesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Protesters%') ,'4f841339-9e98-4a63-9729-99d8f8eue202', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Protesters%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Protesters%') ,'4u871339-0e98-4k63-9929-99d8f0eue202', '-1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Protesters%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4', '1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Moscow%') ,'4f841339-9e98-4a63-9729-99d8f8eue202', '-1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Moscow%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '-1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Moscow%') ,'4u871339-0e98-4k63-9929-99d8f0eue202', '-1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Twitter%') ,'4f847339-9e68-4o73-9429-97d8f1eue707', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Twitter%') ,'4u871339-0e98-4k63-9929-99d8f0eue202', '-1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Facebook%') ,'4f847339-9e68-4o73-9429-97d8f1eue707', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Facebook%') ,'4u871339-0e98-4k63-9929-99d8f0eue202', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Facebook%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Trading%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Trump%') ,'4f841339-9e98-4a63-9729-99d8f8eue202', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Trump%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Trump%') ,'4u871339-0e98-4k63-9929-99d8f0eue202', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Trump%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Trump%') ,'qd525gr2-gt26-1gt8-hm6t-737er7g6o8j6', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Trump%') ,'xs545ge2-et79-3st5-yv6t-247er7g9d6e9', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Trump%') ,'rf547ge3-wt75-4sw5-bv6r-647er7f9d7e5', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Trump%') ,'2f347539-6e63-4o53-4469-57d8g1eue608', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Trump%') ,'4f847339-9e68-4o73-9429-97d8f1eue707', '1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Thousands%') ,'4f841339-9e98-4a63-9729-99d8f8eue202', '-1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Thousands%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Thousands%') ,'4u871339-0e98-4k63-9929-99d8f0eue202', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Thousands%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4', '1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Uber%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '-1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Video streaming:%') ,'4f841339-9e98-4a63-9729-99d8f8eue202', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Video streaming:%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Video streaming:%') ,'4u871339-0e98-4k63-9929-99d8f0eue202', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Video streaming:%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Video streaming:%') ,'4f847339-9e68-4o73-9429-97d8f1eue707', '1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Huawei%') ,'4f847339-9e68-4o73-9429-97d8f1eue707', '-1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Huawei%') ,'4u871339-0e98-4k63-9929-99d8f0eue202', '-1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Zipline%') ,'4f847339-9e68-4o73-9429-97d8f1eue707', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Zipline%') ,'4u871339-0e98-4k63-9929-99d8f0eue202', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Zipline%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'World%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Rainfall %') ,'4f841339-9e98-4a63-9729-99d8f8eue202', '-1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Rainfall %') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '-1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Rainfall %') ,'4u871339-0e98-4k63-9929-99d8f0eue202', '-1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Rainfall %') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4', '-1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Isle%') ,'4f841339-9e98-4a63-9729-99d8f8eue202', '-1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Isle%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Isle%') ,'4u871339-0e98-4k63-9929-99d8f0eue202', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Isle%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4', '1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Biggest%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '-1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'New%') ,'4f841339-9e98-4a63-9729-99d8f8eue202', '-1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'New%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '-1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'New%') ,'4u871339-0e98-4k63-9929-99d8f0eue202', '-1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Nasa%') ,'4f841339-9e98-4a63-9729-99d8f8eue202', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Nasa%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Nasa%') ,'4u871339-0e98-4k63-9929-99d8f0eue202', '-1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Nasa%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Nasa%') ,'4f847339-9e68-4o73-9429-97d8f1eue707', '1')");

            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Islamic%') ,'4f841339-9e98-4a63-9729-99d8f8eue202', '-1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Islamic%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Islamic%') ,'xs545ge2-et79-3st5-yv6t-247er7g9d6e9', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Islamic%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4', '1')");
            migrationBuilder.Sql("INSERT INTO Votes (PostId, AppUserId, Mark) VALUES ((SELECT ID FROM Posts WHERE Title LIKE 'Islamic%') ,'2f347539-6e63-4o53-4469-57d8g1eue608', '-1')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Votes WHERE AppUserId IN ('4f841339-9e98-4a63-9729-99d8f8eue202' ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4' ,'4u871339-0e98-4k63-9929-99d8f0eue202' ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4' ,'4f847339-9e68-4o73-9429-97d8f1eue707','rf547ge3-wt75-4sw5-bv6r-647er7f9d7e5', '2f347539-6e63-4o53-4469-57d8g1eue608', 'xs545ge2-et79-3st5-yv6t-247er7g9d6e9')");
        }
    }
}
