using System;


namespace Atelier1
{
    class Compte
    {
        private static int cpt = 0;
        private int num;
        private MAD solde;
        private Client client;
        private static MAD plafond = new MAD(2000);
        public Compte(float s , string n , string p , string a)
        {
            cpt += 1;
            num = cpt;
            solde = new MAD(s);
            client = new Client(n, p, a);
        }
        public bool crediter(MAD montant)
        {
            if (MAD.test(montant,plafond) == false)
            {
                solde = solde + montant;
                return true;
            }
            return false;
        }
        public bool debiter(MAD montant)
        {
            if (MAD.test(montant, plafond) == false)
            {
                solde = solde - montant;
                return true;
            }
            return false;
        }
        public void virement(Compte C, MAD M)
        {
            C.debiter(M);
            this.crediter(M);
        }
        public void afficher()
        {
            client.afficher();
            Console.WriteLine("matricule "+num+"\n");
            solde.afficer();
        }
    }
}
