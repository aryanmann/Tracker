namespace Tracker
{
    partial class TrackerForm
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dataManipulation = new System.Windows.Forms.Panel();
            this.listSubject = new System.Windows.Forms.ListBox();
            this.listTopic = new System.Windows.Forms.ListBox();
            this.listFormula = new System.Windows.Forms.DataGridView();
            this.subjectOptions = new System.Windows.Forms.Button();
            this.topicOptions = new System.Windows.Forms.Button();
            this.formulaAdd = new System.Windows.Forms.Button();
            this.formulaDelete = new System.Windows.Forms.Button();
            this.menuData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataTopic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataFormula = new System.Windows.Forms.ToolStripMenuItem();
            this.dataInformation = new System.Windows.Forms.Panel();
            this.menuBar.SuspendLayout();
            this.dataManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit,
            this.menuData});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(847, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(37, 20);
            this.menuExit.Text = "Exit";
            // 
            // dataManipulation
            // 
            this.dataManipulation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataManipulation.Controls.Add(this.formulaDelete);
            this.dataManipulation.Controls.Add(this.formulaAdd);
            this.dataManipulation.Controls.Add(this.topicOptions);
            this.dataManipulation.Controls.Add(this.subjectOptions);
            this.dataManipulation.Controls.Add(this.listFormula);
            this.dataManipulation.Controls.Add(this.listTopic);
            this.dataManipulation.Controls.Add(this.listSubject);
            this.dataManipulation.Location = new System.Drawing.Point(13, 28);
            this.dataManipulation.Name = "dataManipulation";
            this.dataManipulation.Size = new System.Drawing.Size(417, 479);
            this.dataManipulation.TabIndex = 1;
            // 
            // listSubject
            // 
            this.listSubject.FormattingEnabled = true;
            this.listSubject.Location = new System.Drawing.Point(4, 4);
            this.listSubject.Name = "listSubject";
            this.listSubject.Size = new System.Drawing.Size(200, 95);
            this.listSubject.TabIndex = 0;
            this.listSubject.SelectedIndexChanged += new System.EventHandler(this.listSubject_SelectedIndexChanged);
            // 
            // listTopic
            // 
            this.listTopic.FormattingEnabled = true;
            this.listTopic.Location = new System.Drawing.Point(210, 4);
            this.listTopic.Name = "listTopic";
            this.listTopic.Size = new System.Drawing.Size(200, 95);
            this.listTopic.TabIndex = 1;
            this.listTopic.SelectedIndexChanged += new System.EventHandler(this.listTopic_SelectedIndexChanged);
            // 
            // listFormula
            // 
            this.listFormula.AllowUserToOrderColumns = true;
            this.listFormula.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listFormula.Location = new System.Drawing.Point(4, 137);
            this.listFormula.Name = "listFormula";
            this.listFormula.Size = new System.Drawing.Size(406, 307);
            this.listFormula.TabIndex = 2;
            // 
            // subjectOptions
            // 
            this.subjectOptions.Location = new System.Drawing.Point(4, 105);
            this.subjectOptions.Name = "subjectOptions";
            this.subjectOptions.Size = new System.Drawing.Size(200, 26);
            this.subjectOptions.TabIndex = 3;
            this.subjectOptions.Text = "Subject Options";
            this.subjectOptions.UseVisualStyleBackColor = true;
            // 
            // topicOptions
            // 
            this.topicOptions.Location = new System.Drawing.Point(210, 105);
            this.topicOptions.Name = "topicOptions";
            this.topicOptions.Size = new System.Drawing.Size(200, 26);
            this.topicOptions.TabIndex = 4;
            this.topicOptions.Text = "Topic Options";
            this.topicOptions.UseVisualStyleBackColor = true;
            // 
            // formulaAdd
            // 
            this.formulaAdd.Location = new System.Drawing.Point(4, 450);
            this.formulaAdd.Name = "formulaAdd";
            this.formulaAdd.Size = new System.Drawing.Size(200, 26);
            this.formulaAdd.TabIndex = 5;
            this.formulaAdd.Text = "Add New Formula";
            this.formulaAdd.UseVisualStyleBackColor = true;
            // 
            // formulaDelete
            // 
            this.formulaDelete.Location = new System.Drawing.Point(210, 450);
            this.formulaDelete.Name = "formulaDelete";
            this.formulaDelete.Size = new System.Drawing.Size(200, 26);
            this.formulaDelete.TabIndex = 6;
            this.formulaDelete.Text = "Delete Formula";
            this.formulaDelete.UseVisualStyleBackColor = true;
            // 
            // menuData
            // 
            this.menuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDataSubject,
            this.menuDataTopic,
            this.menuDataFormula});
            this.menuData.Name = "menuData";
            this.menuData.Size = new System.Drawing.Size(43, 20);
            this.menuData.Text = "Data";
            // 
            // menuDataSubject
            // 
            this.menuDataSubject.Name = "menuDataSubject";
            this.menuDataSubject.Size = new System.Drawing.Size(152, 22);
            this.menuDataSubject.Text = "Subject";
            // 
            // menuDataTopic
            // 
            this.menuDataTopic.Name = "menuDataTopic";
            this.menuDataTopic.Size = new System.Drawing.Size(152, 22);
            this.menuDataTopic.Text = "Topic";
            // 
            // menuDataFormula
            // 
            this.menuDataFormula.Name = "menuDataFormula";
            this.menuDataFormula.Size = new System.Drawing.Size(152, 22);
            this.menuDataFormula.Text = "Formula";
            // 
            // dataInformation
            // 
            this.dataInformation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataInformation.Location = new System.Drawing.Point(437, 28);
            this.dataInformation.Name = "dataInformation";
            this.dataInformation.Size = new System.Drawing.Size(398, 479);
            this.dataInformation.TabIndex = 2;
            // 
            // TrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 519);
            this.Controls.Add(this.dataInformation);
            this.Controls.Add(this.dataManipulation);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "TrackerForm";
            this.Text = "Infirmula";
            this.Load += new System.EventHandler(this.TrackerForm_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.dataManipulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Panel dataManipulation;
        private System.Windows.Forms.Button topicOptions;
        private System.Windows.Forms.Button subjectOptions;
        private System.Windows.Forms.DataGridView listFormula;
        private System.Windows.Forms.ListBox listTopic;
        private System.Windows.Forms.ListBox listSubject;
        private System.Windows.Forms.Button formulaDelete;
        private System.Windows.Forms.Button formulaAdd;
        private System.Windows.Forms.ToolStripMenuItem menuData;
        private System.Windows.Forms.ToolStripMenuItem menuDataSubject;
        private System.Windows.Forms.ToolStripMenuItem menuDataTopic;
        private System.Windows.Forms.ToolStripMenuItem menuDataFormula;
        private System.Windows.Forms.Panel dataInformation;
    }
}

