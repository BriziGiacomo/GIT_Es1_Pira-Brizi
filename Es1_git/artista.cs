public class Artista
    {
        public string Nome { get; set; }
        public string Genere { get; set; }

        public Artista(string nome, string genere)
        {
            Nome = nome;
            Genere = genere;
        }

        public override string ToString()
        {
            return $"Artista: {Nome} | Genere: {Genere}";
        }
    }