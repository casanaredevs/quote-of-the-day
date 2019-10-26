namespace QOTD.Services.Contracts
{
    using System;
    using QOTD.Models;
    using System.Collections.Generic;
    public interface IQuoteService
    {
        Frase Get();
        Frase GetByDate(DateTime day);
        List<Frase> GetByWeek(DateTime firstDay, DateTime secondDay);
    }
}