using Microsoft.EntityFrameworkCore.Migrations;

using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MySchool.DataAccess.Migrations
{
	public partial class InitialCreate : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			_ = migrationBuilder.CreateTable(
				name: "Employees",
				columns: table => new
				{
					Id = table.Column<long>(type: "bigint", nullable: false)
						.Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
					Name = table.Column<string>(type: "text", nullable: false),
					Password = table.Column<string>(type: "text", nullable: false),
					Phone = table.Column<string>(type: "text", nullable: false),
					PhoneVerified = table.Column<bool>(type: "boolean", nullable: false),
					Role = table.Column<int>(type: "integer", nullable: false),
					Image = table.Column<string>(type: "text", nullable: false)
				},
				constraints: table =>
				{
					_ = table.PrimaryKey("PK_Employees", x => x.Id);
				});

			_ = migrationBuilder.CreateTable(
				name: "Students",
				columns: table => new
				{
					Id = table.Column<long>(type: "bigint", nullable: false)
						.Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
					Pin = table.Column<string>(type: "text", nullable: false),
					Info = table.Column<string>(type: "text", nullable: false),
					Studying = table.Column<bool>(type: "boolean", nullable: false)
				},
				constraints: table =>
				{
					_ = table.PrimaryKey("PK_Students", x => x.Id);
				});

			_ = migrationBuilder.CreateTable(
				name: "Articles",
				columns: table => new
				{
					Id = table.Column<long>(type: "bigint", nullable: false)
						.Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
					Title = table.Column<string>(type: "text", nullable: false),
					Image = table.Column<string>(type: "text", nullable: false),
					HTML = table.Column<string>(type: "text", nullable: false),
					Views = table.Column<long>(type: "bigint", nullable: false),
					EmployeeId = table.Column<long>(type: "bigint", nullable: false),
					CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
				},
				constraints: table =>
				{
					_ = table.PrimaryKey("PK_Articles", x => x.Id);
					_ = table.ForeignKey(
						name: "FK_Articles_Employees_EmployeeId",
						column: x => x.EmployeeId,
						principalTable: "Employees",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			_ = migrationBuilder.CreateTable(
				name: "Charters",
				columns: table => new
				{
					Id = table.Column<long>(type: "bigint", nullable: false)
						.Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
					StudentId = table.Column<long>(type: "bigint", nullable: false),
					Image = table.Column<string>(type: "text", nullable: false),
					CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
				},
				constraints: table =>
				{
					_ = table.PrimaryKey("PK_Charters", x => x.Id);
					_ = table.ForeignKey(
						name: "FK_Charters_Students_StudentId",
						column: x => x.StudentId,
						principalTable: "Students",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			_ = migrationBuilder.CreateTable(
				name: "Comments",
				columns: table => new
				{
					Id = table.Column<long>(type: "bigint", nullable: false)
						.Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
					Content = table.Column<string>(type: "text", nullable: false),
					ArticleId = table.Column<long>(type: "bigint", nullable: false),
					StudentId = table.Column<long>(type: "bigint", nullable: false),
					CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
				},
				constraints: table =>
				{
					_ = table.PrimaryKey("PK_Comments", x => x.Id);
					_ = table.ForeignKey(
						name: "FK_Comments_Articles_ArticleId",
						column: x => x.ArticleId,
						principalTable: "Articles",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					_ = table.ForeignKey(
						name: "FK_Comments_Students_StudentId",
						column: x => x.StudentId,
						principalTable: "Students",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			_ = migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "Id", "Image", "Name", "Password", "Phone", "PhoneVerified", "Role" },
				values: new object[] { 1L, "", "Admin", "eab774a782c906cb9b95749769ae2b99fa1891b02837204a6a0a55bee6fe280c", "+998930090415", true, 666 });

			_ = migrationBuilder.CreateIndex(
				name: "IX_Articles_EmployeeId",
				table: "Articles",
				column: "EmployeeId");

			_ = migrationBuilder.CreateIndex(
				name: "IX_Charters_StudentId",
				table: "Charters",
				column: "StudentId");

			_ = migrationBuilder.CreateIndex(
				name: "IX_Comments_ArticleId",
				table: "Comments",
				column: "ArticleId");

			_ = migrationBuilder.CreateIndex(
				name: "IX_Comments_StudentId",
				table: "Comments",
				column: "StudentId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			_ = migrationBuilder.DropTable(
				name: "Charters");

			_ = migrationBuilder.DropTable(
				name: "Comments");

			_ = migrationBuilder.DropTable(
				name: "Articles");

			_ = migrationBuilder.DropTable(
				name: "Students");

			_ = migrationBuilder.DropTable(
				name: "Employees");
		}
	}
}
