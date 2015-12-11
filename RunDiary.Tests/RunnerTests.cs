using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunDiary.Models;
using System.Collections.Generic;

namespace RunDiary.Tests
{
    [TestClass]
    public class RunnerTests
    {
        [TestMethod]
        public void RunnerEnsureICanCreateInstance()
        {
            Runner a_runner = new Runner();
            Assert.IsNotNull(a_runner);
        }

        [TestMethod]
        public void RunnerEnsureRunnerHasAllTheThings()
        {
            Runner a_runner = new Runner();
            a_runner.RunnerId = 1;
            a_runner.Handle = "SuperFastGuy";

            Assert.AreEqual(1, a_runner.RunnerId);
            Assert.AreEqual("SuperFastGuy", a_runner.Handle);
        }

        [TestMethod]
        public void RunnerEnsureCanHaveRuns()
        {
            List<Run> list_of_runs = new List<Run>
            {
                new Run { RunName = "neighborhood loop",
                RunDistance = 3.5
                },
                new Run { RunName = "Turkey Trot",
                RunDistance = 3.1
                }
            };
            Runner a_runner = new Runner { Handle = "superFastGuy", Runs = list_of_runs };
            List<Run> actual_runs = a_runner.Runs;
            CollectionAssert.AreEqual(list_of_runs, actual_runs);

        }
    }
}
