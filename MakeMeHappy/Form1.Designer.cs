namespace MakeMeHappy
{
    partial class Form1
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
            this.opResim = new System.Windows.Forms.OpenFileDialog();
            this.pctResim = new System.Windows.Forms.PictureBox();
            this.cmbSozler = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).BeginInit();
            this.SuspendLayout();
            // 
            // opResim
            // 
            this.opResim.FileName = "openFileDialog1";
            // 
            // pctResim
            // 
            this.pctResim.Location = new System.Drawing.Point(32, 12);
            this.pctResim.Name = "pctResim";
            this.pctResim.Size = new System.Drawing.Size(286, 349);
            this.pctResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctResim.TabIndex = 0;
            this.pctResim.TabStop = false;
            // 
            // cmbSozler
            // 
            this.cmbSozler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSozler.FormattingEnabled = true;
            this.cmbSozler.Location = new System.Drawing.Point(32, 378);
            this.cmbSozler.Name = "cmbSozler";
            this.cmbSozler.Size = new System.Drawing.Size(286, 21);
            this.cmbSozler.TabIndex = 2;
            this.cmbSozler.SelectedIndexChanged += new System.EventHandler(this.cmbSozler_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 430);
            this.Controls.Add(this.cmbSozler);
            this.Controls.Add(this.pctResim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opResim;
        private System.Windows.Forms.PictureBox pctResim;
        private System.Windows.Forms.ComboBox cmbSozler;
    }
}

