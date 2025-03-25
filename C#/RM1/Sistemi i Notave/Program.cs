using System;

class Program
{
    static void Main()
    {
        double piketDetyrave = 0;
        double piketKuizit = 0;
        double piketProvimit = 0;
        double notaMesatare = 0;
        string vazhdo = "jo";


        do
        {
            Console.Write("Shkruani piket për detyrat (0-100): ");
            piketDetyrave = Convert.ToDouble(Console.ReadLine());

            Console.Write("Shkruani piket për kuizin (0-100): ");
            piketKuizit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Shkruani piket për provimin (0-100): ");
            piketProvimit = Convert.ToDouble(Console.ReadLine());

            notaMesatare = (piketDetyrave + piketKuizit + piketProvimit) / 3;

            Console.WriteLine($"Nota mesatare e studentit është: {notaMesatare}");

            if (notaMesatare >= 90 && notaMesatare <= 100)
                Console.WriteLine("Nota juaj eshte : A");

            else if (notaMesatare >= 80 && notaMesatare <= 89)
                Console.WriteLine("Nota juaj eshte : B");

            else if (notaMesatare >= 70 && notaMesatare <= 79)
                Console.WriteLine("Nota juaj eshte : C");

            else if (notaMesatare >= 60 && notaMesatare <= 69)
                Console.WriteLine("Nota juaj eshte : D");

            else
                Console.WriteLine("Nota juaj eshte : F");


            Console.Write("A dëshiron të llogarisni noten per dike tjeter? (po/jo): ");
            vazhdo = Console.ReadLine();

        } while (vazhdo == "po");
    }
}