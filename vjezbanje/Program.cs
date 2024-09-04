using vjezbanje;

internal class Program
{

    private static void Main(string[] args)
    {

        Console.WriteLine("Aplikacija pokrenuta.");

        OsobaController osobaController = new OsobaController();
        Console.WriteLine("****OPCIJE ZA IMENIK****");
        
        while (true)
        {
            Console.WriteLine("Odaberi opciju: \n1. Dohvati osobu\n2. Dohvati sve osobe\n3. Kreiraj novu osobu\n4. Ažuriraj osobu\n5. Izbriši osobu iz imenika\n6. Izađi iz programa");
            var opcija = Console.ReadLine();
            switch (opcija) {
                case "1":
                    Console.WriteLine("Unesi ID osobe koju želiš dohvatiti: ");
                    var idDohvati = Int32.Parse(Console.ReadLine());
                    osobaController.dohvatiOsobu(idDohvati);
                    break;
                case "2":
                    osobaController.dohvatiSveOsobe();
                    break;
                case "3":
                    osobaController.kreirajOsobu();
                    break;
                case "4":
                    Console.WriteLine("Unesi ID osobe koju želiš ažurirati: ");
                    var id = Int32.Parse(Console.ReadLine());
                    osobaController.azurirajOsobu(id);
                    break;
                case "5":
                    Console.WriteLine("Unesi ID osobe koju želiš obrisati: ");
                    var idBrisi = Int32.Parse(Console.ReadLine());
                    osobaController.obrisiOsobu(idBrisi);
                    break;
                case "6":
                    break;
            }
            Console.WriteLine("Želite li nastaviti ili izaći iz programa?\nUpiši 1 za nastavak\nUpiši 2 za izlaz");
            var zelimLiNastavit = Console.ReadLine();
            if (zelimLiNastavit == "1") continue;
            else if (zelimLiNastavit == "2") break;
        } 
    }
}

