using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

namespace Comparaison_de_2_Objets
{
    class Program
    {
        static void Main(string[] args)
        {
            Stagaire s1 = new Stagaire();

            Console.WriteLine("give the s1 informations in below ");

            s1.Num = int.Parse(Console.ReadLine());
            s1.Nom = Console.ReadLine();
            s1.Prenom = Console.ReadLine();
            s1.datenaissance = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Your data is \n");

            s1.Afficher();

            // 2eme Stagaire a comparer 

            Stagaire s2 = new Stagaire();

            s2.Num = int.Parse(Console.ReadLine());
            s2.Nom = Console.ReadLine();
            s2.Prenom = Console.ReadLine();
            s2.datenaissance = Convert.ToDateTime(Console.ReadLine());

            if (s1.ComparerDeuxStagaires(s2) == true)
                Console.WriteLine(true);

            else
                Console.WriteLine(false);


        }
    }
}
