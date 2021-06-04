namespace AjengKripto
{
    partial class FormUtama
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNL = new System.Windows.Forms.Label();
            this.textNamaLengkap = new System.Windows.Forms.TextBox();
            this.labelTTL = new System.Windows.Forms.Label();
            this.textTempat = new System.Windows.Forms.TextBox();
            this.dateTimePickerTL = new System.Windows.Forms.DateTimePicker();
            this.labelKelas = new System.Windows.Forms.Label();
            this.textKelas = new System.Windows.Forms.TextBox();
            this.richtextAlamat = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labelJK = new System.Windows.Forms.Label();
            this.rbPria = new System.Windows.Forms.RadioButton();
            this.rbWanita = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(20, 63);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(625, 214);
            this.dg.TabIndex = 0;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(211, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(218, 26);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Cipher Text CRUD";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelNL
            // 
            this.labelNL.AutoSize = true;
            this.labelNL.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNL.Location = new System.Drawing.Point(16, 297);
            this.labelNL.Name = "labelNL";
            this.labelNL.Size = new System.Drawing.Size(107, 23);
            this.labelNL.TabIndex = 62;
            this.labelNL.Text = "Nama Lengkap";
            this.labelNL.Click += new System.EventHandler(this.label3_Click);
            // 
            // textNamaLengkap
            // 
            this.textNamaLengkap.Location = new System.Drawing.Point(178, 298);
            this.textNamaLengkap.Name = "textNamaLengkap";
            this.textNamaLengkap.Size = new System.Drawing.Size(258, 20);
            this.textNamaLengkap.TabIndex = 61;
            // 
            // labelTTL
            // 
            this.labelTTL.AutoSize = true;
            this.labelTTL.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTL.Location = new System.Drawing.Point(16, 336);
            this.labelTTL.Name = "labelTTL";
            this.labelTTL.Size = new System.Drawing.Size(153, 23);
            this.labelTTL.TabIndex = 64;
            this.labelTTL.Text = "Tempat, Tanggal Lahir";
            // 
            // textTempat
            // 
            this.textTempat.Location = new System.Drawing.Point(178, 339);
            this.textTempat.Name = "textTempat";
            this.textTempat.Size = new System.Drawing.Size(121, 20);
            this.textTempat.TabIndex = 63;
            // 
            // dateTimePickerTL
            // 
            this.dateTimePickerTL.Location = new System.Drawing.Point(306, 338);
            this.dateTimePickerTL.Name = "dateTimePickerTL";
            this.dateTimePickerTL.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerTL.TabIndex = 65;
            // 
            // labelKelas
            // 
            this.labelKelas.AutoSize = true;
            this.labelKelas.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKelas.Location = new System.Drawing.Point(16, 410);
            this.labelKelas.Name = "labelKelas";
            this.labelKelas.Size = new System.Drawing.Size(44, 23);
            this.labelKelas.TabIndex = 67;
            this.labelKelas.Text = "Kelas";
            // 
            // textKelas
            // 
            this.textKelas.Location = new System.Drawing.Point(178, 411);
            this.textKelas.Name = "textKelas";
            this.textKelas.Size = new System.Drawing.Size(121, 20);
            this.textKelas.TabIndex = 66;
            // 
            // richtextAlamat
            // 
            this.richtextAlamat.Location = new System.Drawing.Point(178, 449);
            this.richtextAlamat.Name = "richtextAlamat";
            this.richtextAlamat.Size = new System.Drawing.Size(258, 79);
            this.richtextAlamat.TabIndex = 75;
            this.richtextAlamat.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 23);
            this.label10.TabIndex = 74;
            this.label10.Text = "Alamat";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(557, 375);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 76;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(557, 404);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 77;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(557, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 78;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelJK
            // 
            this.labelJK.AutoSize = true;
            this.labelJK.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJK.Location = new System.Drawing.Point(16, 374);
            this.labelJK.Name = "labelJK";
            this.labelJK.Size = new System.Drawing.Size(96, 23);
            this.labelJK.TabIndex = 81;
            this.labelJK.Text = "Jenis Kelamin";
            // 
            // rbPria
            // 
            this.rbPria.AutoSize = true;
            this.rbPria.Location = new System.Drawing.Point(178, 375);
            this.rbPria.Name = "rbPria";
            this.rbPria.Size = new System.Drawing.Size(43, 17);
            this.rbPria.TabIndex = 82;
            this.rbPria.TabStop = true;
            this.rbPria.Text = "Pria";
            this.rbPria.UseVisualStyleBackColor = true;
            this.rbPria.CheckedChanged += new System.EventHandler(this.rbPria_CheckedChanged);
            // 
            // rbWanita
            // 
            this.rbWanita.AutoSize = true;
            this.rbWanita.Location = new System.Drawing.Point(256, 375);
            this.rbWanita.Name = "rbWanita";
            this.rbWanita.Size = new System.Drawing.Size(59, 17);
            this.rbWanita.TabIndex = 83;
            this.rbWanita.TabStop = true;
            this.rbWanita.Text = "Wanita";
            this.rbWanita.UseVisualStyleBackColor = true;
            this.rbWanita.CheckedChanged += new System.EventHandler(this.rbWanita_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(557, 298);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 84;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 547);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.rbWanita);
            this.Controls.Add(this.rbPria);
            this.Controls.Add(this.labelJK);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.richtextAlamat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelKelas);
            this.Controls.Add(this.textKelas);
            this.Controls.Add(this.dateTimePickerTL);
            this.Controls.Add(this.labelTTL);
            this.Controls.Add(this.textTempat);
            this.Controls.Add(this.labelNL);
            this.Controls.Add(this.textNamaLengkap);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dg);
            this.MaximizeBox = false;
            this.Name = "FormUtama";
            this.Text = "AJENG - KRIPTO - Text Chiper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNL;
        private System.Windows.Forms.TextBox textNamaLengkap;
        private System.Windows.Forms.Label labelTTL;
        private System.Windows.Forms.TextBox textTempat;
        private System.Windows.Forms.DateTimePicker dateTimePickerTL;
        private System.Windows.Forms.Label labelKelas;
        private System.Windows.Forms.TextBox textKelas;
        private System.Windows.Forms.RichTextBox richtextAlamat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labelJK;
        private System.Windows.Forms.RadioButton rbPria;
        private System.Windows.Forms.RadioButton rbWanita;
        private System.Windows.Forms.Button btnRefresh;
    }
}

