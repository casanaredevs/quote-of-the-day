using System;
using Xunit;
using QOTD.DataAccess;
using Moq;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using QOTD.Models;
using QOTD.Services.Implementation;
using System.Linq.Expressions;

namespace QOTD.Test
{
    public class FraseServiceTest
    {
        [Fact]
        public void Get_Frase_Dia()
        {
            // Arrange
            var frase = new Frase
            {
                Id = 1,
                Texto = "El testing es un belleza",
                Autor = "Juan David Pareja Soto",
                Categoria = new Categoria
                {
                    Id = 1,
                    Nombre = "Frases Motivacionales"
                },
                Fecha = new DateTime(2019, 10, 25)
            };

            var context = new Mock<QuoteDbContext>();
            var dbSetMock = ServiceTestsHelper.GetMockDbSet<Frase>(frase);
            context.Setup(x => x.Set<Frase>()).Returns(dbSetMock.Object);
            var repository = new Repository<Frase>(context.Object);

            // Act
            var service = new QuoteService(repository);
            var fraseDia = service.GetByDate(new DateTime(2019, 10, 25));


            //Assert
            Assert.Equal(frase, fraseDia);
        }

        [Fact]
        public void Get_Frase_Semana()
        {
            DateTime enero1 = new DateTime(2019, 01, 01);
            // Arrange
            List<Frase> frases = new List<Frase>();
            for (int i = 0; i < 365; i++)
            {
                frases.Add(new Frase
                {
                    Id = i,
                    Texto = $"El testing es un belleza {i}",
                    Autor = "Juan David Pareja Soto",
                    Categoria = new Categoria
                    {
                        Id = 1,
                        Nombre = "Frases Motivacionales"
                    },
                    Fecha = enero1
                });
                enero1 = enero1.AddDays(1);
            }
            var fraseHoy = new Frase
            {
                Id = 1,
                Texto = $"El testing es un belleza 1",
                Autor = "Juan David Pareja Soto",
                Categoria = new Categoria
                {
                    Id = 1,
                    Nombre = "Frases Motivacionales"
                },
                Fecha = new DateTime(2019, 01, 01)
            };
            var context = new Mock<QuoteDbContext>();
            var dbSetMock = ServiceTestsHelper.GetMockDbSet<Frase>(frases);
            context.Setup(x => x.Set<Frase>()).Returns(dbSetMock.Object);
            var repository = new Repository<Frase>(context.Object);

            // Act
            var service = new QuoteService(repository);
            var fraseDia = service.GetByWeek(new DateTime(2019, 01, 01), new DateTime(2019, 01, 07));

            //Assert
            Assert.Equal(7, fraseDia.Count());
        }
    }
}