using System;



namespace Atelier1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Compte C = new Compte(5000,"ijfr","ijfr","ijfr");
            Compte C2 = new Compte(15000,"ijfr","ijfr","ijfr");
            MAD M = new MAD(2000);
            // C.virement(C2,M);
            C.virement(C2,M);
            C.afficher();
            C2.afficher();
        }
    }
}
