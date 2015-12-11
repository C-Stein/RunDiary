using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunDiary.Models;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace RunDiary.Tests.Models
{
    [TestClass]
    public class RDRepositoryTests
    {
        private Mock<RDContext> mock_context;
        private Mock<DbSet<Runner>> mock_set;
        private Mock<DbSet<Run>> mock_run_set;
        private RDRepository repository;

        private void ConnectMocksToDataStore(IEnumerable<Runner> data_store)
        {
            var data_source = data_store.AsQueryable<Runner>();
            mock_set.As<IQueryable<Runner>>().Setup(data => data.Provider).Returns(data_source.Provider);
            mock_set.As<IQueryable<Runner>>().Setup(data => data.Expression).Returns(data_source.Expression);
            mock_set.As<IQueryable<Runner>>().Setup(data => data.ElementType).Returns(data_source.ElementType);
            mock_set.As<IQueryable<Runner>>().Setup(data => data.GetEnumerator()).Returns(data_source.GetEnumerator());

            mock_context.Setup(a => a.Runners).Returns(mock_set.Object);
        }

        private void ConnectMocksToDataStore(IEnumerable<Run> data_store)
        {
            var data_source = data_store.AsQueryable<Run>();
            mock_set.As<IQueryable<Run>>().Setup(data => data.Provider).Returns(data_source.Provider);
            mock_set.As<IQueryable<Run>>().Setup(data => data.Expression).Returns(data_source.Expression);
            mock_set.As<IQueryable<Run>>().Setup(data => data.ElementType).Returns(data_source.ElementType);
            mock_set.As<IQueryable<Run>>().Setup(data => data.GetEnumerator()).Returns(data_source.GetEnumerator());

            mock_context.Setup(a => a.Runs).Returns(mock_run_set.Object);
        }

        [TestInitialize]
        public void Initialize()
        {
            mock_context = new Mock<RDContext>();
            mock_set = new Mock<DbSet<Runner>>();
            mock_run_set = new Mock<DbSet<Run>>();
            repository = new RDRepository(mock_context.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            mock_context = null;
            mock_set = null;
            mock_run_set = null;
            repository = null;
        }

        [TestMethod]
        public void RDContextEnsureICanCreateInstance()
        {
            RDContext context = mock_context.Object;
            Assert.IsNotNull(context);
        }

        [TestMethod]
        public void RDRepositoryEnsureICanCreateInstance()
        {
            Assert.IsNotNull(repository);
        }

        [TestMethod]
        public void RDRepositoryEnsureICanCreateARun()
        {
            List<Run> expected_runs = new List<Run>();
            ConnectMocksToDataStore(expected_runs);
            Runner runner1 = new Runner { Handle = "SuperFastGuy" };
            string runName = "Neighborhood Loop";
            mock_run_set.Setup(j => j.Add(It.IsAny<Run>())).Callback((Run s) => expected_runs.Add(s));

            bool successful = repository.CreateRun(runner1, runName);
        }
    }
}
