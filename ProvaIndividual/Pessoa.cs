namespace ProvaIndividual;
public abstract class Pessoa
{
    public string? Nome { get; set; }
    public string? Cpf
    {
        get { return Cpf; }
        set
        {
            if (value.Length != 11) throw new Exception("Cpf inválido");
            Cpf = value;
        }
    }
    public DateTime DataNascimento
    {
        get
        {
            return DataNascimento;
        }
        set
        {
            if (value > DateTime.Now)
            {
                throw new Exception("Data de nascimento inválida");
            }
            else
            {
                DataNascimento = value;
            }
        }
    }
}
