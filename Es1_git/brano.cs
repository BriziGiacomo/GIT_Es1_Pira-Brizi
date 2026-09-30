public class Brano
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public int Durata { get; set; }  

        public Brano(string titolo, string autore, int durata)
        {
            Titolo = titolo;
            Autore = autore;
            Durata = durata;
        }

        public bool ShortSong()
        {
            return Durata < 180;
        }

        public override string ToString()
        {
            return $"{Titolo} - {Autore} ({Durata} sec)";
        }
    }

    

    