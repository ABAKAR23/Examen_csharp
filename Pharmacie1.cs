using pharmacie;

internal class Pharmacie
{
    private List<Medicament> stocks;
    private List<Patient> patients;
    private List<Ordonnance> ordonnances;

    public Pharmacie()
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
