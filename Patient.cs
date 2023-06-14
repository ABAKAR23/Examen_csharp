using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacie
{
    public  class Patient
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }

        public Patient(string nom, string adresse)
        {
            Nom = nom;
            Adresse = adresse;
        }
    }
}
