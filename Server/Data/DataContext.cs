namespace UDI_kodetest.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Person> Personer { get; set; }
        public DbSet<Soknad> Soknader { get; set; }
        public DbSet<Vedtak> Vedtak { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Sett opp 1-1 forhold mellom søknad og kontaktperson
            modelBuilder.Entity<Soknad>()
                .HasOne(s => s.Kontakt)
                .WithOne()
                .HasForeignKey<Soknad>(s => s.KontaktId)
                .OnDelete(DeleteBehavior.NoAction); // Ikke slette person dersom søknad slettes

            // Sett opp 1-1 forhold mellom søknad og søker
            modelBuilder.Entity<Soknad>()
                .HasOne(s => s.Soker)
                .WithOne()
                .HasForeignKey<Soknad>(s => s.SokerId)
                .OnDelete(DeleteBehavior.NoAction); // Ikke slette person dersom søknad slettes

            // Sett opp 1-1 forhold mellom søknad og vedtak
            modelBuilder.Entity<Soknad>()
                .HasOne(s => s.Vedtak)
                .WithOne()
                .HasForeignKey<Soknad>(s => s.VedtakId);
        }
    }
}
