using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pharmacie
{
    public class Ordonnance
    {
        public string NomPatient { get; set; }
        public List<string> Medicaments { get; set; }
        public Ordonnance(string nomPatient)
        {
            NomPatient = nomPatient;
        }


        public void AjouterMedicament(string nomMedicament)
        {
            Medicaments.Add(nomMedicament);
        }
    }
}
