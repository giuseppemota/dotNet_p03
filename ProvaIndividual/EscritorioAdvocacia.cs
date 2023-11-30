namespace ProvaIndividual;
public class EscritorioAdvocacia
{
    protected List<Advogado> advogados = new List<Advogado>();
    protected List<Cliente> clientes = new List<Cliente>();

public void AdicionarAdvogado(Advogado advogado)
{
    if (advogados.Exists(x => x.Cpf == advogado.Cpf || x.CNA == advogado.CNA))
    {
        throw new Exception("Advogado ja existe");
    }
    else
    {
        advogados.Add(advogado);
    }
}
}
