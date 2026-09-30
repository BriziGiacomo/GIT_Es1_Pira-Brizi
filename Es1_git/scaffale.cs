public class Scaffale
    {
        public int Numero { get; set; }
        public List<CD> CollezioneCD { get; set; }

        public Scaffale(int numero)
        {
            Numero = numero;
            CollezioneCD = new List<CD>();
        }

        public void AggiungiCD(CD cd)
        {
            CollezioneCD.Add(cd);
        }

        public void MostraContenuto()
        {
            Console.WriteLine($"Scaffale N.{Numero} contiene:");
            foreach (CD cd in CollezioneCD)
            {
                Console.WriteLine($" * {cd.Titolo} ({cd.Autore})");
            }
        }
    }