namespace Project.V6
{
    partial class EditPatientForm_GID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelInputs_GID = new Panel();
            textBoxNote_GID = new TextBox();
            labelNote_GID = new Label();
            checkBoxIsDispensary_GID = new CheckBox();
            numericUpDownDisabilityDays_GID = new NumericUpDown();
            labelDisabilityDays_GID = new Label();
            checkBoxIsAmbulatory_GID = new CheckBox();
            textBoxDiagnosis_GID = new TextBox();
            labelDiagnosis_GID = new Label();
            textBoxDoctorSpecialization_GID = new TextBox();
            labelDoctorSpecialization_GID = new Label();
            textBoxDoctorPosition_GID = new TextBox();
            labelDoctorPosition_GID = new Label();
            textBoxDoctorFullName_GID = new TextBox();
            labelDoctorFullName_GID = new Label();
            dateTimePickerBirthDate_GID = new DateTimePicker();
            labelBirthDate_GID = new Label();
            textBoxMiddleName_GID = new TextBox();
            labelMiddleName_GID = new Label();
            textBoxFirstName_GID = new TextBox();
            labelFirstName_GID = new Label();
            textBoxLastName_GID = new TextBox();
            labelLastName_GID = new Label();
            panelButtons_GID = new Panel();
            buttonCancel_GID = new Button();
            buttonOk_GID = new Button();
            panelInputs_GID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisabilityDays_GID).BeginInit();
            panelButtons_GID.SuspendLayout();
            SuspendLayout();
            // 
            // panelInputs_GID
            // 
            panelInputs_GID.Controls.Add(textBoxNote_GID);
            panelInputs_GID.Controls.Add(labelNote_GID);
            panelInputs_GID.Controls.Add(checkBoxIsDispensary_GID);
            panelInputs_GID.Controls.Add(numericUpDownDisabilityDays_GID);
            panelInputs_GID.Controls.Add(labelDisabilityDays_GID);
            panelInputs_GID.Controls.Add(checkBoxIsAmbulatory_GID);
            panelInputs_GID.Controls.Add(textBoxDiagnosis_GID);
            panelInputs_GID.Controls.Add(labelDiagnosis_GID);
            panelInputs_GID.Controls.Add(textBoxDoctorSpecialization_GID);
            panelInputs_GID.Controls.Add(labelDoctorSpecialization_GID);
            panelInputs_GID.Controls.Add(textBoxDoctorPosition_GID);
            panelInputs_GID.Controls.Add(labelDoctorPosition_GID);
            panelInputs_GID.Controls.Add(textBoxDoctorFullName_GID);
            panelInputs_GID.Controls.Add(labelDoctorFullName_GID);
            panelInputs_GID.Controls.Add(dateTimePickerBirthDate_GID);
            panelInputs_GID.Controls.Add(labelBirthDate_GID);
            panelInputs_GID.Controls.Add(textBoxMiddleName_GID);
            panelInputs_GID.Controls.Add(labelMiddleName_GID);
            panelInputs_GID.Controls.Add(textBoxFirstName_GID);
            panelInputs_GID.Controls.Add(labelFirstName_GID);
            panelInputs_GID.Controls.Add(textBoxLastName_GID);
            panelInputs_GID.Controls.Add(labelLastName_GID);
            panelInputs_GID.Controls.Add(panelButtons_GID);
            panelInputs_GID.Dock = DockStyle.Fill;
            panelInputs_GID.Location = new Point(0, 0);
            panelInputs_GID.Name = "panelInputs_GID";
            panelInputs_GID.Size = new Size(800, 450);
            panelInputs_GID.TabIndex = 0;
            panelInputs_GID.Paint += panelInputs_GID_Paint;
            // 
            // textBoxNote_GID
            // 
            textBoxNote_GID.Location = new Point(218, 345);
            textBoxNote_GID.Multiline = true;
            textBoxNote_GID.Name = "textBoxNote_GID";
            textBoxNote_GID.ScrollBars = ScrollBars.Vertical;
            textBoxNote_GID.Size = new Size(177, 44);
            textBoxNote_GID.TabIndex = 22;
            // 
            // labelNote_GID
            // 
            labelNote_GID.AutoSize = true;
            labelNote_GID.Location = new Point(131, 358);
            labelNote_GID.Name = "labelNote_GID";
            labelNote_GID.Size = new Size(81, 15);
            labelNote_GID.TabIndex = 21;
            labelNote_GID.Text = "Примечание:";
            // 
            // checkBoxIsDispensary_GID
            // 
            checkBoxIsDispensary_GID.AutoSize = true;
            checkBoxIsDispensary_GID.Location = new Point(8, 320);
            checkBoxIsDispensary_GID.Name = "checkBoxIsDispensary_GID";
            checkBoxIsDispensary_GID.Size = new Size(204, 19);
            checkBoxIsDispensary_GID.TabIndex = 20;
            checkBoxIsDispensary_GID.Text = "Состоит на диспансерном учёте";
            checkBoxIsDispensary_GID.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDisabilityDays_GID
            // 
            numericUpDownDisabilityDays_GID.Location = new Point(218, 288);
            numericUpDownDisabilityDays_GID.Maximum = new decimal(new int[] { 3650, 0, 0, 0 });
            numericUpDownDisabilityDays_GID.Name = "numericUpDownDisabilityDays_GID";
            numericUpDownDisabilityDays_GID.Size = new Size(120, 23);
            numericUpDownDisabilityDays_GID.TabIndex = 19;
            // 
            // labelDisabilityDays_GID
            // 
            labelDisabilityDays_GID.AutoSize = true;
            labelDisabilityDays_GID.Location = new Point(18, 290);
            labelDisabilityDays_GID.Name = "labelDisabilityDays_GID";
            labelDisabilityDays_GID.Size = new Size(194, 15);
            labelDisabilityDays_GID.TabIndex = 18;
            labelDisabilityDays_GID.Text = "Срок нетрудоспособности (дней):";
            // 
            // checkBoxIsAmbulatory_GID
            // 
            checkBoxIsAmbulatory_GID.AutoSize = true;
            checkBoxIsAmbulatory_GID.Location = new Point(55, 258);
            checkBoxIsAmbulatory_GID.Name = "checkBoxIsAmbulatory_GID";
            checkBoxIsAmbulatory_GID.Size = new Size(157, 19);
            checkBoxIsAmbulatory_GID.TabIndex = 17;
            checkBoxIsAmbulatory_GID.Text = "Амбулаторное лечение";
            checkBoxIsAmbulatory_GID.UseVisualStyleBackColor = true;
            // 
            // textBoxDiagnosis_GID
            // 
            textBoxDiagnosis_GID.Location = new Point(218, 224);
            textBoxDiagnosis_GID.Name = "textBoxDiagnosis_GID";
            textBoxDiagnosis_GID.Size = new Size(100, 23);
            textBoxDiagnosis_GID.TabIndex = 16;
            // 
            // labelDiagnosis_GID
            // 
            labelDiagnosis_GID.AutoSize = true;
            labelDiagnosis_GID.Location = new Point(157, 227);
            labelDiagnosis_GID.Name = "labelDiagnosis_GID";
            labelDiagnosis_GID.Size = new Size(55, 15);
            labelDiagnosis_GID.TabIndex = 15;
            labelDiagnosis_GID.Text = "Диагноз:";
            // 
            // textBoxDoctorSpecialization_GID
            // 
            textBoxDoctorSpecialization_GID.Location = new Point(218, 192);
            textBoxDoctorSpecialization_GID.Name = "textBoxDoctorSpecialization_GID";
            textBoxDoctorSpecialization_GID.Size = new Size(100, 23);
            textBoxDoctorSpecialization_GID.TabIndex = 14;
            // 
            // labelDoctorSpecialization_GID
            // 
            labelDoctorSpecialization_GID.AutoSize = true;
            labelDoctorSpecialization_GID.Location = new Point(119, 195);
            labelDoctorSpecialization_GID.Name = "labelDoctorSpecialization_GID";
            labelDoctorSpecialization_GID.Size = new Size(96, 15);
            labelDoctorSpecialization_GID.TabIndex = 13;
            labelDoctorSpecialization_GID.Text = "Специализация:";
            labelDoctorSpecialization_GID.Click += labelDoctorSpecialization_GID_Click;
            // 
            // textBoxDoctorPosition_GID
            // 
            textBoxDoctorPosition_GID.Location = new Point(218, 158);
            textBoxDoctorPosition_GID.Name = "textBoxDoctorPosition_GID";
            textBoxDoctorPosition_GID.Size = new Size(100, 23);
            textBoxDoctorPosition_GID.TabIndex = 12;
            // 
            // labelDoctorPosition_GID
            // 
            labelDoctorPosition_GID.AutoSize = true;
            labelDoctorPosition_GID.Location = new Point(140, 161);
            labelDoctorPosition_GID.Name = "labelDoctorPosition_GID";
            labelDoctorPosition_GID.Size = new Size(72, 15);
            labelDoctorPosition_GID.TabIndex = 11;
            labelDoctorPosition_GID.Text = "Должность:";
            labelDoctorPosition_GID.Click += labelDoctorPosition_GID_Click;
            // 
            // textBoxDoctorFullName_GID
            // 
            textBoxDoctorFullName_GID.Location = new Point(218, 129);
            textBoxDoctorFullName_GID.Name = "textBoxDoctorFullName_GID";
            textBoxDoctorFullName_GID.Size = new Size(100, 23);
            textBoxDoctorFullName_GID.TabIndex = 10;
            // 
            // labelDoctorFullName_GID
            // 
            labelDoctorFullName_GID.AutoSize = true;
            labelDoctorFullName_GID.Location = new Point(140, 132);
            labelDoctorFullName_GID.Name = "labelDoctorFullName_GID";
            labelDoctorFullName_GID.Size = new Size(72, 15);
            labelDoctorFullName_GID.TabIndex = 9;
            labelDoctorFullName_GID.Text = "ФИО врача:";
            // 
            // dateTimePickerBirthDate_GID
            // 
            dateTimePickerBirthDate_GID.Location = new Point(218, 99);
            dateTimePickerBirthDate_GID.Name = "dateTimePickerBirthDate_GID";
            dateTimePickerBirthDate_GID.Size = new Size(200, 23);
            dateTimePickerBirthDate_GID.TabIndex = 8;
            // 
            // labelBirthDate_GID
            // 
            labelBirthDate_GID.AutoSize = true;
            labelBirthDate_GID.Location = new Point(119, 105);
            labelBirthDate_GID.Name = "labelBirthDate_GID";
            labelBirthDate_GID.Size = new Size(93, 15);
            labelBirthDate_GID.TabIndex = 7;
            labelBirthDate_GID.Text = "Дата рождения:";
            // 
            // textBoxMiddleName_GID
            // 
            textBoxMiddleName_GID.Location = new Point(218, 70);
            textBoxMiddleName_GID.Name = "textBoxMiddleName_GID";
            textBoxMiddleName_GID.Size = new Size(100, 23);
            textBoxMiddleName_GID.TabIndex = 6;
            // 
            // labelMiddleName_GID
            // 
            labelMiddleName_GID.AutoSize = true;
            labelMiddleName_GID.Location = new Point(151, 70);
            labelMiddleName_GID.Name = "labelMiddleName_GID";
            labelMiddleName_GID.Size = new Size(61, 15);
            labelMiddleName_GID.TabIndex = 5;
            labelMiddleName_GID.Text = "Отчество:";
            // 
            // textBoxFirstName_GID
            // 
            textBoxFirstName_GID.Location = new Point(218, 36);
            textBoxFirstName_GID.Name = "textBoxFirstName_GID";
            textBoxFirstName_GID.Size = new Size(100, 23);
            textBoxFirstName_GID.TabIndex = 4;
            // 
            // labelFirstName_GID
            // 
            labelFirstName_GID.AutoSize = true;
            labelFirstName_GID.Location = new Point(178, 39);
            labelFirstName_GID.Name = "labelFirstName_GID";
            labelFirstName_GID.Size = new Size(34, 15);
            labelFirstName_GID.TabIndex = 3;
            labelFirstName_GID.Text = "Имя:";
            labelFirstName_GID.Click += labelFirstName_GID_Click;
            // 
            // textBoxLastName_GID
            // 
            textBoxLastName_GID.Location = new Point(218, 7);
            textBoxLastName_GID.Name = "textBoxLastName_GID";
            textBoxLastName_GID.Size = new Size(100, 23);
            textBoxLastName_GID.TabIndex = 2;
            // 
            // labelLastName_GID
            // 
            labelLastName_GID.AutoSize = true;
            labelLastName_GID.Location = new Point(151, 9);
            labelLastName_GID.Name = "labelLastName_GID";
            labelLastName_GID.Size = new Size(61, 15);
            labelLastName_GID.TabIndex = 1;
            labelLastName_GID.Text = "Фамилия:";
            labelLastName_GID.Click += labelLastName_GID_Click;
            // 
            // panelButtons_GID
            // 
            panelButtons_GID.Controls.Add(buttonCancel_GID);
            panelButtons_GID.Controls.Add(buttonOk_GID);
            panelButtons_GID.Dock = DockStyle.Bottom;
            panelButtons_GID.Location = new Point(0, 395);
            panelButtons_GID.Name = "panelButtons_GID";
            panelButtons_GID.Size = new Size(800, 55);
            panelButtons_GID.TabIndex = 0;
            // 
            // buttonCancel_GID
            // 
            buttonCancel_GID.Location = new Point(359, 20);
            buttonCancel_GID.Name = "buttonCancel_GID";
            buttonCancel_GID.Size = new Size(75, 23);
            buttonCancel_GID.TabIndex = 1;
            buttonCancel_GID.Text = "Отмена";
            buttonCancel_GID.UseVisualStyleBackColor = true;
            // 
            // buttonOk_GID
            // 
            buttonOk_GID.Location = new Point(243, 20);
            buttonOk_GID.Name = "buttonOk_GID";
            buttonOk_GID.Size = new Size(75, 23);
            buttonOk_GID.TabIndex = 0;
            buttonOk_GID.Text = "Сохранить";
            buttonOk_GID.UseVisualStyleBackColor = true;
            buttonOk_GID.Click += buttonOk_GID_Click;
            // 
            // EditPatientForm_GID
            // 
            AcceptButton = buttonOk_GID;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel_GID;
            ClientSize = new Size(800, 450);
            Controls.Add(panelInputs_GID);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditPatientForm_GID";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Пациент — добавление/редактирование";
            panelInputs_GID.ResumeLayout(false);
            panelInputs_GID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisabilityDays_GID).EndInit();
            panelButtons_GID.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInputs_GID;
        private TextBox textBoxFirstName_GID;
        private Label labelFirstName_GID;
        private TextBox textBoxLastName_GID;
        private Label labelLastName_GID;
        private Panel panelButtons_GID;
        private TextBox textBoxDoctorPosition_GID;
        private Label labelDoctorPosition_GID;
        private TextBox textBoxDoctorFullName_GID;
        private Label labelDoctorFullName_GID;
        private DateTimePicker dateTimePickerBirthDate_GID;
        private Label labelBirthDate_GID;
        private TextBox textBoxMiddleName_GID;
        private Label labelMiddleName_GID;
        private TextBox textBoxDoctorSpecialization_GID;
        private Label labelDoctorSpecialization_GID;
        private TextBox textBoxDiagnosis_GID;
        private Label labelDiagnosis_GID;
        private CheckBox checkBoxIsDispensary_GID;
        private NumericUpDown numericUpDownDisabilityDays_GID;
        private Label labelDisabilityDays_GID;
        private CheckBox checkBoxIsAmbulatory_GID;
        private TextBox textBoxNote_GID;
        private Label labelNote_GID;
        private Button buttonCancel_GID;
        private Button buttonOk_GID;
    }
}