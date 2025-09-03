using System;
using System.Collections.Generic;
using Esamsat.Models;
using Microsoft.EntityFrameworkCore;

namespace Esamsat.Db;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appgroupuser> Appgroupusers { get; set; }

    public virtual DbSet<Appotor> Appotors { get; set; }

    public virtual DbSet<Approle> Approles { get; set; }

    public virtual DbSet<Appuser> Appusers { get; set; }

    public virtual DbSet<Jnsdok> Jnsdoks { get; set; }

    public virtual DbSet<Jnsgolongan> Jnsgolongans { get; set; }

    public virtual DbSet<Jnsguna> Jnsgunas { get; set; }

    public virtual DbSet<Jnshist> Jnshists { get; set; }

    public virtual DbSet<Jnsjr> Jnsjrs { get; set; }

    public virtual DbSet<Jnskatkendaraan> Jnskatkendaraans { get; set; }

    public virtual DbSet<Jnskendaraan> Jnskendaraans { get; set; }

    public virtual DbSet<Jnsmilik> Jnsmiliks { get; set; }

    public virtual DbSet<Jnspajak> Jnspajaks { get; set; }

    public virtual DbSet<Jnsplat> Jnsplats { get; set; }

    public virtual DbSet<Jnsprogresif> Jnsprogresifs { get; set; }

    public virtual DbSet<Jnsranmor> Jnsranmors { get; set; }

    public virtual DbSet<Jnsstrurek> Jnsstrureks { get; set; }

    public virtual DbSet<Jnstarif> Jnstarifs { get; set; }

    public virtual DbSet<Jnsumum> Jnsumums { get; set; }

    public virtual DbSet<Mapjnspendapatan> Mapjnspendapatans { get; set; }

    public virtual DbSet<Masterbadan> Masterbadans { get; set; }

    public virtual DbSet<Masterbank> Masterbanks { get; set; }

    public virtual DbSet<Masterbbm> Masterbbms { get; set; }

    public virtual DbSet<Masterbendahara> Masterbendaharas { get; set; }

    public virtual DbSet<Masterflow> Masterflows { get; set; }

    public virtual DbSet<Masterhapusdendum> Masterhapusdenda { get; set; }

    public virtual DbSet<Masterjabttd> Masterjabttds { get; set; }

    public virtual DbSet<Masterjnspendapatan> Masterjnspendapatans { get; set; }

    public virtual DbSet<Masterkabkotaall> Masterkabkotaalls { get; set; }

    public virtual DbSet<Masterkabkotum> Masterkabkota { get; set; }

    public virtual DbSet<Masterkaupt> Masterkaupts { get; set; }

    public virtual DbSet<Masterkecamatan> Masterkecamatans { get; set; }

    public virtual DbSet<Masterkelurahan> Masterkelurahans { get; set; }

    public virtual DbSet<Masterkiosk> Masterkiosks { get; set; }

    public virtual DbSet<Masterktp> Masterktps { get; set; }

    public virtual DbSet<Masterlibur> Masterliburs { get; set; }

    public virtual DbSet<Mastermerk> Mastermerks { get; set; }

    public virtual DbSet<Masternpwpd> Masternpwpds { get; set; }

    public virtual DbSet<Masterpegawai> Masterpegawais { get; set; }

    public virtual DbSet<Masterprovinsi> Masterprovinsis { get; set; }

    public virtual DbSet<Masterrekd> Masterrekds { get; set; }

    public virtual DbSet<Masterreknrc> Masterreknrcs { get; set; }

    public virtual DbSet<Masterrt> Masterrts { get; set; }

    public virtual DbSet<Masterrw> Masterrws { get; set; }

    public virtual DbSet<Mastertarif> Mastertarifs { get; set; }

    public virtual DbSet<Mastertarifnjop> Mastertarifnjops { get; set; }

    public virtual DbSet<Mastertek> Masterteks { get; set; }

    public virtual DbSet<Masterupt> Masterupts { get; set; }

    public virtual DbSet<Masteruunjop> Masteruunjops { get; set; }

    public virtual DbSet<Masterwp> Masterwps { get; set; }

    public virtual DbSet<Masterwpdatum> Masterwpdata { get; set; }

    public virtual DbSet<Transdatakohir> Transdatakohirs { get; set; }

    public virtual DbSet<Transpendataan> Transpendataans { get; set; }

    public virtual DbSet<Transpendataandet> Transpendataandets { get; set; }

    public virtual DbSet<Transpenetapan> Transpenetapans { get; set; }

    public virtual DbSet<Transst> Transsts { get; set; }

    public virtual DbSet<Transstsdet> Transstsdets { get; set; }

    public virtual DbSet<Transwpdataantri> Transwpdataantris { get; set; }

    public virtual DbSet<Transwpdatafile> Transwpdatafiles { get; set; }

    public virtual DbSet<Transwpdatum> Transwpdata { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-KQ6H7VF\\SQL2017IKHLAS;Initial Catalog=V@LID49_SAMSAT;User ID=sa;Password=Teknologicanggih123;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appgroupuser>(entity =>
        {
            entity.HasKey(e => e.Kdgroup).HasName("PK_APPGROUPUER");

            entity.ToTable("APPGROUPUSER");

            entity.Property(e => e.Kdgroup)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KDGROUP");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Ket)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KET");
            entity.Property(e => e.Nmgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NMGROUP");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Appotor>(entity =>
        {
            entity.HasKey(e => new { e.Kdgroup, e.Roleid });

            entity.ToTable("APPOTOR");

            entity.Property(e => e.Kdgroup)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KDGROUP");
            entity.Property(e => e.Roleid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ROLEID");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.KdgroupNavigation).WithMany(p => p.Appotors)
                .HasForeignKey(d => d.Kdgroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPOTOR_APPGROUPUSER");

            entity.HasOne(d => d.Role).WithMany(p => p.Appotors)
                .HasForeignKey(d => d.Roleid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPOTOR_APPROLE");
        });

        modelBuilder.Entity<Approle>(entity =>
        {
            entity.HasKey(e => e.Roleid);

            entity.ToTable("APPROLE");

            entity.Property(e => e.Roleid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ROLEID");
            entity.Property(e => e.Bantuan)
                .HasMaxLength(255)
                .HasColumnName("BANTUAN");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Icon)
                .HasMaxLength(255)
                .HasColumnName("ICON");
            entity.Property(e => e.Idapp).HasColumnName("IDAPP");
            entity.Property(e => e.Kdlevel).HasColumnName("KDLEVEL");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("LINK");
            entity.Property(e => e.Menuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MENUID");
            entity.Property(e => e.Parentid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PARENTID");
            entity.Property(e => e.Role)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("ROLE");
            entity.Property(e => e.Show).HasColumnName("SHOW");
            entity.Property(e => e.Type)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TYPE");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Appuser>(entity =>
        {
            entity.HasKey(e => e.Userid);

            entity.ToTable("APPUSER");

            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERID");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Idpeg).HasColumnName("IDPEG");
            entity.Property(e => e.Idupt).HasColumnName("IDUPT");
            entity.Property(e => e.Kdgroup)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KDGROUP");
            entity.Property(e => e.Kdtahap)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDTAHAP");
            entity.Property(e => e.Nama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAMA");
            entity.Property(e => e.Nik)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIK");
            entity.Property(e => e.Pwd)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PWD");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IduptNavigation).WithMany(p => p.Appusers)
                .HasForeignKey(d => d.Idupt)
                .HasConstraintName("FK_APPUSER_MASTERUPT");
        });

        modelBuilder.Entity<Jnsdok>(entity =>
        {
            entity.HasKey(e => e.Kddok);

            entity.ToTable("JNSDOK");

            entity.Property(e => e.Kddok)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KDDOK");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Kterangan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KTERANGAN");
            entity.Property(e => e.Namadok)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAMADOK");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Jnsgolongan>(entity =>
        {
            entity.HasKey(e => e.Jnsgolid);

            entity.ToTable("JNSGOLONGAN");

            entity.Property(e => e.Jnsgolid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JNSGOLID");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Golongan)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GOLONGAN");
            entity.Property(e => e.Jnskendid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JNSKENDID");
            entity.Property(e => e.Katid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KATID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
            entity.Property(e => e.Viewall)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VIEWALL");

            entity.HasOne(d => d.Jnskend).WithMany(p => p.Jnsgolongans)
                .HasForeignKey(d => d.Jnskendid)
                .HasConstraintName("FK_JNSGOLONGAN_JNSKENDARAAN");

            entity.HasOne(d => d.Kat).WithMany(p => p.Jnsgolongans)
                .HasForeignKey(d => d.Katid)
                .HasConstraintName("FK_JNSGOLONGAN_JNSKATKENDARAAN");
        });

        modelBuilder.Entity<Jnsguna>(entity =>
        {
            entity.HasKey(e => e.Kdguna);

            entity.ToTable("JNSGUNA");

            entity.Property(e => e.Kdguna)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KDGUNA");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Groupbpkb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GROUPBPKB");
            entity.Property(e => e.Guna)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GUNA");
            entity.Property(e => e.Gunaplat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GUNAPLAT");
            entity.Property(e => e.Progresif)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PROGRESIF");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Jnshist>(entity =>
        {
            entity.HasKey(e => e.Kdhist);

            entity.ToTable("JNSHIST");

            entity.Property(e => e.Kdhist)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDHIST");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Kdflow)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDFLOW");
            entity.Property(e => e.Nmhist)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NMHIST");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Jnsjr>(entity =>
        {
            entity.ToTable("JNSJR");

            entity.Property(e => e.Jnsjrid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JNSJRID");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Goljns)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GOLJNS");
            entity.Property(e => e.Kodejr)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KODEJR");
            entity.Property(e => e.Kterangan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KTERANGAN");
            entity.Property(e => e.Pu)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PU");
            entity.Property(e => e.Roda).HasColumnName("RODA");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Jnskatkendaraan>(entity =>
        {
            entity.HasKey(e => e.Katid);

            entity.ToTable("JNSKATKENDARAAN");

            entity.Property(e => e.Katid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KATID");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Jenisbpkb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("JENISBPKB");
            entity.Property(e => e.Kendaraan)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KENDARAAN");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Jnskendaraan>(entity =>
        {
            entity.HasKey(e => e.Jnskendid);

            entity.ToTable("JNSKENDARAAN");

            entity.Property(e => e.Jnskendid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JNSKENDID");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Golpjr).HasColumnName("GOLPJR");
            entity.Property(e => e.Golujr).HasColumnName("GOLUJR");
            entity.Property(e => e.Jnsjrid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JNSJRID");
            entity.Property(e => e.Jnskend)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("JNSKEND");
            entity.Property(e => e.Katid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KATID");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.Jnsjr).WithMany(p => p.Jnskendaraans)
                .HasForeignKey(d => d.Jnsjrid)
                .HasConstraintName("FK_JNSKENDARAAN_JNSJR");
        });

        modelBuilder.Entity<Jnsmilik>(entity =>
        {
            entity.HasKey(e => e.Kdmilik);

            entity.ToTable("JNSMILIK");

            entity.Property(e => e.Kdmilik)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KDMILIK");
            entity.Property(e => e.Bpkpid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("BPKPID");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Milik)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MILIK");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Jnspajak>(entity =>
        {
            entity.HasKey(e => e.Kdjnspjk);

            entity.ToTable("JNSPAJAK");

            entity.Property(e => e.Kdjnspjk)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KDJNSPJK");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Kterangan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KTERANGAN");
            entity.Property(e => e.Nmjnspjk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NMJNSPJK");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Jnsplat>(entity =>
        {
            entity.HasKey(e => e.Kdplat);

            entity.ToTable("JNSPLAT");

            entity.Property(e => e.Kdplat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KDPLAT");
            entity.Property(e => e.AbBbn1)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AbBBN1");
            entity.Property(e => e.AbBbn2)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AbBBN2");
            entity.Property(e => e.AbPkb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AbPKB");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.DnumBbn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DNumBBN");
            entity.Property(e => e.DnumPkb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DNumPKB");
            entity.Property(e => e.DumBrg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DUmBrg");
            entity.Property(e => e.DumOrg)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DUmOrg");
            entity.Property(e => e.MinNumBbn1)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MinNumBBN1");
            entity.Property(e => e.MinNumBbn2)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MinNumBBN2");
            entity.Property(e => e.MinNumPkb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("MinNumPKB");
            entity.Property(e => e.NumBbn1)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("NumBBN1");
            entity.Property(e => e.NumBbn2)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("NumBBN2");
            entity.Property(e => e.NumFiskal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NumPkb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("NumPKB");
            entity.Property(e => e.OpsBbn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OpsBBN");
            entity.Property(e => e.OpsDnumBbn)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OpsDNumBBN");
            entity.Property(e => e.OpsDnumPkb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OpsDNumPKB");
            entity.Property(e => e.OpsNumBbn1)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OpsNumBBN1");
            entity.Property(e => e.OpsNumBbn2)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OpsNumBBN2");
            entity.Property(e => e.OpsNumPkb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OpsNumPKB");
            entity.Property(e => e.OpsPkb)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OpsPKB");
            entity.Property(e => e.Plat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PLAT");
            entity.Property(e => e.PlatJr).HasColumnName("PlatJR");
            entity.Property(e => e.Pu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PU");
            entity.Property(e => e.Snid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SNID");
            entity.Property(e => e.UmBrg).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UmOrg).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Jnsprogresif>(entity =>
        {
            entity.HasKey(e => e.Kdprogresif);

            entity.ToTable("JNSPROGRESIF");

            entity.Property(e => e.Kdprogresif)
                .ValueGeneratedNever()
                .HasColumnName("KDPROGRESIF");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Progresif)
                .HasColumnType("decimal(28, 2)")
                .HasColumnName("PROGRESIF");
            entity.Property(e => e.Progresifr4)
                .HasColumnType("decimal(28, 2)")
                .HasColumnName("PROGRESIFR4");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Jnsranmor>(entity =>
        {
            entity.HasKey(e => e.Kdranmor);

            entity.ToTable("JNSRANMOR");

            entity.Property(e => e.Kdranmor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDRANMOR");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Nmranmor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NMRANMOR");
            entity.Property(e => e.Snid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SNID");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Jnsstrurek>(entity =>
        {
            entity.HasKey(e => e.Mtglevel);

            entity.ToTable("JNSSTRUREK");

            entity.Property(e => e.Mtglevel)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MTGLEVEL");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Kterangan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KTERANGAN");
            entity.Property(e => e.Nmlevel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NMLEVEL");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Jnstarif>(entity =>
        {
            entity.HasKey(e => e.Kdjnstarif);

            entity.ToTable("JNSTARIF");

            entity.Property(e => e.Kdjnstarif)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDJNSTARIF");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idrekd).HasColumnName("IDREKD");
            entity.Property(e => e.Idupt).HasColumnName("IDUPT");
            entity.Property(e => e.Jnskendid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JNSKENDID");
            entity.Property(e => e.Nmjnstarif)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NMJNSTARIF");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdrekdNavigation).WithMany(p => p.Jnstarifs)
                .HasForeignKey(d => d.Idrekd)
                .HasConstraintName("FK_JNSTARIF_MASTERREKD");

            entity.HasOne(d => d.IduptNavigation).WithMany(p => p.Jnstarifs)
                .HasForeignKey(d => d.Idupt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JNSTARIF_MASTERUPT");

            entity.HasOne(d => d.Jnskend).WithMany(p => p.Jnstarifs)
                .HasForeignKey(d => d.Jnskendid)
                .HasConstraintName("FK_JNSTARIF_JNSKENDARAAN");
        });

        modelBuilder.Entity<Jnsumum>(entity =>
        {
            entity.HasKey(e => e.Kdumum);

            entity.ToTable("JNSUMUM");

            entity.Property(e => e.Kdumum)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDUMUM");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KETERANGAN");
            entity.Property(e => e.Nmumum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NMUMUM");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Mapjnspendapatan>(entity =>
        {
            entity.HasKey(e => e.Idmapjnsd);

            entity.ToTable("MAPJNSPENDAPATAN");

            entity.Property(e => e.Idmapjnsd).HasColumnName("IDMAPJNSD");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idrekbbnkb).HasColumnName("IDREKBBNKB");
            entity.Property(e => e.Idrekopsenbbnkb).HasColumnName("IDREKOPSENBBNKB");
            entity.Property(e => e.Idrekopsenpkb).HasColumnName("IDREKOPSENPKB");
            entity.Property(e => e.Idrekpkb).HasColumnName("IDREKPKB");
            entity.Property(e => e.Idrekpnbp).HasColumnName("IDREKPNBP");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KETERANGAN");
            entity.Property(e => e.Nmjnspendapatan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NMJNSPENDAPATAN");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdrekbbnkbNavigation).WithMany(p => p.MapjnspendapatanIdrekbbnkbNavigations)
                .HasForeignKey(d => d.Idrekbbnkb)
                .HasConstraintName("FK_MAPJNSPENDAPATAN_MASTERREKD1");

            entity.HasOne(d => d.IdrekopsenbbnkbNavigation).WithMany(p => p.MapjnspendapatanIdrekopsenbbnkbNavigations)
                .HasForeignKey(d => d.Idrekopsenbbnkb)
                .HasConstraintName("FK_MAPJNSPENDAPATAN_MASTERREKD3");

            entity.HasOne(d => d.IdrekopsenpkbNavigation).WithMany(p => p.MapjnspendapatanIdrekopsenpkbNavigations)
                .HasForeignKey(d => d.Idrekopsenpkb)
                .HasConstraintName("FK_MAPJNSPENDAPATAN_MASTERREKD2");

            entity.HasOne(d => d.IdrekpkbNavigation).WithMany(p => p.MapjnspendapatanIdrekpkbNavigations)
                .HasForeignKey(d => d.Idrekpkb)
                .HasConstraintName("FK_MAPJNSPENDAPATAN_MASTERREKD");

            entity.HasOne(d => d.IdrekpnbpNavigation).WithMany(p => p.MapjnspendapatanIdrekpnbpNavigations)
                .HasForeignKey(d => d.Idrekpnbp)
                .HasConstraintName("FK_MAPJNSPENDAPATAN_MASTERREKD4");
        });

        modelBuilder.Entity<Masterbadan>(entity =>
        {
            entity.HasKey(e => e.Idbadan);

            entity.ToTable("MASTERBADAN");

            entity.Property(e => e.Idbadan).HasColumnName("IDBADAN");
            entity.Property(e => e.Alamat)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ALAMAT");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idkabkokta).HasColumnName("IDKABKOKTA");
            entity.Property(e => e.Idktp).HasColumnName("IDKTP");
            entity.Property(e => e.Idprovinsi).HasColumnName("IDPROVINSI");
            entity.Property(e => e.Ket)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KET");
            entity.Property(e => e.Namabadan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAMABADAN");
            entity.Property(e => e.Nib)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIB");
            entity.Property(e => e.Nohp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOHP");
            entity.Property(e => e.Tgldaftar)
                .HasColumnType("datetime")
                .HasColumnName("TGLDAFTAR");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdkabkoktaNavigation).WithMany(p => p.Masterbadans)
                .HasForeignKey(d => d.Idkabkokta)
                .HasConstraintName("FK_MASTERBADAN_MASTERKABKOTA");

            entity.HasOne(d => d.IdktpNavigation).WithMany(p => p.Masterbadans)
                .HasForeignKey(d => d.Idktp)
                .HasConstraintName("FK_MASTERBADAN_MASTERKTP");

            entity.HasOne(d => d.IdprovinsiNavigation).WithMany(p => p.Masterbadans)
                .HasForeignKey(d => d.Idprovinsi)
                .HasConstraintName("FK_MASTERBADAN_MASTERPROVINSI");
        });

        modelBuilder.Entity<Masterbank>(entity =>
        {
            entity.HasKey(e => e.Idbank);

            entity.ToTable("MASTERBANK");

            entity.HasIndex(e => e.Kodebank, "UC_MASTERBANK");

            entity.Property(e => e.Idbank).HasColumnName("IDBANK");
            entity.Property(e => e.Akronimbank)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AKRONIMBANK");
            entity.Property(e => e.Alamatbank)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALAMATBANK");
            entity.Property(e => e.Cabangbank)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CABANGBANK");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Kodebank)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODEBANK");
            entity.Property(e => e.Namabank)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAMABANK");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Masterbbm>(entity =>
        {
            entity.HasKey(e => e.Kodebbm);

            entity.ToTable("MASTERBBM");

            entity.Property(e => e.Kodebbm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODEBBM");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Ket)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KET");
            entity.Property(e => e.Namabbm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAMABBM");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Masterbendahara>(entity =>
        {
            entity.HasKey(e => e.Idbend);

            entity.ToTable("MASTERBENDAHARA");

            entity.Property(e => e.Idbend).HasColumnName("IDBEND");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idbank).HasColumnName("IDBANK");
            entity.Property(e => e.Idpegawai).HasColumnName("IDPEGAWAI");
            entity.Property(e => e.Idreknrc).HasColumnName("IDREKNRC");
            entity.Property(e => e.Jabatan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("JABATAN");
            entity.Property(e => e.Jnsbend)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("JNSBEND");
            entity.Property(e => e.Ket)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KET");
            entity.Property(e => e.Koordinator).HasColumnName("KOORDINATOR");
            entity.Property(e => e.Namarek)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAMAREK");
            entity.Property(e => e.Norek)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOREK");
            entity.Property(e => e.Pangkat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PANGKAT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Telepon)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TELEPON");
            entity.Property(e => e.Uid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UID");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdbankNavigation).WithMany(p => p.Masterbendaharas)
                .HasForeignKey(d => d.Idbank)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERBENDAHARA_MASTERBANK");

            entity.HasOne(d => d.IdpegawaiNavigation).WithMany(p => p.Masterbendaharas)
                .HasForeignKey(d => d.Idpegawai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERBENDAHARA_MASTERPEGAWAI");

            entity.HasOne(d => d.IdreknrcNavigation).WithMany(p => p.Masterbendaharas)
                .HasForeignKey(d => d.Idreknrc)
                .HasConstraintName("FK_MASTERBENDAHARA_MASTERREKNRC");

            entity.HasOne(d => d.KoordinatorNavigation).WithMany(p => p.Masterbendaharas)
                .HasForeignKey(d => d.Koordinator)
                .HasConstraintName("FK_MASTERBENDAHARA_MASTERUPT");
        });

        modelBuilder.Entity<Masterflow>(entity =>
        {
            entity.HasKey(e => e.Kdflow);

            entity.ToTable("MASTERFLOW");

            entity.Property(e => e.Kdflow)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KDFLOW");
            entity.Property(e => e.AtbKend)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Bataslayanan).HasColumnName("BATASLAYANAN");
            entity.Property(e => e.Bbn1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("BBN1");
            entity.Property(e => e.Bbn2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("BBN2");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.FlowJr)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FlowJR");
            entity.Property(e => e.Nmflow)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NMFLOW");
            entity.Property(e => e.Perpanjangstnk)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PERPANJANGSTNK");
            entity.Property(e => e.Pkb)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PKB");
            entity.Property(e => e.Potongan)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("POTONGAN");
            entity.Property(e => e.Sahstnk)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SAHSTNK");
            entity.Property(e => e.Satuan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SATUAN");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Stnkbaru)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("STNKBaru");
            entity.Property(e => e.Swd)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SWD");
            entity.Property(e => e.Tnkb)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TNKB");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Masterhapusdendum>(entity =>
        {
            entity.HasKey(e => e.Idhapusdenda);

            entity.ToTable("MASTERHAPUSDENDA");

            entity.Property(e => e.Idhapusdenda).HasColumnName("IDHAPUSDENDA");
            entity.Property(e => e.Akhir)
                .HasColumnType("datetime")
                .HasColumnName("AKHIR");
            entity.Property(e => e.Awal)
                .HasColumnType("datetime")
                .HasColumnName("AWAL");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Jenis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JENIS");
            entity.Property(e => e.Ket)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KET");
            entity.Property(e => e.Nilai)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NILAI");
            entity.Property(e => e.Satuan)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SATUAN");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
            entity.Property(e => e.Uraian)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("URAIAN");
        });

        modelBuilder.Entity<Masterjabttd>(entity =>
        {
            entity.HasKey(e => e.Idjabttd);

            entity.ToTable("MASTERJABTTD");

            entity.Property(e => e.Idjabttd).HasColumnName("IDJABTTD");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idpegawai).HasColumnName("IDPEGAWAI");
            entity.Property(e => e.Jabatan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JABATAN");
            entity.Property(e => e.Kddok)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KDDOK");
            entity.Property(e => e.Ket)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KET");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdpegawaiNavigation).WithMany(p => p.Masterjabttds)
                .HasForeignKey(d => d.Idpegawai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERJABTTD_MASTERPEGAWAI");

            entity.HasOne(d => d.KddokNavigation).WithMany(p => p.Masterjabttds)
                .HasForeignKey(d => d.Kddok)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERJABTTD_JNSDOK");
        });

        modelBuilder.Entity<Masterjnspendapatan>(entity =>
        {
            entity.HasKey(e => e.Idjnsd);

            entity.ToTable("MASTERJNSPENDAPATAN");

            entity.Property(e => e.Idjnsd).HasColumnName("IDJNSD");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Jatuhtempo).HasColumnName("JATUHTEMPO");
            entity.Property(e => e.Kdrek)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KDREK");
            entity.Property(e => e.Nmjnspendapatan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NMJNSPENDAPATAN");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Selfassessment)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SELFASSESSMENT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Masterkabkotaall>(entity =>
        {
            entity.HasKey(e => e.Idkabkotaall);

            entity.ToTable("MASTERKABKOTAALL");

            entity.Property(e => e.Idkabkotaall).HasColumnName("IDKABKOTAALL");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idprovinsi).HasColumnName("IDPROVINSI");
            entity.Property(e => e.Kdkabkota)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("KDKABKOTA");
            entity.Property(e => e.Nmkabkota)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NMKABKOTA");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdprovinsiNavigation).WithMany(p => p.Masterkabkotaalls)
                .HasForeignKey(d => d.Idprovinsi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERKABKOTAALL_MASTERPROVINSI");
        });

        modelBuilder.Entity<Masterkabkotum>(entity =>
        {
            entity.HasKey(e => e.Idkabkota);

            entity.ToTable("MASTERKABKOTA");

            entity.Property(e => e.Idkabkota).HasColumnName("IDKABKOTA");
            entity.Property(e => e.Akronim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AKRONIM");
            entity.Property(e => e.Bpkbid)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("BPKBID");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Ibukota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IBUKOTA");
            entity.Property(e => e.Idprovinsi).HasColumnName("IDPROVINSI");
            entity.Property(e => e.Kdkabkota)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDKABKOTA");
            entity.Property(e => e.Nmkabkota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NMKABKOTA");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdprovinsiNavigation).WithMany(p => p.Masterkabkota)
                .HasForeignKey(d => d.Idprovinsi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERKABKOTA_MASTERPROVINSI");
        });

        modelBuilder.Entity<Masterkaupt>(entity =>
        {
            entity.HasKey(e => e.Idkaupt);

            entity.ToTable("MASTERKAUPT");

            entity.Property(e => e.Idkaupt).HasColumnName("IDKAUPT");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idpegawai).HasColumnName("IDPEGAWAI");
            entity.Property(e => e.Idupt).HasColumnName("IDUPT");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdpegawaiNavigation).WithMany(p => p.Masterkaupts)
                .HasForeignKey(d => d.Idpegawai)
                .HasConstraintName("FK_MASTERKAUPT_MASTERPEGAWAI");

            entity.HasOne(d => d.IduptNavigation).WithMany(p => p.Masterkaupts)
                .HasForeignKey(d => d.Idupt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERKAUPT_MASTERUPT");
        });

        modelBuilder.Entity<Masterkecamatan>(entity =>
        {
            entity.HasKey(e => e.Idkecamatan);

            entity.ToTable("MASTERKECAMATAN");

            entity.Property(e => e.Idkecamatan).HasColumnName("IDKECAMATAN");
            entity.Property(e => e.Alamat)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALAMAT");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.Idkabkota).HasColumnName("IDKABKOTA");
            entity.Property(e => e.Kdkecamatan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDKECAMATAN");
            entity.Property(e => e.Nmkecamatan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NMKECAMATAN");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Telepon)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TELEPON");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdkabkotaNavigation).WithMany(p => p.Masterkecamatans)
                .HasForeignKey(d => d.Idkabkota)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERKECAMATAN_MASTERKABKOTA");
        });

        modelBuilder.Entity<Masterkelurahan>(entity =>
        {
            entity.HasKey(e => e.Idkelurahan);

            entity.ToTable("MASTERKELURAHAN");

            entity.Property(e => e.Idkelurahan).HasColumnName("IDKELURAHAN");
            entity.Property(e => e.Alamat)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALAMAT");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idkecamatan).HasColumnName("IDKECAMATAN");
            entity.Property(e => e.Kdkelurahan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDKELURAHAN");
            entity.Property(e => e.Kodepos)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KODEPOS");
            entity.Property(e => e.Nmkelurahan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NMKELURAHAN");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Telepon)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TELEPON");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdkecamatanNavigation).WithMany(p => p.Masterkelurahans)
                .HasForeignKey(d => d.Idkecamatan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERKELURAHAN_MASTERKECAMATAN");
        });

        modelBuilder.Entity<Masterkiosk>(entity =>
        {
            entity.HasKey(e => e.Idkios);

            entity.ToTable("MASTERKIOSK");

            entity.Property(e => e.Idkios).HasColumnName("IDKIOS");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Datakiosk)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DATAKIOSK");
            entity.Property(e => e.Idparent).HasColumnName("IDPARENT");
            entity.Property(e => e.Kodekiosk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KODEKIOSK");
            entity.Property(e => e.Level)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEVEL");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Masterktp>(entity =>
        {
            entity.HasKey(e => e.Idktp);

            entity.ToTable("MASTERKTP");

            entity.Property(e => e.Idktp).HasColumnName("IDKTP");
            entity.Property(e => e.Agama).HasColumnName("AGAMA");
            entity.Property(e => e.Alamat)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ALAMAT");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Dusun)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DUSUN");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Goldarah)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("GOLDARAH");
            entity.Property(e => e.Idkabkokta).HasColumnName("IDKABKOKTA");
            entity.Property(e => e.Idkecamatan).HasColumnName("IDKECAMATAN");
            entity.Property(e => e.Idkelurahan).HasColumnName("IDKELURAHAN");
            entity.Property(e => e.Idprovinsi).HasColumnName("IDPROVINSI");
            entity.Property(e => e.Idrt).HasColumnName("IDRT");
            entity.Property(e => e.Idrw).HasColumnName("IDRW");
            entity.Property(e => e.Jeniskelamin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JENISKELAMIN");
            entity.Property(e => e.Kdrt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KDRT");
            entity.Property(e => e.Ket)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KET");
            entity.Property(e => e.Nama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAMA");
            entity.Property(e => e.Namaayah)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAMAAYAH");
            entity.Property(e => e.Namaibu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAMAIBU");
            entity.Property(e => e.Negara)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NEGARA");
            entity.Property(e => e.Nik)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIK");
            entity.Property(e => e.Nikah).HasColumnName("NIKAH");
            entity.Property(e => e.Nip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIP");
            entity.Property(e => e.Nobpjs)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOBPJS");
            entity.Property(e => e.Nohp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOHP");
            entity.Property(e => e.Nokk)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOKK");
            entity.Property(e => e.Pekerjaan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PEKERJAAN");
            entity.Property(e => e.Pendidikan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PENDIDIKAN");
            entity.Property(e => e.Statint)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATINT");
            entity.Property(e => e.Statwn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATWN");
            entity.Property(e => e.Tempatlahir)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TEMPATLAHIR");
            entity.Property(e => e.Tgldaftar)
                .HasColumnType("datetime")
                .HasColumnName("TGLDAFTAR");
            entity.Property(e => e.Tglint)
                .HasColumnType("datetime")
                .HasColumnName("TGLINT");
            entity.Property(e => e.Tgllahir)
                .HasColumnType("datetime")
                .HasColumnName("TGLLAHIR");
            entity.Property(e => e.Tglregistrasi)
                .HasColumnType("datetime")
                .HasColumnName("TGLREGISTRASI");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdkabkoktaNavigation).WithMany(p => p.Masterktps)
                .HasForeignKey(d => d.Idkabkokta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERKTP_MASTERKABKOTAALL");

            entity.HasOne(d => d.IdkecamatanNavigation).WithMany(p => p.Masterktps)
                .HasForeignKey(d => d.Idkecamatan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERKTP_MASTERKECAMATAN");

            entity.HasOne(d => d.IdkelurahanNavigation).WithMany(p => p.Masterktps)
                .HasForeignKey(d => d.Idkelurahan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERKTP_MASTERKELURAHAN");

            entity.HasOne(d => d.IdprovinsiNavigation).WithMany(p => p.Masterktps)
                .HasForeignKey(d => d.Idprovinsi)
                .HasConstraintName("FK_MASTERKTP_MASTERPROVINSI");

            entity.HasOne(d => d.IdrtNavigation).WithMany(p => p.Masterktps)
                .HasForeignKey(d => d.Idrt)
                .HasConstraintName("FK_MASTERKTP_MASTERRT");

            entity.HasOne(d => d.IdrwNavigation).WithMany(p => p.Masterktps)
                .HasForeignKey(d => d.Idrw)
                .HasConstraintName("FK_MASTERKTP_MASTERRW");
        });

        modelBuilder.Entity<Masterlibur>(entity =>
        {
            entity.HasKey(e => e.Idlibur);

            entity.ToTable("MASTERLIBUR");

            entity.HasIndex(e => new { e.Idkabkota, e.Tanggal }, "UC_MASTERLIBUR");

            entity.Property(e => e.Idlibur).HasColumnName("IDLIBUR");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idkabkota).HasColumnName("IDKABKOTA");
            entity.Property(e => e.Ket)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KET");
            entity.Property(e => e.Level)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEVEL");
            entity.Property(e => e.Namalibur)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NAMALIBUR");
            entity.Property(e => e.Tanggal)
                .HasColumnType("datetime")
                .HasColumnName("TANGGAL");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdkabkotaNavigation).WithMany(p => p.Masterliburs)
                .HasForeignKey(d => d.Idkabkota)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERLIBUR_MASTERKABKOTA");
        });

        modelBuilder.Entity<Mastermerk>(entity =>
        {
            entity.HasKey(e => e.Idmerk);

            entity.ToTable("MASTERMERK");

            entity.Property(e => e.Idmerk).HasColumnName("IDMERK");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Kdmerk)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDMERK");
            entity.Property(e => e.Ket)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KET");
            entity.Property(e => e.Nmmerk)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NMMERK");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Masternpwpd>(entity =>
        {
            entity.HasKey(e => e.Idnpwpd);

            entity.ToTable("MASTERNPWPD");

            entity.Property(e => e.Idnpwpd).HasColumnName("IDNPWPD");
            entity.Property(e => e.Alamat)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALAMAT");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idbadan).HasColumnName("IDBADAN");
            entity.Property(e => e.Idktp).HasColumnName("IDKTP");
            entity.Property(e => e.Ket)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("KET");
            entity.Property(e => e.Namabadan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAMABADAN");
            entity.Property(e => e.Nib)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIB");
            entity.Property(e => e.Npwpd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NPWPD");
            entity.Property(e => e.Statnpwpd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATNPWPD");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Tgldaftar)
                .HasColumnType("datetime")
                .HasColumnName("TGLDAFTAR");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdbadanNavigation).WithMany(p => p.Masternpwpds)
                .HasForeignKey(d => d.Idbadan)
                .HasConstraintName("FK_MASTERNPWPD_MASTERBADAN");

            entity.HasOne(d => d.IdktpNavigation).WithMany(p => p.Masternpwpds)
                .HasForeignKey(d => d.Idktp)
                .HasConstraintName("FK_MASTERNPWPD_MASTERKTP");
        });

        modelBuilder.Entity<Masterpegawai>(entity =>
        {
            entity.HasKey(e => e.Idpegawai);

            entity.ToTable("MASTERPEGAWAI");

            entity.HasIndex(e => e.Nip, "UC1_MASTERPEGAWAI");

            entity.HasIndex(e => e.Nik, "UC_MASTERPEGAWAI");

            entity.Property(e => e.Idpegawai).HasColumnName("IDPEGAWAI");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Golongan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GOLONGAN");
            entity.Property(e => e.Idktp).HasColumnName("IDKTP");
            entity.Property(e => e.Idupt).HasColumnName("IDUPT");
            entity.Property(e => e.Jabatan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("JABATAN");
            entity.Property(e => e.Nama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAMA");
            entity.Property(e => e.Nik)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIK");
            entity.Property(e => e.Nip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIP");
            entity.Property(e => e.Pangkat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PANGKAT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Telepon)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TELEPON");
            entity.Property(e => e.Uid)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UID");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdktpNavigation).WithMany(p => p.Masterpegawais)
                .HasForeignKey(d => d.Idktp)
                .HasConstraintName("FK_MASTERPEGAWAI_MASTERKTP");

            entity.HasOne(d => d.IduptNavigation).WithMany(p => p.Masterpegawais)
                .HasForeignKey(d => d.Idupt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERPEGAWAI_MASTERUPT");
        });

        modelBuilder.Entity<Masterprovinsi>(entity =>
        {
            entity.HasKey(e => e.Idprovinsi);

            entity.ToTable("MASTERPROVINSI");

            entity.Property(e => e.Idprovinsi).HasColumnName("IDPROVINSI");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Kdprovinsi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KDPROVINSI");
            entity.Property(e => e.Nmprovinsi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NMPROVINSI");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Masterrekd>(entity =>
        {
            entity.HasKey(e => e.Idrekd);

            entity.ToTable("MASTERREKD");

            entity.Property(e => e.Idrekd).HasColumnName("IDREKD");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idparent).HasColumnName("IDPARENT");
            entity.Property(e => e.Kdjnspjk)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KDJNSPJK");
            entity.Property(e => e.Kdrek)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KDREK");
            entity.Property(e => e.Mtglevel)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MTGLEVEL");
            entity.Property(e => e.Nmrek)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NMREK");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TYPE");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.KdjnspjkNavigation).WithMany(p => p.Masterrekds)
                .HasForeignKey(d => d.Kdjnspjk)
                .HasConstraintName("FK_MASTERREKD_JNSPAJAK");

            entity.HasOne(d => d.MtglevelNavigation).WithMany(p => p.Masterrekds)
                .HasForeignKey(d => d.Mtglevel)
                .HasConstraintName("FK_MASTERREKD_JNSSTRUREK");
        });

        modelBuilder.Entity<Masterreknrc>(entity =>
        {
            entity.HasKey(e => e.Idreknrc);

            entity.ToTable("MASTERREKNRC");

            entity.HasIndex(e => e.Kdrek, "UC_MASTERREKNRC");

            entity.Property(e => e.Idreknrc).HasColumnName("IDREKNRC");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Kdrek)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KDREK");
            entity.Property(e => e.Mtglevel)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MTGLEVEL");
            entity.Property(e => e.Nmrek)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NMREK");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TYPE");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.MtglevelNavigation).WithMany(p => p.Masterreknrcs)
                .HasForeignKey(d => d.Mtglevel)
                .HasConstraintName("FK_MASTERREKNRC_JNSSTRUREK");
        });

        modelBuilder.Entity<Masterrt>(entity =>
        {
            entity.HasKey(e => e.Idrt);

            entity.ToTable("MASTERRT");

            entity.Property(e => e.Idrt).HasColumnName("IDRT");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idrw).HasColumnName("IDRW");
            entity.Property(e => e.Kdrt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDRT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdrwNavigation).WithMany(p => p.Masterrts)
                .HasForeignKey(d => d.Idrw)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERRT_MASTERRW");
        });

        modelBuilder.Entity<Masterrw>(entity =>
        {
            entity.HasKey(e => e.Idrw);

            entity.ToTable("MASTERRW");

            entity.Property(e => e.Idrw).HasColumnName("IDRW");
            entity.Property(e => e.Alamat)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ALAMAT");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idkelurahan).HasColumnName("IDKELURAHAN");
            entity.Property(e => e.Kdrw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDRW");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdkelurahanNavigation).WithMany(p => p.Masterrws)
                .HasForeignKey(d => d.Idkelurahan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERRW_MASTERKELURAHAN");
        });

        modelBuilder.Entity<Mastertarif>(entity =>
        {
            entity.HasKey(e => e.Idtarif);

            entity.ToTable("MASTERTARIF");

            entity.Property(e => e.Idtarif).HasColumnName("IDTARIF");
            entity.Property(e => e.Akhir)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AKHIR");
            entity.Property(e => e.Awal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AWAL");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Jnskendid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JNSKENDID");
            entity.Property(e => e.Kdflow)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KDFLOW");
            entity.Property(e => e.Kdjnspjk)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KDJNSPJK");
            entity.Property(e => e.Kdplat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KDPLAT");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KETERANGAN");
            entity.Property(e => e.Satuan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SATUAN");
            entity.Property(e => e.Statumum)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUMUM");
            entity.Property(e => e.Tarif)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TARIF");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.Jnskend).WithMany(p => p.Mastertarifs)
                .HasForeignKey(d => d.Jnskendid)
                .HasConstraintName("FK_MASTERTARIF_JNSKENDARAAN");

            entity.HasOne(d => d.KdflowNavigation).WithMany(p => p.Mastertarifs)
                .HasForeignKey(d => d.Kdflow)
                .HasConstraintName("FK_MASTERTARIF_MASTERFLOW");

            entity.HasOne(d => d.KdjnspjkNavigation).WithMany(p => p.Mastertarifs)
                .HasForeignKey(d => d.Kdjnspjk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERTARIF_JNSPAJAK");

            entity.HasOne(d => d.KdplatNavigation).WithMany(p => p.Mastertarifs)
                .HasForeignKey(d => d.Kdplat)
                .HasConstraintName("FK_MASTERTARIF_JNSPLAT");
        });

        modelBuilder.Entity<Mastertarifnjop>(entity =>
        {
            entity.HasKey(e => e.Idtarifnjop);

            entity.ToTable("MASTERTARIFNJOP");

            entity.Property(e => e.Idtarifnjop).HasColumnName("IDTARIFNJOP");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idmerk).HasColumnName("IDMERK");
            entity.Property(e => e.Idrekd).HasColumnName("IDREKD");
            entity.Property(e => e.Iduunjop).HasColumnName("IDUUNJOP");
            entity.Property(e => e.Kdjnstarif)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDJNSTARIF");
            entity.Property(e => e.Kodebbm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODEBBM");
            entity.Property(e => e.Namatarif)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NAMATARIF");
            entity.Property(e => e.Njop)
                .HasColumnType("money")
                .HasColumnName("NJOP");
            entity.Property(e => e.Silinder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SILINDER");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Tahun)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TAHUN");
            entity.Property(e => e.Tipe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TIPE");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdmerkNavigation).WithMany(p => p.Mastertarifnjops)
                .HasForeignKey(d => d.Idmerk)
                .HasConstraintName("FK_MASTERTARIFNJOP_MASTERMERK");

            entity.HasOne(d => d.IdrekdNavigation).WithMany(p => p.Mastertarifnjops)
                .HasForeignKey(d => d.Idrekd)
                .HasConstraintName("FK_MASTERTARIFNJOP_MASTERREKD");

            entity.HasOne(d => d.IduunjopNavigation).WithMany(p => p.Mastertarifnjops)
                .HasForeignKey(d => d.Iduunjop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERTARIFNJOP_MASTERUUNJOP");

            entity.HasOne(d => d.KdjnstarifNavigation).WithMany(p => p.Mastertarifnjops)
                .HasForeignKey(d => d.Kdjnstarif)
                .HasConstraintName("FK_MASTERTARIFNJOP_JNSTARIF");

            entity.HasOne(d => d.KodebbmNavigation).WithMany(p => p.Mastertarifnjops)
                .HasForeignKey(d => d.Kodebbm)
                .HasConstraintName("FK_MASTERTARIFNJOP_MASTERBBM");
        });

        modelBuilder.Entity<Mastertek>(entity =>
        {
            entity.HasKey(e => e.Idteks);

            entity.ToTable("MASTERTEKS");

            entity.Property(e => e.Idteks).HasColumnName("IDTEKS");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Datateks)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("DATATEKS");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Masterupt>(entity =>
        {
            entity.HasKey(e => e.Idupt);

            entity.ToTable("MASTERUPT");

            entity.Property(e => e.Idupt).HasColumnName("IDUPT");
            entity.Property(e => e.Akroupt)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AKROUPT");
            entity.Property(e => e.Alamat)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ALAMAT");
            entity.Property(e => e.Bendahara).HasColumnName("BENDAHARA");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idbank).HasColumnName("IDBANK");
            entity.Property(e => e.Idkabkota).HasColumnName("IDKABKOTA");
            entity.Property(e => e.Idparent).HasColumnName("IDPARENT");
            entity.Property(e => e.Kdlevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KDLEVEL");
            entity.Property(e => e.Kdupt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KDUPT");
            entity.Property(e => e.Kepala).HasColumnName("KEPALA");
            entity.Property(e => e.Koordinator).HasColumnName("KOORDINATOR");
            entity.Property(e => e.Nmupt)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NMUPT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Telepon)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TELEPON");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TYPE");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.BendaharaNavigation).WithMany(p => p.MasteruptBendaharaNavigations)
                .HasForeignKey(d => d.Bendahara)
                .HasConstraintName("FK_MASTERUPT_MASTERPEGAWAI2");

            entity.HasOne(d => d.IdbankNavigation).WithMany(p => p.Masterupts)
                .HasForeignKey(d => d.Idbank)
                .HasConstraintName("FK_MASTERUPT_MASTERBANK");

            entity.HasOne(d => d.IdkabkotaNavigation).WithMany(p => p.Masterupts)
                .HasForeignKey(d => d.Idkabkota)
                .HasConstraintName("FK_MASTERUPT_MASTERKABKOTA");

            entity.HasOne(d => d.KepalaNavigation).WithMany(p => p.MasteruptKepalaNavigations)
                .HasForeignKey(d => d.Kepala)
                .HasConstraintName("FK_MASTERUPT_MASTERPEGAWAI");

            entity.HasOne(d => d.KoordinatorNavigation).WithMany(p => p.MasteruptKoordinatorNavigations)
                .HasForeignKey(d => d.Koordinator)
                .HasConstraintName("FK_MASTERUPT_MASTERPEGAWAI1");
        });

        modelBuilder.Entity<Masteruunjop>(entity =>
        {
            entity.HasKey(e => e.Iduunjop);

            entity.ToTable("MASTERUUNJOP");

            entity.Property(e => e.Iduunjop).HasColumnName("IDUUNJOP");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Isiperkada)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ISIPERKADA");
            entity.Property(e => e.Ket)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KET");
            entity.Property(e => e.Noperkada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOPERKADA");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Tahun)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TAHUN");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
        });

        modelBuilder.Entity<Masterwp>(entity =>
        {
            entity.HasKey(e => e.Idwp);

            entity.ToTable("MASTERWP");

            entity.Property(e => e.Idwp).HasColumnName("IDWP");
            entity.Property(e => e.Aakhirskp)
                .HasColumnType("datetime")
                .HasColumnName("AAKHIRSKP");
            entity.Property(e => e.Alamat)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ALAMAT");
            entity.Property(e => e.Awalskp)
                .HasColumnType("datetime")
                .HasColumnName("AWALSKP");
            entity.Property(e => e.Bbm)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BBM");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Cylinder).HasColumnName("CYLINDER");
            entity.Property(e => e.Daftarstnk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DAFTARSTNK");
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.Groupblokir)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GROUPBLOKIR");
            entity.Property(e => e.Idbadan).HasColumnName("IDBADAN");
            entity.Property(e => e.Idgroupusaha)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("IDGROUPUSAHA");
            entity.Property(e => e.Idkabkokta).HasColumnName("IDKABKOKTA");
            entity.Property(e => e.Idkecamatan).HasColumnName("IDKECAMATAN");
            entity.Property(e => e.Idkelurahan).HasColumnName("IDKELURAHAN");
            entity.Property(e => e.Idklasifikasi)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("IDKLASIFIKASI");
            entity.Property(e => e.Idktp).HasColumnName("IDKTP");
            entity.Property(e => e.Idlokasi)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("IDLOKASI");
            entity.Property(e => e.Idmerk).HasColumnName("IDMERK");
            entity.Property(e => e.Idrt).HasColumnName("IDRT");
            entity.Property(e => e.Idrw).HasColumnName("IDRW");
            entity.Property(e => e.Insidentil)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("INSIDENTIL");
            entity.Property(e => e.Jnskendid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JNSKENDID");
            entity.Property(e => e.Kdguna)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KDGUNA");
            entity.Property(e => e.Kdmilik)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KDMILIK");
            entity.Property(e => e.Kdplat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KDPLAT");
            entity.Property(e => e.Kendke).HasColumnName("KENDKE");
            entity.Property(e => e.Keteblokir)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("KETEBLOKIR");
            entity.Property(e => e.Kodebbm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODEBBM");
            entity.Property(e => e.Kodelokasi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODELOKASI");
            entity.Property(e => e.Kodepolisi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KODEPOLISI");
            entity.Property(e => e.Laporjual)
                .HasColumnType("datetime")
                .HasColumnName("LAPORJUAL");
            entity.Property(e => e.Lastskp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LASTSKP");
            entity.Property(e => e.Merk)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MERK");
            entity.Property(e => e.Namabadan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAMABADAN");
            entity.Property(e => e.Namapemilik)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAMAPEMILIK");
            entity.Property(e => e.Nikpemilik)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NIKPEMILIK");
            entity.Property(e => e.Nobpkb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOBPKB");
            entity.Property(e => e.Nodaftar)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NODAFTAR");
            entity.Property(e => e.Nomesin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMESIN");
            entity.Property(e => e.Nopollama)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOPOLLAMA");
            entity.Property(e => e.Norangka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NORANGKA");
            entity.Property(e => e.Nosah1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOSAH1");
            entity.Property(e => e.Nosah2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOSAH2");
            entity.Property(e => e.Nosah3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOSAH3");
            entity.Property(e => e.Nosah4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOSAH4");
            entity.Property(e => e.Nostnkb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOSTNKB");
            entity.Property(e => e.Notelppemilik)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOTELPPEMILIK");
            entity.Property(e => e.Objekbadanno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OBJEKBADANNO");
            entity.Property(e => e.Pekerjaan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PEKERJAAN");
            entity.Property(e => e.Putih)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PUTIH");
            entity.Property(e => e.Sdstnk)
                .HasColumnType("datetime")
                .HasColumnName("SDSTNK");
            entity.Property(e => e.Statint)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATINT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Tahunbuat).HasColumnName("TAHUNBUAT");
            entity.Property(e => e.Telepon)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TELEPON");
            entity.Property(e => e.TglSkp)
                .HasColumnType("datetime")
                .HasColumnName("TglSKP");
            entity.Property(e => e.Tglcetakstnk)
                .HasColumnType("datetime")
                .HasColumnName("TGLCETAKSTNK");
            entity.Property(e => e.Tgldaftar)
                .HasColumnType("datetime")
                .HasColumnName("TGLDAFTAR");
            entity.Property(e => e.Tglhapus)
                .HasColumnType("datetime")
                .HasColumnName("TGLHAPUS");
            entity.Property(e => e.Tgljualbeli)
                .HasColumnType("datetime")
                .HasColumnName("TGLJUALBELI");
            entity.Property(e => e.Tglmutasi)
                .HasColumnType("datetime")
                .HasColumnName("TGLMUTASI");
            entity.Property(e => e.Tglsah)
                .HasColumnType("datetime")
                .HasColumnName("TGLSAH");
            entity.Property(e => e.Tglsah1)
                .HasColumnType("datetime")
                .HasColumnName("TGLSAH1");
            entity.Property(e => e.Tglsah2)
                .HasColumnType("datetime")
                .HasColumnName("TGLSAH2");
            entity.Property(e => e.Tglsah3)
                .HasColumnType("datetime")
                .HasColumnName("TGLSAH3");
            entity.Property(e => e.Tglsah4)
                .HasColumnType("datetime")
                .HasColumnName("TGLSAH4");
            entity.Property(e => e.Tglstnk)
                .HasColumnType("datetime")
                .HasColumnName("TGLSTNK");
            entity.Property(e => e.Tipe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPE");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
            entity.Property(e => e.Warna)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WARNA");

            entity.HasOne(d => d.IdbadanNavigation).WithMany(p => p.Masterwps)
                .HasForeignKey(d => d.Idbadan)
                .HasConstraintName("FK_MASTERWP_MASTERBADAN");

            entity.HasOne(d => d.IdkabkoktaNavigation).WithMany(p => p.Masterwps)
                .HasForeignKey(d => d.Idkabkokta)
                .HasConstraintName("FK_MASTERWP_MASTERKABKOTAALL");

            entity.HasOne(d => d.IdkecamatanNavigation).WithMany(p => p.Masterwps)
                .HasForeignKey(d => d.Idkecamatan)
                .HasConstraintName("FK_MASTERWP_MASTERKECAMATAN");

            entity.HasOne(d => d.IdkelurahanNavigation).WithMany(p => p.Masterwps)
                .HasForeignKey(d => d.Idkelurahan)
                .HasConstraintName("FK_MASTERWP_MASTERKELURAHAN");

            entity.HasOne(d => d.IdrtNavigation).WithMany(p => p.Masterwps)
                .HasForeignKey(d => d.Idrt)
                .HasConstraintName("FK_MASTERWP_MASTERRT");

            entity.HasOne(d => d.IdrwNavigation).WithMany(p => p.Masterwps)
                .HasForeignKey(d => d.Idrw)
                .HasConstraintName("FK_MASTERWP_MASTERRW");

            entity.HasOne(d => d.Jnskend).WithMany(p => p.Masterwps)
                .HasForeignKey(d => d.Jnskendid)
                .HasConstraintName("FK_MASTERWP_JNSKENDARAAN");

            entity.HasOne(d => d.KdgunaNavigation).WithMany(p => p.Masterwps)
                .HasForeignKey(d => d.Kdguna)
                .HasConstraintName("FK_MASTERWP_JNSGUNA");

            entity.HasOne(d => d.KdmilikNavigation).WithMany(p => p.Masterwps)
                .HasForeignKey(d => d.Kdmilik)
                .HasConstraintName("FK_MASTERWP_JNSMILIK");

            entity.HasOne(d => d.KdplatNavigation).WithMany(p => p.Masterwps)
                .HasForeignKey(d => d.Kdplat)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERWP_JNSPLAT");
        });

        modelBuilder.Entity<Masterwpdatum>(entity =>
        {
            entity.HasKey(e => e.Idwpdata);

            entity.ToTable("MASTERWPDATA");

            entity.Property(e => e.Idwpdata).HasColumnName("IDWPDATA");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idjnsd).HasColumnName("IDJNSD");
            entity.Property(e => e.Idwp).HasColumnName("IDWP");
            entity.Property(e => e.Tglpendataan)
                .HasColumnType("datetime")
                .HasColumnName("TGLPENDATAAN");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdjnsdNavigation).WithMany(p => p.Masterwpdata)
                .HasForeignKey(d => d.Idjnsd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERWPDATA_MASTERJNSPENDAPATAN");

            entity.HasOne(d => d.IdwpNavigation).WithMany(p => p.Masterwpdata)
                .HasForeignKey(d => d.Idwp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MASTERWPDATA_MASTERWP");
        });

        modelBuilder.Entity<Transdatakohir>(entity =>
        {
            entity.HasKey(e => e.Idkohir);

            entity.ToTable("TRANSDATAKOHIR");

            entity.Property(e => e.Idkohir).HasColumnName("IDKOHIR");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idbank)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("IDBANK");
            entity.Property(e => e.Idupt).HasColumnName("IDUPT");
            entity.Property(e => e.Idwp).HasColumnName("IDWP");
            entity.Property(e => e.Ket)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("KET");
            entity.Property(e => e.Masaakhir)
                .HasColumnType("datetime")
                .HasColumnName("MASAAKHIR");
            entity.Property(e => e.Masaawal)
                .HasColumnType("datetime")
                .HasColumnName("MASAAWAL");
            entity.Property(e => e.Ntpd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NTPD");
            entity.Property(e => e.Penagih)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PENAGIH");
            entity.Property(e => e.Skrupt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SKRUPT");
            entity.Property(e => e.Tglkurangbayar)
                .HasColumnType("datetime")
                .HasColumnName("TGLKURANGBAYAR");
            entity.Property(e => e.Tglntpd)
                .HasColumnType("datetime")
                .HasColumnName("TGLNTPD");
            entity.Property(e => e.Tglpenetapan)
                .HasColumnType("datetime")
                .HasColumnName("TGLPENETAPAN");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
            entity.Property(e => e.Validjr)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VALIDJR");
            entity.Property(e => e.Validjrby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VALIDJRBY");
            entity.Property(e => e.Validpol)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VALIDPOL");
            entity.Property(e => e.Validpolby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VALIDPOLBY");

            entity.HasOne(d => d.IduptNavigation).WithMany(p => p.Transdatakohirs)
                .HasForeignKey(d => d.Idupt)
                .HasConstraintName("FK_TRANSDATAKOHIR_MASTERUPT");

            entity.HasOne(d => d.IdwpNavigation).WithMany(p => p.Transdatakohirs)
                .HasForeignKey(d => d.Idwp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSDATAKOHIR_MASTERWP");
        });

        modelBuilder.Entity<Transpendataan>(entity =>
        {
            entity.HasKey(e => e.Idpendataan);

            entity.ToTable("TRANSPENDATAAN");

            entity.Property(e => e.Idpendataan).HasColumnName("IDPENDATAAN");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idupt).HasColumnName("IDUPT");
            entity.Property(e => e.Idwpdata).HasColumnName("IDWPDATA");
            entity.Property(e => e.Jmlomzetawal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JMLOMZETAWAL");
            entity.Property(e => e.Kdflow)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KDFLOW");
            entity.Property(e => e.Masaakhir)
                .HasColumnType("datetime")
                .HasColumnName("MASAAKHIR");
            entity.Property(e => e.Masaawal)
                .HasColumnType("datetime")
                .HasColumnName("MASAAWAL");
            entity.Property(e => e.Spt)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SPT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Tarifpjk)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TARIFPJK");
            entity.Property(e => e.Tglpendataan)
                .HasColumnType("datetime")
                .HasColumnName("TGLPENDATAAN");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
            entity.Property(e => e.Uruttgl).HasColumnName("URUTTGL");

            entity.HasOne(d => d.IdwpdataNavigation).WithMany(p => p.Transpendataans)
                .HasForeignKey(d => d.Idwpdata)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSPENDATAAN_MASTERWPDATA");
        });

        modelBuilder.Entity<Transpendataandet>(entity =>
        {
            entity.HasKey(e => e.Idpendataandet);

            entity.ToTable("TRANSPENDATAANDET");

            entity.Property(e => e.Idpendataandet).HasColumnName("IDPENDATAANDET");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idpendataan).HasColumnName("IDPENDATAAN");
            entity.Property(e => e.Idpenetapan).HasColumnName("IDPENETAPAN");
            entity.Property(e => e.Ket1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lokasi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("LOKASI");
            entity.Property(e => e.Nourut).HasColumnName("NOURUT");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Tarifpajak)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TARIFPAJAK");
            entity.Property(e => e.TransId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TransID");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
            entity.Property(e => e.UsahaId).HasColumnName("UsahaID");

            entity.HasOne(d => d.IdpendataanNavigation).WithMany(p => p.Transpendataandets)
                .HasForeignKey(d => d.Idpendataan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSPENDATAANDET_TRANSPENDATAAN");

            entity.HasOne(d => d.IdpenetapanNavigation).WithMany(p => p.Transpendataandets)
                .HasForeignKey(d => d.Idpenetapan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSPENDATAANDET_TRANSPENETAPAN");
        });

        modelBuilder.Entity<Transpenetapan>(entity =>
        {
            entity.HasKey(e => e.Idpenetapan);

            entity.ToTable("TRANSPENETAPAN");

            entity.Property(e => e.Idpenetapan).HasColumnName("IDPENETAPAN");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Denda)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DENDA");
            entity.Property(e => e.DendaOpsKota).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DendaOpsProv).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Idkohir).HasColumnName("IDKOHIR");
            entity.Property(e => e.Idwpdata).HasColumnName("IDWPDATA");
            entity.Property(e => e.Jmlbayar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JMLBAYAR");
            entity.Property(e => e.Jmlkurangbayar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JMLKURANGBAYAR");
            entity.Property(e => e.Jmlomzetawal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JMLOMZETAWAL");
            entity.Property(e => e.Jmlperingatan).HasColumnName("JMLPERINGATAN");
            entity.Property(e => e.Kdflow)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KDFLOW");
            entity.Property(e => e.Kenaikan)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KENAIKAN");
            entity.Property(e => e.Masaakhir)
                .HasColumnType("datetime")
                .HasColumnName("MASAAKHIR");
            entity.Property(e => e.Masaawal)
                .HasColumnType("datetime")
                .HasColumnName("MASAAWAL");
            entity.Property(e => e.Nokohir)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOKOHIR");
            entity.Property(e => e.OpsId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OpsID");
            entity.Property(e => e.OpsKota).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OpsProv).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Statbayar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATBAYAR");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATUS");
            entity.Property(e => e.Tarifpajak)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TARIFPAJAK");
            entity.Property(e => e.Tglbayar)
                .HasColumnType("datetime")
                .HasColumnName("TGLBAYAR");
            entity.Property(e => e.Tgljatuhtempo)
                .HasColumnType("datetime")
                .HasColumnName("TGLJATUHTEMPO");
            entity.Property(e => e.Tglkurangbayar)
                .HasColumnType("datetime")
                .HasColumnName("TGLKURANGBAYAR");
            entity.Property(e => e.Tglpenetapan)
                .HasColumnType("datetime")
                .HasColumnName("TGLPENETAPAN");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
            entity.Property(e => e.Uruttgl).HasColumnName("URUTTGL");

            entity.HasOne(d => d.IdkohirNavigation).WithMany(p => p.Transpenetapans)
                .HasForeignKey(d => d.Idkohir)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSPENETAPAN_TRANSDATAKOHIR");

            entity.HasOne(d => d.IdwpdataNavigation).WithMany(p => p.Transpenetapans)
                .HasForeignKey(d => d.Idwpdata)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSPENETAPAN_MASTERWPDATA");
        });

        modelBuilder.Entity<Transst>(entity =>
        {
            entity.HasKey(e => e.Idsts);

            entity.ToTable("TRANSSTS");

            entity.Property(e => e.Idsts).HasColumnName("IDSTS");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idbend).HasColumnName("IDBEND");
            entity.Property(e => e.Idupt).HasColumnName("IDUPT");
            entity.Property(e => e.Keterangan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KETERANGAN");
            entity.Property(e => e.Nosts)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOSTS");
            entity.Property(e => e.Ntpd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NTPD");
            entity.Property(e => e.SetoranDari)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Statbayar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATBAYAR");
            entity.Property(e => e.Statsts).HasColumnName("STATSTS");
            entity.Property(e => e.Tglntpd)
                .HasColumnType("datetime")
                .HasColumnName("TGLNTPD");
            entity.Property(e => e.Tglsts)
                .HasColumnType("datetime")
                .HasColumnName("TGLSTS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdbendNavigation).WithMany(p => p.Transsts)
                .HasForeignKey(d => d.Idbend)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSSTS_MASTERBENDAHARA");

            entity.HasOne(d => d.IduptNavigation).WithMany(p => p.Transsts)
                .HasForeignKey(d => d.Idupt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSSTS_MASTERUPT");
        });

        modelBuilder.Entity<Transstsdet>(entity =>
        {
            entity.HasKey(e => e.Idstsdet);

            entity.ToTable("TRANSSTSDET");

            entity.Property(e => e.Idstsdet).HasColumnName("IDSTSDET");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idrekd).HasColumnName("IDREKD");
            entity.Property(e => e.Idsts).HasColumnName("IDSTS");
            entity.Property(e => e.Jenis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("JENIS");
            entity.Property(e => e.Nilaists)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NILAISTS");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdrekdNavigation).WithMany(p => p.Transstsdets)
                .HasForeignKey(d => d.Idrekd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSSTSDET_MASTERREKD");

            entity.HasOne(d => d.IdstsNavigation).WithMany(p => p.Transstsdets)
                .HasForeignKey(d => d.Idsts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSSTSDET_TRANSSTS");
        });

        modelBuilder.Entity<Transwpdataantri>(entity =>
        {
            entity.HasKey(e => e.Idantri);

            entity.ToTable("TRANSWPDATAANTRI");

            entity.Property(e => e.Idantri).HasColumnName("IDANTRI");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idktp).HasColumnName("IDKTP");
            entity.Property(e => e.Idtwpdata).HasColumnName("IDTWPDATA");
            entity.Property(e => e.Ket)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KET");
            entity.Property(e => e.Noantri)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOANTRI");
            entity.Property(e => e.Statantri)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATANTRI");
            entity.Property(e => e.Tglantri)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TGLANTRI");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdktpNavigation).WithMany(p => p.Transwpdataantris)
                .HasForeignKey(d => d.Idktp)
                .HasConstraintName("FK_TRANSWPDATAANTRI_MASTERKTP");

            entity.HasOne(d => d.IdtwpdataNavigation).WithMany(p => p.Transwpdataantris)
                .HasForeignKey(d => d.Idtwpdata)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSWPDATAANTRI_TRANSWPDATA");
        });

        modelBuilder.Entity<Transwpdatafile>(entity =>
        {
            entity.HasKey(e => e.Idfile);

            entity.ToTable("TRANSWPDATAFILE");

            entity.Property(e => e.Idfile).HasColumnName("IDFILE");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Direktory)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIREKTORY");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXTENSION");
            entity.Property(e => e.Idtwpdata).HasColumnName("IDTWPDATA");
            entity.Property(e => e.Namafile)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("NAMAFILE");
            entity.Property(e => e.Size).HasColumnName("SIZE");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.IdtwpdataNavigation).WithMany(p => p.Transwpdatafiles)
                .HasForeignKey(d => d.Idtwpdata)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSWPDATAFILE_TRANSWPDATA");
        });

        modelBuilder.Entity<Transwpdatum>(entity =>
        {
            entity.HasKey(e => e.Idtwpdata);

            entity.ToTable("TRANSWPDATA");

            entity.Property(e => e.Idtwpdata).HasColumnName("IDTWPDATA");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATEBY");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Idnpwpd).HasColumnName("IDNPWPD");
            entity.Property(e => e.Kdflow)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KDFLOW");
            entity.Property(e => e.Tgldaftar)
                .HasColumnType("datetime")
                .HasColumnName("TGLDAFTAR");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPDATEBY");
            entity.Property(e => e.Updatedate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATEDATE");

            entity.HasOne(d => d.IdnpwpdNavigation).WithMany(p => p.Transwpdata)
                .HasForeignKey(d => d.Idnpwpd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSWPDATA_MASTERNPWPD");

            entity.HasOne(d => d.KdflowNavigation).WithMany(p => p.Transwpdata)
                .HasForeignKey(d => d.Kdflow)
                .HasConstraintName("FK_TRANSWPDATA_MASTERFLOW1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
