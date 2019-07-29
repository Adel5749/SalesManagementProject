namespace CanadaSalesManagement1.PL
{
    partial class FrmPreviewImage
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
            this.picProdImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProdImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picProdImage
            // 
            this.picProdImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProdImage.Location = new System.Drawing.Point(0, 0);
            this.picProdImage.Name = "picProdImage";
            this.picProdImage.Size = new System.Drawing.Size(378, 223);
            this.picProdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProdImage.TabIndex = 0;
            this.picProdImage.TabStop = false;
            // 
            // FrmPreviewImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 223);
            this.Controls.Add(this.picProdImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPreviewImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview Product Image";
            ((System.ComponentModel.ISupportInitialize)(this.picProdImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picProdImage;
    }
}