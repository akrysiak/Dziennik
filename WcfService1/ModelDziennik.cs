namespace WcfService1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDziennik : DbContext
    {
        public ModelDziennik()
            : base("name=ModelDziennik")
        {
        }

        public virtual DbSet<TKlasa> TKlasa { get; set; }
        public virtual DbSet<TNauczyciel> TNauczyciel { get; set; }
        public virtual DbSet<TOcena> TOcena { get; set; }
        public virtual DbSet<TPrzedmiot> TPrzedmiot { get; set; }
        public virtual DbSet<TUczen> TUczen { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TKlasa>()
                .Property(e => e.Nazwa)
                .IsFixedLength();

            modelBuilder.Entity<TNauczyciel>()
                .Property(e => e.Nauczyciel)
                .IsFixedLength();

            modelBuilder.Entity<TOcena>()
                .Property(e => e.Ocena)
                .IsFixedLength();

            modelBuilder.Entity<TPrzedmiot>()
                .Property(e => e.Nazwa)
                .IsFixedLength();

            modelBuilder.Entity<TUczen>()
                .Property(e => e.Imie)
                .IsFixedLength();

            modelBuilder.Entity<TUczen>()
                .Property(e => e.Nazwisko)
                .IsFixedLength();

            modelBuilder.Entity<TUczen>()
                .Property(e => e.Ulica)
                .IsFixedLength();

            modelBuilder.Entity<TUczen>()
                .Property(e => e.Miejscowosc)
                .IsFixedLength();

            modelBuilder.Entity<TUczen>()
                .Property(e => e.Kod)
                .IsFixedLength();

            modelBuilder.Entity<TUczen>()
                .Property(e => e.Kontakt)
                .IsFixedLength();
        }
    }
}
