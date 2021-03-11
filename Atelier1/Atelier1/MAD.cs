using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class MAD
    {
        private float valeur;
        public MAD(float v)
        {
            valeur = v;
        }
        public void afficer()
        {
            Console.Write("le solde est : " + valeur + " ");
        }
        public static MAD operator+(MAD m ,MAD c)
        {
            MAD t = new MAD(m.valeur + c.valeur);
            return t;
        } 
        public static bool test(MAD a, MAD B)
        {
            if (B.valeur > a.valeur)
            {
                return true;
            }
            return false;
        } 
        public static MAD operator-(MAD A, MAD B)
        {
            MAD t = new MAD(A.valeur-B.valeur);
            return t;
        }
    }
}
