using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema04
{
    class Program
    {
        static void Main(string[] args)
        {
            // ex 1
            // Creati un obiect Animal cu caracteristicile: tipAnimal de tip String (caine, pisica, iepure etc), 
            // culoare de tip String, varsta de tip int. Clasa va contine declararea variabilelor, metode de tip accesor (set si get)
            // si 3 constructori.In Program.cs sau o clasa cu metoda Main creati 3 instante ale clasei Animal in metoda main.

            Animal animal1 = new Animal();
            animal1.tipAnimal = "caine";
            animal1.culoare = "maro";
            animal1.varsta = 3;

            Console.WriteLine();
            Console.WriteLine("Tip animal: " + animal1.tipAnimal + "\nCuloare: " + animal1.culoare + "\nVarsta: " + animal1.varsta);

            Animal animal2 = new Animal("pisica");
            animal2.culoare = "gri";
            animal2.varsta = 1;

            Console.WriteLine();
            Console.WriteLine("Tip animal: " + animal2.tipAnimal + "\nCuloare: " + animal2.culoare + "\nVarsta: " + animal2.varsta);

            Animal animal3 = new Animal("iepure", "alb", 2);

            Console.WriteLine();
            Console.WriteLine("Tip animal: " + animal3.tipAnimal + "\nCuloare: " + animal3.culoare + "\nVarsta: " + animal3.varsta);


            Console.ReadKey();

            // ex 2

            // Create un obiect / clasa Imobil ce contine variabilele: tipCasa de tip String (apartament, casa, vila etc),
            // nrEtaje de tip int, pret de tip double. Declarati variabilele, metodele accesor set si get si constructori
            // care sa va ajute la crearea instantelor acestui obiect. Apelati clasa Imobil in Program.cs sau o clasa cu metoda Main,
            // utilizand constructorii si metodele set si get din clasa Imobil.

            Imobil imobil1 = new Imobil();
            imobil1.tipCasa = "apartament";
            imobil1.nrEtaje = 8;
            imobil1.pret = 60000;

            Console.WriteLine();
            Console.WriteLine("Tip imobil: " + imobil1.tipCasa + "\nNumar etaje: " + imobil1.nrEtaje + "\nPret: " + imobil1.pret);

            Imobil imobil2 = new Imobil("casa");
            imobil2.nrEtaje = 1;
            imobil2.pret = 70000;

            Console.WriteLine();
            Console.WriteLine("Tip imobil: " + imobil2.tipCasa + "\nNumar etaje: " + imobil2.nrEtaje + "\nPret: " + imobil2.pret);

            Imobil imobil3 = new Imobil("vila", 2, 80000);

            Console.WriteLine();
            Console.WriteLine("Tip imobil: " + imobil3.tipCasa + "\nNumar etaje: " + imobil3.nrEtaje + "\nPret: " + imobil3.pret);

            Console.ReadKey();


            // tema 3 ex 6: Avand un vector de numere intregi, adunati un nr double la valorile stocate
            // si pastrati rezultatul in alt vector corespunzator.

            Console.WriteLine();
            Console.WriteLine("tema 3 ex 6");


            int[] vector3 = new int[] { 4, 8, 12, 1, 7 };
            double d = 5.2;
            double[] vector3Modificat = new double[vector3.Length];
            for (int i = 0; i < vector3.Length; i++)
            {
                vector3Modificat[i] = vector3[i] + d;
                Console.Write(vector3Modificat[i] + " ");
            }


            Console.ReadKey();
        }
    }
}
