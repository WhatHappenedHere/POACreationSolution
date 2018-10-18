namespace TestApp
{
    partial class DocumentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSave = new System.Windows.Forms.Button();
            this.gpM2Type = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbOrderHint = new System.Windows.Forms.Label();
            this.tbOrder = new System.Windows.Forms.TextBox();
            this.lbOrder = new System.Windows.Forms.Label();
            this.lbProviderHint = new System.Windows.Forms.Label();
            this.tbProvider = new System.Windows.Forms.TextBox();
            this.lbProvider = new System.Windows.Forms.Label();
            this.lbPersonsDocumentHint = new System.Windows.Forms.Label();
            this.tbIssuedByOrganization = new System.Windows.Forms.TextBox();
            this.lbIssuedByOrganization = new System.Windows.Forms.Label();
            this.tbPersonDocumentDate = new System.Windows.Forms.TextBox();
            this.lbPersonDocumentDate = new System.Windows.Forms.Label();
            this.tbPersonDocumentNumber = new System.Windows.Forms.TextBox();
            this.lbPersonDocumentNumber = new System.Windows.Forms.Label();
            this.tbSeries = new System.Windows.Forms.TextBox();
            this.lbSeries = new System.Windows.Forms.Label();
            this.lbPersonHint = new System.Windows.Forms.Label();
            this.cbDocumentType = new System.Windows.Forms.ComboBox();
            this.lbDocumentType = new System.Windows.Forms.Label();
            this.tbIssuedByPerson = new System.Windows.Forms.TextBox();
            this.lbIssuedByPerson = new System.Windows.Forms.Label();
            this.dtpDocumentDate = new System.Windows.Forms.DateTimePicker();
            this.lbDocumentDate = new System.Windows.Forms.Label();
            this.tbPayer = new System.Windows.Forms.TextBox();
            this.lbPayer = new System.Windows.Forms.Label();
            this.tbRecipient = new System.Windows.Forms.TextBox();
            this.lbRecipient = new System.Windows.Forms.Label();
            this.tbDocumentNumber = new System.Windows.Forms.TextBox();
            this.lbDocumentNumber = new System.Windows.Forms.Label();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.dtpDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.lbDateOfIssue = new System.Windows.Forms.Label();
            this.btDeleteSelectedRow = new System.Windows.Forms.Button();
            this.pnlTableData = new System.Windows.Forms.Panel();
            this.btFillTable = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbMeasurementUnit = new System.Windows.Forms.TextBox();
            this.lbMeasurementUnit = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbTableDescription = new System.Windows.Forms.Label();
            this.dgvPOAData = new System.Windows.Forms.DataGridView();
            this.columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMeasurementUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialogPOA = new System.Windows.Forms.SaveFileDialog();
            this.gpM2Type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlTableData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOAData)).BeginInit();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Location = new System.Drawing.Point(353, 434);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(168, 22);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Зберегти";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpM2Type
            // 
            this.gpM2Type.Controls.Add(this.splitContainer1);
            this.gpM2Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpM2Type.Location = new System.Drawing.Point(0, 0);
            this.gpM2Type.Name = "gpM2Type";
            this.gpM2Type.Size = new System.Drawing.Size(917, 486);
            this.gpM2Type.TabIndex = 35;
            this.gpM2Type.TabStop = false;
            this.gpM2Type.Text = "Форма № М-2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbOrderHint);
            this.splitContainer1.Panel1.Controls.Add(this.tbOrder);
            this.splitContainer1.Panel1.Controls.Add(this.lbOrder);
            this.splitContainer1.Panel1.Controls.Add(this.lbProviderHint);
            this.splitContainer1.Panel1.Controls.Add(this.tbProvider);
            this.splitContainer1.Panel1.Controls.Add(this.lbProvider);
            this.splitContainer1.Panel1.Controls.Add(this.lbPersonsDocumentHint);
            this.splitContainer1.Panel1.Controls.Add(this.tbIssuedByOrganization);
            this.splitContainer1.Panel1.Controls.Add(this.lbIssuedByOrganization);
            this.splitContainer1.Panel1.Controls.Add(this.tbPersonDocumentDate);
            this.splitContainer1.Panel1.Controls.Add(this.lbPersonDocumentDate);
            this.splitContainer1.Panel1.Controls.Add(this.tbPersonDocumentNumber);
            this.splitContainer1.Panel1.Controls.Add(this.lbPersonDocumentNumber);
            this.splitContainer1.Panel1.Controls.Add(this.tbSeries);
            this.splitContainer1.Panel1.Controls.Add(this.lbSeries);
            this.splitContainer1.Panel1.Controls.Add(this.lbPersonHint);
            this.splitContainer1.Panel1.Controls.Add(this.cbDocumentType);
            this.splitContainer1.Panel1.Controls.Add(this.lbDocumentType);
            this.splitContainer1.Panel1.Controls.Add(this.tbIssuedByPerson);
            this.splitContainer1.Panel1.Controls.Add(this.lbIssuedByPerson);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDocumentDate);
            this.splitContainer1.Panel1.Controls.Add(this.lbDocumentDate);
            this.splitContainer1.Panel1.Controls.Add(this.tbPayer);
            this.splitContainer1.Panel1.Controls.Add(this.lbPayer);
            this.splitContainer1.Panel1.Controls.Add(this.tbRecipient);
            this.splitContainer1.Panel1.Controls.Add(this.lbRecipient);
            this.splitContainer1.Panel1.Controls.Add(this.tbDocumentNumber);
            this.splitContainer1.Panel1.Controls.Add(this.lbDocumentNumber);
            this.splitContainer1.Panel1.Controls.Add(this.dtpExpirationDate);
            this.splitContainer1.Panel1.Controls.Add(this.lbExpirationDate);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDateOfIssue);
            this.splitContainer1.Panel1.Controls.Add(this.lbDateOfIssue);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btDeleteSelectedRow);
            this.splitContainer1.Panel2.Controls.Add(this.pnlTableData);
            this.splitContainer1.Panel2.Controls.Add(this.lbTableDescription);
            this.splitContainer1.Panel2.Controls.Add(this.dgvPOAData);
            this.splitContainer1.Panel2.Controls.Add(this.btSave);
            this.splitContainer1.Size = new System.Drawing.Size(911, 467);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.TabIndex = 69;
            // 
            // lbOrderHint
            // 
            this.lbOrderHint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOrderHint.AutoSize = true;
            this.lbOrderHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOrderHint.Location = new System.Drawing.Point(204, 444);
            this.lbOrderHint.Name = "lbOrderHint";
            this.lbOrderHint.Size = new System.Drawing.Size(85, 13);
            this.lbOrderHint.TabIndex = 98;
            this.lbOrderHint.Text = "№ і дата наряду";
            // 
            // tbOrder
            // 
            this.tbOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrder.Location = new System.Drawing.Point(132, 421);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.Size = new System.Drawing.Size(232, 20);
            this.tbOrder.TabIndex = 97;
            // 
            // lbOrder
            // 
            this.lbOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbOrder.AutoSize = true;
            this.lbOrder.Location = new System.Drawing.Point(30, 424);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(71, 13);
            this.lbOrder.TabIndex = 96;
            this.lbOrder.Text = "цінностей за";
            // 
            // lbProviderHint
            // 
            this.lbProviderHint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProviderHint.AutoSize = true;
            this.lbProviderHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProviderHint.Location = new System.Drawing.Point(204, 396);
            this.lbProviderHint.Name = "lbProviderHint";
            this.lbProviderHint.Size = new System.Drawing.Size(74, 13);
            this.lbProviderHint.TabIndex = 95;
            this.lbProviderHint.Text = "постачальник";
            // 
            // tbProvider
            // 
            this.tbProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProvider.Location = new System.Drawing.Point(132, 373);
            this.tbProvider.Name = "tbProvider";
            this.tbProvider.Size = new System.Drawing.Size(232, 20);
            this.tbProvider.TabIndex = 94;
            // 
            // lbProvider
            // 
            this.lbProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbProvider.AutoSize = true;
            this.lbProvider.Location = new System.Drawing.Point(30, 376);
            this.lbProvider.Name = "lbProvider";
            this.lbProvider.Size = new System.Drawing.Size(96, 13);
            this.lbProvider.TabIndex = 93;
            this.lbProvider.Text = "На отримання від";
            // 
            // lbPersonsDocumentHint
            // 
            this.lbPersonsDocumentHint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPersonsDocumentHint.AutoSize = true;
            this.lbPersonsDocumentHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPersonsDocumentHint.Location = new System.Drawing.Point(151, 348);
            this.lbPersonsDocumentHint.Name = "lbPersonsDocumentHint";
            this.lbPersonsDocumentHint.Size = new System.Drawing.Size(118, 13);
            this.lbPersonsDocumentHint.TabIndex = 92;
            this.lbPersonsDocumentHint.Text = "ким виданий документ";
            // 
            // tbIssuedByOrganization
            // 
            this.tbIssuedByOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIssuedByOrganization.Location = new System.Drawing.Point(86, 325);
            this.tbIssuedByOrganization.Name = "tbIssuedByOrganization";
            this.tbIssuedByOrganization.Size = new System.Drawing.Size(278, 20);
            this.tbIssuedByOrganization.TabIndex = 91;
            // 
            // lbIssuedByOrganization
            // 
            this.lbIssuedByOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbIssuedByOrganization.AutoSize = true;
            this.lbIssuedByOrganization.Location = new System.Drawing.Point(30, 328);
            this.lbIssuedByOrganization.Name = "lbIssuedByOrganization";
            this.lbIssuedByOrganization.Size = new System.Drawing.Size(50, 13);
            this.lbIssuedByOrganization.TabIndex = 90;
            this.lbIssuedByOrganization.Text = "Виданий";
            // 
            // tbPersonDocumentDate
            // 
            this.tbPersonDocumentDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPersonDocumentDate.Location = new System.Drawing.Point(267, 299);
            this.tbPersonDocumentDate.Name = "tbPersonDocumentDate";
            this.tbPersonDocumentDate.Size = new System.Drawing.Size(97, 20);
            this.tbPersonDocumentDate.TabIndex = 89;
            // 
            // lbPersonDocumentDate
            // 
            this.lbPersonDocumentDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPersonDocumentDate.AutoSize = true;
            this.lbPersonDocumentDate.Location = new System.Drawing.Point(240, 302);
            this.lbPersonDocumentDate.Name = "lbPersonDocumentDate";
            this.lbPersonDocumentDate.Size = new System.Drawing.Size(21, 13);
            this.lbPersonDocumentDate.TabIndex = 88;
            this.lbPersonDocumentDate.Text = "від";
            // 
            // tbPersonDocumentNumber
            // 
            this.tbPersonDocumentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPersonDocumentNumber.Location = new System.Drawing.Point(164, 299);
            this.tbPersonDocumentNumber.Name = "tbPersonDocumentNumber";
            this.tbPersonDocumentNumber.Size = new System.Drawing.Size(67, 20);
            this.tbPersonDocumentNumber.TabIndex = 87;
            // 
            // lbPersonDocumentNumber
            // 
            this.lbPersonDocumentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPersonDocumentNumber.AutoSize = true;
            this.lbPersonDocumentNumber.Location = new System.Drawing.Point(123, 302);
            this.lbPersonDocumentNumber.Name = "lbPersonDocumentNumber";
            this.lbPersonDocumentNumber.Size = new System.Drawing.Size(39, 13);
            this.lbPersonDocumentNumber.TabIndex = 86;
            this.lbPersonDocumentNumber.Text = "номер";
            // 
            // tbSeries
            // 
            this.tbSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSeries.Location = new System.Drawing.Point(70, 299);
            this.tbSeries.Name = "tbSeries";
            this.tbSeries.Size = new System.Drawing.Size(47, 20);
            this.tbSeries.TabIndex = 85;
            // 
            // lbSeries
            // 
            this.lbSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSeries.AutoSize = true;
            this.lbSeries.Location = new System.Drawing.Point(29, 302);
            this.lbSeries.Name = "lbSeries";
            this.lbSeries.Size = new System.Drawing.Size(33, 13);
            this.lbSeries.TabIndex = 84;
            this.lbSeries.Text = "серія";
            // 
            // lbPersonHint
            // 
            this.lbPersonHint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPersonHint.AutoSize = true;
            this.lbPersonHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPersonHint.Location = new System.Drawing.Point(195, 242);
            this.lbPersonHint.Name = "lbPersonHint";
            this.lbPersonHint.Size = new System.Drawing.Size(134, 13);
            this.lbPersonHint.TabIndex = 83;
            this.lbPersonHint.Text = "прізвище, ім\'я, по батькові";
            // 
            // cbDocumentType
            // 
            this.cbDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDocumentType.FormattingEnabled = true;
            this.cbDocumentType.Items.AddRange(new object[] {
            "паспорт"});
            this.cbDocumentType.Location = new System.Drawing.Point(218, 272);
            this.cbDocumentType.Name = "cbDocumentType";
            this.cbDocumentType.Size = new System.Drawing.Size(146, 21);
            this.cbDocumentType.TabIndex = 82;
            // 
            // lbDocumentType
            // 
            this.lbDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDocumentType.AutoSize = true;
            this.lbDocumentType.Location = new System.Drawing.Point(30, 275);
            this.lbDocumentType.Name = "lbDocumentType";
            this.lbDocumentType.Size = new System.Drawing.Size(162, 13);
            this.lbDocumentType.TabIndex = 81;
            this.lbDocumentType.Text = "Документ, що засвідчує особу";
            // 
            // tbIssuedByPerson
            // 
            this.tbIssuedByPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIssuedByPerson.Location = new System.Drawing.Point(99, 219);
            this.tbIssuedByPerson.Name = "tbIssuedByPerson";
            this.tbIssuedByPerson.Size = new System.Drawing.Size(265, 20);
            this.tbIssuedByPerson.TabIndex = 80;
            // 
            // lbIssuedByPerson
            // 
            this.lbIssuedByPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbIssuedByPerson.AutoSize = true;
            this.lbIssuedByPerson.Location = new System.Drawing.Point(30, 222);
            this.lbIssuedByPerson.Name = "lbIssuedByPerson";
            this.lbIssuedByPerson.Size = new System.Drawing.Size(44, 13);
            this.lbIssuedByPerson.TabIndex = 79;
            this.lbIssuedByPerson.Text = "Видано";
            // 
            // dtpDocumentDate
            // 
            this.dtpDocumentDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDocumentDate.Location = new System.Drawing.Point(164, 112);
            this.dtpDocumentDate.Name = "dtpDocumentDate";
            this.dtpDocumentDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDocumentDate.TabIndex = 78;
            // 
            // lbDocumentDate
            // 
            this.lbDocumentDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDocumentDate.AutoSize = true;
            this.lbDocumentDate.Location = new System.Drawing.Point(30, 115);
            this.lbDocumentDate.Name = "lbDocumentDate";
            this.lbDocumentDate.Size = new System.Drawing.Size(90, 13);
            this.lbDocumentDate.TabIndex = 77;
            this.lbDocumentDate.Text = "Дата документа";
            // 
            // tbPayer
            // 
            this.tbPayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPayer.Location = new System.Drawing.Point(99, 184);
            this.tbPayer.Name = "tbPayer";
            this.tbPayer.Size = new System.Drawing.Size(265, 20);
            this.tbPayer.TabIndex = 76;
            // 
            // lbPayer
            // 
            this.lbPayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPayer.AutoSize = true;
            this.lbPayer.Location = new System.Drawing.Point(30, 187);
            this.lbPayer.Name = "lbPayer";
            this.lbPayer.Size = new System.Drawing.Size(50, 13);
            this.lbPayer.TabIndex = 75;
            this.lbPayer.Text = "Платник";
            // 
            // tbRecipient
            // 
            this.tbRecipient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecipient.Location = new System.Drawing.Point(99, 149);
            this.tbRecipient.Name = "tbRecipient";
            this.tbRecipient.Size = new System.Drawing.Size(265, 20);
            this.tbRecipient.TabIndex = 74;
            // 
            // lbRecipient
            // 
            this.lbRecipient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRecipient.AutoSize = true;
            this.lbRecipient.Location = new System.Drawing.Point(30, 152);
            this.lbRecipient.Name = "lbRecipient";
            this.lbRecipient.Size = new System.Drawing.Size(63, 13);
            this.lbRecipient.TabIndex = 73;
            this.lbRecipient.Text = "Одержувач";
            // 
            // tbDocumentNumber
            // 
            this.tbDocumentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDocumentNumber.Location = new System.Drawing.Point(164, 76);
            this.tbDocumentNumber.Name = "tbDocumentNumber";
            this.tbDocumentNumber.Size = new System.Drawing.Size(200, 20);
            this.tbDocumentNumber.TabIndex = 72;
            // 
            // lbDocumentNumber
            // 
            this.lbDocumentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDocumentNumber.AutoSize = true;
            this.lbDocumentNumber.Location = new System.Drawing.Point(30, 79);
            this.lbDocumentNumber.Name = "lbDocumentNumber";
            this.lbDocumentNumber.Size = new System.Drawing.Size(75, 13);
            this.lbDocumentNumber.TabIndex = 71;
            this.lbDocumentNumber.Text = "№ документа";
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpirationDate.Location = new System.Drawing.Point(164, 40);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(200, 20);
            this.dtpExpirationDate.TabIndex = 70;
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbExpirationDate.AutoSize = true;
            this.lbExpirationDate.Location = new System.Drawing.Point(30, 43);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(117, 13);
            this.lbExpirationDate.TabIndex = 69;
            this.lbExpirationDate.Text = "Довіреність дійсна до";
            // 
            // dtpDateOfIssue
            // 
            this.dtpDateOfIssue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfIssue.Location = new System.Drawing.Point(164, 3);
            this.dtpDateOfIssue.Name = "dtpDateOfIssue";
            this.dtpDateOfIssue.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfIssue.TabIndex = 68;
            // 
            // lbDateOfIssue
            // 
            this.lbDateOfIssue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDateOfIssue.AutoSize = true;
            this.lbDateOfIssue.Location = new System.Drawing.Point(30, 6);
            this.lbDateOfIssue.Name = "lbDateOfIssue";
            this.lbDateOfIssue.Size = new System.Drawing.Size(67, 13);
            this.lbDateOfIssue.TabIndex = 67;
            this.lbDateOfIssue.Text = "Дата видачі";
            // 
            // btDeleteSelectedRow
            // 
            this.btDeleteSelectedRow.Location = new System.Drawing.Point(17, 376);
            this.btDeleteSelectedRow.Name = "btDeleteSelectedRow";
            this.btDeleteSelectedRow.Size = new System.Drawing.Size(165, 23);
            this.btDeleteSelectedRow.TabIndex = 71;
            this.btDeleteSelectedRow.Text = "Видалити виділений рядок";
            this.btDeleteSelectedRow.UseVisualStyleBackColor = true;
            this.btDeleteSelectedRow.Click += new System.EventHandler(this.btDeleteSelectedRow_Click);
            // 
            // pnlTableData
            // 
            this.pnlTableData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableData.Controls.Add(this.btFillTable);
            this.pnlTableData.Controls.Add(this.tbAmount);
            this.pnlTableData.Controls.Add(this.lbAmount);
            this.pnlTableData.Controls.Add(this.tbMeasurementUnit);
            this.pnlTableData.Controls.Add(this.lbMeasurementUnit);
            this.pnlTableData.Controls.Add(this.tbType);
            this.pnlTableData.Controls.Add(this.lbType);
            this.pnlTableData.Location = new System.Drawing.Point(17, 40);
            this.pnlTableData.Name = "pnlTableData";
            this.pnlTableData.Size = new System.Drawing.Size(492, 116);
            this.pnlTableData.TabIndex = 70;
            // 
            // btFillTable
            // 
            this.btFillTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFillTable.Location = new System.Drawing.Point(394, 43);
            this.btFillTable.Name = "btFillTable";
            this.btFillTable.Size = new System.Drawing.Size(95, 23);
            this.btFillTable.TabIndex = 87;
            this.btFillTable.Text = "Додати";
            this.btFillTable.UseVisualStyleBackColor = true;
            this.btFillTable.Click += new System.EventHandler(this.btFillTable_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmount.Location = new System.Drawing.Point(190, 81);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(198, 20);
            this.tbAmount.TabIndex = 86;
            // 
            // lbAmount
            // 
            this.lbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(14, 84);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(115, 13);
            this.lbAmount.TabIndex = 85;
            this.lbAmount.Text = "Кількість (прописом):";
            // 
            // tbMeasurementUnit
            // 
            this.tbMeasurementUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMeasurementUnit.Location = new System.Drawing.Point(190, 45);
            this.tbMeasurementUnit.Name = "tbMeasurementUnit";
            this.tbMeasurementUnit.Size = new System.Drawing.Size(198, 20);
            this.tbMeasurementUnit.TabIndex = 84;
            // 
            // lbMeasurementUnit
            // 
            this.lbMeasurementUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMeasurementUnit.AutoSize = true;
            this.lbMeasurementUnit.Location = new System.Drawing.Point(14, 48);
            this.lbMeasurementUnit.Name = "lbMeasurementUnit";
            this.lbMeasurementUnit.Size = new System.Drawing.Size(90, 13);
            this.lbMeasurementUnit.TabIndex = 83;
            this.lbMeasurementUnit.Text = "Одиниця виміру:";
            // 
            // tbType
            // 
            this.tbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbType.Location = new System.Drawing.Point(190, 9);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(198, 20);
            this.tbType.TabIndex = 82;
            // 
            // lbType
            // 
            this.lbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(14, 12);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(137, 13);
            this.lbType.TabIndex = 81;
            this.lbType.Text = "Найменування цінностей:";
            // 
            // lbTableDescription
            // 
            this.lbTableDescription.AutoSize = true;
            this.lbTableDescription.Location = new System.Drawing.Point(14, 6);
            this.lbTableDescription.Name = "lbTableDescription";
            this.lbTableDescription.Size = new System.Drawing.Size(225, 13);
            this.lbTableDescription.TabIndex = 69;
            this.lbTableDescription.Text = "Перелік цінностей, які належить отримати:";
            // 
            // dgvPOAData
            // 
            this.dgvPOAData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPOAData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOAData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNumber,
            this.columnType,
            this.columnMeasurementUnit,
            this.columnAmount});
            this.dgvPOAData.Location = new System.Drawing.Point(3, 187);
            this.dgvPOAData.Name = "dgvPOAData";
            this.dgvPOAData.Size = new System.Drawing.Size(518, 179);
            this.dgvPOAData.TabIndex = 68;
            // 
            // columnNumber
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.columnNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.columnNumber.HeaderText = "№п/п";
            this.columnNumber.Name = "columnNumber";
            this.columnNumber.ReadOnly = true;
            // 
            // columnType
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnType.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnType.HeaderText = "Найменування цінностей";
            this.columnType.Name = "columnType";
            this.columnType.ReadOnly = true;
            // 
            // columnMeasurementUnit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnMeasurementUnit.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnMeasurementUnit.HeaderText = "Одиниця виміру";
            this.columnMeasurementUnit.Name = "columnMeasurementUnit";
            this.columnMeasurementUnit.ReadOnly = true;
            // 
            // columnAmount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.columnAmount.HeaderText = "Кількість (прописом)";
            this.columnAmount.Name = "columnAmount";
            this.columnAmount.ReadOnly = true;
            // 
            // saveFileDialogPOA
            // 
            this.saveFileDialogPOA.FileName = "new_poa";
            // 
            // DocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 486);
            this.Controls.Add(this.gpM2Type);
            this.Name = "DocumentForm";
            this.Text = "Power of attorney";
            this.gpM2Type.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlTableData.ResumeLayout(false);
            this.pnlTableData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOAData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.GroupBox gpM2Type;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPOA;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbOrderHint;
        private System.Windows.Forms.TextBox tbOrder;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Label lbProviderHint;
        private System.Windows.Forms.TextBox tbProvider;
        private System.Windows.Forms.Label lbProvider;
        private System.Windows.Forms.Label lbPersonsDocumentHint;
        private System.Windows.Forms.TextBox tbIssuedByOrganization;
        private System.Windows.Forms.Label lbIssuedByOrganization;
        private System.Windows.Forms.TextBox tbPersonDocumentDate;
        private System.Windows.Forms.Label lbPersonDocumentDate;
        private System.Windows.Forms.TextBox tbPersonDocumentNumber;
        private System.Windows.Forms.Label lbPersonDocumentNumber;
        private System.Windows.Forms.TextBox tbSeries;
        private System.Windows.Forms.Label lbSeries;
        private System.Windows.Forms.Label lbPersonHint;
        private System.Windows.Forms.ComboBox cbDocumentType;
        private System.Windows.Forms.Label lbDocumentType;
        private System.Windows.Forms.TextBox tbIssuedByPerson;
        private System.Windows.Forms.Label lbIssuedByPerson;
        private System.Windows.Forms.DateTimePicker dtpDocumentDate;
        private System.Windows.Forms.Label lbDocumentDate;
        private System.Windows.Forms.TextBox tbPayer;
        private System.Windows.Forms.Label lbPayer;
        private System.Windows.Forms.TextBox tbRecipient;
        private System.Windows.Forms.Label lbRecipient;
        private System.Windows.Forms.TextBox tbDocumentNumber;
        private System.Windows.Forms.Label lbDocumentNumber;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.DateTimePicker dtpDateOfIssue;
        private System.Windows.Forms.Label lbDateOfIssue;
        private System.Windows.Forms.Label lbTableDescription;
        private System.Windows.Forms.DataGridView dgvPOAData;
        private System.Windows.Forms.Panel pnlTableData;
        private System.Windows.Forms.Button btFillTable;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox tbMeasurementUnit;
        private System.Windows.Forms.Label lbMeasurementUnit;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMeasurementUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAmount;
        private System.Windows.Forms.Button btDeleteSelectedRow;
    }
}