int n1;
Console.WriteLine("Digite um número");
try
{
    n1 = int.Parse(Console.ReadLine());
    for (int i = 1; i <= 9; i++)
    {
        Console.WriteLine(n1 + "x" + i + "=" + (n1 * i));
    }
}
catch (Exception digitou_letra)
{
    Console.WriteLine("Você digitou uma letra");
}
finally
{
    Console.WriteLine("Pressione uma tecla para sair");
    Console.ReadKey();
}

