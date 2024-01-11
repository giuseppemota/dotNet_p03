using Microsoft.EntityFrameworkCore;

namespace EntityDatabase.Models;
public class TechMedContext : DbContext
{

    public DbSet<Medico> Medicos { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Atendimento> Atendimentos { get; set; }
    public DbSet<Exame> Exames { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var connectionString = "server=localhost;user=dotnet;password=tic2023;database=giuseppemed";
        var serverVersion = ServerVersion.AutoDetect(connectionString);

        optionsBuilder.UseMySql(connectionString, serverVersion);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Medico>().ToTable("Medicos").HasKey(m => m.MedicoId);
        modelBuilder.Entity<Paciente>().ToTable("Pacientes").HasKey(p => p.PacienteId);
        modelBuilder.Entity<Atendimento>().ToTable("Atendimentos").HasKey(a => a.AtendimentoId);
        modelBuilder.Entity<Exame>().ToTable("Exames").HasKey(a => a.ExameId);

        modelBuilder.Entity<Atendimento>()
            .HasOne(a => a.Medico)
            .WithMany(m => m.Atendimentos)
            .HasForeignKey(a => a.MedicoId);

        modelBuilder.Entity<Atendimento>()
            .HasOne(a => a.Paciente)
            .WithMany(m => m.Atendimentos)
            .HasForeignKey(a => a.MedicoId);

        modelBuilder.Entity<Atendimento>()
            .HasMany(a => a.Exames)
            .WithOne(x => x.Atendimento);
    }
    // codigo omitido
}

public abstract class Pessoa
{

    public required string Nome { get; set; }
    public required string CPF { get; set; }
}

public class Medico : Pessoa
{
    public int MedicoId { get; set; }
    public required string CRM { get; set; }
    public string? Especialidade { get; set; }
    public decimal? Salario { get; set; }
    public ICollection<Atendimento>? Atendimentos { get; }
}

public class Paciente : Pessoa
{
    public int PacienteId { get; set; }
    public string? Endereco { get; set; }
    public string? Telefone { get; set; }
    public ICollection<Atendimento>? Atendimentos { get; }
}

public class Atendimento
{
    public int AtendimentoId { get; set; }
    public DateTime DataHora { get; set; }
    public int MedicoId { get; set; }
    public required Medico Medico { get; set; }
    public int PacienteId { get; set; }
    public required Paciente Paciente { get; set; }
    public ICollection<Exame>? Exames { get; }
}

public class Exame
{
    public int ExameId { get; set; }
    public string? Local { get; set; }
    public DateTime DataHora { get; set; }
    public required Atendimento Atendimento { get; set; }
}
