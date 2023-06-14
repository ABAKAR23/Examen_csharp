using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacie
{
    public  class Facture
    {
        public string NomPatient { get; set; }
        public List<string> Medicaments { get; set; }
        public decimal MontantTotal { get; set; }


        public Facture(string nomPatient, List<string> medicaments, decimal montantTotal)
        {
            NomPatient = nomPatient;
            Medicaments = medicaments;
            MontantTotal = montantTotal;
        }

        public void AfficherFacture()
        {
            Console.WriteLine("Facture");
            Console.WriteLine("---------");
            Console.WriteLine($"Patient : {NomPatient}");
            Console.WriteLine("Médicaments :");

            foreach (var medicament in Medicaments)
            {
                Console.WriteLine($"- {medicament}");
                Console.WriteLine($"Montant total : {MontantTotal:C}");
                Console.WriteLine("---------");
            }


        }
    }
}
