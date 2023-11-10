#region Numeros inteiros no C#:
        

        sbyte SByte = 10;
        Console.WriteLine(SByte);

        byte Byte = 255;
        Console.WriteLine(Byte);

        short Short = 30000;
        Console.WriteLine(Short);

        ushort UShort = 60000;
        Console.WriteLine(UShort);

        int Int = 2000000000;
        Console.WriteLine(Int);

        uint UInt = 4000000000;
        Console.WriteLine(UInt);

        long Long = 9000000000000000000;
        Console.WriteLine(Long);

        ulong ULong = 18000000000000000000;
        Console.WriteLine(ULong);

#endregion

#region Convertendo Double para int:
double numeroDouble = 10.7;
        int numeroInteiro;

        numeroInteiro = (int)numeroDouble;
        Console.WriteLine("Número double: " + numeroDouble);
        Console.WriteLine("Número inteiro depois da conversão: " + numeroInteiro);

#endregion

#region Operadores Aritméticos:

        int x = 10;
        int y = 3;

        Console.WriteLine("O resultado da soma é: " + (x+y));
        Console.WriteLine("O resultado da subtração é: " + (x-y));
        Console.WriteLine("O resultado da multiplicação é: " + (x*y));
        Console.WriteLine("O resultado da divisão é: " + (x/y));

#endregion

#region Operadores de Comparação:

        int a = 5;
        int b = 8;

        string resultado = a > b ? "Valor de A é maior que B" : "Valor de B é maior a A";
        Console.WriteLine(resultado);
#endregion

