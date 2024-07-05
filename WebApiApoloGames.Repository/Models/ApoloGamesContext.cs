using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApiApoloGames.Repository.Models
{
    public partial class ApoloGamesContext : DbContext
    {
        public ApoloGamesContext()
        {
        }

        public ApoloGamesContext(DbContextOptions<ApoloGamesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BlackList> BlackLists { get; set; } = null!;
        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Complex> Complexes { get; set; } = null!;
        public virtual DbSet<ComplexAddress> ComplexAddresses { get; set; } = null!;
        public virtual DbSet<ComplexComment> ComplexComments { get; set; } = null!;
        public virtual DbSet<ComplexImage> ComplexImages { get; set; } = null!;
        public virtual DbSet<ComplexSchedule> ComplexSchedules { get; set; } = null!;
        public virtual DbSet<ComplexSocialNetwork> ComplexSocialNetworks { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Day> Days { get; set; } = null!;
        public virtual DbSet<Field> Fields { get; set; } = null!;
        public virtual DbSet<FieldComment> FieldComments { get; set; } = null!;
        public virtual DbSet<FieldScore> FieldScores { get; set; } = null!;
        public virtual DbSet<Match> Matches { get; set; } = null!;
        public virtual DbSet<Owner> Owners { get; set; } = null!;
        public virtual DbSet<OwnerPayment> OwnerPayments { get; set; } = null!;
        public virtual DbSet<PaymentsMethod> PaymentsMethods { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<PlayersTeam> PlayersTeams { get; set; } = null!;
        public virtual DbSet<Prize> Prizes { get; set; } = null!;
        public virtual DbSet<PrizesTournament> PrizesTournaments { get; set; } = null!;
        public virtual DbSet<Province> Provinces { get; set; } = null!;
        public virtual DbSet<SocialNetwork> SocialNetworks { get; set; } = null!;
        public virtual DbSet<Sport> Sports { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<Surface> Surfaces { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;
        public virtual DbSet<Tournament> Tournaments { get; set; } = null!;
        public virtual DbSet<TournamentMatch> TournamentMatches { get; set; } = null!;
        public virtual DbSet<TournamentTeam> TournamentTeams { get; set; } = null!;
        public virtual DbSet<TypesTournament> TypesTournaments { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-AOPI5P0\\SQLEXPRESS;Database=ApoloGames;User Id=maty;Password=Maty37294363;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlackList>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateDeleated).HasColumnType("date");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCity).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Complex>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComplexAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComplexAddress");

                entity.Property(e => e.Street)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComplexComment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("date");
            });

            modelBuilder.Entity<ComplexImage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.UrlImage).IsUnicode(false);
            });

            modelBuilder.Entity<ComplexSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComplexSchedule");
            });

            modelBuilder.Entity<ComplexSocialNetwork>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCountry).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateDeleated).HasColumnType("date");

                entity.Property(e => e.DateModified).HasColumnType("date");
            });

            modelBuilder.Entity<Day>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdDay).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Field>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FieldComment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.ReplyToldComment)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FieldScore>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Match>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.DateDeleted).HasColumnType("date");

                entity.Property(e => e.DateModified).HasColumnType("date");
            });

            modelBuilder.Entity<OwnerPayment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Alias)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cbu).HasColumnName("CBU");

                entity.Property(e => e.IdOwnerPayment).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PaymentsMethod>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPaymentMethod).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idtype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDType");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayersTeam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PlayersTeam");

                entity.Property(e => e.Dni).HasColumnName("DNI");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prize>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrizesTournament>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvince).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SocialNetwork>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sport>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSport).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Surface>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSurface).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlImage)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tournament>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateInscriptionFrom).HasColumnType("date");

                entity.Property(e => e.DateInscriptionTo).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TournamentMatch>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TournamentTeam>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TypesTournament>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Rules)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
