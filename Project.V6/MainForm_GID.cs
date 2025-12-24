using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Tyuiu.GroshevID.Sprint7.Lib.Models;
using Tyuiu.GroshevID.Sprint7.Lib.Services;

namespace Project.V6
{
    public partial class MainForm_GID : Form
    {
        private ClinicRepository_GID _repository_GID;
        private List<PatientRecord_GID> _patients_GID;
        private string _csvPath_GID;

        public MainForm_GID()
        {
            InitializeComponent();

            _repository_GID = new ClinicRepository_GID();
            _csvPath_GID = Path.Combine(Application.StartupPath, "patients_GID.csv");

            _repository_GID.EnsureCsvExists(_csvPath_GID);
            _patients_GID = _repository_GID.LoadFromCsv(_csvPath_GID);

            dataGridViewPatients_GID.DataSource = _patients_GID;
        }

        private void MainForm_GID_Load(object sender, EventArgs e)
        {
        }
    }
}
