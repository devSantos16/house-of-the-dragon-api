// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using house_of_the_dragon_api.Context;

#nullable disable

namespace house_of_the_dragon_api.Migrations
{
    [DbContext(typeof(HouseOfTheDragonContext))]
    partial class HouseOfTheDragonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("house_of_the_dragon_api.models.Book", b =>
                {
                    b.Property<int>("idBook")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idBook"), 1L, 1);

                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idBook");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("house_of_the_dragon_api.models.BookCharacter", b =>
                {
                    b.Property<int>("IdBookCharacter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBookCharacter"), 1L, 1);

                    b.Property<int>("BookIdBook")
                        .HasColumnType("int");

                    b.Property<int>("CharacterIdCharacter")
                        .HasColumnType("int");

                    b.HasKey("IdBookCharacter");

                    b.HasIndex("BookIdBook");

                    b.HasIndex("CharacterIdCharacter");

                    b.ToTable("BooksCharacters");
                });

            modelBuilder.Entity("house_of_the_dragon_api.models.Character", b =>
                {
                    b.Property<int>("IdCharacter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCharacter"), 1L, 1);

                    b.Property<int>("Birth")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DragonIdDragon")
                        .HasColumnType("int");

                    b.Property<int>("HouseIdhouse")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCharacter");

                    b.HasIndex("DragonIdDragon");

                    b.HasIndex("HouseIdhouse");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("house_of_the_dragon_api.models.Dragon", b =>
                {
                    b.Property<int>("IdDragon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDragon"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDragon");

                    b.ToTable("Dragons");
                });

            modelBuilder.Entity("house_of_the_dragon_api.models.House", b =>
                {
                    b.Property<int>("IdHouse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHouse"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("home")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdHouse");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("house_of_the_dragon_api.models.BookCharacter", b =>
                {
                    b.HasOne("house_of_the_dragon_api.models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookIdBook")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("house_of_the_dragon_api.models.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterIdCharacter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Character");
                });

            modelBuilder.Entity("house_of_the_dragon_api.models.Character", b =>
                {
                    b.HasOne("house_of_the_dragon_api.models.Dragon", "Dragon")
                        .WithMany()
                        .HasForeignKey("DragonIdDragon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("house_of_the_dragon_api.models.House", "House")
                        .WithMany()
                        .HasForeignKey("HouseIdhouse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dragon");

                    b.Navigation("House");
                });
#pragma warning restore 612, 618
        }
    }
}
