using System;
using Xunit;
using QOTD.DataAccess;
using Moq;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace QOTD.Test
{
    public class RepositoryTest
    {
        [Fact]
        public void Add_TestClassObjectPassed_ProperMethodCalled()
        {
            // Arrange
            var testObject = new TestClass();

            var context = new Mock<QuoteDbContext>();
            var dbSetMock = ServiceTestsHelper.GetMockDbSet<TestClass>(testObject);

            context.Setup(x => x.Set<TestClass>()).Returns(dbSetMock.Object);
            // Act
            var repository = new Repository<TestClass>(context.Object);
            repository.Add(testObject);

            //Assert
            context.Verify(x => x.Set<TestClass>());
            dbSetMock.Verify(x => x.Add(It.Is<TestClass>(y => y == testObject)));
        }

        [Fact]
        public void Get_TestClassObjectPassed_ProperMethodCalled()
        {
            // Arrange
            var testObject = new TestClass();

            var context = new Mock<QuoteDbContext>();
            var dbSetMock = new Mock<DbSet<TestClass>>();

            context.Setup(x => x.Set<TestClass>()).Returns(dbSetMock.Object);
            dbSetMock.Setup(x => x.Find(It.IsAny<int>())).Returns(testObject);

            // Act
            var repository = new Repository<TestClass>(context.Object);
            repository.Get(1);

            // Assert
            context.Verify(x => x.Set<TestClass>());
            dbSetMock.Verify(x => x.Find(It.IsAny<int>()));
        }

        [Fact]
        public void GetAll_TestClassObjectPassed_ProperMethodCalled()
        {
            // Arrange
            var testObject = new TestClass() { Id = 1 };
            var testList = new List<TestClass>() { testObject };

            var dbSetMock = ServiceTestsHelper.GetMockDbSet<TestClass>(testList);

            var context = new Mock<QuoteDbContext>();
            context.Setup(x => x.Set<TestClass>()).Returns(dbSetMock.Object);

            // Act
            var repository = new Repository<TestClass>(context.Object);
            var result = repository.GetAll();

            // Assert
            Assert.Equal(testList, result.ToList());
        }

        [Fact]
        public void Find_TestClassObjectPassed_ProperMethodCalled()
        {
            var testObject = new TestClass() { Id = 1 };
            var testList = new List<TestClass>() { testObject };

            var dbSetMock = ServiceTestsHelper.GetMockDbSet<TestClass>(testList);

            var context = new Mock<QuoteDbContext>();
            context.Setup(x => x.Set<TestClass>()).Returns(dbSetMock.Object);

            var repository = new Repository<TestClass>(context.Object);

            var result = repository.Find(x => x.Id == 1);

            Assert.Equal(testList, result.ToList());
        }
    }
}
