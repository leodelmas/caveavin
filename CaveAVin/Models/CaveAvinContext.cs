using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CaveAVin.Models;

public partial class CaveAvinContext : DbContext
{
    public CaveAvinContext()
    {
    }

    public CaveAvinContext(DbContextOptions<CaveAvinContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appellation> Appellations { get; set; }

    public virtual DbSet<Avi> Avis { get; set; }

    public virtual DbSet<Bouteille> Bouteilles { get; set; }

    public virtual DbSet<Cave> Caves { get; set; }

    public virtual DbSet<Couleur> Couleurs { get; set; }

    public virtual DbSet<Fabricant> Fabricants { get; set; }

    public virtual DbSet<Famille> Familles { get; set; }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=bdd.mtre.fr;User ID=CaveAVin;Password=Rfypq5iME3A332;Database=CaveAVin;Trusted_Connection=False;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appellation>(entity =>
        {
            entity.HasKey(e => e.IdAppellation).HasName("PK__Appellat__79847EF2DDB99F27");

            entity.ToTable("Appellation");

            entity.Property(e => e.IdAppellation).HasColumnName("idAppellation");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
        });

        modelBuilder.Entity<Avi>(entity =>
        {
            entity.HasKey(e => e.IdAvis).HasName("PK__Avis__DEFE99676AA631B9");

            entity.Property(e => e.IdAvis).HasColumnName("idAvis");
            entity.Property(e => e.IdBouteille).HasColumnName("idBouteille");
            entity.Property(e => e.IdUtilisateur).HasColumnName("idUtilisateur");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Texte)
                .HasColumnType("text")
                .HasColumnName("texte");

            entity.HasOne(d => d.IdBouteilleNavigation).WithMany(p => p.Avis)
                .HasForeignKey(d => d.IdBouteille)
                .HasConstraintName("FK__Avis__idBouteill__4AB81AF0");

            entity.HasOne(d => d.IdUtilisateurNavigation).WithMany(p => p.Avis)
                .HasForeignKey(d => d.IdUtilisateur)
                .HasConstraintName("FK__Avis__idUtilisat__4BAC3F29");
        });

        modelBuilder.Entity<Bouteille>(entity =>
        {
            entity.HasKey(e => e.IdBouteille).HasName("PK__Bouteill__ED266ABD1AC30C2E");

            entity.ToTable("Bouteille");

            entity.Property(e => e.IdBouteille).HasColumnName("idBouteille");
            entity.Property(e => e.AnneeGardeMax).HasColumnName("anneeGardeMax");
            entity.Property(e => e.AnneeGardeMin).HasColumnName("anneeGardeMin");
            entity.Property(e => e.IdAppellation).HasColumnName("idAppellation");
            entity.Property(e => e.IdCave).HasColumnName("idCave");
            entity.Property(e => e.IdCouleur).HasColumnName("idCouleur");
            entity.Property(e => e.Millesime).HasColumnName("millesime");
            entity.Property(e => e.NomComplet)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nomComplet");
            entity.Property(e => e.NumEmplacement).HasColumnName("numEmplacement");
            entity.Property(e => e.NumTiroir).HasColumnName("numTiroir");

            entity.HasOne(d => d.IdAppellationNavigation).WithMany(p => p.Bouteilles)
                .HasForeignKey(d => d.IdAppellation)
                .HasConstraintName("FK__Bouteille__idApp__46E78A0C");

            entity.HasOne(d => d.IdCaveNavigation).WithMany(p => p.Bouteilles)
                .HasForeignKey(d => d.IdCave)
                .HasConstraintName("FK__Bouteille__idCav__47DBAE45");

            entity.HasOne(d => d.IdCouleurNavigation).WithMany(p => p.Bouteilles)
                .HasForeignKey(d => d.IdCouleur)
                .HasConstraintName("FK__Bouteille__idCou__45F365D3");
        });

        modelBuilder.Entity<Cave>(entity =>
        {
            entity.HasKey(e => e.IdCave).HasName("PK__Cave__8BA38971E925E3B3");

            entity.ToTable("Cave");

            entity.Property(e => e.IdCave).HasColumnName("idCave");
            entity.Property(e => e.Designation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.IdFabricant).HasColumnName("idFabricant");
            entity.Property(e => e.IdFamille).HasColumnName("idFamille");
            entity.Property(e => e.IdUtilisateur).HasColumnName("idUtilisateur");
            entity.Property(e => e.NbBouteillesParTiroir).HasColumnName("nbBouteillesParTiroir");
            entity.Property(e => e.NbTiroirs).HasColumnName("nbTiroirs");
            entity.Property(e => e.TemperatureFonctionnement)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("temperatureFonctionnement");

            entity.HasOne(d => d.IdFabricantNavigation).WithMany(p => p.Caves)
                .HasForeignKey(d => d.IdFabricant)
                .HasConstraintName("FK__Cave__idFabrican__3D5E1FD2");

            entity.HasOne(d => d.IdFamilleNavigation).WithMany(p => p.Caves)
                .HasForeignKey(d => d.IdFamille)
                .HasConstraintName("FK__Cave__idFamille__3E52440B");

            entity.HasOne(d => d.IdUtilisateurNavigation).WithMany(p => p.Caves)
                .HasForeignKey(d => d.IdUtilisateur)
                .HasConstraintName("FK__Cave__idUtilisat__3F466844");
        });

        modelBuilder.Entity<Couleur>(entity =>
        {
            entity.HasKey(e => e.IdCouleur).HasName("PK__Couleur__EB7FDCDED7F3CFA4");

            entity.ToTable("Couleur");

            entity.Property(e => e.IdCouleur).HasColumnName("idCouleur");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
        });

        modelBuilder.Entity<Fabricant>(entity =>
        {
            entity.HasKey(e => e.IdFabricant).HasName("PK__Fabrican__FF6C91FD423326CB");

            entity.ToTable("Fabricant");

            entity.Property(e => e.IdFabricant).HasColumnName("idFabricant");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
        });

        modelBuilder.Entity<Famille>(entity =>
        {
            entity.HasKey(e => e.IdFamille).HasName("PK__Famille__CC8A4978AE9B326E");

            entity.ToTable("Famille");

            entity.Property(e => e.IdFamille).HasColumnName("idFamille");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
        });

        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.HasKey(e => e.IdUtilisateur).HasName("PK__Utilisat__5366DB192B57F0FF");

            entity.ToTable("Utilisateur");

            entity.Property(e => e.IdUtilisateur).HasColumnName("idUtilisateur");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.MotDePasse)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("motDePasse");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
