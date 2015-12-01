namespace ClassifiedDevelopment.Archery
{
    partial class frmArcheryFileCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArcheryFileCreator));
            this.dlgFolderSource = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgFolderDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dlgFolderSource
            // 
            this.dlgFolderSource.Description = "Select Archery source";
            this.dlgFolderSource.ShowNewFolderButton = false;
            // 
            // dlgFolderDestination
            // 
            this.dlgFolderDestination.Description = "Select Archery destination";
            this.dlgFolderDestination.ShowNewFolderButton = false;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(13, 13);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(44, 13);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(16, 29);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(182, 20);
            this.txtSource.TabIndex = 1;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(204, 27);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(30, 23);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "…";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(204, 70);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(30, 23);
            this.btnDestination.TabIndex = 5;
            this.btnDestination.Text = "…";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(16, 72);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(182, 20);
            this.txtDestination.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destination:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(16, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmArcheryFileCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 139);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmArcheryFileCreator";
            this.Text = "Create Archery File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog dlgFolderSource;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderDestination;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}