using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetYuzuncuYil.Repository.Migrations
{
    public partial class İnitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterMail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WriterPassword = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    WriterID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Writers_WriterID",
                        column: x => x.WriterID,
                        principalTable: "Writers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryDescription", "CategoryStatus", "Name" },
                values: new object[,]
                {
                    { 1, null, true, "Sanat" },
                    { 2, null, true, "Ekonomi" },
                    { 3, null, true, "Edebiyat" },
                    { 4, null, true, "Spor" }
                });

            migrationBuilder.InsertData(
                table: "Writers",
                columns: new[] { "Id", "Name", "WriterMail", "WriterPassword", "WriterSurname" },
                values: new object[,]
                {
                    { 1, "Gökçe", "gokce_balci@gmail.com", "1wfy54", "Balcı" },
                    { 2, "Akın", "akın_yılmaz@gmail.com", "02ax5tp", "Yılmaz" },
                    { 3, "Deniz", "deniz_gokturk@gmail.com", "84dc774", "Göktürk" }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "BlogContent", "BlogCreateDate", "BlogImage", "CategoryID", "Name", "WriterID" },
                values: new object[] { 1, "Yeni bir yıla girerken, 2023'ü büyük bir acı ile başlayıp 100. yıl coşkusuyla uğurladık. Türkiye Finans olarak, bu yıl boyunca yenilikçi yapımızın odağına insanı alarak değerli paydaşlarımızla birlikte yoğun bir yıl geçirdik.", new DateTime(2024, 1, 4, 22, 37, 8, 580, DateTimeKind.Local).AddTicks(2741), "https://www.turkiyefinans.com.tr/tr-tr/blog/PublishingImages/2023-detay.jpg", 2, "2023'ü Geride Bırakırken", 3 });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "BlogContent", "BlogCreateDate", "BlogImage", "CategoryID", "Name", "WriterID" },
                values: new object[] { 2, "İyi görünen insanları diğerlerinden ayıran temel özelliklerden biri ince bir bele sahip olmalarıdır. İnce bir bel estetik açıdan göze daha hoş gelir. İnce olmak ve fit görünmek için çok çalışırız. Bel çevresinde biriken yağlardan tamamen kurtulamayız. Bu yağlardan kurtulmak istiyorsak bel bölgesini hedef alan bazı egzersizler vardır. Bel inceltmek için en hızlı hareketleri evde, hiçbir aparat kullanmadan uygulayabilirsiniz", new DateTime(2024, 1, 4, 22, 37, 8, 580, DateTimeKind.Local).AddTicks(2750), "https://www.skechers.com.tr/blog/wp-content/uploads/2023/05/Bel-inceltme-Hareketleri.jpg", 4, "Bel inceltme Hareketleri", 1 });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "BlogContent", "BlogCreateDate", "BlogImage", "CategoryID", "Name", "WriterID" },
                values: new object[] { 3, "Kaplumbağa Terbiyecisi Tablosu, Osman Hamdi Bey tarafından 1906 ve 1907 yıllarında iki farklı çeşidini çizdiği resimlerdir.Osmanlı İmparatorluğu Lale Devri’ndeki “Sadabad Eğlenceleri” nde gece bahçelerin aydınlatılması için kaplumbağaların sırtlarına mumlar dikilerek serbest bırakılmaları bilgisi hikaye olarak anlatılır.\r\n\r\nO dönemde kaplumbağalar, dikkat çeken hizmetliler olarak görülür ve eğlencelere dahil edilirdi.", new DateTime(2024, 1, 4, 22, 37, 8, 580, DateTimeKind.Local).AddTicks(2751), "https://www.lavitasarim.com/wp-content/uploads/2020/08/kaplumbaga-terbiyecisi-osman-hamdi-bey-lavi-tasarim.jpg", 1, "Kaplumbağa Terbiyecisi Tablosu Hikayesi ve Anlamı", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blogs",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_WriterID",
                table: "Blogs",
                column: "WriterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Writers");
        }
    }
}
