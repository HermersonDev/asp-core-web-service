using System.Collections.Generic;

namespace web_service.Models
{
    public class Esporte
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumeroJogadores { get; set; }
        public int NumeroJogadoresTime { get; set; }
        public List<Pelada> Pelada { get; set; }

    }
}