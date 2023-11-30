namespace ProvaIndividual;
public abstract class Relatorio
{
    public static void AdvogadoIdadeEntre(List<Advogado> advogados, int idadeMin, int idadeMax)
    {
        foreach (var item in advogados)
        {
            if (item.Idade >= idadeMin && item.Idade <= idadeMax)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }


    public static void ClienteIdadeEntre(List<Cliente> clientes, int idadeMin, int idadeMax)
    {
        foreach (var item in clientes)
        {
            if (item.Idade >= idadeMin && item.Idade <= idadeMax)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    public static void ClienteEstadoCivil(List<Cliente> clientes)
    {
        foreach (var item in clientes)
        {
            if (item.EstadoCivil)
            {
                Console.WriteLine("Solteiro");
            }
            else
            {
                Console.WriteLine("Casado");
            }
        }
    }

    public static void ClienteOrdemAlfabetica(List<Cliente> lista)
    {
        lista.Sort();
        foreach (var item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public static void ClienteComProfissao(List<Cliente> lista, string profissao)
    {
        foreach (var item in lista)
        {
            if (item.Profissao == profissao)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    public static void PessoasAniversariantes(List<Pessoa> lista, int mes)
    {
        foreach (var item in lista)
        {
            if (item.DataNascimento.Month == mes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    
}
