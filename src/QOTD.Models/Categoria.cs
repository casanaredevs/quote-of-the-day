using System.Collections.Generic;

namespace QOTD.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public IList<Frase> Frases { get; set; }        
    }
}