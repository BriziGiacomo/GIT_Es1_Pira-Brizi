 class Program
    {
        static void Main(string[] args)
        {
            // --- TEST STUDENTE 1 ---
            Console.WriteLine("=== TEST STUDENTE 1 ===");
            Brano b1 = new Brano("Bohemian Rhapsody", "Queen", 354);
            Brano b2 = new Brano("Song 2", "Blur", 122);

            Artista a1 = new Artista("Queen", "Rock");
            Recensione r1 = new Recensione(5, "Capolavoro assoluto");

            Console.WriteLine(b1.ToString());
            Console.WriteLine($"'{b1.Titolo}' è breve (ShortSong)? {b1.ShortSong()}");
            Console.WriteLine($"'{b2.Titolo}' è breve (ShortSong)? {b2.ShortSong()}");
            Console.WriteLine(a1.ToString());
            Console.WriteLine(r1.ToString());


            // --- TEST STUDENTE 2 ---
            Console.WriteLine("\n=== TEST STUDENTE 2 ===");
            CD cd1 = new CD("Greatest Hits", "Queen");
            cd1.AggiungiBrano(b1);
            cd1.AggiungiBrano(b2);

            Console.WriteLine(cd1.ToString());

            LettoreCD lettore = new LettoreCD("Sony");
            lettore.InserisciCD(cd1);
            lettore.Riproduci();

            Scaffale scaffale = new Scaffale(1);
            scaffale.AggiungiCD(cd1);
            scaffale.MostraContenuto();


            // --- TEST STUDENTE 3 ---
            Console.WriteLine("\n=== TEST STUDENTE 3 ===");
            Negozio negozio = new Negozio("Disco Club");
            negozio.AggiungiAlCatalogo(cd1);
            negozio.StampaCatalogo();

            Utente cliente = new Utente("Luca", 20.0);
            cliente.AcquistaCD(cd1, 15.0);

            Console.WriteLine("\nPremi un tasto per terminare...");
            Console.ReadKey();
        }
    }
}