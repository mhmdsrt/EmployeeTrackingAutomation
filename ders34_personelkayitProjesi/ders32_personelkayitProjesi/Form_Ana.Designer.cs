
namespace ders32_personelkayitProjesi
{
    partial class Form_Ana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ana));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmeslek = new System.Windows.Forms.TextBox();
            this.radiobtnbekar = new System.Windows.Forms.RadioButton();
            this.radiobtnevli = new System.Windows.Forms.RadioButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboboxsehir = new System.Windows.Forms.ComboBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btngrafikler = new System.Windows.Forms.Button();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tablepersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_Veri_TabaniDataSet = new ders32_personelkayitProjesi.Personel_Veri_TabaniDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.table_personelTableAdapter = new ders32_personelkayitProjesi.Personel_Veri_TabaniDataSetTableAdapters.Table_personelTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmeslek);
            this.groupBox1.Controls.Add(this.radiobtnbekar);
            this.groupBox1.Controls.Add(this.radiobtnevli);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.comboboxsehir);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(252, 71);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(163, 34);
            this.txtID.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Personel_ID:";
            // 
            // txtmeslek
            // 
            this.txtmeslek.Location = new System.Drawing.Point(252, 370);
            this.txtmeslek.Name = "txtmeslek";
            this.txtmeslek.Size = new System.Drawing.Size(163, 34);
            this.txtmeslek.TabIndex = 14;
            // 
            // radiobtnbekar
            // 
            this.radiobtnbekar.AutoSize = true;
            this.radiobtnbekar.Location = new System.Drawing.Point(355, 326);
            this.radiobtnbekar.Name = "radiobtnbekar";
            this.radiobtnbekar.Size = new System.Drawing.Size(102, 33);
            this.radiobtnbekar.TabIndex = 13;
            this.radiobtnbekar.TabStop = true;
            this.radiobtnbekar.Text = "Bekar";
            this.radiobtnbekar.UseVisualStyleBackColor = true;
            // 
            // radiobtnevli
            // 
            this.radiobtnevli.AutoSize = true;
            this.radiobtnevli.Location = new System.Drawing.Point(260, 326);
            this.radiobtnevli.Name = "radiobtnevli";
            this.radiobtnevli.Size = new System.Drawing.Size(77, 33);
            this.radiobtnevli.TabIndex = 12;
            this.radiobtnevli.TabStop = true;
            this.radiobtnevli.Text = "Evli";
            this.radiobtnevli.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(252, 273);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(163, 34);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // comboboxsehir
            // 
            this.comboboxsehir.FormattingEnabled = true;
            this.comboboxsehir.Items.AddRange(new object[] {
            "Adana\t",
            "Adıyaman\t",
            "Afyonkarahisar\t",
            "Ağrı\t",
            "Aksaray\t",
            "Amasya\t",
            "Ankara\t",
            "Antalya\t",
            "Ardahan\t",
            "Artvin\t",
            "Aydın\t",
            "Balıkesir\t",
            "Bartın\t",
            "Batman\t",
            "Bayburt\t",
            "Bilecik\t",
            "Bingöl\t",
            "Bitlis\t",
            "Bolu\t",
            "Burdur\t",
            "Bursa\t",
            "Çanakkale\t",
            "Çankırı\t",
            "Çorum\t",
            "Denizli\t",
            "Diyarbakır\t",
            "Düzce\t",
            "Edirne\t",
            "Elazığ\t",
            "Erzincan\t",
            "Erzurum\t",
            "Eskişehir\t",
            "Gaziantep\t",
            "Giresun\t",
            "Gümüşhane\t",
            "Hakkâri\t",
            "Hatay\t",
            "Iğdır\t",
            "Isparta\t",
            "İstanbul\t ",
            "İzmir\t",
            "Kahramanmaraş\t",
            "Karabük\t",
            "Karaman\t",
            "Kars\t",
            "Kastamonu\t",
            "Kayseri\t",
            "Kırıkkale\t",
            "Kırklareli\t",
            "Kırşehir\t",
            "Kilis\t",
            "Kocaeli\t",
            "Konya\t",
            "Kütahya\t",
            "Malatya\t",
            "Manisa\t",
            "Mardin\t",
            "Mersin\t",
            "Muğla\t",
            "Muş\t",
            "Nevşehir\t",
            "Niğde\t",
            "Ordu\t",
            "Osmaniye\t",
            "Rize\t",
            "Sakarya\t",
            "Samsun\t",
            "Siirt\t",
            "Sinop\t",
            "Sivas\t",
            "Şanlıurfa\t",
            "Şırnak\t",
            "Tekirdağ\t",
            "Tokat\t",
            "Trabzon\t",
            "Tunceli\t",
            "Uşak\t",
            "Van\t",
            "Yalova\t",
            "Yozgat\t",
            "Zonguldak\t"});
            this.comboboxsehir.Location = new System.Drawing.Point(252, 223);
            this.comboboxsehir.Name = "comboboxsehir";
            this.comboboxsehir.Size = new System.Drawing.Size(163, 37);
            this.comboboxsehir.TabIndex = 10;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(252, 173);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(163, 34);
            this.txtsoyad.TabIndex = 9;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(252, 124);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(163, 34);
            this.txtad.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Personel Durum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Personel Meslek:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Personel Maaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Personel Şehir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btngrafikler);
            this.groupBox2.Controls.Add(this.btnistatistik);
            this.groupBox2.Controls.Add(this.btntemizle);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(577, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 430);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEMLER";
            // 
            // btngrafikler
            // 
            this.btngrafikler.AutoSize = true;
            this.btngrafikler.Location = new System.Drawing.Point(0, 370);
            this.btngrafikler.Name = "btngrafikler";
            this.btngrafikler.Size = new System.Drawing.Size(195, 50);
            this.btngrafikler.TabIndex = 6;
            this.btngrafikler.Text = "Grafikler";
            this.btngrafikler.UseVisualStyleBackColor = true;
            this.btngrafikler.Click += new System.EventHandler(this.btngrafikler_Click);
            // 
            // btnistatistik
            // 
            this.btnistatistik.AutoSize = true;
            this.btnistatistik.Location = new System.Drawing.Point(0, 314);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(195, 50);
            this.btnistatistik.TabIndex = 5;
            this.btnistatistik.Text = "İstatistik";
            this.btnistatistik.UseVisualStyleBackColor = true;
            this.btnistatistik.Click += new System.EventHandler(this.btnistatistik_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.AutoSize = true;
            this.btntemizle.Location = new System.Drawing.Point(0, 258);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(195, 50);
            this.btntemizle.TabIndex = 4;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.AutoSize = true;
            this.btnguncelle.Location = new System.Drawing.Point(0, 202);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(195, 50);
            this.btnguncelle.TabIndex = 3;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.AutoSize = true;
            this.btnsil.Location = new System.Drawing.Point(0, 146);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(195, 50);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.AutoSize = true;
            this.btnkaydet.Location = new System.Drawing.Point(0, 90);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(195, 50);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(0, 33);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(195, 50);
            this.btnlistele.TabIndex = 0;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(0, 450);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1566, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1560, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tablepersonelBindingSource
            // 
            this.tablepersonelBindingSource.DataMember = "Table_personel";
            this.tablepersonelBindingSource.DataSource = this.personel_Veri_TabaniDataSet;
            // 
            // personel_Veri_TabaniDataSet
            // 
            this.personel_Veri_TabaniDataSet.DataSetName = "Personel_Veri_TabaniDataSet";
            this.personel_Veri_TabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1112, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // table_personelTableAdapter
            // 
            this.table_personelTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1565, 856);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Ana";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablepersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboboxsehir;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.RadioButton radiobtnbekar;
        private System.Windows.Forms.RadioButton radiobtnevli;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txtmeslek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngrafikler;
        private System.Windows.Forms.Button btnistatistik;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Personel_Veri_TabaniDataSet personel_Veri_TabaniDataSet;
        private System.Windows.Forms.BindingSource tablepersonelBindingSource;
        private Personel_Veri_TabaniDataSetTableAdapters.Table_personelTableAdapter table_personelTableAdapter;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

