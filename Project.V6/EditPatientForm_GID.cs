using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GroshevID.Sprint7.Lib.Models;

namespace Project.V6
{
    public partial class EditPatientForm_GID : Form
    {
        // То, что вернётся наружу после OK
        public PatientRecord_GID ResultRecord_GID { get; private set; }

        private readonly int _existingId_GID; // 0 если добавление, иначе редактирование

        // Конструктор для ДОБАВЛЕНИЯ
        public EditPatientForm_GID()
        {
            InitializeComponent();
            _existingId_GID = 0;
            ConfigureDefaults_GID();
        }

        // Конструктор для РЕДАКТИРОВАНИЯ
        public EditPatientForm_GID(PatientRecord_GID recordToEdit)
        {
            InitializeComponent();
            _existingId_GID = recordToEdit?.Id ?? 0;
            ConfigureDefaults_GID();
            FillControlsFromRecord_GID(recordToEdit);
        }

        private void ConfigureDefaults_GID()
        {
            // Базовые значения
            dateTimePickerBirthDate_GID.MaxDate = DateTime.Today;
            if (dateTimePickerBirthDate_GID.Value > DateTime.Today)
                dateTimePickerBirthDate_GID.Value = DateTime.Today;

            numericUpDownDisabilityDays_GID.Minimum = 0;
            numericUpDownDisabilityDays_GID.Maximum = 3650;

            // Кнопки диалога
            buttonOk_GID.DialogResult = DialogResult.OK;
            buttonCancel_GID.DialogResult = DialogResult.Cancel;
        }

        private void FillControlsFromRecord_GID(PatientRecord_GID r)
        {
            if (r == null) return;

            textBoxLastName_GID.Text = r.LastName;
            textBoxFirstName_GID.Text = r.FirstName;
            textBoxMiddleName_GID.Text = r.MiddleName;

            dateTimePickerBirthDate_GID.Value = (r.BirthDate == DateTime.MinValue)
                ? DateTime.Today
                : r.BirthDate;

            textBoxDoctorFullName_GID.Text = r.DoctorFullName;
            textBoxDoctorPosition_GID.Text = r.DoctorPosition;
            textBoxDoctorSpecialization_GID.Text = r.DoctorSpecialization;

            textBoxDiagnosis_GID.Text = r.Diagnosis;
            checkBoxIsAmbulatory_GID.Checked = r.IsAmbulatory;

            numericUpDownDisabilityDays_GID.Value = Math.Max(
                numericUpDownDisabilityDays_GID.Minimum,
                Math.Min(numericUpDownDisabilityDays_GID.Maximum, r.DisabilityDays));

            checkBoxIsDispensary_GID.Checked = r.IsDispensary;
            textBoxNote_GID.Text = r.Note;
        }

        private bool ValidateInputs_GID()
        {
            if (string.IsNullOrWhiteSpace(textBoxLastName_GID.Text))
            {
                MessageBox.Show("Введите фамилию пациента.");
                textBoxLastName_GID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxFirstName_GID.Text))
            {
                MessageBox.Show("Введите имя пациента.");
                textBoxFirstName_GID.Focus();
                return false;
            }

            if (dateTimePickerBirthDate_GID.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Дата рождения не может быть в будущем.");
                dateTimePickerBirthDate_GID.Focus();
                return false;
            }

            return true;
        }

        private PatientRecord_GID BuildRecordFromControls_GID()
        {
            return new PatientRecord_GID
            {
                Id = _existingId_GID, // при добавлении = 0, репозиторий назначит Id сам
                LastName = textBoxLastName_GID.Text.Trim(),
                FirstName = textBoxFirstName_GID.Text.Trim(),
                MiddleName = textBoxMiddleName_GID.Text.Trim(),
                BirthDate = dateTimePickerBirthDate_GID.Value.Date,

                DoctorFullName = textBoxDoctorFullName_GID.Text.Trim(),
                DoctorPosition = textBoxDoctorPosition_GID.Text.Trim(),
                DoctorSpecialization = textBoxDoctorSpecialization_GID.Text.Trim(),

                Diagnosis = textBoxDiagnosis_GID.Text.Trim(),
                IsAmbulatory = checkBoxIsAmbulatory_GID.Checked,
                DisabilityDays = (int)numericUpDownDisabilityDays_GID.Value,
                IsDispensary = checkBoxIsDispensary_GID.Checked,

                Note = textBoxNote_GID.Text.Trim()
            };
        }

        // Привяжи этот метод к Click кнопки "Сохранить" (buttonOk_GID)
        private void buttonOk_GID_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs_GID())
            {
                this.DialogResult = DialogResult.None; // не закрывать форму
                return;
            }

            ResultRecord_GID = BuildRecordFromControls_GID();
            // DialogResult=OK уже задан, форма закроется
        }

        private void labelFirstName_GID_Click(object sender, EventArgs e)
        {

        }

        private void labelDoctorSpecialization_GID_Click(object sender, EventArgs e)
        {

        }

        private void labelLastName_GID_Click(object sender, EventArgs e)
        {

        }

        private void labelDoctorPosition_GID_Click(object sender, EventArgs e)
        {

        }

        private void panelInputs_GID_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
