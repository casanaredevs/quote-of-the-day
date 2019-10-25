using System.Collections.Generic;
using System.Linq;
using QOTD.Models;

namespace QOTD.DataAccess
{
    public class CategoriaRepository
    {
        private readonly QuoteDbContext _context;

        public CategoriaRepository(QuoteDbContext context)
        {
            this._context = context;
        }

        public List<Categoria> Get()
        {
            return this._context.Categorias.ToList();
        }
 
        public bool Add(Categoria categoria)
        {
            this._context.Categorias.Add(categoria);
            var count = this._context.SaveChanges();
            return count > 0;
        }

        //Se omiten los otros CRUD
    }
}