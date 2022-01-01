using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparaison_de_2_Objets
{
    class Stagaire
    {
        private int num;
        private string nom, prenom;
        private DateTime dateNaissance;

        // Constructeur par defaut 

        public Stagaire()
        {

        }

        // Constructeur d'Initialisation 
        public Stagaire(int num, string nom, string prenom, DateTime dateNaissance)
        {
            this.num = num;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        public Stagaire(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        // Getters & Setters 

        public int Num
        {
            get
            {
                return this.num;
            }

            set
            {
                this.num = value;
            }
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }

            set
            {
                this.nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return this.prenom;
            }

            set
            {
                this.prenom = value;
            }
        }

        public DateTime datenaissance
        {
            get
            {
                return this.dateNaissance;
            }

            set
            {
                this.dateNaissance = value;
            }
        }

        // Methods 

        public void Afficher()
        {
            Console.WriteLine("hello Guys ");
            Console.WriteLine("Le num est: " + this.Num);
            Console.WriteLine("Le nom est: " + this.Nom);
            Console.WriteLine("Le prenom est: " + this.Prenom);
            Console.WriteLine("La date de naissance est: " + this.datenaissance);
        }

        // Comparer deux stagaires 

        public bool ComparerDeuxStagaires (Stagaire s)
        {
            if (this.Num == s.Num)
                return true;

            else
                return false;
        }
    }
}
