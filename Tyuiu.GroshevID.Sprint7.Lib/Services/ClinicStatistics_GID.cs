using System.Collections.Generic;
using System.Linq;
using Tyuiu.GroshevID.Sprint7.Lib.Models;

namespace Tyuiu.GroshevID.Sprint7.Lib.Services
{
    public class ClinicStatistics_GID
    {
        public int Count(List<PatientRecord_GID> records) => records.Count;

        public int SumDisabilityDays(List<PatientRecord_GID> records) =>
            records.Sum(r => r.DisabilityDays);

        public double AverageDisabilityDays(List<PatientRecord_GID> records) =>
            records.Count == 0 ? 0 : records.Average(r => r.DisabilityDays);

        public int MinDisabilityDays(List<PatientRecord_GID> records) =>
            records.Count == 0 ? 0 : records.Min(r => r.DisabilityDays);

        public int MaxDisabilityDays(List<PatientRecord_GID> records) =>
            records.Count == 0 ? 0 : records.Max(r => r.DisabilityDays);
    }
}