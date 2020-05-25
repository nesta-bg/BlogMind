using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogMind.Migrations
{
    public partial class PopulateAspNetUsersAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO AspNetUsers (Id, Name, UserName, Email, EmailConfirmed, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount, Discriminator, Website) VALUES ('4f841339-9e98-4a63-9729-99d8f8eue202', 'Clementina DuBuque', 'Moriah.Stanton', 'Rey.Padberg@karina.biz', 'false', '024-648-3804', 'false', 'false', 'true', '0', 'AppUser', 'ambrose.net')");
            migrationBuilder.Sql("INSERT INTO AspNetUsers (Id, Name, UserName, Email, EmailConfirmed, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount, Discriminator, Website) VALUES ('df037be1-bf79-4cd2-bi6e-677ea7f9r0e4', 'Glenna Reichert', 'Delphine', 'Chaim_McDermott@dana.io', 'false', '(775)976-6794 x41206', 'false', 'false', 'true', '0', 'AppUser', 'conrad.com')");
            migrationBuilder.Sql("INSERT INTO AspNetUsers (Id, Name, UserName, Email, EmailConfirmed, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount, Discriminator, Website) VALUES ('4u871339-0e98-4k63-9929-99d8f0eue202', 'Nicholas Runolfsdottir V', 'Maxime_Nienow', 'Sherwood@rosamond.me', 'false', '586.493.6943 x140', 'false', 'false', 'true', '0', 'AppUser', 'jacynthe.com')");
            migrationBuilder.Sql("INSERT INTO AspNetUsers (Id, Name, UserName, Email, EmailConfirmed, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount, Discriminator, Website) VALUES ('ef047be3-bd75-4cw2-bt6e-677er7f9r7e4', 'Kurtis Weissnat', 'Elwyn.Skiles', 'Telly.Hoeger@billy.biz', 'false', '210.067.6132', 'false', 'false', 'true', '0', 'AppUser', 'elvis.io')");
            migrationBuilder.Sql("INSERT INTO AspNetUsers (Id, Name, UserName, Email, EmailConfirmed, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount, Discriminator, Website) VALUES ('4f847339-9e68-4o73-9429-97d8f1eue707', 'Mrs. Dennis Schulist', 'Leopoldo_Corkery', 'Karley_Dach@jasper.info', 'false', '1-477-935-8478 x6430', 'false', 'false', 'true', '0', 'AppUser', 'ola.org')");
            migrationBuilder.Sql("INSERT INTO AspNetUsers (Id, Name, UserName, Email, EmailConfirmed, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount, Discriminator, Website) VALUES ('rf547ge3-wt75-4sw5-bv6r-647er7f9d7e5', 'Chelsey Dietrich', 'Kamren', 'Lucio_Hettinger@annie.ca', 'false', '(254)954-1289', 'false', 'false', 'true', '0', 'AppUser', 'demarco.info')");
            migrationBuilder.Sql("INSERT INTO AspNetUsers (Id, Name, UserName, Email, EmailConfirmed, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount, Discriminator, Website) VALUES ('2f347539-6e63-4o53-4469-57d8g1eue608', 'Patricia Lebsack', 'Karianne', 'Julianne.OConner@kory.org', 'false', '493-170-9623 x156', 'false', 'false', 'true', '0', 'AppUser', 'kale.biz')");
            migrationBuilder.Sql("INSERT INTO AspNetUsers (Id, Name, UserName, Email, EmailConfirmed, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount, Discriminator, Website) VALUES ('xs545ge2-et79-3st5-yv6t-247er7g9d6e9', 'Clementine Bauch', 'Samantha', 'Nathan@yesenia.net', 'false', '1-463-123-4447', 'false', 'false', 'true', '0', 'AppUser', 'ramiro.info')");
            migrationBuilder.Sql("INSERT INTO AspNetUsers (Id, Name, UserName, Email, EmailConfirmed, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount, Discriminator, Website) VALUES ('4i387037-5e90-6o03-0468-95d8g1eue860', 'Ervin Howell', 'Antonette', 'Shanna@melissa.tv', 'false', '010-692-6593 x09125', 'false', 'false', 'true', '0', 'AppUser', 'anastasia.net')");
            migrationBuilder.Sql("INSERT INTO AspNetUsers (Id, Name, UserName, Email, EmailConfirmed, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount, Discriminator, Website) VALUES ('qd525gr2-gt26-1gt8-hm6t-737er7g6o8j6', 'Leanne Graham', 'Bret', 'Sincere@april.biz', 'false', '1-770-736-8031 x56442', 'false', 'false', 'true', '0', 'AppUser', 'hildegard.org')");

            migrationBuilder.Sql("INSERT INTO Addresses (Street, Suite, City, Zipcode, AppUserId) VALUES ('Kulas Light', 'Apt. 556', 'Gwenborough', '92998 - 3874', '4f841339-9e98-4a63-9729-99d8f8eue202')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, Suite, City, Zipcode, AppUserId) VALUES ('Victor Plains', 'Suite 879', 'Wisokyburgh', '90566-7771', 'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, Suite, City, Zipcode, AppUserId) VALUES ('Douglas Extension', 'Suite 847', 'McKenziehaven', '59590-4157', '4u871339-0e98-4k63-9929-99d8f0eue202')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, Suite, City, Zipcode, AppUserId) VALUES ('Hoeger Mall', 'Apt. 692', 'South Elvis', '53919-4257', 'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, Suite, City, Zipcode, AppUserId) VALUES ('Skiles Walks', 'Suite 351', 'Roscoeview', '33263', '4f847339-9e68-4o73-9429-97d8f1eue707')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, Suite, City, Zipcode, AppUserId) VALUES ('Norberto Crossing', 'Apt. 950', 'South Christy', '23505-1337', 'rf547ge3-wt75-4sw5-bv6r-647er7f9d7e5')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, Suite, City, Zipcode, AppUserId) VALUES ('Rex Trail', 'Suite 280', 'Howemouth', '58804-1099', '2f347539-6e63-4o53-4469-57d8g1eue608')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, Suite, City, Zipcode, AppUserId) VALUES ('Ellsworth Summit', 'Suite 729', 'Aliyaview', '45169', 'xs545ge2-et79-3st5-yv6t-247er7g9d6e9')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, Suite, City, Zipcode, AppUserId) VALUES ('Dayna Park', 'Suite 449', 'Bartholomebury', '76495-3109', '4i387037-5e90-6o03-0468-95d8g1eue860')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, Suite, City, Zipcode, AppUserId) VALUES ('Kattie Turnpike', 'Suite 198', 'Lebsackbury', '31428-2261', 'qd525gr2-gt26-1gt8-hm6t-737er7g6o8j6')");

            migrationBuilder.Sql("INSERT INTO Companies (Name, CatchPhrase, Bs, AppUserId ) VALUES ('Hoeger LLC', 'Centralized empowering task-force', 'target end-to-end models', '4f841339-9e98-4a63-9729-99d8f8eue202')");
            migrationBuilder.Sql("INSERT INTO Companies (Name, CatchPhrase, Bs, AppUserId ) VALUES ('Yost and Sons', 'Switchable contextually-based project', 'aggregate real-time technologies', 'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4')");
            migrationBuilder.Sql("INSERT INTO Companies (Name, CatchPhrase, Bs, AppUserId ) VALUES ('Abernathy Group', 'Implemented secondary concept', 'e-enable extensible e-tailers', '4u871339-0e98-4k63-9929-99d8f0eue202')");
            migrationBuilder.Sql("INSERT INTO Companies (Name, CatchPhrase, Bs, AppUserId ) VALUES ('Johns Group', 'Configurable multimedia task-force', 'generate enterprise e-tailers', 'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4')");
            migrationBuilder.Sql("INSERT INTO Companies (Name, CatchPhrase, Bs, AppUserId ) VALUES ('Considine-Lockman', 'Synchronised bottom-line interface', 'e-enable innovative applications', '4f847339-9e68-4o73-9429-97d8f1eue707')");
            migrationBuilder.Sql("INSERT INTO Companies (Name, CatchPhrase, Bs, AppUserId ) VALUES ('Keebler LLC', 'User-centric fault-tolerant solution', 'revolutionize end-to-end systems', 'rf547ge3-wt75-4sw5-bv6r-647er7f9d7e5')");
            migrationBuilder.Sql("INSERT INTO Companies (Name, CatchPhrase, Bs, AppUserId ) VALUES ('Robel-Corkery', 'Multi-tiered zero tolerance productivity', 'transition cutting-edge web services', '2f347539-6e63-4o53-4469-57d8g1eue608')");
            migrationBuilder.Sql("INSERT INTO Companies (Name, CatchPhrase, Bs, AppUserId ) VALUES ('Romaguera-Jacobson', 'Face to face bifurcated interface', 'e-enable strategic applications', 'xs545ge2-et79-3st5-yv6t-247er7g9d6e9')");
            migrationBuilder.Sql("INSERT INTO Companies (Name, CatchPhrase, Bs, AppUserId ) VALUES ('Deckow-Crist', 'Proactive didactic contingency', 'synergize scalable supply-chains', '4i387037-5e90-6o03-0468-95d8g1eue860')");
            migrationBuilder.Sql("INSERT INTO Companies (Name, CatchPhrase, Bs, AppUserId ) VALUES ('Romaguera-Crona', 'Multi-layered client-server neural-net', 'harness real-time e-markets', 'qd525gr2-gt26-1gt8-hm6t-737er7g6o8j6')");

            migrationBuilder.Sql("INSERT INTO Geos (Lat, Lng, AddressId) VALUES ('-37.3159', '81.1496', '10')");
            migrationBuilder.Sql("INSERT INTO Geos (Lat, Lng, AddressId) VALUES ('-43.9509', '-34.4618', '9')");
            migrationBuilder.Sql("INSERT INTO Geos (Lat, Lng, AddressId) VALUES ('-68.6102', '-47.0653', '8')");
            migrationBuilder.Sql("INSERT INTO Geos (Lat, Lng, AddressId) VALUES ('29.4572', '-164.2990', '7')");
            migrationBuilder.Sql("INSERT INTO Geos (Lat, Lng, AddressId) VALUES ('-31.8129', '62.5342', '6')");
            migrationBuilder.Sql("INSERT INTO Geos (Lat, Lng, AddressId) VALUES ('-71.41979', '71.7478', '5')");
            migrationBuilder.Sql("INSERT INTO Geos (Lat, Lng, AddressId) VALUES ('24.8918', '21.8984', '4')");
            migrationBuilder.Sql("INSERT INTO Geos (Lat, Lng, AddressId) VALUES ('-14.3990', '-120.7677', '3')");
            migrationBuilder.Sql("INSERT INTO Geos (Lat, Lng, AddressId) VALUES ('-24.6463', '-168.8889', '2')");
            migrationBuilder.Sql("INSERT INTO Geos (Lat, Lng, AddressId) VALUES ('-38.2386', '57.2232', '1')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Email='Rey.Padberg@karina.biz'");
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Email='Chaim_McDermott@dana.io'");
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Email='Sherwood@rosamond.me'");
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Email='Telly.Hoeger@billy.biz'");
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Email='Karley_Dach@jasper.info'");
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Email='Lucio_Hettinger@annie.ca'");
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Email='Julianne.OConner@kory.org'");
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Email='Nathan@yesenia.net'");
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Email='Shanna@melissa.tv'");
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Email='Sincere@april.biz'");
        }
    }
}
