using System.Collections.Generic;
using System.Linq;
using Tyuiu.GroshevID.Sprint7.Lib.Models;

namespace Tyuiu.GroshevID.Sprint7.Lib.Services
{
    public class ClinicStatistics_IIS
    {
        public int GetTotalCount(List<PatientRecord_GID> records)
        {
            return records.Count;
        }

        public int GetMinDisabilityDays(List<PatientRecord_GID> records)
        {
            return records.Min(r => r.DisabilityDays);
        }

        public int GetMaxDisabilityDays(List<PatientRecord_GID> records)
        {
            return records.Max(r => r.DisabilityDays);
        }

        public double GetAverageDisabilityDays(List<PatientRecord_GID> records)
        {
            return records.Average(r => r.DisabilityDays);
        }
    }
}
