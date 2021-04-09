﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateLastActivity")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            DateLastActivity = new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 2,
                            DateLastActivity = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 3,
                            DateLastActivity = new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 4,
                            DateLastActivity = new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 5,
                            DateLastActivity = new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 6,
                            DateLastActivity = new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 7,
                            DateLastActivity = new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 8,
                            DateLastActivity = new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 9,
                            DateLastActivity = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 10,
                            DateLastActivity = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 11,
                            DateLastActivity = new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 12,
                            DateLastActivity = new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 13,
                            DateLastActivity = new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 14,
                            DateLastActivity = new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 15,
                            DateLastActivity = new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 16,
                            DateLastActivity = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 17,
                            DateLastActivity = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 18,
                            DateLastActivity = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 19,
                            DateLastActivity = new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 20,
                            DateLastActivity = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 21,
                            DateLastActivity = new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 22,
                            DateLastActivity = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 23,
                            DateLastActivity = new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 24,
                            DateLastActivity = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 25,
                            DateLastActivity = new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 26,
                            DateLastActivity = new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 27,
                            DateLastActivity = new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 28,
                            DateLastActivity = new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 29,
                            DateLastActivity = new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 30,
                            DateLastActivity = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 31,
                            DateLastActivity = new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 32,
                            DateLastActivity = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 33,
                            DateLastActivity = new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 34,
                            DateLastActivity = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 35,
                            DateLastActivity = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 36,
                            DateLastActivity = new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 37,
                            DateLastActivity = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 38,
                            DateLastActivity = new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 39,
                            DateLastActivity = new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 40,
                            DateLastActivity = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 41,
                            DateLastActivity = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 42,
                            DateLastActivity = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 43,
                            DateLastActivity = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 44,
                            DateLastActivity = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 45,
                            DateLastActivity = new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 46,
                            DateLastActivity = new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 47,
                            DateLastActivity = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 48,
                            DateLastActivity = new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 49,
                            DateLastActivity = new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 50,
                            DateLastActivity = new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 51,
                            DateLastActivity = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 52,
                            DateLastActivity = new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 53,
                            DateLastActivity = new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 54,
                            DateLastActivity = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 55,
                            DateLastActivity = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 56,
                            DateLastActivity = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 57,
                            DateLastActivity = new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 58,
                            DateLastActivity = new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 59,
                            DateLastActivity = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 60,
                            DateLastActivity = new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistration = new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}