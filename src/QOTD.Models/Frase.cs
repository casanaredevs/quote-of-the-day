using System;

namespace QOTD.Models
{
    public class Frase
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public string Autor { get; set; }
        public DateTime Fecha { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}