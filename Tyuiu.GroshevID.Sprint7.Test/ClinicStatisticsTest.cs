using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tyuiu.GroshevID.Sprint7.Lib.Models;
using Tyuiu.GroshevID.Sprint7.Lib.Services;

namespace Tyuiu.GroshevID.Sprint7.Test
{
    [TestClass]
    public class ClinicStatisticsTest_GID
    {
        [TestMethod]
        public void Statistics_ShouldReturnCorrectValues_GID()
        {
            var stat = new ClinicStatistics_GID();
            var list = new List<PatientRecord_GID>
            {
                new PatientRecord_GID { DisabilityDays = 5 },
                new PatientRecord_GID { DisabilityDays = 15 },
            };

            Assert.AreEqual(2, stat.Count(list));
            Assert.AreEqual(5, stat.MinDisabilityDays(list));
            Assert.AreEqual(15, stat.MaxDisabilityDays(list));
            Assert.AreEqual(10, stat.AverageDisabilityDays(list));
        }
    }
}
