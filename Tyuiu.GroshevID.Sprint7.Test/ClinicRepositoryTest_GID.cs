using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using Tyuiu.GroshevID.Sprint7.Lib.Models;
using Tyuiu.GroshevID.Sprint7.Lib.Services;

namespace Tyuiu.GroshevID.Sprint7.Test
{
    [TestClass]
    public class ClinicRepositoryTest_GID
    {
        [TestMethod]
        public void AddRecord_ShouldAssignId_AndAdd_GID()
        {
            var repo = new ClinicRepository_GID();
            var list = new List<PatientRecord_GID>();

            var r = new PatientRecord_GID
            {
                LastName = "Иванов",
                FirstName = "Иван",
                BirthDate = new DateTime(2000, 1, 1)
            };

            repo.AddRecord(list, r);

            Assert.AreEqual(1, list.Count);
            Assert.IsTrue(list[0].Id > 0);
        }

        [TestMethod]
        public void SaveLoad_ShouldReturnSameCount_GID()
        {
            var repo = new ClinicRepository_GID();
            var list = new List<PatientRecord_GID>();

            repo.AddRecord(list, new PatientRecord_GID
            {
                LastName = "Петров",
                FirstName = "Пётр",
                BirthDate = new DateTime(1999, 5, 10),
                DoctorFullName = "Иванов И.И.",
                Diagnosis = "ОРВИ",
                IsAmbulatory = true,
                DisabilityDays = 5,
                IsDispensary = false,
                Note = "test"
            });

            string path = Path.Combine(Path.GetTempPath(), $"patients_{Guid.NewGuid()}.csv");

            try
            {
                repo.SaveToCsv(path, list);
                var loaded = repo.LoadFromCsv(path);

                Assert.AreEqual(1, loaded.Count);
                Assert.AreEqual("Петров", loaded[0].LastName);
                Assert.AreEqual("ОРВИ", loaded[0].Diagnosis);
            }
            finally
            {
                if (File.Exists(path)) File.Delete(path);
            }
        }

        [TestMethod]
        public void UpdateRecord_ShouldUpdateById_GID()
        {
            var repo = new ClinicRepository_GID();
            var list = new List<PatientRecord_GID>();

            var r = new PatientRecord_GID { LastName = "Сидоров", FirstName = "Сидор", BirthDate = new DateTime(2001, 2, 2) };
            repo.AddRecord(list, r);

            var updated = new PatientRecord_GID
            {
                Id = r.Id,
                LastName = "Сидоров",
                FirstName = "Сидор",
                BirthDate = r.BirthDate,
                Diagnosis = "Грипп",
                DisabilityDays = 10
            };

            repo.UpdateRecord(list, updated);

            Assert.AreEqual("Грипп", list[0].Diagnosis);
            Assert.AreEqual(10, list[0].DisabilityDays);
        }

        [TestMethod]
        public void DeleteRecord_ShouldRemoveById_GID()
        {
            var repo = new ClinicRepository_GID();
            var list = new List<PatientRecord_GID>();

            repo.AddRecord(list, new PatientRecord_GID { LastName = "A", FirstName = "A", BirthDate = new DateTime(2000, 1, 1) });
            repo.AddRecord(list, new PatientRecord_GID { LastName = "B", FirstName = "B", BirthDate = new DateTime(2000, 1, 1) });

            int idToDelete = list[0].Id;

            repo.DeleteRecord(list, idToDelete);

            Assert.AreEqual(1, list.Count);
            Assert.IsFalse(list.Exists(x => x.Id == idToDelete));
        }

    }
}
