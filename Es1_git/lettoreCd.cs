public class LettoreCD
    {
        public string Marca { get; set; }
        public CD CdCaricato { get; set; }

        public LettoreCD(string marca)
        {
            Marca = marca;
            CdCaricato = null;
        }

        public void InserisciCD(CD cd)
        {
            CdCaricato = cd;
            Console.WriteLine($"[Lettore {Marca}] Inserito il CD: '{cd.Titolo}'.");
        }

        public void Riproduci()
        {
            if (CdCaricato != null)
            {
                Console.WriteLine($"[Lettore {Marca}] In riproduzione: {CdCaricato.Titolo}");
            }
            else
            {
                Console.WriteLine($"[Lettore {Marca}] Nastro/CD vuoto.");
            }
        }
    }