﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarNoteWebAPICore.DataAccess;

namespace StarNoteWebAPICore.Migrations
{
    [DbContext(typeof(StarNoteEntity))]
    [Migration("20221008113804_V2")]
    partial class V2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("StarNoteWebAPICore.Models.CaseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Parameter")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_case");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.CompanyModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Companyadress")
                        .HasColumnType("text");

                    b.Property<string>("Companyname")
                        .HasColumnType("text");

                    b.Property<string>("Eposta")
                        .HasColumnType("text");

                    b.Property<string>("Taxname")
                        .HasColumnType("text");

                    b.Property<string>("Taxno")
                        .HasColumnType("text");

                    b.Property<string>("Tckimlik")
                        .HasColumnType("text");

                    b.Property<string>("Telefon")
                        .HasColumnType("text");

                    b.Property<string>("İlçe")
                        .HasColumnType("text");

                    b.Property<string>("İsim")
                        .HasColumnType("text");

                    b.Property<string>("Şehir")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_company");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.CostumerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adres")
                        .HasColumnType("text");

                    b.Property<string>("Eposta")
                        .HasColumnType("text");

                    b.Property<string>("Tckimlik")
                        .HasColumnType("text");

                    b.Property<string>("Telefon")
                        .HasColumnType("text");

                    b.Property<string>("İlçe")
                        .HasColumnType("text");

                    b.Property<string>("İsim")
                        .HasColumnType("text");

                    b.Property<string>("Şehir")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_costumer");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.CostumerOrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Acıklama")
                        .HasColumnType("text");

                    b.Property<string>("Adres")
                        .HasColumnType("text");

                    b.Property<double>("Beklenentutar")
                        .HasColumnType("double");

                    b.Property<string>("Durum")
                        .HasColumnType("text");

                    b.Property<string>("Eposta")
                        .HasColumnType("text");

                    b.Property<string>("Firmaadresi")
                        .HasColumnType("text");

                    b.Property<string>("Firmaadı")
                        .HasColumnType("text");

                    b.Property<string>("Kayıtdetay")
                        .HasColumnType("text");

                    b.Property<string>("Kayıtdetay1")
                        .HasColumnType("text");

                    b.Property<string>("Kayıtdetay2")
                        .HasColumnType("text");

                    b.Property<string>("Kayıttarihi")
                        .HasColumnType("text");

                    b.Property<string>("Kdv")
                        .HasColumnType("text");

                    b.Property<string>("Kullanıcı")
                        .HasColumnType("text");

                    b.Property<double>("Notergideri")
                        .HasColumnType("double");

                    b.Property<string>("Producthistory")
                        .HasColumnType("text");

                    b.Property<string>("Randevutarihi")
                        .HasColumnType("text");

                    b.Property<string>("Satıselemanı")
                        .HasColumnType("text");

                    b.Property<string>("Satışyöntemi")
                        .HasColumnType("text");

                    b.Property<int>("Savetype")
                        .HasColumnType("int");

                    b.Property<string>("Siparişno")
                        .HasColumnType("text");

                    b.Property<string>("Specialid")
                        .HasColumnType("text");

                    b.Property<string>("Talimatadliye")
                        .HasColumnType("text");

                    b.Property<string>("Talimatkararno")
                        .HasColumnType("text");

                    b.Property<string>("Talimatmahkeme")
                        .HasColumnType("text");

                    b.Property<string>("Tckimlik")
                        .HasColumnType("text");

                    b.Property<string>("Telefon")
                        .HasColumnType("text");

                    b.Property<string>("Tür")
                        .HasColumnType("text");

                    b.Property<string>("Türdetay")
                        .HasColumnType("text");

                    b.Property<string>("Vergidairesi")
                        .HasColumnType("text");

                    b.Property<string>("Vergino")
                        .HasColumnType("text");

                    b.Property<string>("Ödemeyöntemi")
                        .HasColumnType("text");

                    b.Property<double>("Önödeme")
                        .HasColumnType("double");

                    b.Property<double>("Ücret")
                        .HasColumnType("double");

                    b.Property<string>("İlçe")
                        .HasColumnType("text");

                    b.Property<string>("İsim")
                        .HasColumnType("text");

                    b.Property<string>("Şehir")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_customerorder");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.FilemanagementModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Dosyaadı")
                        .HasColumnType("text");

                    b.Property<string>("Firmadı")
                        .HasColumnType("text");

                    b.Property<string>("Kayıtdetay")
                        .HasColumnType("text");

                    b.Property<string>("Klasörno")
                        .HasColumnType("text");

                    b.Property<int>("Mainid")
                        .HasColumnType("int");

                    b.Property<string>("Müşteriadı")
                        .HasColumnType("text");

                    b.Property<string>("Türadı")
                        .HasColumnType("text");

                    b.Property<string>("Türdetay")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_filemanagement");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.JobOrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Acıklama")
                        .HasColumnType("text");

                    b.Property<string>("Birim")
                        .HasColumnType("text");

                    b.Property<string>("Durum")
                        .HasColumnType("text");

                    b.Property<int>("Hesaplananadet")
                        .HasColumnType("int");

                    b.Property<double>("Hesaplanantutar")
                        .HasColumnType("double");

                    b.Property<string>("Joborder")
                        .HasColumnType("text");

                    b.Property<int>("Karaktersayı")
                        .HasColumnType("int");

                    b.Property<int>("Kelimesayı")
                        .HasColumnType("int");

                    b.Property<int>("Lowerid")
                        .HasColumnType("int");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<int>("Satırsayı")
                        .HasColumnType("int");

                    b.Property<double>("Tavsiyeedilentutar")
                        .HasColumnType("double");

                    b.Property<double>("Ücret")
                        .HasColumnType("double");

                    b.Property<string>("Ürün")
                        .HasColumnType("text");

                    b.Property<string>("Ürün2")
                        .HasColumnType("text");

                    b.Property<string>("Ürün2detay")
                        .HasColumnType("text");

                    b.Property<int>("Üstid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tbl_joborder");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.KdvModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Parameter")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_kdvsource");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.LisanceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Durum")
                        .HasColumnType("text");

                    b.Property<string>("LisansAdı")
                        .HasColumnType("text");

                    b.Property<string>("Sonaermetarihi")
                        .HasColumnType("text");

                    b.Property<string>("Ürünanahtarı")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_lisance");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.PaymenttypeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Parameter")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_paymenttype");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.ProcesstypeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Parameter")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_processtype");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Parameter")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_product");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.RememberstatusModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Parameter")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_rememberstatus");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.RemembertypeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Parameter")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_remembertype");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.RemindingModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnaKayıt")
                        .HasColumnType("text");

                    b.Property<string>("AnaKayıtdetay")
                        .HasColumnType("text");

                    b.Property<int>("Anakayıtid")
                        .HasColumnType("int");

                    b.Property<string>("Hatırlatmadurumu")
                        .HasColumnType("text");

                    b.Property<string>("Hatırlatmamesajı")
                        .HasColumnType("text");

                    b.Property<string>("Hatırlatmatipi")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("tbl_remember");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.SalesmanModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Parameter")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_salesman");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.StokModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Alışfiyat")
                        .HasColumnType("double");

                    b.Property<string>("Birim")
                        .HasColumnType("text");

                    b.Property<string>("Kdv")
                        .HasColumnType("text");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<double>("Satışfiyat")
                        .HasColumnType("double");

                    b.Property<string>("Stokadı")
                        .HasColumnType("text");

                    b.Property<string>("Stokkod")
                        .HasColumnType("text");

                    b.Property<double>("İskonto")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("tbl_stok");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.TypeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Parameter")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_type");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.TypedetailModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Parameter")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_typedetail");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.UnitModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Parameter")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_unit");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.UsersModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Isactive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Kayıttarihi")
                        .HasColumnType("text");

                    b.Property<string>("Kullanıcıadi")
                        .HasColumnType("text");

                    b.Property<string>("Mailadres")
                        .HasColumnType("text");

                    b.Property<string>("Soyisim")
                        .HasColumnType("text");

                    b.Property<string>("Yetki")
                        .HasColumnType("text");

                    b.Property<string>("İsim")
                        .HasColumnType("text");

                    b.Property<string>("Şifre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tbl_users");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.partial_analysis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PRICE")
                        .HasColumnType("text");

                    b.Property<string>("RAN_DATE")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("partial_analysis");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.partial_saleschart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("PRICE")
                        .HasColumnType("double");

                    b.Property<string>("RAN_DATE")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("partial_saleschart");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.partial_salesman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PCS")
                        .HasColumnType("text");

                    b.Property<string>("PCSTYPE")
                        .HasColumnType("text");

                    b.Property<string>("PRICE")
                        .HasColumnType("text");

                    b.Property<string>("PRODUCT")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("partial_salesman");
                });

            modelBuilder.Entity("StarNoteWebAPICore.Models.partial_salespie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("COUNT")
                        .HasColumnType("int");

                    b.Property<string>("PAYMENT")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("partial_salespie");
                });
#pragma warning restore 612, 618
        }
    }
}
