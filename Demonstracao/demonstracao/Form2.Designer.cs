namespace demonstracao
{
    partial class Form2
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
            this.btnDesligaLED = new System.Windows.Forms.Button();
            this.btnLigaLED = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDesligaLED
            // 
            this.btnDesligaLED.Location = new System.Drawing.Point(166, -1);
            this.btnDesligaLED.Name = "btnDesligaLED";
            this.btnDesligaLED.Size = new System.Drawing.Size(161, 72);
            this.btnDesligaLED.TabIndex = 0;
            this.btnDesligaLED.Text = "Desligar";
            this.btnDesligaLED.UseVisualStyleBackColor = true;
            this.btnDesligaLED.Click += new System.EventHandler(this.btnDesligaLED_Click);
            // 
            // btnLigaLED
            // 
            this.btnLigaLED.Location = new System.Drawing.Point(-1, -1);
            this.btnLigaLED.Name = "btnLigaLED";
            this.btnLigaLED.Size = new System.Drawing.Size(161, 72);
            this.btnLigaLED.TabIndex = 1;
            this.btnLigaLED.Text = "Ligar";
            this.btnLigaLED.UseVisualStyleBackColor = true;
            this.btnLigaLED.Click += new System.EventHandler(this.btnLigaLED_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 68);
            this.Controls.Add(this.btnLigaLED);
            this.Controls.Add(this.btnDesligaLED);
            this.Name = "Form2";
            this.Text = "Comando";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDesligaLED;
        private System.Windows.Forms.Button btnLigaLED;
    }
}