﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ToDo.Persistence.DataContexts;

#nullable disable

namespace ToDo.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231229154534_Add TodoItem")]
    partial class AddTodoItem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ToDo.Domain.Entities.TodoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("DueTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDone")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("ModifiedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("ReminderTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.HasKey("Id");

                    b.ToTable("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
