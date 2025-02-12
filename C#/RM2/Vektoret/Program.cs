using System;

class Program
{
    static void Main()
    {
        int[] notat = new int[10];


        for (int i = 0; i < 10; i++)
        {
            Console.Write("Futni notën nga 4 deri ne 10 : ");
            notat[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Notat e dhena:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(notat[i]);
        }

        int notaMeELarte = notat[0];
        int notaMeEUlet = notat[0];
        int shuma = 0;
        int notaMbi5 = 0;

        for (int i = 0; i < 10; i++)
        {

            if (notat[i] > notaMeELarte)
                notaMeELarte = notat[i];

            if (notat[i] < notaMeEUlet)
                notaMeEUlet = notat[i];

            shuma += notat[i];

            if (notat[i] > 5)
                notaMbi5++;
        }

        double mesatarja = shuma / 10;

        Console.WriteLine($"Nota me e larte: {notaMeELarte}");

        Console.WriteLine($"Nota me e ulet: {notaMeEUlet}");
        Console.WriteLine($"Nota mesatare: {mesatarja}");

        Console.WriteLine($"Numri i notave mbi 5: {notaMbi5}");

    }
}