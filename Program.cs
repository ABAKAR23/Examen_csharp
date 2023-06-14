using pharmacie;

Pharmacie pharmacie = new Pharmacie();
pharmacie.AjouterMedicament("Paracetamol", 50, 5.99m);
pharmacie.AjouterMedicament("Aspirine", 100, 3.99m);
Patient patient = new Patient("kelley abakar", "123 Rue Principale");
Ordonnance ordonnance = new Ordonnance(patient.Nom);
Console.WriteLine("Stocks de la pharmacie :");
pharmacie.AfficherStocks();
Console.WriteLine("Liste des ordonnances :");





