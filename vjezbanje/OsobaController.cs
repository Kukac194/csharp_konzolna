namespace vjezbanje
{
    class OsobaController : IOsobaController
    {
        private Osoba osoba;
        private static int idOsobe = 0;
        private static List<Osoba> osobe = new List<Osoba>();

        public void kreirajOsobu() {
            osoba = new Osoba();
            osoba.setId(idOsobe++);

            stringInputi("ime", osoba);
            stringInputi("prezime", osoba);
            stringInputi("drzava", osoba);
            stringInputi("grad", osoba);
            stringInputi("telefon", osoba);
            stringInputi("email", osoba);


            while (true)
            {
                Console.WriteLine("Unesi dob osobe: ");
                var dob = Console.ReadLine();

                if (String.IsNullOrEmpty(dob))
                {
                    Console.WriteLine("Dob ne smije biti prazna!");
                    continue;
                }
                else
                {
                    var intRep = Int32.Parse(dob);
                    if (intRep < 0 || intRep == 0) 
                    {
                        Console.WriteLine("Dob ne smije biti manja 0 ili jednaka 0!");
                        continue;
                    }

                    osoba.setAge(Int32.Parse(dob));
                    break;
                }
            }
            osobe.Add(osoba);
            Console.WriteLine("Ime: {0} | Prezime: {1} | Dob: {2}", osoba.getFirstName(), osoba.getLastName(), osoba.getAge());
        }

        private void stringInputi(String startniInput, Osoba osoba)
        {

            while (true)
            {
                Console.WriteLine("Unesi {0} osobe: ", startniInput);
                var parametar = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(parametar))
                {
                    Console.WriteLine("{0} polje ne smije biti prazno!", startniInput);
                    continue;
                }
                else
                {
                    switch(startniInput)
                    {
                        case "ime":
                            osoba.setFirstName(parametar); break;
                        case "prezime":
                            osoba.setLastName(parametar);break;
                        case "grad":
                            osoba.setCity(parametar); break;
                        case "telefon":
                            osoba.setPhone(parametar); break;
                        case "drzava":
                            osoba.setCountry(parametar); break;
                        case "email":
                            osoba.setEmail(parametar);break;
                    }
                  
                    break;
                }

            }
        }

    
        public void dohvatiOsobu(int id)
        {

            try
            {
                Osoba osoba = osobe.Find(o => o.getId() == id);

                if (osoba == null)
                {
                    throw new Exception("Osoba ne postoji.");
                }

                Console.WriteLine(
                    "ID: {0}\nIme: {1}\nPrezime: {2}\nDob: {3}\nE-mail: {4}\nTelefon: {5}\nGrad: {6}\nDržava: {7}",
                    osoba.getId(),
                    osoba.getFirstName(),
                    osoba.getLastName(),
                    osoba.getAge(),
                    osoba.getEmail(),
                    osoba.getPhone(),
                    osoba.getCity(),
                    osoba.getCountry()
                    );
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public void obrisiOsobu(int id)
        {
            try
            {
                Osoba osoba = osobe.Find(o => o.getId() == id);

                if (osoba == null)
                {
                    throw new Exception("Osoba ne postoji.");
                }

                osobe.Remove(osoba);
                Console.WriteLine("Osoba sa ID-em {0} uspješno izbrisana.", id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void azurirajOsobu(int id)
        {
            Console.WriteLine("Azuriram osobu s ID-em {0}", id);
        }

        public void dohvatiSveOsobe()
        {
            foreach(Osoba osoba in osobe)
            {
                Console.WriteLine("----------");

                Console.WriteLine(
                "ID: {0}\nIme: {1}\nPrezime: {2}\nDob: {3}\nE-mail: {4}\nTelefon: {5}\nGrad: {6}\nDržava: {7}",
                osoba.getId(),
                osoba.getFirstName(),
                osoba.getLastName(),
                osoba.getAge(),
                osoba.getEmail(),
                osoba.getPhone(),
                osoba.getCity(),
                osoba.getCountry()
                );
                Console.WriteLine("----------");
            }
        }
    }
}
