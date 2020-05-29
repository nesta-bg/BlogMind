﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogMind.Migrations
{
    public partial class SeedPostsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Protesters set Minneapolis police station ablaze', 'A police station in Minneapolis has been set alight during a third night of protests over the death of an unarmed black man in custody on Monday.', '4f841339-9e98-4a63-9729-99d8f8eue202')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Moscow more than doubles city''s Covid-19 death toll', 'Moscow''s authorities have more than doubled the official death toll from Covid-19 in the Russian capital for the month of April. The city''s health department now says 1,561 people died from the disease - not 639 as initially announced.', '4f841339-9e98-4a63-9729-99d8f8eue202')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('UK could offer ''path to citizenship'' for Hong Kong''s British passport holders', 'The UK could offer British National (Overseas) passport holders in Hong Kong a path to UK citizenship if China does not suspend plans for a security law in the territory, UK Foreign Secretary Dominic Raab says.', '4f841339-9e98-4a63-9729-99d8f8eue202')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Twitter hides Trump tweet for ''glorifying violence''', 'Twitter has hidden one of President Donald Trump''s tweets from his profile, saying it violates rules about glorifying violence. But instead of being deleted, it has been replaced with a warning and can be viewed by clicking on it.', '4f841339-9e98-4a63-9729-99d8f8eue202')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Facebook dominates cases of recorded social media grooming', 'Police in England and Wales recorded more than 10,000 online grooming offences on social media over two-and-a-half years. Where the method was recorded, more than half - 55% - took place on a Facebook-owned app.', '4f841339-9e98-4a63-9729-99d8f8eue202')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Trading Standards squad targets anti-5G USB stick', 'Trading Standards officers are seeking to halt sales of a device that has been claimed to offer protection against the supposed dangers of 5G via use of quantum technology. Cyber - security experts say the £339 5GBioShield appears to no more than a basic USB drive.', '4f841339-9e98-4a63-9729-99d8f8eue202')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Trump signs executive order targeting Twitter after fact-checking row', 'US President Donald Trump has signed an executive order aimed at removing some of the legal protections given to social media platforms. He said the firms had ''unchecked power'' to censure and edit the views of users.', '4f841339-9e98-4a63-9729-99d8f8eue202')");

            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Thousands of TalkTalk users hit by internet problems', 'Tens of thousands of TalkTalk customers reported problems with their internet connection on Friday morning. Popular tracking website DownDetector logged more than 30,000 reports beginning at around 10:00 BST, scattered across the UK.', 'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Uber destroys thousands of bikes and scooters', 'Uber is destroying thousands of electric bikes and scooters, after selling its Jump business to Lime. Videos of its red bikes being crushed at a US recycling centre were shared on social media, angering cycling advocates.', 'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Coronavirus: France set to roll out contact-tracing app before UK', 'French smartphone owners can download a coronavirus contact-tracing app from Tuesday, its Prime Minister said. That is set to pre-date a UK counterpart.', 'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Video streaming: Lockdown sees fifth of UK homes sign deals', 'One in five households in Britain – six million – signed up to an online video subscription service during the Covid-19 lockdown, data suggests. The majority of those sign-ups, 52%, are going to Disney+, according to market research firm Kantar.', 'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4')");

            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Huawei executive suffers US extradition blow', 'A Canadian court has ruled that the case of senior Huawei executive Meng Wanzhou, who is fighting extradition to the United States, can go forward.', '4u871339-0e98-4k63-9929-99d8f0eue202')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Zipline drones deliver supplies and PPE to US hospitals', 'Drone firm Zipline has been given the go-ahead to deliver medical supplies and personal protective equipment to hospitals in North Carolina. The firm will be allowed to use drones on two specified routes after the Federal Aviation Administration granted it an emergency waiver.', '4u871339-0e98-4k63-9929-99d8f0eue202')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('World''s deepest octopus captured on camera', 'The deepest ever sighting of an octopus has been made by cameras on the Indian Ocean floor. The animal was spotted 7,000m down in the Java Trench - almost 2km deeper than the previous reliable recording.', '4u871339-0e98-4k63-9929-99d8f0eue202')");

            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Rainfall shutdown during lockdown', 'According to the Met Office, it has been the sunniest spring on record for the UK, while parts of Scotland, and north west and north east England also declared their driest spring on record.', 'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Isle of Wight pterosaur species fossil hailed as UK first', 'A fossil of a species of prehistoric reptile, previously found in China and Brazil, has been discovered in the UK for the first time, a university said.', 'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4')");

            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Biggest UK solar plant approved', 'The go-ahead has been given to the UK''s biggest solar farm, stretching 900 acres on the north Kent coast. The government has approved the controversial scheme, which will supply power to 91,000 homes.', '4f847339-9e68-4o73-9429-97d8f1eue707')");

            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('New date agreed for UN climate summit in Glasgow', 'The COP26 UN summit will now take place between 1 and 12 November next year. It was originally supposed to take place in November 2020. However, it had to be postponed due to the pandemic.', 'rf547ge3-wt75-4sw5-bv6r-647er7f9d7e5')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Nasa SpaceX launch: Big day called off because of weather', 'Poor weather has forced SpaceX to call off the launch of Nasa astronauts Doug Hurley and Bob Behnken to the International Space Station (ISS).', 'rf547ge3-wt75-4sw5-bv6r-647er7f9d7e5')");

            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Coronavirus: Rishi Sunak urged by MPs to extend self-employed help', 'MPs have urged Chancellor Rishi Sunak to extend support for the self-employed during the coronavirus pandemic.', '2f347539-6e63-4o53-4469-57d8g1eue608')");
            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('Islamic State: RAF carries out four air strikes in May', 'Royal Air Force drones and Typhoons carried out four sets of air strikes against the Islamic State group (IS) in May, the Ministry of Defence has said.', '2f347539-6e63-4o53-4469-57d8g1eue608')");

            migrationBuilder.Sql("INSERT INTO Posts (Title, Body, AppUserId) VALUES ('UK could offer ''path to citizenship'' for Hong Kong''s British passport holders', 'The UK could offer British National (Overseas) passport holders in Hong Kong a path to UK citizenship if China does not suspend plans for a security law in the territory, UK Foreign Secretary Dominic Raab says.', 'xs545ge2-et79-3st5-yv6t-247er7g9d6e9')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Posts WHERE AppUserId IN ('4f841339-9e98-4a63-9729-99d8f8eue202' ,'df037be1-bf79-4cd2-bi6e-677ea7f9r0e4' ,'4u871339-0e98-4k63-9929-99d8f0eue202' ,'ef047be3-bd75-4cw2-bt6e-677er7f9r7e4' ,'4f847339-9e68-4o73-9429-97d8f1eue707','rf547ge3-wt75-4sw5-bv6r-647er7f9d7e5', '2f347539-6e63-4o53-4469-57d8g1eue608', 'xs545ge2-et79-3st5-yv6t-247er7g9d6e9')");
        }
    }
}