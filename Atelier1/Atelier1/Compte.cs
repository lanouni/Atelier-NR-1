using System;
using System.Collections.Generic;

namespace Atelier1
{
    class Compte
    {
        private static int cpt = 0;
        private int num;
        protected MAD solde;
        private static MAD plafond = new MAD(2000);
        private List<Operation> op;
        public Compte(float s )
        {
            cpt += 1;
            num = cpt;
            solde = new MAD(s);
            op = new List<Operation>();
        }
        public bool crediter(MAD montant)
        {
            if (MAD.test(montant,plafond) == false)
            {
                solde = solde + montant;
                op.Add(new Operation(montant,"credite"));
                return true;
            }
            return false;
        }
        public virtual bool debiter(MAD montant)
        {
            if (MAD.test(montant, plafond) == false)
            {
                solde = solde - montant;
                op.Add(new Operation(montant, "debiter"));
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
            Console.Write("matricule "+num);
            solde.afficer();
        }
    }
}
