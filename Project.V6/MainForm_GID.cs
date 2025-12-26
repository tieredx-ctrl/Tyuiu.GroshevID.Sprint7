using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Drawing.Drawing2D;
using Tyuiu.GroshevID.Sprint7.Lib.Models;
using Tyuiu.GroshevID.Sprint7.Lib.Services;

namespace Project.V6
{
    public partial class MainForm_GID : Form
    {
        private ClinicRepository_GID _repository_GID;
        private List<PatientRecord_GID> _patients_GID;
        private ClinicStatistics_GID _statistics_GID;
        private string _csvPath_GID;

        private void UpdateStatistics_GID()
        {
            labelTotalCount_GID.Text =
                $"Всего пациентов: {_statistics_GID.Count(_patients_GID)}";

            labelAverage_GID.Text =
                $"Средний срок: {_statistics_GID.AverageDisabilityDays(_patients_GID):0.##}";

            labelMin_GID.Text =
                $"Min: {_statistics_GID.MinDisabilityDays(_patients_GID)}";

            labelMax_GID.Text =
                $"Max: {_statistics_GID.MaxDisabilityDays(_patients_GID)}";
        }

        public MainForm_GID()
        {
            InitializeComponent();

            toolButtonEditPatient_GID.Click += toolButtonEditPatient_GID_Click;

            _repository_GID = new ClinicRepository_GID();
            _statistics_GID = new ClinicStatistics_GID();

            _csvPath_GID = Path.Combine(Application.StartupPath, "patients_GID.csv");
            _repository_GID.EnsureCsvExists(_csvPath_GID);

            _patients_GID = _repository_GID.LoadFromCsv(_csvPath_GID);
            dataGridViewPatients_GID.DataSource = _patients_GID;

            UpdateStatistics_GID();
            UpdateChartData_GID();
        }

        private void MainForm_GID_Load(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMain_GID_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panelSearchFilter_GID_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolButtonAddPatient_GID_Click(object sender, EventArgs e)
        {
            using var form = new EditPatientForm_GID();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                var record = form.ResultRecord_GID;

                _repository_GID.AddRecord(_patients_GID, record);
                _repository_GID.SaveToCsv(_csvPath_GID, _patients_GID);

                dataGridViewPatients_GID.DataSource = null;
                dataGridViewPatients_GID.DataSource = _patients_GID;

                UpdateStatistics_GID();
                UpdateChartData_GID();
            }
        }

        private void toolButtonDeletePatient_GID_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients_GID.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пациента");
                return;
            }

            var patient = (PatientRecord_GID)dataGridViewPatients_GID.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show(
                $"Удалить пациента {patient.LastName}?",
                "Подтверждение",
                MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes) return;

            _repository_GID.DeleteRecord(_patients_GID, patient.Id);
            _repository_GID.SaveToCsv(_csvPath_GID, _patients_GID);

            dataGridViewPatients_GID.DataSource = null;
            dataGridViewPatients_GID.DataSource = _patients_GID;

            UpdateStatistics_GID();
            UpdateChartData_GID();
        }

        private void toolButtonEditPatient_GID_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients_GID.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пациента для редактирования.");
                return;
            }

            var selected = (PatientRecord_GID)dataGridViewPatients_GID.SelectedRows[0].DataBoundItem;

            using var form = new EditPatientForm_GID(selected);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                var updated = form.ResultRecord_GID;

                _repository_GID.UpdateRecord(_patients_GID, updated);
                _repository_GID.SaveToCsv(_csvPath_GID, _patients_GID);

                dataGridViewPatients_GID.DataSource = null;
                dataGridViewPatients_GID.DataSource = _patients_GID;

                UpdateStatistics_GID();
                UpdateChartData_GID();
            }
        }

        private void toolButtonSearch_GID_Click(object sender, EventArgs e)
        {
            string query = textBoxSearchLastName_GID.Text.Trim();

            var result = _repository_GID.SearchByLastName(_patients_GID, query);

            dataGridViewPatients_GID.DataSource = null;
            dataGridViewPatients_GID.DataSource = result;
        }

        private void toolButtonSort_GID_Click(object sender, EventArgs e)
        {
            _patients_GID = _repository_GID.SortByBirthDate(_patients_GID);

            dataGridViewPatients_GID.DataSource = null;
            dataGridViewPatients_GID.DataSource = _patients_GID;
        }

        private void menuItemFileOpen_GID_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _csvPath_GID = dialog.FileName;
                _patients_GID = _repository_GID.LoadFromCsv(_csvPath_GID);

                dataGridViewPatients_GID.DataSource = null;
                dataGridViewPatients_GID.DataSource = _patients_GID;

                UpdateStatistics_GID();
            }
        }

        private void menuItemFileSave_GID_Click(object sender, EventArgs e)
        {
            _repository_GID.SaveToCsv(_csvPath_GID, _patients_GID);
            MessageBox.Show("Данные сохранены");
        }

        private void menuItemFileExit_GID_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewPatients_GID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Dictionary<string, int> _chartData_GID = new();

        private void UpdateChartData_GID()
        {
            // Берём данные для графика из репозитория (у тебя метод уже есть)
            _chartData_GID = _repository_GID.GetCountByDoctor(_patients_GID);

            // Перерисовать панель
            panelChart_GID.Invalidate();
        }

        private void panelChart_GID_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            // Если данных нет
            if (_chartData_GID == null || _chartData_GID.Count == 0)
            {
                using var font = new Font("Segoe UI", 10);
                g.DrawString("Нет данных для графика", font, Brushes.Gray, new PointF(12, 12));
                return;
            }

            // Поля/рамки
            int leftPad = 50;
            int rightPad = 20;
            int topPad = 40;
            int bottomPad = 120; // место под подписи врачей

            var rect = panelChart_GID.ClientRectangle;
            int plotWidth = rect.Width - leftPad - rightPad;
            int plotHeight = rect.Height - topPad - bottomPad;

            if (plotWidth <= 50 || plotHeight <= 50)
                return;

            // Заголовок
            using (var titleFont = new Font("Segoe UI", 11, FontStyle.Bold))
            {
                g.DrawString("Пациенты по врачам", titleFont, Brushes.Black, new PointF(12, 10));
            }

            // Оси
            using var axisPen = new Pen(Color.Black, 1);
            var origin = new Point(leftPad, topPad + plotHeight);
            g.DrawLine(axisPen, origin.X, topPad, origin.X, origin.Y);                 // Y
            g.DrawLine(axisPen, origin.X, origin.Y, origin.X + plotWidth, origin.Y);   // X

            // Сортируем по убыванию (чтобы красиво)
            var items = _chartData_GID
                .OrderByDescending(kv => kv.Value)
                .ToList();

            int maxValue = Math.Max(1, items.Max(kv => kv.Value));

            // Параметры столбиков
            int n = items.Count;
            float slot = plotWidth / (float)n;
            float barWidth = Math.Max(8, slot * 0.6f);
            float gap = slot - barWidth;

            // Сетка/подписи по Y (0..max)
            int yTicks = Math.Min(5, maxValue); // до 5 подписей
            using var gridPen = new Pen(Color.LightGray, 1);

            using var labelFont = new Font("Segoe UI", 9);

            for (int t = 0; t <= yTicks; t++)
            {
                int value = (int)Math.Round(maxValue * (t / (double)yTicks));
                float y = origin.Y - (value / (float)maxValue) * plotHeight;

                // Линия сетки
                g.DrawLine(gridPen, origin.X, y, origin.X + plotWidth, y);

                // Подпись значения
                string s = value.ToString();
                var size = g.MeasureString(s, labelFont);
                g.DrawString(s, labelFont, Brushes.Black, origin.X - 8 - size.Width, y - size.Height / 2);
            }

            // Рисуем столбики
            using var barBrush = new SolidBrush(Color.FromArgb(70, 130, 180)); // steelblue
            using var barBorder = new Pen(Color.FromArgb(40, 90, 140), 1);

            for (int i = 0; i < n; i++)
            {
                var (name, count) = (items[i].Key, items[i].Value);

                float h = (count / (float)maxValue) * plotHeight;
                float x = origin.X + i * slot + gap / 2f;
                float y = origin.Y - h;

                var barRect = new RectangleF(x, y, barWidth, h);
                g.FillRectangle(barBrush, barRect);
                g.DrawRectangle(barBorder, x, y, barWidth, h);

                // Значение над столбиком
                string valText = count.ToString();
                var valSize = g.MeasureString(valText, labelFont);
                g.DrawString(valText, labelFont, Brushes.Black,
                    new PointF(x + (barWidth - valSize.Width) / 2f, y - valSize.Height - 2));

                // Подпись врача снизу (повёрнутая)
                var label = string.IsNullOrWhiteSpace(name) ? "(без врача)" : name;

                g.TranslateTransform(x + barWidth / 2f, origin.Y + 10);
                g.RotateTransform(-45);
                g.DrawString(label, labelFont, Brushes.Black, new PointF(0, 0));
                g.ResetTransform();
            }
        }

    }
}
