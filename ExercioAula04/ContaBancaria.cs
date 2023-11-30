namespace ExercioAula04;
public class ContaBancaria
{
    public double Saldo
    {
        get { return Saldo; }
        set
        {
            if (value > 0)
            {
                Saldo = value;
            }
            else
                throw new ArgumentException("O saldo não pode ser negativo");
        }
    }
}
