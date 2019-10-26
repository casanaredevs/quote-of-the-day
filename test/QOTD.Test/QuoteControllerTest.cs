using System;
using Xunit;
using QOTD.DataAccess;
using Moq;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using QOTD.Models;
using QOTD.WebApi.Controllers;
using QOTD.Services.Implementation;

namespace QOTD.Test
{
    public class QuoteControllerTest
    {
        [Fact]
        public void Get_ShouldBeReturn_AllQuotes()
        {
            // Arrange
            var mockRepo = new Mock<IRepository<Frase>>();
            mockRepo.Setup(repo => repo.GetAll())
                .Returns(GetQuotes());
                        
            var service = new QuoteService(mockRepo.Object);

            var controller = new QuoteController(service);

            // Act
            var result = controller.GetFrases();

            // Assert
            Assert.IsType<List<Frase>>(result);            
            Assert.Equal(365, result.Count());
        }

        public List<Frase> GetQuotes()
        {
            DateTime enero1 = new DateTime(2019, 01, 01);
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
            return frases;
        }
    }
}