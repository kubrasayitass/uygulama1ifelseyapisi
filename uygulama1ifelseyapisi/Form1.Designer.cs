namespace uygulama1ifelseyapisi
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
            this.btnTıkla = new System.Windows.Forms.Button();
            this.lblYaz = new System.Windows.Forms.Label();
            this.cbMavi = new System.Windows.Forms.RadioButton();
            this.cbSari = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnTıkla
            // 
            this.btnTıkla.Location = new System.Drawing.Point(12, 67);
            this.btnTıkla.Name = "btnTıkla";
            this.btnTıkla.Size = new System.Drawing.Size(75, 23);
            this.btnTıkla.TabIndex = 0;
            this.btnTıkla.Text = "tıkla";
            this.btnTıkla.UseVisualStyleBackColor = true;
            this.btnTıkla.Click += new System.EventHandler(this.btnTıkla_Click);
            // 
            // lblYaz
            // 
            this.lblYaz.AutoSize = true;
            this.lblYaz.Location = new System.Drawing.Point(12, 105);
            this.lblYaz.Name = "lblYaz";
            this.lblYaz.Size = new System.Drawing.Size(25, 13);
            this.lblYaz.TabIndex = 1;
            this.lblYaz.Text = "Yaz";
            // 
            // cbMavi
            // 
            this.cbMavi.AutoSize = true;
            this.cbMavi.Location = new System.Drawing.Point(12, 139);
            this.cbMavi.Name = "cbMavi";
            this.cbMavi.Size = new System.Drawing.Size(47, 17);
            this.cbMavi.TabIndex = 2;
            this.cbMavi.TabStop = true;
            this.cbMavi.Text = "mavi";
            this.cbMavi.UseVisualStyleBackColor = true;
            // 
            // cbSari
            // 
            this.cbSari.AutoSize = true;
            this.cbSari.Location = new System.Drawing.Point(12, 174);
            this.cbSari.Name = "cbSari";
            this.cbSari.Size = new System.Drawing.Size(41, 17);
            this.cbSari.TabIndex = 3;
            this.cbSari.TabStop = true;
            this.cbSari.Text = "sarı";
            this.cbSari.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSari);
            this.Controls.Add(this.cbMavi);
            this.Controls.Add(this.lblYaz);
            this.Controls.Add(this.btnTıkla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTıkla;
        private System.Windows.Forms.Label lblYaz;
        private System.Windows.Forms.RadioButton cbMavi;
        private System.Windows.Forms.RadioButton cbSari;
    }
}

