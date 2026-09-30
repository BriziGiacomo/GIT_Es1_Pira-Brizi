public class Recensione
    {
        public int Voto { get; set; } 
        public string Commento { get; set; }

        public Recensione(int voto, string commento)
        {
            Voto = voto;
            Commento = commento;
        }

        public bool EsitoPositivo()
        {
            return Voto >= 3;
        }

        public override string ToString()
        {
            return $"Valutazione: {Voto}/5 - Note: {Commento}";
        }
    }