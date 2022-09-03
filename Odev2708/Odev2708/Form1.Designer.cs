namespace Odev2708
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
            this.labelisim = new System.Windows.Forms.Label();
            this.comboBoxisim = new System.Windows.Forms.ComboBox();
            this.labelSoyisim = new System.Windows.Forms.Label();
            this.comboBoxSoyisim = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelisim
            // 
            this.labelisim.AutoSize = true;
            this.labelisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelisim.Location = new System.Drawing.Point(12, 53);
            this.labelisim.Name = "labelisim";
            this.labelisim.Size = new System.Drawing.Size(44, 18);
            this.labelisim.TabIndex = 0;
            this.labelisim.Text = "Isim:";
            // 
            // comboBoxisim
            // 
            this.comboBoxisim.FormattingEnabled = true;
            this.comboBoxisim.Location = new System.Drawing.Point(91, 50);
            this.comboBoxisim.Name = "comboBoxisim";
            this.comboBoxisim.Size = new System.Drawing.Size(121, 21);
            this.comboBoxisim.TabIndex = 1;
            // 
            // labelSoyisim
            // 
            this.labelSoyisim.AutoSize = true;
            this.labelSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyisim.Location = new System.Drawing.Point(12, 94);
            this.labelSoyisim.Name = "labelSoyisim";
            this.labelSoyisim.Size = new System.Drawing.Size(73, 18);
            this.labelSoyisim.TabIndex = 0;
            this.labelSoyisim.Text = "Soyisim:";
            // 
            // comboBoxSoyisim
            // 
            this.comboBoxSoyisim.FormattingEnabled = true;
            this.comboBoxSoyisim.Location = new System.Drawing.Point(91, 91);
            this.comboBoxSoyisim.Name = "comboBoxSoyisim";
            this.comboBoxSoyisim.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSoyisim.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 213);
            this.Controls.Add(this.comboBoxSoyisim);
            this.Controls.Add(this.labelSoyisim);
            this.Controls.Add(this.comboBoxisim);
            this.Controls.Add(this.labelisim);
            this.Name = "Form1";
            this.Text = "Bilgi Formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelisim;
        private System.Windows.Forms.ComboBox comboBoxisim;
        private System.Windows.Forms.Label labelSoyisim;
        private System.Windows.Forms.ComboBox comboBoxSoyisim;
    }
}

