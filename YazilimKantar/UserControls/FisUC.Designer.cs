namespace YazilimKantar.UserControls
{
    partial class FisUC
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FisUC));
            this.pnlDVeri = new System.Windows.Forms.Panel();
            this.pnlRapor = new System.Windows.Forms.Panel();
            this.pnlRaporUst = new System.Windows.Forms.Panel();
            this.tcBrut = new System.Windows.Forms.TabControl();
            this.tpDaraData = new System.Windows.Forms.TabPage();
            this.dgwBrut = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tartimNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giFirmAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gitilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tartimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazilimKantarDataSet = new YazilimKantar.YazilimKantarDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.YonTus = new System.Windows.Forms.ImageList(this.components);
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnElmnBir = new System.Windows.Forms.Button();
            this.btnGunceleme = new System.Windows.Forms.Button();
            this.btnElmnSon = new System.Windows.Forms.Button();
            this.btnSonrakiElmn = new System.Windows.Forms.Button();
            this.btnOncekiElmn = new System.Windows.Forms.Button();
            this.btnArama = new System.Windows.Forms.Button();
            this.cBxGrs = new System.Windows.Forms.ComboBox();
            this.brutTableAdapter = new YazilimKantar.YazilimKantarDataSetTableAdapters.BrutTableAdapter();
            this.pnlDVeri.SuspendLayout();
            this.pnlRapor.SuspendLayout();
            this.tcBrut.SuspendLayout();
            this.tpDaraData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimKantarDataSet)).BeginInit();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDVeri
            // 
            this.pnlDVeri.Controls.Add(this.pnlRapor);
            this.pnlDVeri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDVeri.Location = new System.Drawing.Point(0, 110);
            this.pnlDVeri.Name = "pnlDVeri";
            this.pnlDVeri.Size = new System.Drawing.Size(980, 520);
            this.pnlDVeri.TabIndex = 28;
            // 
            // pnlRapor
            // 
            this.pnlRapor.Controls.Add(this.pnlRaporUst);
            this.pnlRapor.Controls.Add(this.tcBrut);
            this.pnlRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRapor.Location = new System.Drawing.Point(0, 0);
            this.pnlRapor.Name = "pnlRapor";
            this.pnlRapor.Size = new System.Drawing.Size(980, 520);
            this.pnlRapor.TabIndex = 103;
            // 
            // pnlRaporUst
            // 
            this.pnlRaporUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.pnlRaporUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRaporUst.Location = new System.Drawing.Point(0, 0);
            this.pnlRaporUst.Name = "pnlRaporUst";
            this.pnlRaporUst.Size = new System.Drawing.Size(980, 20);
            this.pnlRaporUst.TabIndex = 103;
            // 
            // tcBrut
            // 
            this.tcBrut.Controls.Add(this.tpDaraData);
            this.tcBrut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBrut.Location = new System.Drawing.Point(0, 0);
            this.tcBrut.Name = "tcBrut";
            this.tcBrut.SelectedIndex = 0;
            this.tcBrut.Size = new System.Drawing.Size(980, 520);
            this.tcBrut.TabIndex = 103;
            // 
            // tpDaraData
            // 
            this.tpDaraData.BackColor = System.Drawing.Color.Firebrick;
            this.tpDaraData.Controls.Add(this.dgwBrut);
            this.tpDaraData.Location = new System.Drawing.Point(4, 22);
            this.tpDaraData.Name = "tpDaraData";
            this.tpDaraData.Padding = new System.Windows.Forms.Padding(3);
            this.tpDaraData.Size = new System.Drawing.Size(972, 494);
            this.tpDaraData.TabIndex = 0;
            // 
            // dgwBrut
            // 
            this.dgwBrut.AutoGenerateColumns = false;
            this.dgwBrut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBrut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.tartimNoDataGridViewTextBoxColumn,
            this.plakaNoDataGridViewTextBoxColumn,
            this.giTarihDataGridViewTextBoxColumn,
            this.ciTarihDataGridViewTextBoxColumn,
            this.giSaatDataGridViewTextBoxColumn,
            this.ciSaatDataGridViewTextBoxColumn,
            this.firmAdiDataGridViewTextBoxColumn,
            this.giFirmAdiDataGridViewTextBoxColumn,
            this.malzemeDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.gelilDataGridViewTextBoxColumn,
            this.gitilDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.tartimDataGridViewTextBoxColumn,
            this.brutDataGridViewTextBoxColumn,
            this.kgDataGridViewTextBoxColumn});
            this.dgwBrut.DataSource = this.brutBindingSource;
            this.dgwBrut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwBrut.Location = new System.Drawing.Point(3, 3);
            this.dgwBrut.Name = "dgwBrut";
            this.dgwBrut.Size = new System.Drawing.Size(966, 488);
            this.dgwBrut.TabIndex = 0;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tartimNoDataGridViewTextBoxColumn
            // 
            this.tartimNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tartimNoDataGridViewTextBoxColumn.DataPropertyName = "TartimNo";
            this.tartimNoDataGridViewTextBoxColumn.HeaderText = "TartimNo";
            this.tartimNoDataGridViewTextBoxColumn.Name = "tartimNoDataGridViewTextBoxColumn";
            // 
            // plakaNoDataGridViewTextBoxColumn
            // 
            this.plakaNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plakaNoDataGridViewTextBoxColumn.DataPropertyName = "PlakaNo";
            this.plakaNoDataGridViewTextBoxColumn.HeaderText = "PlakaNo";
            this.plakaNoDataGridViewTextBoxColumn.Name = "plakaNoDataGridViewTextBoxColumn";
            // 
            // giTarihDataGridViewTextBoxColumn
            // 
            this.giTarihDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giTarihDataGridViewTextBoxColumn.DataPropertyName = "GiTarih";
            this.giTarihDataGridViewTextBoxColumn.HeaderText = "GiTarih";
            this.giTarihDataGridViewTextBoxColumn.Name = "giTarihDataGridViewTextBoxColumn";
            // 
            // ciTarihDataGridViewTextBoxColumn
            // 
            this.ciTarihDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ciTarihDataGridViewTextBoxColumn.DataPropertyName = "CiTarih";
            this.ciTarihDataGridViewTextBoxColumn.HeaderText = "CiTarih";
            this.ciTarihDataGridViewTextBoxColumn.Name = "ciTarihDataGridViewTextBoxColumn";
            // 
            // giSaatDataGridViewTextBoxColumn
            // 
            this.giSaatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giSaatDataGridViewTextBoxColumn.DataPropertyName = "GiSaat";
            this.giSaatDataGridViewTextBoxColumn.HeaderText = "GiSaat";
            this.giSaatDataGridViewTextBoxColumn.Name = "giSaatDataGridViewTextBoxColumn";
            // 
            // ciSaatDataGridViewTextBoxColumn
            // 
            this.ciSaatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ciSaatDataGridViewTextBoxColumn.DataPropertyName = "CiSaat";
            this.ciSaatDataGridViewTextBoxColumn.HeaderText = "CiSaat";
            this.ciSaatDataGridViewTextBoxColumn.Name = "ciSaatDataGridViewTextBoxColumn";
            // 
            // firmAdiDataGridViewTextBoxColumn
            // 
            this.firmAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firmAdiDataGridViewTextBoxColumn.DataPropertyName = "FirmAdi";
            this.firmAdiDataGridViewTextBoxColumn.HeaderText = "FirmAdi";
            this.firmAdiDataGridViewTextBoxColumn.Name = "firmAdiDataGridViewTextBoxColumn";
            // 
            // giFirmAdiDataGridViewTextBoxColumn
            // 
            this.giFirmAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giFirmAdiDataGridViewTextBoxColumn.DataPropertyName = "GiFirmAdi";
            this.giFirmAdiDataGridViewTextBoxColumn.HeaderText = "GiFirmAdi";
            this.giFirmAdiDataGridViewTextBoxColumn.Name = "giFirmAdiDataGridViewTextBoxColumn";
            // 
            // malzemeDataGridViewTextBoxColumn
            // 
            this.malzemeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.malzemeDataGridViewTextBoxColumn.DataPropertyName = "Malzeme";
            this.malzemeDataGridViewTextBoxColumn.HeaderText = "Malzeme";
            this.malzemeDataGridViewTextBoxColumn.Name = "malzemeDataGridViewTextBoxColumn";
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "Operator";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            // 
            // gelilDataGridViewTextBoxColumn
            // 
            this.gelilDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gelilDataGridViewTextBoxColumn.DataPropertyName = "Gelil";
            this.gelilDataGridViewTextBoxColumn.HeaderText = "Gelil";
            this.gelilDataGridViewTextBoxColumn.Name = "gelilDataGridViewTextBoxColumn";
            // 
            // gitilDataGridViewTextBoxColumn
            // 
            this.gitilDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gitilDataGridViewTextBoxColumn.DataPropertyName = "Gitil";
            this.gitilDataGridViewTextBoxColumn.HeaderText = "Gitil";
            this.gitilDataGridViewTextBoxColumn.Name = "gitilDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // tartimDataGridViewTextBoxColumn
            // 
            this.tartimDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tartimDataGridViewTextBoxColumn.DataPropertyName = "Tartim";
            this.tartimDataGridViewTextBoxColumn.HeaderText = "Tartim";
            this.tartimDataGridViewTextBoxColumn.Name = "tartimDataGridViewTextBoxColumn";
            // 
            // brutDataGridViewTextBoxColumn
            // 
            this.brutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brutDataGridViewTextBoxColumn.DataPropertyName = "Brut";
            this.brutDataGridViewTextBoxColumn.HeaderText = "Brut";
            this.brutDataGridViewTextBoxColumn.Name = "brutDataGridViewTextBoxColumn";
            // 
            // kgDataGridViewTextBoxColumn
            // 
            this.kgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kgDataGridViewTextBoxColumn.DataPropertyName = "Kg";
            this.kgDataGridViewTextBoxColumn.HeaderText = "Kg";
            this.kgDataGridViewTextBoxColumn.Name = "kgDataGridViewTextBoxColumn";
            // 
            // brutBindingSource
            // 
            this.brutBindingSource.DataMember = "Brut";
            this.brutBindingSource.DataSource = this.yazilimKantarDataSet;
            // 
            // yazilimKantarDataSet
            // 
            this.yazilimKantarDataSet.DataSetName = "YazilimKantarDataSet";
            this.yazilimKantarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(145, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Plaka No  :";
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.Honeydew;
            this.pnlUst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUst.Controls.Add(this.pictureBox1);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(980, 55);
            this.pnlUst.TabIndex = 105;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(334, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // YonTus
            // 
            this.YonTus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("YonTus.ImageStream")));
            this.YonTus.TransparentColor = System.Drawing.Color.Transparent;
            this.YonTus.Images.SetKeyName(0, "fast-forward.png");
            this.YonTus.Images.SetKeyName(1, "fast-forward-sonraki.png");
            this.YonTus.Images.SetKeyName(2, "play-button.png");
            this.YonTus.Images.SetKeyName(3, "play-button-sonraki.png");
            this.YonTus.Images.SetKeyName(4, "repeat.png");
            this.YonTus.Images.SetKeyName(5, "chat.png");
            this.YonTus.Images.SetKeyName(6, "magnifying-glass.png");
            // 
            // btnRapor
            // 
            this.btnRapor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRapor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRapor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRapor.FlatAppearance.BorderSize = 2;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRapor.ImageIndex = 5;
            this.btnRapor.ImageList = this.YonTus;
            this.btnRapor.Location = new System.Drawing.Point(424, 65);
            this.btnRapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(40, 40);
            this.btnRapor.TabIndex = 111;
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnElmnBir
            // 
            this.btnElmnBir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElmnBir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnElmnBir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElmnBir.FlatAppearance.BorderSize = 2;
            this.btnElmnBir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElmnBir.ImageIndex = 0;
            this.btnElmnBir.ImageList = this.YonTus;
            this.btnElmnBir.Location = new System.Drawing.Point(483, 65);
            this.btnElmnBir.Margin = new System.Windows.Forms.Padding(2);
            this.btnElmnBir.Name = "btnElmnBir";
            this.btnElmnBir.Size = new System.Drawing.Size(40, 40);
            this.btnElmnBir.TabIndex = 106;
            this.btnElmnBir.UseVisualStyleBackColor = false;
            // 
            // btnGunceleme
            // 
            this.btnGunceleme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGunceleme.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGunceleme.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGunceleme.FlatAppearance.BorderSize = 2;
            this.btnGunceleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGunceleme.ImageIndex = 4;
            this.btnGunceleme.ImageList = this.YonTus;
            this.btnGunceleme.Location = new System.Drawing.Point(609, 64);
            this.btnGunceleme.Margin = new System.Windows.Forms.Padding(2);
            this.btnGunceleme.Name = "btnGunceleme";
            this.btnGunceleme.Size = new System.Drawing.Size(40, 40);
            this.btnGunceleme.TabIndex = 110;
            this.btnGunceleme.UseVisualStyleBackColor = false;
            // 
            // btnElmnSon
            // 
            this.btnElmnSon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElmnSon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnElmnSon.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElmnSon.FlatAppearance.BorderSize = 2;
            this.btnElmnSon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElmnSon.ImageIndex = 1;
            this.btnElmnSon.ImageList = this.YonTus;
            this.btnElmnSon.Location = new System.Drawing.Point(738, 64);
            this.btnElmnSon.Margin = new System.Windows.Forms.Padding(2);
            this.btnElmnSon.Name = "btnElmnSon";
            this.btnElmnSon.Size = new System.Drawing.Size(40, 40);
            this.btnElmnSon.TabIndex = 109;
            this.btnElmnSon.UseVisualStyleBackColor = false;
            // 
            // btnSonrakiElmn
            // 
            this.btnSonrakiElmn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSonrakiElmn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSonrakiElmn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSonrakiElmn.FlatAppearance.BorderSize = 2;
            this.btnSonrakiElmn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSonrakiElmn.ImageIndex = 3;
            this.btnSonrakiElmn.ImageList = this.YonTus;
            this.btnSonrakiElmn.Location = new System.Drawing.Point(675, 64);
            this.btnSonrakiElmn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonrakiElmn.Name = "btnSonrakiElmn";
            this.btnSonrakiElmn.Size = new System.Drawing.Size(40, 40);
            this.btnSonrakiElmn.TabIndex = 108;
            this.btnSonrakiElmn.UseVisualStyleBackColor = false;
            // 
            // btnOncekiElmn
            // 
            this.btnOncekiElmn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOncekiElmn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOncekiElmn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOncekiElmn.FlatAppearance.BorderSize = 2;
            this.btnOncekiElmn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOncekiElmn.ImageIndex = 2;
            this.btnOncekiElmn.ImageList = this.YonTus;
            this.btnOncekiElmn.Location = new System.Drawing.Point(546, 65);
            this.btnOncekiElmn.Margin = new System.Windows.Forms.Padding(2);
            this.btnOncekiElmn.Name = "btnOncekiElmn";
            this.btnOncekiElmn.Size = new System.Drawing.Size(40, 40);
            this.btnOncekiElmn.TabIndex = 107;
            this.btnOncekiElmn.UseVisualStyleBackColor = false;
            // 
            // btnArama
            // 
            this.btnArama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArama.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnArama.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArama.FlatAppearance.BorderSize = 2;
            this.btnArama.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArama.ImageIndex = 6;
            this.btnArama.ImageList = this.YonTus;
            this.btnArama.Location = new System.Drawing.Point(366, 65);
            this.btnArama.Margin = new System.Windows.Forms.Padding(2);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(40, 40);
            this.btnArama.TabIndex = 112;
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // cBxGrs
            // 
            this.cBxGrs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBxGrs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBxGrs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBxGrs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBxGrs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBxGrs.FormattingEnabled = true;
            this.cBxGrs.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cBxGrs.Location = new System.Drawing.Point(231, 71);
            this.cBxGrs.Name = "cBxGrs";
            this.cBxGrs.Size = new System.Drawing.Size(119, 27);
            this.cBxGrs.TabIndex = 113;
            // 
            // brutTableAdapter
            // 
            this.brutTableAdapter.ClearBeforeFill = true;
            // 
            // FisUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.cBxGrs);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnElmnBir);
            this.Controls.Add(this.btnGunceleme);
            this.Controls.Add(this.btnElmnSon);
            this.Controls.Add(this.btnSonrakiElmn);
            this.Controls.Add(this.btnOncekiElmn);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDVeri);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "FisUC";
            this.Size = new System.Drawing.Size(980, 630);
            this.pnlDVeri.ResumeLayout(false);
            this.pnlRapor.ResumeLayout(false);
            this.tcBrut.ResumeLayout(false);
            this.tpDaraData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimKantarDataSet)).EndInit();
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDVeri;
        private System.Windows.Forms.Panel pnlRapor;
        private System.Windows.Forms.Panel pnlRaporUst;
        private System.Windows.Forms.TabControl tcBrut;
        private System.Windows.Forms.TabPage tpDaraData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList YonTus;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnElmnBir;
        private System.Windows.Forms.Button btnGunceleme;
        private System.Windows.Forms.Button btnElmnSon;
        private System.Windows.Forms.Button btnSonrakiElmn;
        private System.Windows.Forms.Button btnOncekiElmn;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.DataGridView dgwBrut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tartimNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giFirmAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gitilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tartimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource brutBindingSource;
        private YazilimKantarDataSet yazilimKantarDataSet;
        private System.Windows.Forms.ComboBox cBxGrs;
        private YazilimKantarDataSetTableAdapters.BrutTableAdapter brutTableAdapter;
    }
}
