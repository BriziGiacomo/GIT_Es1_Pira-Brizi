public class CD
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public List<Brano> ListaBrani { get; set; }

        public CD(string titolo, string autore)
        {
            Titolo = titolo;
            Autore = autore;
            ListaBrani = new List<Brano>();
        }

        // Metodo per aggiungere un brano al CD
        public void AggiungiBrano(Brano brano)
        {
            ListaBrani.Add(brano);
        }

        // Calcolo della durata complessiva del CD
        public int DurataComplessiva()
        {
            int durataTotale = 0;
            foreach (Brano b in ListaBrani)
            {
                durataTotale += b.Durata;
            }
            return durataTotale;
        }

        // Override del metodo ToString
        public override string ToString()
        {
            string info = $"--- CD: {Titolo} di {Autore} (Durata totale: {DurataComplessiva()} sec) ---\n";
            foreach (Brano b in ListaBrani)
            {
                info += $" - {b.ToString()}\n";
            }
            return info;
        }
    }