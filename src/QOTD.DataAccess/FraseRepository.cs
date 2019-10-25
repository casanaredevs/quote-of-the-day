using System.Collections.Generic;
using System.Linq;
using QOTD.Models;

namespace QOTD.DataAccess
{
    public class FraseRepository
    {
        private readonly QuoteDbContext _context;

        public FraseRepository(QuoteDbContext context)
        {
            this._context = context;
        }

        public List<Frase> Get()
        {
            return this._context.Frases.ToList();
        }
 
        public bool Add(Frase frase)
        {
            this._context.Frases.Add(frase);
            var count = this._context.SaveChanges();
            return count > 0;
        }

        //Se omiten los otros CRUD
    }
}