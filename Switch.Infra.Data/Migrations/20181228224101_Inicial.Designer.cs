﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Switch.Infra.Data.Context;

namespace Switch.Infra.Data.Migrations
{
    [DbContext(typeof(SwitchContext))]
    [Migration("20181228224101_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Switch.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dataNascimento");

                    b.Property<string>("email");

                    b.Property<string>("nome");

                    b.Property<string>("senha");

                    b.Property<int>("sexo");

                    b.Property<string>("sobreNome");

                    b.Property<string>("urlFoto");

                    b.HasKey("id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
