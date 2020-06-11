using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogMind.Migrations
{
    public partial class SeedLikesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'laudantium%') ,'4f841339-9e98-4a63-9729-99d8f8eue202')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'laudantium%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'laudantium%') ,'4u871339-0e98-4k63-9929-99d8f0eue202')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'laudantium%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4')");

            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'est%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'est%') ,'4f847339-9e68-4o73-9429-97d8f1eue707')");

            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'doloribus%') ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'doloribus%') ,'rf547ge3-wt75-4sw5-bv6r-647er7f9d7e5')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'doloribus%') ,'2f347539-6e63-4o53-4469-57d8g1eue608')");

            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'ut%') ,'2f347539-6e63-4o53-4469-57d8g1eue608')");

            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'repudiandae%') ,'rf547ge3-wt75-4sw5-bv6r-647er7f9d7e5')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'repudiandae%') ,'xs545ge2-et79-3st5-yv6t-247er7g9d6e9')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'repudiandae%') ,'4i387037-5e90-6o03-0468-95d8g1eue860')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'repudiandae%') ,'qd525gr2-gt26-1gt8-hm6t-737er7g6o8j6')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'repudiandae%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4')");

            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'expedita%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4')");

            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'iste%') ,'qd525gr2-gt26-1gt8-hm6t-737er7g6o8j6')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'iste%') ,'4f847339-9e68-4o73-9429-97d8f1eue707')");

            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'deleniti%') ,'qd525gr2-gt26-1gt8-hm6t-737er7g6o8j6')");

            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'voluptates%') ,'qd525gr2-gt26-1gt8-hm6t-737er7g6o8j6')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'voluptates%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4')");

            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'incidunt%') ,'4f847339-9e68-4o73-9429-97d8f1eue707')");

            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'occaecati%') ,'qd525gr2-gt26-1gt8-hm6t-737er7g6o8j6')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'occaecati%') ,'4f847339-9e68-4o73-9429-97d8f1eue707')");

            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'illum%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4')");

            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'facere%') ,'qd525gr2-gt26-1gt8-hm6t-737er7g6o8j6')");
            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'facere%') ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4')");

            migrationBuilder.Sql("INSERT INTO Likes (CommentId, AppUserId) VALUES ((SELECT ID FROM Comments WHERE Body LIKE 'exercitationem%') ,'4f847339-9e68-4o73-9429-97d8f1eue707')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM LIKES WHERE AppUserId IN ('4f841339-9e98-4a63-9729-99d8f8eue202' ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4' ,'4u871339-0e98-4k63-9929-99d8f0eue202' ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4' ,'4f847339-9e68-4o73-9429-97d8f1eue707','rf547ge3-wt75-4sw5-bv6r-647er7f9d7e5', '2f347539-6e63-4o53-4469-57d8g1eue608', 'xs545ge2-et79-3st5-yv6t-247er7g9d6e9')");
        }
    }
}

