Console.WriteLine("Hello, World .NET");

#region Teste de Tipos deDados

    int tipoInteiro;
    double tipoDouble;
    string tipoString;
    long tipoLong;

    tipoString = "100";

    tipoInteiro = int.Parse(tipoString);

    //tipoInteiro = int.MaxValue;
    tipoLong = long.MaxValue;
    tipoDouble = double.MaxValue;

    Console.WriteLine("O máximo inteiro é: " + tipoInteiro);
    Console.WriteLine("O máximo long é: " + tipoLong);
    Console.WriteLine("O máximo double é: " + tipoDouble);

#endregion

#region Operadores

    tipoDouble = tipoInteiro + tipoLong;
    System.Console.WriteLine(tipoDouble);
    tipoInteiro = 10 > 5 ? 1 : 0;

#endregion