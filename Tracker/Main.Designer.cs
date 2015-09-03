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
            this.menuData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataTopic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataFormula = new System.Windows.Forms.ToolStripMenuItem();
            this.dataManipulation = new System.Windows.Forms.Panel();
            this.listFormula = new System.Windows.Forms.ListBox();
            this.formulaDelete = new System.Windows.Forms.Button();
            this.formulaAdd = new System.Windows.Forms.Button();
            this.topicOptions = new System.Windows.Forms.Button();
            this.subjectOptions = new System.Windows.Forms.Button();
            this.listTopic = new System.Windows.Forms.ListBox();
            this.listSubject = new System.Windows.Forms.ListBox();
            this.dataInformation = new System.Windows.Forms.Panel();
            this.formulaPicture = new System.Windows.Forms.PictureBox();
            this.propName = new System.Windows.Forms.Label();
            this.propDescription = new System.Windows.Forms.RichTextBox();
            this.propSave = new System.Windows.Forms.Button();
            this.propFormula = new System.Windows.Forms.RichTextBox();
            this.propLabelFormula = new System.Windows.Forms.Label();
            this.propLabelDescription = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.dataManipulation.SuspendLayout();
            this.dataInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formulaPicture)).BeginInit();
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
            this.menuDataSubject.Size = new System.Drawing.Size(118, 22);
            this.menuDataSubject.Text = "Subject";
            // 
            // menuDataTopic
            // 
            this.menuDataTopic.Name = "menuDataTopic";
            this.menuDataTopic.Size = new System.Drawing.Size(118, 22);
            this.menuDataTopic.Text = "Topic";
            // 
            // menuDataFormula
            // 
            this.menuDataFormula.Name = "menuDataFormula";
            this.menuDataFormula.Size = new System.Drawing.Size(118, 22);
            this.menuDataFormula.Text = "Formula";
            // 
            // dataManipulation
            // 
            this.dataManipulation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataManipulation.Controls.Add(this.listFormula);
            this.dataManipulation.Controls.Add(this.formulaDelete);
            this.dataManipulation.Controls.Add(this.formulaAdd);
            this.dataManipulation.Controls.Add(this.topicOptions);
            this.dataManipulation.Controls.Add(this.subjectOptions);
            this.dataManipulation.Controls.Add(this.listTopic);
            this.dataManipulation.Controls.Add(this.listSubject);
            this.dataManipulation.Controls.Add(this.formulaPicture);
            this.dataManipulation.Location = new System.Drawing.Point(13, 28);
            this.dataManipulation.Name = "dataManipulation";
            this.dataManipulation.Size = new System.Drawing.Size(417, 479);
            this.dataManipulation.TabIndex = 1;
            // 
            // listFormula
            // 
            this.listFormula.FormattingEnabled = true;
            this.listFormula.Location = new System.Drawing.Point(4, 137);
            this.listFormula.Name = "listFormula";
            this.listFormula.Size = new System.Drawing.Size(406, 108);
            this.listFormula.TabIndex = 7;
            this.listFormula.SelectedIndexChanged += new System.EventHandler(this.listFormula_SelectedIndexChanged);
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
            // formulaAdd
            // 
            this.formulaAdd.Location = new System.Drawing.Point(4, 450);
            this.formulaAdd.Name = "formulaAdd";
            this.formulaAdd.Size = new System.Drawing.Size(200, 26);
            this.formulaAdd.TabIndex = 5;
            this.formulaAdd.Text = "Add New Formula";
            this.formulaAdd.UseVisualStyleBackColor = true;
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
            // subjectOptions
            // 
            this.subjectOptions.Location = new System.Drawing.Point(4, 105);
            this.subjectOptions.Name = "subjectOptions";
            this.subjectOptions.Size = new System.Drawing.Size(200, 26);
            this.subjectOptions.TabIndex = 3;
            this.subjectOptions.Text = "Subject Options";
            this.subjectOptions.UseVisualStyleBackColor = true;
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
            // listSubject
            // 
            this.listSubject.FormattingEnabled = true;
            this.listSubject.Location = new System.Drawing.Point(4, 4);
            this.listSubject.Name = "listSubject";
            this.listSubject.Size = new System.Drawing.Size(200, 95);
            this.listSubject.TabIndex = 0;
            this.listSubject.SelectedIndexChanged += new System.EventHandler(this.listSubject_SelectedIndexChanged);
            // 
            // dataInformation
            // 
            this.dataInformation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataInformation.Controls.Add(this.propLabelDescription);
            this.dataInformation.Controls.Add(this.propLabelFormula);
            this.dataInformation.Controls.Add(this.propSave);
            this.dataInformation.Controls.Add(this.propFormula);
            this.dataInformation.Controls.Add(this.propDescription);
            this.dataInformation.Controls.Add(this.propName);
            this.dataInformation.Location = new System.Drawing.Point(437, 28);
            this.dataInformation.Name = "dataInformation";
            this.dataInformation.Size = new System.Drawing.Size(398, 479);
            this.dataInformation.TabIndex = 2;
            // 
            // formulaPicture
            // 
            this.formulaPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.formulaPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formulaPicture.Location = new System.Drawing.Point(4, 252);
            this.formulaPicture.Name = "formulaPicture";
            this.formulaPicture.Size = new System.Drawing.Size(406, 192);
            this.formulaPicture.TabIndex = 8;
            this.formulaPicture.TabStop = false;
            // 
            // propName
            // 
            this.propName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.propName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.propName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.propName.Location = new System.Drawing.Point(3, 4);
            this.propName.Name = "propName";
            this.propName.Size = new System.Drawing.Size(392, 58);
            this.propName.TabIndex = 9;
            this.propName.Text = "label1";
            this.propName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // propDescription
            // 
            this.propDescription.Location = new System.Drawing.Point(7, 204);
            this.propDescription.Name = "propDescription";
            this.propDescription.Size = new System.Drawing.Size(378, 180);
            this.propDescription.TabIndex = 10;
            this.propDescription.Text = "";
            // 
            // propSave
            // 
            this.propSave.Location = new System.Drawing.Point(7, 450);
            this.propSave.Name = "propSave";
            this.propSave.Size = new System.Drawing.Size(183, 23);
            this.propSave.TabIndex = 11;
            this.propSave.Text = "Save Details";
            this.propSave.UseVisualStyleBackColor = true;
            this.propSave.Click += new System.EventHandler(this.propSave_Click);
            // 
            // propFormula
            // 
            this.propFormula.Location = new System.Drawing.Point(7, 105);
            this.propFormula.Name = "propFormula";
            this.propFormula.Size = new System.Drawing.Size(378, 65);
            this.propFormula.TabIndex = 12;
            this.propFormula.Text = "";
            // 
            // propLabelFormula
            // 
            this.propLabelFormula.BackColor = System.Drawing.SystemColors.ControlLight;
            this.propLabelFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.propLabelFormula.Location = new System.Drawing.Point(7, 80);
            this.propLabelFormula.Name = "propLabelFormula";
            this.propLabelFormula.Size = new System.Drawing.Size(93, 19);
            this.propLabelFormula.TabIndex = 13;
            this.propLabelFormula.Text = "LaTex Formula";
            this.propLabelFormula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // propLabelDescription
            // 
            this.propLabelDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.propLabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.propLabelDescription.Location = new System.Drawing.Point(7, 182);
            this.propLabelDescription.Name = "propLabelDescription";
            this.propLabelDescription.Size = new System.Drawing.Size(93, 19);
            this.propLabelDescription.TabIndex = 14;
            this.propLabelDescription.Text = "Description";
            this.propLabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dataInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formulaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Panel dataManipulation;
        private System.Windows.Forms.Button topicOptions;
        private System.Windows.Forms.Button subjectOptions;
        private System.Windows.Forms.ListBox listTopic;
        private System.Windows.Forms.ListBox listSubject;
        private System.Windows.Forms.Button formulaDelete;
        private System.Windows.Forms.Button formulaAdd;
        private System.Windows.Forms.ToolStripMenuItem menuData;
        private System.Windows.Forms.ToolStripMenuItem menuDataSubject;
        private System.Windows.Forms.ToolStripMenuItem menuDataTopic;
        private System.Windows.Forms.ToolStripMenuItem menuDataFormula;
        private System.Windows.Forms.Panel dataInformation;
        private System.Windows.Forms.ListBox listFormula;
        private System.Windows.Forms.PictureBox formulaPicture;
        private System.Windows.Forms.Label propName;
        private System.Windows.Forms.RichTextBox propDescription;
        private System.Windows.Forms.Button propSave;
        private System.Windows.Forms.RichTextBox propFormula;
        private System.Windows.Forms.Label propLabelFormula;
        private System.Windows.Forms.Label propLabelDescription;
    }
}

