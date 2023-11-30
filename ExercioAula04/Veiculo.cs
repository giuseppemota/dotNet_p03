namespace ExercioAula04;
public class Veiculo
{
    public string? Marca { get; set; }
    public string? Cor { get; set; }
    public int Ano { get; set; }

    public int IdadeVeiculo => DateTime.Now.Year - Ano;
}


