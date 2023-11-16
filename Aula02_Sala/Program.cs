
string[] collection = { "Item 1", "Item 2", "Item 3", "Item 4" };

foreach (string item in collection)
{
    System.Console.WriteLine(item);
}

#region numeros divisiveis por 3 ou 4

for (int i = 0; i < 30; i++)
{
    if (i % 3 == 0 || i % 4 == 0)
    {
        System.Console.WriteLine(i);
    }
}
#endregion 

#region Fibonnati
int fib1 = 0;
int fib2 = 1;
int fib3 = 0;
while (fib3 <= 100)
{
    fib3 = fib1 + fib2;
    fib1 = fib2;
    fib2 = fib3;
    System.Console.WriteLine(fib3);
}

#endregion

#region 
for (int i = 0; i < 8; i++)
{

    for (int j = 0; j < 8; j++)
    {

    }
}
#endregion

#region Escada

for (int i = 1; i <= 8; i++)
{
    for (int j = 1; j <= i; j++)
    {
        System.Console.Write(i * j + "\n");
    }
    System.Console.WriteLine();
}
#endregion

