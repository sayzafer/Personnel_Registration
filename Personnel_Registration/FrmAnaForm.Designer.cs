namespace Personnel_Registration
{
    partial class FrmAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PBekar = new System.Windows.Forms.RadioButton();
            this.PEvli = new System.Windows.Forms.RadioButton();
            this.PCity = new System.Windows.Forms.ComboBox();
            this.PSalary = new System.Windows.Forms.TextBox();
            this.PJob = new System.Windows.Forms.TextBox();
            this.PLastName = new System.Windows.Forms.TextBox();
            this.PName = new System.Windows.Forms.TextBox();
            this.PID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGraphic = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelDBDataSet = new Personnel_Registration.PersonnelDBDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonnelTableAdapter = new Personnel_Registration.PersonnelDBDataSetTableAdapters.Tbl_PersonnelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PBekar);
            this.groupBox1.Controls.Add(this.PEvli);
            this.groupBox1.Controls.Add(this.PCity);
            this.groupBox1.Controls.Add(this.PSalary);
            this.groupBox1.Controls.Add(this.PJob);
            this.groupBox1.Controls.Add(this.PLastName);
            this.groupBox1.Controls.Add(this.PName);
            this.groupBox1.Controls.Add(this.PID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // PBekar
            // 
            this.PBekar.AutoSize = true;
            this.PBekar.Location = new System.Drawing.Point(289, 320);
            this.PBekar.Name = "PBekar";
            this.PBekar.Size = new System.Drawing.Size(88, 32);
            this.PBekar.TabIndex = 13;
            this.PBekar.TabStop = true;
            this.PBekar.Text = "Bekar";
            this.PBekar.UseVisualStyleBackColor = true;
            this.PBekar.CheckedChanged += new System.EventHandler(this.PBekar_CheckedChanged);
            // 
            // PEvli
            // 
            this.PEvli.AutoSize = true;
            this.PEvli.Location = new System.Drawing.Point(176, 320);
            this.PEvli.Name = "PEvli";
            this.PEvli.Size = new System.Drawing.Size(67, 32);
            this.PEvli.TabIndex = 12;
            this.PEvli.TabStop = true;
            this.PEvli.Text = "Evli";
            this.PEvli.UseVisualStyleBackColor = true;
            this.PEvli.CheckedChanged += new System.EventHandler(this.PEvli_CheckedChanged);
            // 
            // PCity
            // 
            this.PCity.FormattingEnabled = true;
            this.PCity.Location = new System.Drawing.Point(176, 183);
            this.PCity.Name = "PCity";
            this.PCity.Size = new System.Drawing.Size(201, 36);
            this.PCity.TabIndex = 4;
            // 
            // PSalary
            // 
            this.PSalary.Location = new System.Drawing.Point(176, 267);
            this.PSalary.Name = "PSalary";
            this.PSalary.Size = new System.Drawing.Size(201, 36);
            this.PSalary.TabIndex = 6;
            // 
            // PJob
            // 
            this.PJob.Location = new System.Drawing.Point(176, 225);
            this.PJob.Name = "PJob";
            this.PJob.Size = new System.Drawing.Size(201, 36);
            this.PJob.TabIndex = 5;
            // 
            // PLastName
            // 
            this.PLastName.Location = new System.Drawing.Point(176, 141);
            this.PLastName.Name = "PLastName";
            this.PLastName.Size = new System.Drawing.Size(201, 36);
            this.PLastName.TabIndex = 3;
            // 
            // PName
            // 
            this.PName.Location = new System.Drawing.Point(176, 99);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(201, 36);
            this.PName.TabIndex = 2;
            // 
            // PID
            // 
            this.PID.Location = new System.Drawing.Point(176, 54);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(201, 36);
            this.PID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "Durum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Maaş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Şehir:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Meslek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGraphic);
            this.groupBox2.Controls.Add(this.btnStatistic);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnList);
            this.groupBox2.Location = new System.Drawing.Point(473, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnGraphic
            // 
            this.btnGraphic.Location = new System.Drawing.Point(82, 311);
            this.btnGraphic.Name = "btnGraphic";
            this.btnGraphic.Size = new System.Drawing.Size(201, 36);
            this.btnGraphic.TabIndex = 13;
            this.btnGraphic.Text = "Grafikler";
            this.btnGraphic.UseVisualStyleBackColor = true;
            this.btnGraphic.Click += new System.EventHandler(this.btnGraphic_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(82, 269);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(201, 36);
            this.btnStatistic.TabIndex = 12;
            this.btnStatistic.Text = "İstatistik";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(82, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(201, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(82, 185);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(201, 36);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(82, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(201, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(82, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(201, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(82, 55);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(201, 36);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1036, 266);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pLastNameDataGridViewTextBoxColumn,
            this.pCityDataGridViewTextBoxColumn,
            this.pSalaryDataGridViewTextBoxColumn,
            this.pDurumDataGridViewCheckBoxColumn,
            this.pJobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonnelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "PID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "PID";
            this.pIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "PName";
            this.pNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // pLastNameDataGridViewTextBoxColumn
            // 
            this.pLastNameDataGridViewTextBoxColumn.DataPropertyName = "PLastName";
            this.pLastNameDataGridViewTextBoxColumn.HeaderText = "PLastName";
            this.pLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pLastNameDataGridViewTextBoxColumn.Name = "pLastNameDataGridViewTextBoxColumn";
            this.pLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // pCityDataGridViewTextBoxColumn
            // 
            this.pCityDataGridViewTextBoxColumn.DataPropertyName = "PCity";
            this.pCityDataGridViewTextBoxColumn.HeaderText = "PCity";
            this.pCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pCityDataGridViewTextBoxColumn.Name = "pCityDataGridViewTextBoxColumn";
            this.pCityDataGridViewTextBoxColumn.Width = 125;
            // 
            // pSalaryDataGridViewTextBoxColumn
            // 
            this.pSalaryDataGridViewTextBoxColumn.DataPropertyName = "PSalary";
            this.pSalaryDataGridViewTextBoxColumn.HeaderText = "PSalary";
            this.pSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pSalaryDataGridViewTextBoxColumn.Name = "pSalaryDataGridViewTextBoxColumn";
            this.pSalaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // pDurumDataGridViewCheckBoxColumn
            // 
            this.pDurumDataGridViewCheckBoxColumn.DataPropertyName = "PDurum";
            this.pDurumDataGridViewCheckBoxColumn.HeaderText = "PDurum";
            this.pDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.pDurumDataGridViewCheckBoxColumn.Name = "pDurumDataGridViewCheckBoxColumn";
            this.pDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // pJobDataGridViewTextBoxColumn
            // 
            this.pJobDataGridViewTextBoxColumn.DataPropertyName = "PJob";
            this.pJobDataGridViewTextBoxColumn.HeaderText = "PJob";
            this.pJobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pJobDataGridViewTextBoxColumn.Name = "pJobDataGridViewTextBoxColumn";
            this.pJobDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonnelBindingSource
            // 
            this.tblPersonnelBindingSource.DataMember = "Tbl_Personnel";
            this.tblPersonnelBindingSource.DataSource = this.personnelDBDataSet;
            // 
            // personnelDBDataSet
            // 
            this.personnelDBDataSet.DataSetName = "PersonnelDBDataSet";
            this.personnelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(852, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_PersonnelTableAdapter
            // 
            this.tbl_PersonnelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(902, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1057, 688);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmAnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PBekar;
        private System.Windows.Forms.RadioButton PEvli;
        private System.Windows.Forms.ComboBox PCity;
        private System.Windows.Forms.TextBox PSalary;
        private System.Windows.Forms.TextBox PJob;
        private System.Windows.Forms.TextBox PLastName;
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.TextBox PID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGraphic;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonnelDBDataSet personnelDBDataSet;
        private System.Windows.Forms.BindingSource tblPersonnelBindingSource;
        private PersonnelDBDataSetTableAdapters.Tbl_PersonnelTableAdapter tbl_PersonnelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

