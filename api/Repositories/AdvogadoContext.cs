using System.Data.Entity;

public class AdvogadoContext : DbContext
{
    public DbSet<Advogado> Advogados { get; set; }

    public AdvogadoContext() : base("name=AdvogadoDB")
    {
    }
}
