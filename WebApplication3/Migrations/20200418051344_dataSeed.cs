using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class dataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -1, "Todd Phillips", new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crime , Drama , Thriller", "Joker", "http://image.tmdb.org/t/p/w185//nBNZadXqJSdt05SHLqgT0HuC5Gm.jpg" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -2, "David Leitch", new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Action , Adventure", "Fast & Furious Presents: Hobbs & Shaw", "https://camo.githubusercontent.com/2921202280866f3d1d35e68968b10ca1423d2254/68747470733a2f2f696d616765732d6e612e73736c2d696d616765732d616d617a6f6e2e636f6d2f696d616765732f4d2f4d5635424e6a6b324f44517a4e4459784e5635424d6c3542616e426e586b46745a5467774d5463794e4467344e6a45402e5f56315f55583138325f4352302c302c3138322c3236385f414c5f2e6a7067" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -3, "Jon Favreau", new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adventure , Animation , Drama , Family , Musical", "The Lion King", "https://camo.githubusercontent.com/03a3a78891c3d594d29f8d008d9bbf589b35c198/68747470733a2f2f696d616765732d6e612e73736c2d696d616765732d616d617a6f6e2e636f6d2f696d616765732f4d2f4d5635424d5463324d5451334d4441314e6c35424d6c3542616e426e586b46745a5467774f4441334f5449344e6a45402e5f56315f55583138325f4352302c302c3138322c3236385f414c5f2e6a7067" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -4, "Joachim Rønning", new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adventure , Family , Fantasy", "Maleficent: Mistress of Evil", "https://camo.githubusercontent.com/21ed484b2dc8b4c1156069f29143d01f4bbb72c4/68747470733a2f2f696d616765732d6e612e73736c2d696d616765732d616d617a6f6e2e636f6d2f696d616765732f4d2f4d5635424e7a517a4f546b334f5441744e4451305a6930305a54566b4c5749304d5445744d446c6c5a6a4e6b597a4e6a4e5463344c326c745957646c586b4579586b467163476465515856794e6a55304f5451304f5459402e5f56315f55583138325f4352302c302c3138322c3236385f414c5f2e6a7067"
                    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
