using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pharmacie
{


    public class pharmacie
    {
        private List<Medicament> stocks;
        private List<Patient> patients;
        private List<Ordonnance> ordonnances;

        public pharmacie()
        {

            stocks = new List<Medicament>();

            patients = new List<Patient>();

            ordonnances = new List<Ordonnance>();

        }

        public void AjouterMedicament(string nom, int quantite, decimal prix)
        {
            Medicament medicament = new Medicament(nom, quantite, prix);
            stocks.Add(medicament);
            Console.WriteLine($"Le médicament {nom} a été ajouté au stock.");

        }

        public void SupprimerMedicament(string nom)
        {
            Medicament medicament = stocks.Find(m => m.Nom == nom);
            //Medicament medicament = stocks.Find(m => m.N);

            if (medicament != null)
            {
                stocks.Remove(medicament);
                Console.WriteLine($"Le médicament {nom} a été supprimé du stock.");
            }
            else
            {
                Console.WriteLine($"Le médicament {nom} n'existe pas dans le stock.");
            }
        }

        public void AfficherStocks()
        {
            Console.WriteLine("Stocks de la pharmacie :");

            foreach (var medicament in stocks)
            {
                Console.WriteLine($"- Nom : {medicament.Nom}, Quantité : {medicament.Quantite}, Prix : {medicament.Prix}");
            }
        }
    }
}
        