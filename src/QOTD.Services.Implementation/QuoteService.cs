using System;
using System.Collections.Generic;
using QOTD.Models;
using QOTD.DataAccess;
using QOTD.Services.Contracts;
using System.Linq;

namespace QOTD.Services.Implementation
{
    public class QuoteService : IQuoteService
    {
        private readonly IRepository<Frase> _repository;
        public QuoteService(IRepository<Frase> repository)
        {
            this._repository = repository;
        }
        public Frase Get()
        {
            return GetByDate(DateTime.Now);
        }

        public Frase GetByDate(DateTime day)
        {
            return _repository.Find(x => x.Fecha.Equals(day)).FirstOrDefault();
        }

        public List<Frase> GetByWeek(DateTime firstDay, DateTime secondDay)
        {
            return _repository.Find(x => x.Fecha >= firstDay && x.Fecha <= secondDay)
                                .ToList();
        }
    }
}