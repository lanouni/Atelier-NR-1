using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class CompteCourant:Compte
    {
        static MAD decouvert = new MAD(1000);
        public CompteCourant(float s )
            : base(s)
        {
        }
        public override bool debiter(MAD montant)
        {
            if(MAD.test(solde-montant , CompteCourant.decouvert) == false)
            {
                return false;
            }

            return base.debiter(montant);
        }
    }
}
