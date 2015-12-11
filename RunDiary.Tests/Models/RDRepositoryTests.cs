using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunDiary.Models;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace RunDiary.Tests.Models
{
    [TestClass]
    public class RDRepositoryTests
    {
        private Mock<RDContext> mock_context;
        private Mock<DbSet<Runner>> mock_set;
        private RDRepository repository;

        private void ConnectMocksToDataStore(IEnumerable<Runner> data_store)
        {
            var data_source = data_store.AsQueryable<Runner>();
            mock_set.As<IQueryable<Runner>>().Setup(data => data.Provider).Returns(data_source.Provider);
            mock_set.As<IQueryable<Runner>>().Setup(data => data.Expression).Returns(data_source.Expression);
            mock_set.As<IQueryable<Runner>>().Setup(data => data.ElementType).Returns(data_source.ElementType);
            mock_set.As<IQueryable<Runner>>().Setup(data => data.GetEnumerator()).Returns(data_source.GetEnumerator());

            mock_context.Setup(a => a.JitterUsers).Returns(mock_set.Object);
        }

        public void Initialize()
        {
            mock_context = new Mock<RDContext>();
            mock_set = new Mock<DbSet<Runner>>();
            repository = new RDRepository(mock_context.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            mock_context = null;
            mock_set = null;
            repository = null;
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
