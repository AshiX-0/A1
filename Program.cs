using System;

namespace TP9
{
    class Program
    {
        static void Main()
        {
            
        }

        static void Ex1()
        {
            Console.WriteLine("Entrez votre age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 25)
            {
                Console.WriteLine("Salut gamin");
            }
            else if (age < 55 && age >= 25)
            {
                Console.WriteLine("Bonjour monsieur");
            }
            else
            {
                Console.WriteLine("Je te vénère, oh mon grand maître");
            }
        }
        static void Ex2()
        {
            Console.WriteLine("Entrer poids");
            double poids = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entrer taille en cm");
            double taille = Convert.ToDouble(Console.ReadLine()) / 100;
            double imc = poids / (taille * taille);
            if (imc < 19)
            {
                Console.WriteLine("maigre");
            }
            else if (imc >= 19 && imc < 25)
            {
                Console.WriteLine("Sans interet");
            }
            else if (imc >= 25 && imc < 40)
            {
                Console.WriteLine("Gros");
            }
            else
            {
                Console.WriteLine("Obese");
            }

            
        }
        static void Ex3()
        {
            Console.WriteLine("Entrez deux réels a et b: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if ((a-b) == 0.0)
            {
                Console.WriteLine("les deux nombres sont égaux");
            }
            else if ((a-b) > 0.0) 
            {
                Console.WriteLine("le premier nombre est le plus grand");
            }
            else
            {
                Console.WriteLine("Le deuxieme nombre est plus grand");
            }
        }
        static void Ex4()
        {
            Console.WriteLine("Entrez un nombre réel");
            double xyz = Convert.ToDouble(Console.ReadLine());
            if (xyz >= 0.0)
            {
                Console.WriteLine("Valeur absolue : "+xyz);
            }
            else
            {
                xyz = -xyz;
                Console.WriteLine("Valeur absolue : " + xyz);
            }
        }
        static void Ex5()
        {
            Console.WriteLine("Donnez longueur coté");
            double side = Convert.ToDouble(Console.ReadLine());
            double area = side * side;
            Console.WriteLine("Surface = " + area);
        }
        static void Ex6()
        {
            Console.WriteLine("Donnez longueur : ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Donnez largeur : ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            double area = side1 * side2;
            Console.WriteLine("Surface = " + area);
        }
        static void Ex7()
        {
            Console.WriteLine("Donnez rayon");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("Surface = " + area);
        }
        static void Ex8()
        {
            Console.WriteLine("Donnez rayon");
            double radius = Convert.ToDouble(Console.ReadLine());
            double areaC = Math.PI * radius * radius;
            double sideSq = Math.Sqrt(areaC);
            Console.WriteLine("Coté du carré de même surface : " + sideSq);
        }
        static void Ex9()
        {
            int val1 = 34;
            int val2 = 678;
            Console.WriteLine("val1 = " + val1 + "; val2 = " + val2);
            int buff = val1;
            val1 = val2;
            val2 = buff;
            Console.WriteLine("val1 = " + val1 + "; val2 = " + val2);
        }
        static void Ex10()
        {
            string syll = Console.ReadLine();
            syll = syll + syll;
            Console.WriteLine(syll);
        }
        static void Ex11()
        {
            string syll = "ah";
            Console.WriteLine("Nbr de répétitions ? : ");
            int n = Convert.ToInt32(Console.ReadLine());
            string lign = "";
            for (int i = 0; i < n; i++)
            {
                lign = lign + syll;
            }
            Console.WriteLine(lign);
        }
        static void Ex12()
        {
            Console.WriteLine("Donnez un entier : ");
            int nbr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Donnez un autre entier : ");
            int nbr2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moyenne = " + (nbr1 + nbr2) / 2);
        }
        static void Ex13()
        {
            Console.WriteLine("Donnez une température en Celcius : ");
            double tempC = Convert.ToDouble(Console.ReadLine());
            double tempF = 32 + 1.8 * tempC;
            Console.WriteLine("Temperature en Farhenheit : " + tempF);
        }
    }
}
