using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacie
{
    public class Medicament
    {
        public string Nom { get; set; }
        public int Quantite { get; set; }
        public decimal Prix { get; set; }


        public Medicament(string nom, int quantite, decimal prix)
        {
            Nom = nom;
            Quantite = quantite;
            Prix = prix;
        }
    }
}
