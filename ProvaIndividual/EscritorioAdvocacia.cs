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

    public void AdicionarCliente(Cliente cliente)
    {
        if (clientes.Exists(x => x.Cpf == cliente.Cpf))
        {
            throw new Exception("Cliente ja existe");
        }
        else
        {
            clientes.Add(cliente);
        }
    }

    public void RemoverAdvogado(Advogado advogado)
    {
        if (advogados.Exists(x => x.Cpf == advogado.Cpf || x.CNA == advogado.CNA))
        {
            advogados.Remove(advogado);
        }
        else
        {
            throw new Exception("Advogado nao existe");
        }

    }

    public void RemoverCliente(Cliente cliente)
    {
        if (clientes.Exists(x => x.Cpf == cliente.Cpf))
        {
            clientes.Remove(cliente);
        }
        else
        {
            throw new Exception("Cliente nao existe");
        }
    }
}
