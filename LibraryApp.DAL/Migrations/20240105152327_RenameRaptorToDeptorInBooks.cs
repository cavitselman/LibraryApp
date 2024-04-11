﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RenameRaptorToDeptorInBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Raptor",
                table: "Books",
                newName: "Deptor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Deptor",
                table: "Books",
                newName: "Raptor");
        }
    }
}
