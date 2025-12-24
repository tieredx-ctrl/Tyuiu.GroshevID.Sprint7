using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Tyuiu.GroshevID.Sprint7.Lib.Models;

namespace Tyuiu.GroshevID.Sprint7.Lib.Services
{
    public class ClinicRepository_GID
    {
        public const char Separator_GID = ';';
        public const string DateFormat_GID = "yyyy-MM-dd";

        public static readonly string Header_GID =
            "Id;LastName;FirstName;MiddleName;BirthDate;DoctorFullName;DoctorPosition;DoctorSpecialization;Diagnosis;IsAmbulatory;DisabilityDays;IsDispensary;Note";

        // ---------- FILE I/O ----------

        public List<PatientRecord_GID> LoadFromCsv(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<PatientRecord_GID>();

            var lines = File.ReadAllLines(filePath, Encoding.UTF8)
                            .Where(l => !string.IsNullOrWhiteSpace(l))
                            .ToList();

            if (lines.Count == 0)
                return new List<PatientRecord_GID>();

            int startIndex = IsHeaderLine_GID(lines[0]) ? 1 : 0;
            var result = new List<PatientRecord_GID>();

            for (int i = startIndex; i < lines.Count; i++)
            {
                var fields = SplitCsvLine_GID(lines[i], Separator_GID);
                if (fields.Count < 13) continue;

                result.Add(ParseFields_GID(fields));
            }

            return result;
        }

        public void SaveToCsv(string filePath, List<PatientRecord_GID> records)
        {
            records ??= new List<PatientRecord_GID>();

            var output = new List<string> { Header_GID };
            output.AddRange(records.Select(ToCsvLine_GID));

            File.WriteAllLines(filePath, output, Encoding.UTF8);
        }

        public void EnsureCsvExists(string filePath)
        {
            if (!File.Exists(filePath))
                File.WriteAllText(filePath, Header_GID + Environment.NewLine, Encoding.UTF8);
        }

        // ---------- CRUD ----------

        public PatientRecord_GID AddRecord(List<PatientRecord_GID> records, PatientRecord_GID record)
        {
            record.Id = records.Count == 0 ? 1 : records.Max(r => r.Id) + 1;
            records.Add(record);
            return record;
        }

        public void UpdateRecord(List<PatientRecord_GID> records, PatientRecord_GID updated)
        {
            var index = records.FindIndex(r => r.Id == updated.Id);
            if (index >= 0)
                records[index] = updated;
        }

        public void DeleteRecord(List<PatientRecord_GID> records, int id)
        {
            records.RemoveAll(r => r.Id == id);
        }

        // ---------- SEARCH / FILTER / SORT ----------

        public List<PatientRecord_GID> SearchByLastName(List<PatientRecord_GID> records, string query) =>
            records.Where(r => r.LastName.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();

        public List<PatientRecord_GID> FilterByAmbulatory(List<PatientRecord_GID> records, bool value) =>
            records.Where(r => r.IsAmbulatory == value).ToList();

        public List<PatientRecord_GID> SortByBirthDate(List<PatientRecord_GID> records) =>
            records.OrderBy(r => r.BirthDate).ToList();

        // ---------- DATA FOR CHART ----------

        public Dictionary<string, int> GetCountByDoctor(List<PatientRecord_GID> records) =>
            records.GroupBy(r => r.DoctorFullName)
                   .ToDictionary(g => g.Key, g => g.Count());

        // ---------- HELPERS ----------

        private static bool IsHeaderLine_GID(string line) =>
            line.StartsWith("Id;", StringComparison.OrdinalIgnoreCase);

        private static PatientRecord_GID ParseFields_GID(List<string> f)
        {
            return new PatientRecord_GID
            {
                Id = int.Parse(f[0]),
                LastName = f[1],
                FirstName = f[2],
                MiddleName = f[3],
                BirthDate = DateTime.ParseExact(f[4], DateFormat_GID, CultureInfo.InvariantCulture),
                DoctorFullName = f[5],
                DoctorPosition = f[6],
                DoctorSpecialization = f[7],
                Diagnosis = f[8],
                IsAmbulatory = bool.Parse(f[9]),
                DisabilityDays = int.Parse(f[10]),
                IsDispensary = bool.Parse(f[11]),
                Note = f[12]
            };
        }

        private static string ToCsvLine_GID(PatientRecord_GID r) =>
            string.Join(Separator_GID, new[]
            {
                r.Id.ToString(),
                r.LastName,
                r.FirstName,
                r.MiddleName,
                r.BirthDate.ToString(DateFormat_GID),
                r.DoctorFullName,
                r.DoctorPosition,
                r.DoctorSpecialization,
                r.Diagnosis,
                r.IsAmbulatory.ToString(),
                r.DisabilityDays.ToString(),
                r.IsDispensary.ToString(),
                r.Note
            });

        private static List<string> SplitCsvLine_GID(string line, char sep)
        {
            var result = new List<string>();
            var sb = new StringBuilder();
            bool inQuotes = false;

            foreach (var c in line)
            {
                if (c == '"') inQuotes = !inQuotes;
                else if (c == sep && !inQuotes)
                {
                    result.Add(sb.ToString());
                    sb.Clear();
                }
                else sb.Append(c);
            }
            result.Add(sb.ToString());
            return result;
        }
    }
}