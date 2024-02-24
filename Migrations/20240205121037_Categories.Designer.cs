﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_Library.Data;

#nullable disable

namespace Online_Library.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20240205121037_Categories")]
    partial class Categories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Online_Library.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOnlineBook")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("PdfFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfPublish")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Online_Library.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Категорията на романите включва разнообразни литературни произведения, фокусирани върху развитието на персонални и социални взаимоотношения, често съчетани с интриги и драма.",
                            Title = "Романи"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Историческите романи предоставят читателят да се потапя във времето и пространството на минали епохи, като комбинират реални исторически събития с фиктивни герои и сюжети.",
                            ParentId = 1,
                            Title = "Исторически романи"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Любовните романи се фокусират върху развитието на чувствата и връзките между героите. Обичайно съчетават елементи на романтика и драма, предоставяйки на читателите истории за любов и страст.",
                            ParentId = 1,
                            Title = "Любовни романи"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Трилърите са жанр, чиито истории са изпълнени с напрежение, интриги и неочаквани обрати. Героите се изправят пред опасности и загадки, които често водят до неочаквани развръзки.",
                            Title = "Трилър"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Фантастиката предоставя възможност за изследване на невероятни светове и идеи. Този жанр включва различни подкатегории,които предоставят научнофантастични или фантастични приключения.",
                            Title = "Фантастика"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Научната фантастика се фокусира върху научни и технологични аспекти, представяйки възможни бъдещи сценарии и технологични развития. Често включва елементи на изследователския дух и технологичен прогрес.",
                            ParentId = 5,
                            Title = "Научна фантастика"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Жанрът на фентъзито включва елементи от въображаемо и магическо, предоставяйки на читателите възможността да се потопят в светове, изпълнени с магия, удивителни създания и зашеметяващи приключения.",
                            ParentId = 6,
                            Title = "Фентъзи"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Хорърът е жанр, целящ да интригува и плаши читателя. Често включва неестествени явления, ужасяващи събития и напрежение, които създават усещане за страх и тревога.",
                            Title = "Хорър"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Категорията на фолклора обхваща традиционни и народни истории, легенди, митове и приказки. Тези произведения отразяват културното богатство и наследство на различни общества.",
                            Title = "Фолклор"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Книгите в тази категория имат за цел да развеселят и забавляват читателя чрез хумористични елементи и сатирични образи. Често използват ирония и смешни ситуации, за да предизвикат смях.",
                            Title = "Хумор и сатира"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Детската и юношеска литература е насочена към младата аудитория и обикновено включва приключения, образователни елементи и развиващи сюжети, които съчетават забавление с поучение.",
                            Title = "Детска и Юношеска литература"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Приключенските романи,предоставят възможността читателят да се потопи в изпълнени с действие истории. Героите често се изправят пред различни предизвикателства и опасности.",
                            Title = "Приключенска литература"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Поезията представлява изразително изкуство, което използва ритъм, рима и изразителен език, за да предаде емоции, образи и мисли. Този жанр предоставя разнообразие от стилове и теми.",
                            Title = "Поезия"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Категорията на изкуството обхваща литературни произведения, посветени на различни аспекти на изобразителните, изпълнителските и литературните изкуства.",
                            Title = "Изкуство"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Категорията на обществото включва литературни произведения, които се занимават с различни аспекти на човешкото общество.",
                            Title = "Общество"
                        });
                });

            modelBuilder.Entity("Online_Library.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Online_Library.Models.ReaderCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("From_date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("To_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("User_id");

                    b.ToTable("ReaderCards");
                });

            modelBuilder.Entity("Online_Library.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Birthdate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = new DateOnly(1, 1, 1),
                            CreatedAt = new DateTime(2024, 2, 5, 14, 10, 36, 485, DateTimeKind.Local).AddTicks(3933),
                            Email = "gergankabibli@gmail.com",
                            Name = "Гергана",
                            Password = "Password12345",
                            Role = "Библиотекар",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Username = "gerganka"
                        });
                });

            modelBuilder.Entity("Online_Library.Models.User_Loan_Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("TakenOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TakenTo")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("User_Loan_Books");
                });

            modelBuilder.Entity("Online_Library.View_Model.Users.LoginVM", b =>
                {
                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("LoginVM");
                });

            modelBuilder.Entity("Online_Library.View_Model.Users.Register", b =>
                {
                    b.Property<DateOnly>("Birthdate")
                        .HasColumnType("date");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Register");
                });

            modelBuilder.Entity("Online_Library.Models.Book", b =>
                {
                    b.HasOne("Online_Library.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Online_Library.Models.Category", b =>
                {
                    b.HasOne("Online_Library.Models.Category", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("Online_Library.Models.Rating", b =>
                {
                    b.HasOne("Online_Library.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Library.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Online_Library.Models.ReaderCard", b =>
                {
                    b.HasOne("Online_Library.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Online_Library.Models.User_Loan_Book", b =>
                {
                    b.HasOne("Online_Library.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Library.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Online_Library.Models.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
