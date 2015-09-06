namespace Tracker
{
    partial class ListEdit
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
            this.leTitle = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.ListBox();
            this.addToList = new System.Windows.Forms.Button();
            this.removeFromList = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusSay = new System.Windows.Forms.ToolStripStatusLabel();
            this.itemName = new System.Windows.Forms.TextBox();
            this.saveItem = new System.Windows.Forms.Button();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // leTitle
            // 
            this.leTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.leTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.leTitle.Location = new System.Drawing.Point(13, 13);
            this.leTitle.Name = "leTitle";
            this.leTitle.Size = new System.Drawing.Size(567, 47);
            this.leTitle.TabIndex = 0;
            this.leTitle.Text = "The title of the thing.";
            this.leTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(13, 63);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(567, 134);
            this.itemList.TabIndex = 1;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
            // 
            // addToList
            // 
            this.addToList.Location = new System.Drawing.Point(13, 203);
            this.addToList.Name = "addToList";
            this.addToList.Size = new System.Drawing.Size(277, 30);
            this.addToList.TabIndex = 2;
            this.addToList.Text = "Add A Thing";
            this.addToList.UseVisualStyleBackColor = true;
            this.addToList.Click += new System.EventHandler(this.addToList_Click);
            // 
            // removeFromList
            // 
            this.removeFromList.Location = new System.Drawing.Point(296, 203);
            this.removeFromList.Name = "removeFromList";
            this.removeFromList.Size = new System.Drawing.Size(277, 30);
            this.removeFromList.TabIndex = 3;
            this.removeFromList.Text = "Remove A Thing";
            this.removeFromList.UseVisualStyleBackColor = true;
            this.removeFromList.Click += new System.EventHandler(this.removeFromList_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusSay});
            this.status.Location = new System.Drawing.Point(0, 278);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(592, 22);
            this.status.TabIndex = 4;
            this.status.Text = "statusStrip1";
            // 
            // statusSay
            // 
            this.statusSay.Name = "statusSay";
            this.statusSay.Size = new System.Drawing.Size(60, 17);
            this.statusSay.Text = "Initialized.";
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(13, 239);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(492, 20);
            this.itemName.TabIndex = 5;
            // 
            // saveItem
            // 
            this.saveItem.Location = new System.Drawing.Point(512, 239);
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(68, 20);
            this.saveItem.TabIndex = 6;
            this.saveItem.Text = "Save";
            this.saveItem.UseVisualStyleBackColor = true;
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // ListEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(592, 300);
            this.Controls.Add(this.saveItem);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.status);
            this.Controls.Add(this.removeFromList);
            this.Controls.Add(this.addToList);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.leTitle);
            this.Name = "ListEdit";
            this.Text = "ListEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListEdit_FormClosed);
            this.Load += new System.EventHandler(this.ListEdit_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leTitle;
        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.Button addToList;
        private System.Windows.Forms.Button removeFromList;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusSay;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Button saveItem;
    }
}