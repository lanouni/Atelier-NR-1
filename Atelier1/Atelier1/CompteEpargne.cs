using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class CompteEpargne:Compte
    {
        private float TauxIteret;

        public CompteEpargne(float s )
            :base(s)
        {
            Console.Write("entrer le Taux: ");
            float tauxIteret= float.Parse(Console.ReadLine());
            while(tauxIteret <=0 || tauxIteret >= 100)
            {
                Console.Write("veiller entrer un Taux entre 0 et 100: ");
                tauxIteret = float.Parse(Console.ReadLine());
            }
            TauxIteret = tauxIteret;
        }
        public void calculInteret()
        {
            float res = this.TauxIteret / 100;
            solde += solde * res;
        }
    }
}
