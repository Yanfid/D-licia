// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Context;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(_dbContext))]
    partial class _dbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.BoletaModel", b =>
                {
                    b.Property<int>("Id_Boleta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Boleta"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Id_Venta")
                        .HasColumnType("int");

                    b.HasKey("Id_Boleta");

                    b.HasIndex("Id_Venta");

                    b.ToTable("Boleta");
                });

            modelBuilder.Entity("Models.CargoModel", b =>
                {
                    b.Property<int>("Id_Cargo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Cargo"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(65)
                        .HasColumnType("nvarchar(65)");

                    b.HasKey("Id_Cargo");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("Models.CategoriaModel", b =>
                {
                    b.Property<int>("Id_Categoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Categoria"), 1L, 1);

                    b.Property<int>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("Id_Categoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Models.EmpleadoModel", b =>
                {
                    b.Property<int>("Id_Empleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Empleado"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Id_Cargo")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id_Empleado");

                    b.HasIndex("Id_Cargo");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("Models.Materia_primaModel", b =>
                {
                    b.Property<int>("id_MPrima")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_MPrima"), 1L, 1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Empleado")
                        .HasColumnType("int");

                    b.Property<int>("Id_Medida")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("id_MPrima");

                    b.HasIndex("Id_Empleado");

                    b.HasIndex("Id_Medida");

                    b.ToTable("Materia_Prima");
                });

            modelBuilder.Entity("Models.PedidoModel", b =>
                {
                    b.Property<int>("Id_pedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_pedido"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Direccion_envio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Id_Producto")
                        .HasColumnType("int");

                    b.Property<string>("Nombre_envio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Precio_total")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id_pedido");

                    b.HasIndex("Id_Producto");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Models.ProductosModel", b =>
                {
                    b.Property<int>("Id_Producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Producto"), 1L, 1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Id_Categoria")
                        .HasColumnType("int");

                    b.Property<int>("Id_MPrima")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("Id_Producto");

                    b.HasIndex("Id_Categoria");

                    b.HasIndex("Id_MPrima");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Models.Uni_MedidaModel", b =>
                {
                    b.Property<int>("Id_Medida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Medida"), 1L, 1);

                    b.Property<string>("T_Medida")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Medida");

                    b.ToTable("Uni_Medida");
                });

            modelBuilder.Entity("Models.VentaModel", b =>
                {
                    b.Property<int>("Id_Venta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Venta"), 1L, 1);

                    b.Property<int>("Id_Pedido")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_Venta");

                    b.HasIndex("Id_Pedido");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("Models.BoletaModel", b =>
                {
                    b.HasOne("Models.VentaModel", "Venta")
                        .WithMany()
                        .HasForeignKey("Id_Venta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("Models.EmpleadoModel", b =>
                {
                    b.HasOne("Models.CargoModel", "Cargo")
                        .WithMany()
                        .HasForeignKey("Id_Cargo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("Models.Materia_primaModel", b =>
                {
                    b.HasOne("Models.EmpleadoModel", "Empleado")
                        .WithMany()
                        .HasForeignKey("Id_Empleado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Uni_MedidaModel", "Uni_Medida")
                        .WithMany()
                        .HasForeignKey("Id_Medida")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");

                    b.Navigation("Uni_Medida");
                });

            modelBuilder.Entity("Models.PedidoModel", b =>
                {
                    b.HasOne("Models.ProductosModel", "Productos")
                        .WithMany()
                        .HasForeignKey("Id_Producto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Models.ProductosModel", b =>
                {
                    b.HasOne("Models.CategoriaModel", "Categoria")
                        .WithMany()
                        .HasForeignKey("Id_Categoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Materia_primaModel", "Materia_Prima")
                        .WithMany()
                        .HasForeignKey("Id_MPrima")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Materia_Prima");
                });

            modelBuilder.Entity("Models.VentaModel", b =>
                {
                    b.HasOne("Models.PedidoModel", "Pedido")
                        .WithMany()
                        .HasForeignKey("Id_Pedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
                });
#pragma warning restore 612, 618
        }
    }
}
