using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Operation
    {
        private static int cmt = 0;
        private int numero;
        private MAD montant;
        private string libelle;
        private DateTime date;

        public Operation( MAD montant, string libelle)
        {
            this.numero = cmt++;
            this.montant = montant;
            this.libelle = libelle;
            this.date =DateTime.Now;
        }
        public void afficher()
        {
            string op = "+";
            if(this.libelle == "debiter")
            {
                op = "-";
            }
            Console.WriteLine(date+"| NR: "+ numero + "||"+ op );
            montant.afficer();
        }
    }
}
