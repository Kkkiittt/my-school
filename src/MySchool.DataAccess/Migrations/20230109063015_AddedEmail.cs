using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySchool.DataAccess.Migrations
{
	public partial class AddedEmail : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			_ = migrationBuilder.DropColumn(
				name: "Phone",
				table: "Employees");

			_ = migrationBuilder.RenameColumn(
				name: "PhoneVerified",
				table: "Employees",
				newName: "EmailVerified");

			_ = migrationBuilder.AlterColumn<string>(
				name: "Pin",
				table: "Students",
				type: "text",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "text");

			_ = migrationBuilder.AlterColumn<string>(
				name: "Info",
				table: "Students",
				type: "text",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "text");

			_ = migrationBuilder.AlterColumn<string>(
				name: "Password",
				table: "Employees",
				type: "text",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "text");

			_ = migrationBuilder.AlterColumn<string>(
				name: "Name",
				table: "Employees",
				type: "text",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "text");

			_ = migrationBuilder.AlterColumn<string>(
				name: "Image",
				table: "Employees",
				type: "text",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "text");

			_ = migrationBuilder.AddColumn<string>(
				name: "Email",
				table: "Employees",
				type: "text",
				nullable: true);

			_ = migrationBuilder.AlterColumn<string>(
				name: "Content",
				table: "Comments",
				type: "text",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "text");

			_ = migrationBuilder.AlterColumn<string>(
				name: "Image",
				table: "Charters",
				type: "text",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "text");

			_ = migrationBuilder.AlterColumn<string>(
				name: "Title",
				table: "Articles",
				type: "text",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "text");

			_ = migrationBuilder.AlterColumn<string>(
				name: "Image",
				table: "Articles",
				type: "text",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "text");

			_ = migrationBuilder.AlterColumn<string>(
				name: "HTML",
				table: "Articles",
				type: "text",
				nullable: true,
				oldClrType: typeof(string),
				oldType: "text");

			_ = migrationBuilder.UpdateData(
				table: "Employees",
				keyColumn: "Id",
				keyValue: 1L,
				columns: new[] { "Email", "Password" },
				values: new object[] { "khamidov357@gmail.com", "mk5/RJY1Pg65Z4MqpNnG5rCDUDGtjM2P42MlohbRcEs=" });
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			_ = migrationBuilder.DropColumn(
				name: "Email",
				table: "Employees");

			_ = migrationBuilder.RenameColumn(
				name: "EmailVerified",
				table: "Employees",
				newName: "PhoneVerified");

			_ = migrationBuilder.AlterColumn<string>(
				name: "Pin",
				table: "Students",
				type: "text",
				nullable: false,
				defaultValue: "",
				oldClrType: typeof(string),
				oldType: "text",
				oldNullable: true);

			_ = migrationBuilder.AlterColumn<string>(
				name: "Info",
				table: "Students",
				type: "text",
				nullable: false,
				defaultValue: "",
				oldClrType: typeof(string),
				oldType: "text",
				oldNullable: true);

			_ = migrationBuilder.AlterColumn<string>(
				name: "Password",
				table: "Employees",
				type: "text",
				nullable: false,
				defaultValue: "",
				oldClrType: typeof(string),
				oldType: "text",
				oldNullable: true);

			_ = migrationBuilder.AlterColumn<string>(
				name: "Name",
				table: "Employees",
				type: "text",
				nullable: false,
				defaultValue: "",
				oldClrType: typeof(string),
				oldType: "text",
				oldNullable: true);

			_ = migrationBuilder.AlterColumn<string>(
				name: "Image",
				table: "Employees",
				type: "text",
				nullable: false,
				defaultValue: "",
				oldClrType: typeof(string),
				oldType: "text",
				oldNullable: true);

			_ = migrationBuilder.AddColumn<string>(
				name: "Phone",
				table: "Employees",
				type: "text",
				nullable: false,
				defaultValue: "");

			_ = migrationBuilder.AlterColumn<string>(
				name: "Content",
				table: "Comments",
				type: "text",
				nullable: false,
				defaultValue: "",
				oldClrType: typeof(string),
				oldType: "text",
				oldNullable: true);

			_ = migrationBuilder.AlterColumn<string>(
				name: "Image",
				table: "Charters",
				type: "text",
				nullable: false,
				defaultValue: "",
				oldClrType: typeof(string),
				oldType: "text",
				oldNullable: true);

			_ = migrationBuilder.AlterColumn<string>(
				name: "Title",
				table: "Articles",
				type: "text",
				nullable: false,
				defaultValue: "",
				oldClrType: typeof(string),
				oldType: "text",
				oldNullable: true);

			_ = migrationBuilder.AlterColumn<string>(
				name: "Image",
				table: "Articles",
				type: "text",
				nullable: false,
				defaultValue: "",
				oldClrType: typeof(string),
				oldType: "text",
				oldNullable: true);

			_ = migrationBuilder.AlterColumn<string>(
				name: "HTML",
				table: "Articles",
				type: "text",
				nullable: false,
				defaultValue: "",
				oldClrType: typeof(string),
				oldType: "text",
				oldNullable: true);

			_ = migrationBuilder.UpdateData(
				table: "Employees",
				keyColumn: "Id",
				keyValue: 1L,
				columns: new[] { "Password", "Phone" },
				values: new object[] { "eab774a782c906cb9b95749769ae2b99fa1891b02837204a6a0a55bee6fe280c", "+998930090415" });
		}
	}
}
