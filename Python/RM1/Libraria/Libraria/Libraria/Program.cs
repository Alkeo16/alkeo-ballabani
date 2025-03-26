class Libraria
{
    static void Main(string[] args)
    {

        string[,] librat_matric = new string[99, 4];
        int opsioni;

        do
        {
            Console.WriteLine("Mireserdhe ne librari");
            Console.WriteLine("");
            Console.WriteLine("0. Shtyp zero per te dal nga programi.");
            Console.WriteLine("1. Shtypni 1 per te shtuar nje liber.");
            Console.WriteLine("2. Shtypni 2 per te shitur nje liber.");
            Console.WriteLine("3. Shtypni 3 per te par listen e librave.");

            opsioni = int.Parse(Console.ReadLine());
            Console.Clear();

            if (opsioni == 1)
            {
                librat_matric = shto_liber(librat_matric);
            }
            else if (opsioni == 2)
            {
                Console.WriteLine("Ju keni zgjedhur opsionin 2.");
            }
            else if (opsioni == 3)
            {
                Console.WriteLine("Lista e librave.");
                shfaq_librat(librat_matric);
            }
            else
            {
                Console.WriteLine("Opsioni juaj nuk bo");
            }
        } while (opsioni != 0);
    }


    static string[,] shto_liber(string[,] matrica_librat)
    {
        for (int i = 0; i < 99; i++)
        {
            if (matrica_librat[i, 0] == null)
            {
                Console.Write("Vendos ID e librit te ri :");
                matrica_librat[i, 0] = Console.ReadLine();

                Console.Write("Vendos Titullin e librit te ri :");
                matrica_librat[i, 1] = Console.ReadLine();

                Console.Write("Vendos Autorin e librit te ri :");
                matrica_librat[i, 2] = Console.ReadLine();

                Console.Write("Vendos Sasin e librit te ri :");
                matrica_librat[i, 3] = Console.ReadLine();

                Console.WriteLine("");
                return matrica_librat;
            }
        }

        Console.WriteLine("");
        return matrica_librat;
    }

    static void shfaq_librat(string[,] matrica_librat)
    {
        for (int i = 0; i < 99; i++)
        {
            if (matrica_librat[i, 0] != null)
            {
                Console.Write("ID" + matrica_librat[i, 0] + ",");
                Console.Write("Titulli" + matrica_librat[i, 01] + ",");
                Console.Write("Autori" + matrica_librat[i, 2] + ",");
                Console.Write("Sasia" + matrica_librat[i, 3] + ",");
            }
        }
        Console.WriteLine("");
    }
}