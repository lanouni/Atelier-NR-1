using System;


namespace Atelier1
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        public Client(string n, string p, string a)
        {
            nom = n;
            prenom = p;
            adresse = a;
        }
        public void afficher()
        {
            Console.WriteLine("nom " + nom + " prenom " + prenom+" ");
        }
    }
}
