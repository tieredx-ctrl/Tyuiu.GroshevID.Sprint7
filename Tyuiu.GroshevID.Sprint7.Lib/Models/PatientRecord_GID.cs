using System;

namespace Tyuiu.GroshevID.Sprint7.Lib.Models
{
    public class PatientRecord_GID
    {
        // Пациент
        public int Id { get; set; }
        public string LastName { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public DateTime BirthDate { get; set; }

        // Врач
        public string DoctorFullName { get; set; } = "";
        public string DoctorPosition { get; set; } = "";
        public string DoctorSpecialization { get; set; } = "";

        // Медицинская информация
        public string Diagnosis { get; set; } = "";
        public bool IsAmbulatory { get; set; }
        public int DisabilityDays { get; set; }
        public bool IsDispensary { get; set; }

        // Примечание
        public string Note { get; set; } = "";
    }
}