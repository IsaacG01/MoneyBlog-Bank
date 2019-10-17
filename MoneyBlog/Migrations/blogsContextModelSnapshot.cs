﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoneyBlog.Models;

namespace MoneyBlog.Migrations
{
    [DbContext(typeof(blogsContext))]
    partial class blogsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoneyBlog.Models.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .HasColumnName("accountId")
                        .HasColumnType("int");

                    b.Property<string>("AccountName")
                        .HasColumnName("accountName")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int?>("AccountNumber")
                        .HasColumnName("accountNumber")
                        .HasColumnType("int");

                    b.Property<string>("AccountType")
                        .HasColumnName("accountType")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<decimal?>("Balance")
                        .HasColumnName("balance")
                        .HasColumnType("decimal(18, 0)");

                    b.ToTable("account");
                });

            modelBuilder.Entity("MoneyBlog.Models.Accounttransaction", b =>
                {
                    b.Property<int?>("AccountId")
                        .HasColumnName("accountId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Amount")
                        .HasColumnName("amount")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("Recipient")
                        .HasColumnName("recipient")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime?>("Time")
                        .HasColumnName("time")
                        .HasColumnType("datetime2");

                    b.Property<int>("TransactionId")
                        .HasColumnName("transactionId")
                        .HasColumnType("int");

                    b.ToTable("accounttransaction");
                });

            modelBuilder.Entity("MoneyBlog.Models.Post", b =>
                {
                    b.Property<string>("PostContent")
                        .HasColumnName("postContent")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int>("PostId")
                        .HasColumnName("postId")
                        .HasColumnType("int");

                    b.ToTable("post");
                });

            modelBuilder.Entity("MoneyBlog.Models.Transactiondispute", b =>
                {
                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int>("DisputeId")
                        .HasColumnName("disputeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Time")
                        .HasColumnName("time")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TransactionId")
                        .HasColumnName("transactionId")
                        .HasColumnType("int");

                    b.ToTable("transactiondispute");
                });

            modelBuilder.Entity("MoneyBlog.Models.UserInformation", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Firstname")
                        .HasColumnName("firstname")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Lastname")
                        .HasColumnName("lastname")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int>("Userid")
                        .HasColumnName("userid")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnName("username")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.ToTable("userInformation");
                });

            modelBuilder.Entity("MoneyBlog.Models.Useraccount", b =>
                {
                    b.Property<int?>("AccountId")
                        .HasColumnName("accountId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnName("userId")
                        .HasColumnType("int");

                    b.Property<string>("UserRole")
                        .HasColumnName("userRole")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.ToTable("useraccount");
                });
#pragma warning restore 612, 618
        }
    }
}
