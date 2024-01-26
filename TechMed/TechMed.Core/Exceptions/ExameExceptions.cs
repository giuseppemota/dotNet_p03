namespace TechMed.Core.Exceptions;
public class ExameNotFoundException : Exception
{
    public ExameNotFoundException() :
    base("Exame não encontrado.")
    {  
    }
}

public class ExameAlreadyExistsException : Exception
{
    public ExameAlreadyExistsException() :
    base("Exame já existe.")
    {
    }
}
