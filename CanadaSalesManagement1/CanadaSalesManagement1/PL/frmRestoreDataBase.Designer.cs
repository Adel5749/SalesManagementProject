namespace CanadaSalesManagement1.PL
{
    partial class frmRestoreDataBase
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestoreDataBase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileRestore = new System.Windows.Forms.TextBox();
            this.btnBrowseRestoreFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(308, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 39);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRestoreDataBase
            // 
            this.btnRestoreDataBase.Enabled = false;
            this.btnRestoreDataBase.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnRestoreDataBase.Location = new System.Drawing.Point(73, 154);
            this.btnRestoreDataBase.Name = "btnRestoreDataBase";
            this.btnRestoreDataBase.Size = new System.Drawing.Size(196, 39);
            this.btnRestoreDataBase.TabIndex = 7;
            this.btnRestoreDataBase.Text = "Restore Database";
            this.btnRestoreDataBase.UseVisualStyleBackColor = true;
            this.btnRestoreDataBase.Click += new System.EventHandler(this.btnRestoreDataBase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select the file path to restore database:";
            // 
            // txtFileRestore
            // 
            this.txtFileRestore.Location = new System.Drawing.Point(47, 75);
            this.txtFileRestore.Name = "txtFileRestore";
            this.txtFileRestore.ReadOnly = true;
            this.txtFileRestore.Size = new System.Drawing.Size(341, 24);
            this.txtFileRestore.TabIndex = 5;
            // 
            // btnBrowseRestoreFile
            // 
            this.btnBrowseRestoreFile.Location = new System.Drawing.Point(408, 75);
            this.btnBrowseRestoreFile.Name = "btnBrowseRestoreFile";
            this.btnBrowseRestoreFile.Size = new System.Drawing.Size(75, 24);
            this.btnBrowseRestoreFile.TabIndex = 9;
            this.btnBrowseRestoreFile.Text = ". . . ";
            this.btnBrowseRestoreFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseRestoreFile.UseVisualStyleBackColor = true;
            this.btnBrowseRestoreFile.Click += new System.EventHandler(this.btnBrowseRestoreFile_Click);
            // 
            // frmRestoreDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(553, 304);
            this.Controls.Add(this.btnBrowseRestoreFile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestoreDataBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileRestore);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRestoreDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore DataBase Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestoreDataBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileRestore;
        private System.Windows.Forms.Button btnBrowseRestoreFile;
    }
}