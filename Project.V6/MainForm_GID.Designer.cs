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
            dataGridViewPatients_GID = new DataGridView();
            menuStripMain_GID = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            menuItemFileOpen_GID = new ToolStripMenuItem();
            menuItemFileSave_GID = new ToolStripMenuItem();
            menuItemFileExit_GID = new ToolStripMenuItem();
            menuItemHelpManual_GID = new ToolStripMenuItem();
            руководствоПользователяToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients_GID).BeginInit();
            menuStripMain_GID.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPatients_GID
            // 
            dataGridViewPatients_GID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatients_GID.Location = new Point(56, 110);
            dataGridViewPatients_GID.Name = "dataGridViewPatients_GID";
            dataGridViewPatients_GID.Size = new Size(644, 301);
            dataGridViewPatients_GID.TabIndex = 0;
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
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuItemHelpManual_GID, руководствоПользователяToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // menuItemFileOpen_GID
            // 
            menuItemFileOpen_GID.Name = "menuItemFileOpen_GID";
            menuItemFileOpen_GID.Size = new Size(180, 22);
            menuItemFileOpen_GID.Text = "Открыть";
            // 
            // menuItemFileSave_GID
            // 
            menuItemFileSave_GID.Name = "menuItemFileSave_GID";
            menuItemFileSave_GID.Size = new Size(180, 22);
            menuItemFileSave_GID.Text = "Сохранить";
            // 
            // menuItemFileExit_GID
            // 
            menuItemFileExit_GID.Name = "menuItemFileExit_GID";
            menuItemFileExit_GID.Size = new Size(180, 22);
            menuItemFileExit_GID.Text = "Выход";
            // 
            // menuItemHelpManual_GID
            // 
            menuItemHelpManual_GID.Name = "menuItemHelpManual_GID";
            menuItemHelpManual_GID.Size = new Size(221, 22);
            menuItemHelpManual_GID.Text = "О программе";
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            руководствоПользователяToolStripMenuItem.Size = new Size(221, 22);
            руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            // 
            // MainForm_GID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(dataGridViewPatients_GID);
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
        private ToolStripMenuItem menuItemHelpManual_GID;
        private ToolStripMenuItem руководствоПользователяToolStripMenuItem;
    }
}
