namespace AjengKripto
{
    partial class SettingForm
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
            this.labelNL = new System.Windows.Forms.Label();
            this.numericKey = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericKey)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNL
            // 
            this.labelNL.AutoSize = true;
            this.labelNL.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNL.Location = new System.Drawing.Point(12, 26);
            this.labelNL.Name = "labelNL";
            this.labelNL.Size = new System.Drawing.Size(79, 23);
            this.labelNL.TabIndex = 63;
            this.labelNL.Text = "Nilai Kunci :";
            // 
            // numericKey
            // 
            this.numericKey.Location = new System.Drawing.Point(97, 28);
            this.numericKey.Name = "numericKey";
            this.numericKey.Size = new System.Drawing.Size(120, 20);
            this.numericKey.TabIndex = 64;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 109);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericKey);
            this.Controls.Add(this.labelNL);
            this.Name = "SettingForm";
            this.Text = "Setting Kunci Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.numericKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNL;
        private System.Windows.Forms.NumericUpDown numericKey;
        private System.Windows.Forms.Button button1;
    }
}