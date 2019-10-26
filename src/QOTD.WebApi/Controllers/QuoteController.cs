using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QOTD.Models;
using QOTD.Services.Contracts;

namespace QOTD.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : ControllerBase
    {
        private readonly IQuoteService _quoteService;
        public QuoteController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        [HttpGet]
        public IEnumerable<Frase> GetFrases()
        {
            return this._quoteService.GetAll();
        }

        [HttpGet]
        [Route("hoy")]
        public Frase GetFraseDeHoy()
        {
            DateTime hoy=DateTime.Now.Date;
            return this._quoteService.GetByDate(hoy);
        }

        [HttpGet]
        [Route("semana")]
        public IEnumerable<Frase> GetFrasesDeLaSemana()
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = DateTime.Now.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;

            if (diff < 0)
            {
                diff += 7;
            }
            var firstDay = DateTime.Now.AddDays(-diff).Date;
            var lastDay = firstDay.AddDays(6);

            return this._quoteService.GetByWeek(firstDay, lastDay);
        }
    }
}