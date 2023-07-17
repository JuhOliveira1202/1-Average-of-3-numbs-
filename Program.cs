// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static int LerNumero()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    public static float Media(int a, int b, int c)
    {
        return (a + b + c) / 3;
    }

    public static void Escrever(float v)
    {
        Console.WriteLine(v);
    }

    public static void Main(string[] args)
    {
        int x,y,z;

        Console.Write("Digite o 1º número: ");
        x = LerNumero();

        Console.Write("Digite o 2º número: ");
        y = LerNumero();

        Console.Write("Digite o 3º número: ");
        z = LerNumero();

        Escrever(Media(x, y, z));

    }
}
