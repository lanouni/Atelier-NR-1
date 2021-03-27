using System;
using System.Collections.Generic;

namespace Atelier1
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        private List<Compte>list;
        public Client(string n, string p, string a)
        {
            list = new List<Compte>();
            nom = n;
            prenom = p;
            adresse = a;
            int b = 1;
            float solde = 0;
            string type = "";
            while(true)
            {
                Console.Write("entrer le solde : ");
                solde = float.Parse(Console.ReadLine());
                Console.WriteLine("entrer le type e pour compagne c pour compte courant: ");
                type = Console.ReadLine();
                if (type == "e")
                {
                    CompteEpargne c = new CompteEpargne(solde);
                    list.Add(c);
                    c.calculInteret();
                }
                else if (type == "c")
                {
                    list.Add(new CompteCourant(solde));
                }
                Console.WriteLine("entrer 0 pour quitter ");
                b = Int32.Parse(Console.ReadLine());
                
                if (b == 0)
                {
                    break;
                }
            }
        }
        public void afficher()
        {
            Console.WriteLine("nom " + nom + " prenom " + prenom+" ");
            Console.WriteLine("la liste de compte est :");
            for(int i = 0; i < list.Count; i++)
            {
                list[i].afficher();
            }
        }
    }
}
