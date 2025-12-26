namespace Project.V6
{
    partial class MainForm_GID
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_GID));
            dataGridViewPatients_GID = new DataGridView();
            menuStripMain_GID = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            menuItemFileOpen_GID = new ToolStripMenuItem();
            menuItemFileSave_GID = new ToolStripMenuItem();
            menuItemFileExit_GID = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            menuItemHelpAbout_GID = new ToolStripMenuItem();
            menuItemHelpManual_GID = new ToolStripMenuItem();
            toolStripMain_GID = new ToolStrip();
            toolButtonAddPatient_GID = new ToolStripButton();
            toolButtonEditPatient_GID = new ToolStripButton();
            toolButtonDeletePatient_GID = new ToolStripButton();
            toolButtonSearch_GID = new ToolStripButton();
            toolButtonFilter_GID = new ToolStripButton();
            toolButtonSort_GID = new ToolStripButton();
            bindingSource1 = new BindingSource(components);
            panelSearchFilter_GID = new Panel();
            buttonSearch_GID = new Button();
            textBoxSearchLastName_GID = new TextBox();
            labelSearchLastName_GID = new Label();
            panelStatistics_GID = new Panel();
            labelMax_GID = new Label();
            labelMin_GID = new Label();
            labelAverage_GID = new Label();
            labelTotalCount_GID = new Label();
            panelChart_GID = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients_GID).BeginInit();
            menuStripMain_GID.SuspendLayout();
            toolStripMain_GID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panelSearchFilter_GID.SuspendLayout();
            panelStatistics_GID.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPatients_GID
            // 
            dataGridViewPatients_GID.AllowUserToAddRows = false;
            dataGridViewPatients_GID.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPatients_GID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatients_GID.Dock = DockStyle.Fill;
            dataGridViewPatients_GID.Location = new Point(0, 99);
            dataGridViewPatients_GID.Name = "dataGridViewPatients_GID";
            dataGridViewPatients_GID.ReadOnly = true;
            dataGridViewPatients_GID.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPatients_GID.Size = new Size(464, 402);
            dataGridViewPatients_GID.TabIndex = 0;
            dataGridViewPatients_GID.CellContentClick += dataGridViewPatients_GID_CellContentClick;
            // 
            // menuStripMain_GID
            // 
            menuStripMain_GID.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStripMain_GID.Location = new Point(0, 0);
            menuStripMain_GID.Name = "menuStripMain_GID";
            menuStripMain_GID.Size = new Size(884, 24);
            menuStripMain_GID.TabIndex = 1;
            menuStripMain_GID.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuItemFileOpen_GID, menuItemFileSave_GID, menuItemFileExit_GID });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // menuItemFileOpen_GID
            // 
            menuItemFileOpen_GID.Name = "menuItemFileOpen_GID";
            menuItemFileOpen_GID.Size = new Size(132, 22);
            menuItemFileOpen_GID.Text = "Открыть";
            // 
            // menuItemFileSave_GID
            // 
            menuItemFileSave_GID.Name = "menuItemFileSave_GID";
            menuItemFileSave_GID.Size = new Size(132, 22);
            menuItemFileSave_GID.Text = "Сохранить";
            // 
            // menuItemFileExit_GID
            // 
            menuItemFileExit_GID.Name = "menuItemFileExit_GID";
            menuItemFileExit_GID.Size = new Size(132, 22);
            menuItemFileExit_GID.Text = "Выход";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuItemHelpAbout_GID, menuItemHelpManual_GID });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // menuItemHelpAbout_GID
            // 
            menuItemHelpAbout_GID.Name = "menuItemHelpAbout_GID";
            menuItemHelpAbout_GID.Size = new Size(221, 22);
            menuItemHelpAbout_GID.Text = "О программе";
            // 
            // menuItemHelpManual_GID
            // 
            menuItemHelpManual_GID.Name = "menuItemHelpManual_GID";
            menuItemHelpManual_GID.Size = new Size(221, 22);
            menuItemHelpManual_GID.Text = "Руководство пользователя";
            // 
            // toolStripMain_GID
            // 
            toolStripMain_GID.Items.AddRange(new ToolStripItem[] { toolButtonAddPatient_GID, toolButtonEditPatient_GID, toolButtonDeletePatient_GID, toolButtonSearch_GID, toolButtonFilter_GID, toolButtonSort_GID });
            toolStripMain_GID.Location = new Point(0, 24);
            toolStripMain_GID.Name = "toolStripMain_GID";
            toolStripMain_GID.Size = new Size(884, 25);
            toolStripMain_GID.TabIndex = 2;
            toolStripMain_GID.Text = "toolStrip1";
            toolStripMain_GID.ItemClicked += toolStripMain_GID_ItemClicked;
            // 
            // toolButtonAddPatient_GID
            // 
            toolButtonAddPatient_GID.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolButtonAddPatient_GID.Image = (Image)resources.GetObject("toolButtonAddPatient_GID.Image");
            toolButtonAddPatient_GID.ImageTransparentColor = Color.Magenta;
            toolButtonAddPatient_GID.Name = "toolButtonAddPatient_GID";
            toolButtonAddPatient_GID.Size = new Size(23, 22);
            toolButtonAddPatient_GID.Text = "Добавить";
            toolButtonAddPatient_GID.ToolTipText = "Добавить пациента";
            toolButtonAddPatient_GID.Click += toolButtonAddPatient_GID_Click;
            // 
            // toolButtonEditPatient_GID
            // 
            toolButtonEditPatient_GID.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolButtonEditPatient_GID.Image = (Image)resources.GetObject("toolButtonEditPatient_GID.Image");
            toolButtonEditPatient_GID.ImageTransparentColor = Color.Magenta;
            toolButtonEditPatient_GID.Name = "toolButtonEditPatient_GID";
            toolButtonEditPatient_GID.Size = new Size(23, 22);
            toolButtonEditPatient_GID.Text = "Редактировать";
            toolButtonEditPatient_GID.ToolTipText = "Редактировать выбранного пациента";
            // 
            // toolButtonDeletePatient_GID
            // 
            toolButtonDeletePatient_GID.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolButtonDeletePatient_GID.Image = (Image)resources.GetObject("toolButtonDeletePatient_GID.Image");
            toolButtonDeletePatient_GID.ImageTransparentColor = Color.Magenta;
            toolButtonDeletePatient_GID.Name = "toolButtonDeletePatient_GID";
            toolButtonDeletePatient_GID.Size = new Size(23, 22);
            toolButtonDeletePatient_GID.Text = "Удалить";
            toolButtonDeletePatient_GID.ToolTipText = "Удалить выбранного пациента";
            toolButtonDeletePatient_GID.Click += toolButtonDeletePatient_GID_Click;
            // 
            // toolButtonSearch_GID
            // 
            toolButtonSearch_GID.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolButtonSearch_GID.Image = (Image)resources.GetObject("toolButtonSearch_GID.Image");
            toolButtonSearch_GID.ImageTransparentColor = Color.Magenta;
            toolButtonSearch_GID.Name = "toolButtonSearch_GID";
            toolButtonSearch_GID.Size = new Size(23, 22);
            toolButtonSearch_GID.Text = "Поиск";
            toolButtonSearch_GID.ToolTipText = "Найти пациента по параметрам";
            toolButtonSearch_GID.Click += toolButtonSearch_GID_Click;
            // 
            // toolButtonFilter_GID
            // 
            toolButtonFilter_GID.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolButtonFilter_GID.Image = (Image)resources.GetObject("toolButtonFilter_GID.Image");
            toolButtonFilter_GID.ImageTransparentColor = Color.Magenta;
            toolButtonFilter_GID.Name = "toolButtonFilter_GID";
            toolButtonFilter_GID.Size = new Size(23, 22);
            toolButtonFilter_GID.Text = "Фильтр";
            toolButtonFilter_GID.ToolTipText = "Фильтрация списка";
            // 
            // toolButtonSort_GID
            // 
            toolButtonSort_GID.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolButtonSort_GID.Image = (Image)resources.GetObject("toolButtonSort_GID.Image");
            toolButtonSort_GID.ImageTransparentColor = Color.Magenta;
            toolButtonSort_GID.Name = "toolButtonSort_GID";
            toolButtonSort_GID.Size = new Size(23, 22);
            toolButtonSort_GID.Text = "Сортировка";
            toolButtonSort_GID.ToolTipText = "Сортировать данные";
            toolButtonSort_GID.Click += toolButtonSort_GID_Click;
            // 
            // panelSearchFilter_GID
            // 
            panelSearchFilter_GID.Controls.Add(buttonSearch_GID);
            panelSearchFilter_GID.Controls.Add(textBoxSearchLastName_GID);
            panelSearchFilter_GID.Controls.Add(labelSearchLastName_GID);
            panelSearchFilter_GID.Dock = DockStyle.Top;
            panelSearchFilter_GID.Location = new Point(0, 49);
            panelSearchFilter_GID.Name = "panelSearchFilter_GID";
            panelSearchFilter_GID.Size = new Size(884, 50);
            panelSearchFilter_GID.TabIndex = 3;
            panelSearchFilter_GID.Paint += panelSearchFilter_GID_Paint;
            // 
            // buttonSearch_GID
            // 
            buttonSearch_GID.Location = new Point(241, 12);
            buttonSearch_GID.Name = "buttonSearch_GID";
            buttonSearch_GID.Size = new Size(75, 23);
            buttonSearch_GID.TabIndex = 2;
            buttonSearch_GID.Text = "Найти";
            buttonSearch_GID.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchLastName_GID
            // 
            textBoxSearchLastName_GID.Location = new Point(135, 12);
            textBoxSearchLastName_GID.Name = "textBoxSearchLastName_GID";
            textBoxSearchLastName_GID.Size = new Size(100, 23);
            textBoxSearchLastName_GID.TabIndex = 1;
            // 
            // labelSearchLastName_GID
            // 
            labelSearchLastName_GID.AutoSize = true;
            labelSearchLastName_GID.Location = new Point(12, 15);
            labelSearchLastName_GID.Name = "labelSearchLastName_GID";
            labelSearchLastName_GID.Size = new Size(117, 15);
            labelSearchLastName_GID.TabIndex = 0;
            labelSearchLastName_GID.Text = "Поиск по фамилии:";
            // 
            // panelStatistics_GID
            // 
            panelStatistics_GID.Controls.Add(labelMax_GID);
            panelStatistics_GID.Controls.Add(labelMin_GID);
            panelStatistics_GID.Controls.Add(labelAverage_GID);
            panelStatistics_GID.Controls.Add(labelTotalCount_GID);
            panelStatistics_GID.Dock = DockStyle.Bottom;
            panelStatistics_GID.Location = new Point(0, 501);
            panelStatistics_GID.Name = "panelStatistics_GID";
            panelStatistics_GID.Size = new Size(884, 60);
            panelStatistics_GID.TabIndex = 4;
            // 
            // labelMax_GID
            // 
            labelMax_GID.AutoSize = true;
            labelMax_GID.Location = new Point(287, 30);
            labelMax_GID.Name = "labelMax_GID";
            labelMax_GID.Size = new Size(41, 15);
            labelMax_GID.TabIndex = 3;
            labelMax_GID.Text = "Max: 0";
            // 
            // labelMin_GID
            // 
            labelMin_GID.AutoSize = true;
            labelMin_GID.Location = new Point(241, 30);
            labelMin_GID.Name = "labelMin_GID";
            labelMin_GID.Size = new Size(40, 15);
            labelMin_GID.TabIndex = 2;
            labelMin_GID.Text = "Min: 0";
            // 
            // labelAverage_GID
            // 
            labelAverage_GID.AutoSize = true;
            labelAverage_GID.Location = new Point(139, 30);
            labelAverage_GID.Name = "labelAverage_GID";
            labelAverage_GID.Size = new Size(96, 15);
            labelAverage_GID.TabIndex = 1;
            labelAverage_GID.Text = "Средний срок: 0";
            // 
            // labelTotalCount_GID
            // 
            labelTotalCount_GID.AutoSize = true;
            labelTotalCount_GID.Location = new Point(18, 30);
            labelTotalCount_GID.Name = "labelTotalCount_GID";
            labelTotalCount_GID.Size = new Size(111, 15);
            labelTotalCount_GID.TabIndex = 0;
            labelTotalCount_GID.Text = "Всего пациентов: 0";
            // 
            // panelChart_GID
            // 
            panelChart_GID.Dock = DockStyle.Right;
            panelChart_GID.Location = new Point(464, 99);
            panelChart_GID.Name = "panelChart_GID";
            panelChart_GID.Size = new Size(420, 402);
            panelChart_GID.TabIndex = 4;
            panelChart_GID.Paint += panelChart_GID_Paint;
            // 
            // MainForm_GID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(dataGridViewPatients_GID);
            Controls.Add(panelChart_GID);
            Controls.Add(panelStatistics_GID);
            Controls.Add(panelSearchFilter_GID);
            Controls.Add(toolStripMain_GID);
            Controls.Add(menuStripMain_GID);
            MainMenuStrip = menuStripMain_GID;
            MinimumSize = new Size(900, 600);
            Name = "MainForm_GID";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\"Поликлиника - реестр пациентов\"";
            Load += MainForm_GID_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients_GID).EndInit();
            menuStripMain_GID.ResumeLayout(false);
            menuStripMain_GID.PerformLayout();
            toolStripMain_GID.ResumeLayout(false);
            toolStripMain_GID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panelSearchFilter_GID.ResumeLayout(false);
            panelSearchFilter_GID.PerformLayout();
            panelStatistics_GID.ResumeLayout(false);
            panelStatistics_GID.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPatients_GID;
        private MenuStrip menuStripMain_GID;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem menuItemFileOpen_GID;
        private ToolStripMenuItem menuItemFileSave_GID;
        private ToolStripMenuItem menuItemFileExit_GID;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem menuItemHelpAbout_GID;
        private ToolStripMenuItem menuItemHelpManual_GID;
        private ToolStrip toolStripMain_GID;
        private ToolStripButton toolButtonAddPatient_GID;
        private ToolStripButton toolButtonEditPatient_GID;
        private ToolStripButton toolButtonDeletePatient_GID;
        private ToolStripButton toolButtonSearch_GID;
        private ToolStripButton toolButtonFilter_GID;
        private ToolStripButton toolButtonSort_GID;
        private BindingSource bindingSource1;
        private Panel panelSearchFilter_GID;
        private Button buttonSearch_GID;
        private TextBox textBoxSearchLastName_GID;
        private Label labelSearchLastName_GID;
        private Panel panelStatistics_GID;
        private Label labelMax_GID;
        private Label labelMin_GID;
        private Label labelAverage_GID;
        private Label labelTotalCount_GID;
        private Panel panelChart_GID;
    }
}
