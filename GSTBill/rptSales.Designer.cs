namespace GSTBill
{
    partial class rptSales
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.ddlFirm = new System.Windows.Forms.ComboBox();
            this.listAllFirmSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListAllFirmSelect = new GSTBill.DatasetList.dsListAllFirmSelect();
            this.label9 = new System.Windows.Forms.Label();
            this.ddlParty = new System.Windows.Forms.ComboBox();
            this.listAllPartySelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListAllPartySelect = new GSTBill.DatasetList.dsListAllPartySelect();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.rptSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRptSales = new GSTBill.DatasetList.dsRptSales();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtGrossTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalGST = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.listAllFirmSelectTableAdapter = new GSTBill.DatasetList.dsListAllFirmSelectTableAdapters.ListAllFirmSelectTableAdapter();
            this.listAllPartySelectTableAdapter = new GSTBill.DatasetList.dsListAllPartySelectTableAdapters.ListAllPartySelectTableAdapter();
            this.rptSalesTableAdapter = new GSTBill.DatasetList.dsRptSalesTableAdapters.rptSalesTableAdapter();
            this.firmNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSTINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSTPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGSTPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGSTPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCSPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.challanNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.challanDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brokerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delMobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplyPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAllFirmSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListAllFirmSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllPartySelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListAllPartySelect)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRptSales)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dtpToDate);
            this.panel3.Controls.Add(this.dtpFromDate);
            this.panel3.Controls.Add(this.btnReport);
            this.panel3.Controls.Add(this.ddlFirm);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.ddlParty);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtInvoiceNo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1199, 122);
            this.panel3.TabIndex = 26;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(774, 65);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(223, 30);
            this.dtpToDate.TabIndex = 107;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(442, 65);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(224, 30);
            this.dtpFromDate.TabIndex = 106;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnReport.BackgroundImage = global::GSTBill.Properties.Resources.search;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Gray;
            this.btnReport.Location = new System.Drawing.Point(1054, 12);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(110, 88);
            this.btnReport.TabIndex = 30;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // ddlFirm
            // 
            this.ddlFirm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlFirm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlFirm.DataSource = this.listAllFirmSelectBindingSource;
            this.ddlFirm.DisplayMember = "FirmName";
            this.ddlFirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlFirm.FormattingEnabled = true;
            this.ddlFirm.Location = new System.Drawing.Point(442, 15);
            this.ddlFirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlFirm.Name = "ddlFirm";
            this.ddlFirm.Size = new System.Drawing.Size(223, 30);
            this.ddlFirm.TabIndex = 86;
            this.ddlFirm.ValueMember = "FirmID";
            // 
            // listAllFirmSelectBindingSource
            // 
            this.listAllFirmSelectBindingSource.DataMember = "ListAllFirmSelect";
            this.listAllFirmSelectBindingSource.DataSource = this.dsListAllFirmSelect;
            // 
            // dsListAllFirmSelect
            // 
            this.dsListAllFirmSelect.DataSetName = "dsListAllFirmSelect";
            this.dsListAllFirmSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(32, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 22);
            this.label9.TabIndex = 105;
            this.label9.Text = "InvoiceNo";
            // 
            // ddlParty
            // 
            this.ddlParty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlParty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlParty.DataSource = this.listAllPartySelectBindingSource;
            this.ddlParty.DisplayMember = "PartyName";
            this.ddlParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlParty.FormattingEnabled = true;
            this.ddlParty.Location = new System.Drawing.Point(774, 14);
            this.ddlParty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlParty.Name = "ddlParty";
            this.ddlParty.Size = new System.Drawing.Size(222, 30);
            this.ddlParty.TabIndex = 87;
            this.ddlParty.ValueMember = "PartyID";
            // 
            // listAllPartySelectBindingSource
            // 
            this.listAllPartySelectBindingSource.DataMember = "ListAllPartySelect";
            this.listAllPartySelectBindingSource.DataSource = this.dsListAllPartySelect;
            // 
            // dsListAllPartySelect
            // 
            this.dsListAllPartySelect.DataSetName = "dsListAllPartySelect";
            this.dsListAllPartySelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(678, 18);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 22);
            this.label17.TabIndex = 88;
            this.label17.Text = "Party";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(440, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 37);
            this.label6.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(771, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 37);
            this.label7.TabIndex = 91;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(146, 15);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(143, 30);
            this.txtInvoiceNo.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(772, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 37);
            this.label2.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(321, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 22);
            this.label8.TabIndex = 89;
            this.label8.Text = "Firm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(678, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 103;
            this.label4.Text = "To Date";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(441, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 37);
            this.label5.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(321, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 101;
            this.label3.Text = "From Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 54);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sales Report";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Location = new System.Drawing.Point(0, 869);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 54);
            this.panel2.TabIndex = 25;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(680, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 19;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.LightBlue;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.Location = new System.Drawing.Point(436, 9);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(234, 35);
            this.btnExport.TabIndex = 17;
            this.btnExport.TabStop = false;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmNameDataGridViewTextBoxColumn,
            this.invoiceNoDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.partyNameDataGridViewTextBoxColumn,
            this.gSTINDataGridViewTextBoxColumn,
            this.Unit,
            this.grossAmountDataGridViewTextBoxColumn,
            this.discDataGridViewTextBoxColumn,
            this.discPerDataGridViewTextBoxColumn,
            this.sGSTDataGridViewTextBoxColumn,
            this.sGSTPerDataGridViewTextBoxColumn,
            this.cGSTDataGridViewTextBoxColumn,
            this.cGSTPerDataGridViewTextBoxColumn,
            this.iGSTDataGridViewTextBoxColumn,
            this.iGSTPerDataGridViewTextBoxColumn,
            this.tCSDataGridViewTextBoxColumn,
            this.tCSPerDataGridViewTextBoxColumn,
            this.netAmountDataGridViewTextBoxColumn,
            this.firmIDDataGridViewTextBoxColumn,
            this.partyIDDataGridViewTextBoxColumn,
            this.challanNoDataGridViewTextBoxColumn,
            this.challanDateDataGridViewTextBoxColumn,
            this.brokerDataGridViewTextBoxColumn,
            this.delToDataGridViewTextBoxColumn,
            this.delAddressDataGridViewTextBoxColumn,
            this.delMobileNoDataGridViewTextBoxColumn,
            this.delStateDataGridViewTextBoxColumn,
            this.delGSTDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.modeDataGridViewTextBoxColumn,
            this.vehicleNoDataGridViewTextBoxColumn,
            this.supplyDateDataGridViewTextBoxColumn,
            this.supplyPlaceDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.bankDataGridViewTextBoxColumn,
            this.chequeNoDataGridViewTextBoxColumn,
            this.salesIDDataGridViewTextBoxColumn,
            this.chequeDateDataGridViewTextBoxColumn,
            this.chequeAmountDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.rptSalesBindingSource;
            this.dgv.Location = new System.Drawing.Point(0, 180);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1200, 640);
            this.dgv.TabIndex = 27;
            this.dgv.TabStop = false;
            this.dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            this.dgv.DoubleClick += new System.EventHandler(this.dgvView_DoubleClick);
            // 
            // rptSalesBindingSource
            // 
            this.rptSalesBindingSource.DataMember = "rptSales";
            this.rptSalesBindingSource.DataSource = this.dsRptSales;
            // 
            // dsRptSales
            // 
            this.dsRptSales.DataSetName = "dsRptSales";
            this.dsRptSales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Honeydew;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtGrossTotal);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtTotalGST);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtTotalSales);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(0, 822);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1199, 45);
            this.panel4.TabIndex = 102;
            // 
            // txtGrossTotal
            // 
            this.txtGrossTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtGrossTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrossTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossTotal.ForeColor = System.Drawing.Color.Black;
            this.txtGrossTotal.Location = new System.Drawing.Point(630, 5);
            this.txtGrossTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGrossTotal.Name = "txtGrossTotal";
            this.txtGrossTotal.ReadOnly = true;
            this.txtGrossTotal.Size = new System.Drawing.Size(119, 30);
            this.txtGrossTotal.TabIndex = 76;
            this.txtGrossTotal.TabStop = false;
            this.txtGrossTotal.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(555, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 22);
            this.label11.TabIndex = 96;
            this.label11.Text = "Gross";
            // 
            // txtTotalGST
            // 
            this.txtTotalGST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGST.ForeColor = System.Drawing.Color.Black;
            this.txtTotalGST.Location = new System.Drawing.Point(828, 5);
            this.txtTotalGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalGST.Name = "txtTotalGST";
            this.txtTotalGST.ReadOnly = true;
            this.txtTotalGST.Size = new System.Drawing.Size(119, 30);
            this.txtTotalGST.TabIndex = 76;
            this.txtTotalGST.TabStop = false;
            this.txtTotalGST.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(759, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 22);
            this.label10.TabIndex = 96;
            this.label10.Text = "GST";
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSales.ForeColor = System.Drawing.Color.Black;
            this.txtTotalSales.Location = new System.Drawing.Point(1030, 5);
            this.txtTotalSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.ReadOnly = true;
            this.txtTotalSales.Size = new System.Drawing.Size(119, 30);
            this.txtTotalSales.TabIndex = 76;
            this.txtTotalSales.TabStop = false;
            this.txtTotalSales.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(957, 8);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 22);
            this.label13.TabIndex = 96;
            this.label13.Text = "Sales";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(32, 8);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(498, 22);
            this.label15.TabIndex = 97;
            this.label15.Text = "Total - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -";
            // 
            // listAllFirmSelectTableAdapter
            // 
            this.listAllFirmSelectTableAdapter.ClearBeforeFill = true;
            // 
            // listAllPartySelectTableAdapter
            // 
            this.listAllPartySelectTableAdapter.ClearBeforeFill = true;
            // 
            // rptSalesTableAdapter
            // 
            this.rptSalesTableAdapter.ClearBeforeFill = true;
            // 
            // firmNameDataGridViewTextBoxColumn
            // 
            this.firmNameDataGridViewTextBoxColumn.DataPropertyName = "FirmName";
            this.firmNameDataGridViewTextBoxColumn.HeaderText = "FirmName";
            this.firmNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firmNameDataGridViewTextBoxColumn.Name = "firmNameDataGridViewTextBoxColumn";
            this.firmNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firmNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoiceNoDataGridViewTextBoxColumn
            // 
            this.invoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.HeaderText = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoiceNoDataGridViewTextBoxColumn.Name = "invoiceNoDataGridViewTextBoxColumn";
            this.invoiceNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // partyNameDataGridViewTextBoxColumn
            // 
            this.partyNameDataGridViewTextBoxColumn.DataPropertyName = "PartyName";
            this.partyNameDataGridViewTextBoxColumn.HeaderText = "PartyName";
            this.partyNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partyNameDataGridViewTextBoxColumn.Name = "partyNameDataGridViewTextBoxColumn";
            this.partyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.partyNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // gSTINDataGridViewTextBoxColumn
            // 
            this.gSTINDataGridViewTextBoxColumn.DataPropertyName = "GSTIN";
            this.gSTINDataGridViewTextBoxColumn.HeaderText = "GSTIN";
            this.gSTINDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gSTINDataGridViewTextBoxColumn.Name = "gSTINDataGridViewTextBoxColumn";
            this.gSTINDataGridViewTextBoxColumn.ReadOnly = true;
            this.gSTINDataGridViewTextBoxColumn.Width = 150;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.MinimumWidth = 8;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 150;
            // 
            // grossAmountDataGridViewTextBoxColumn
            // 
            this.grossAmountDataGridViewTextBoxColumn.DataPropertyName = "GrossAmount";
            this.grossAmountDataGridViewTextBoxColumn.HeaderText = "GrossAmount";
            this.grossAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.grossAmountDataGridViewTextBoxColumn.Name = "grossAmountDataGridViewTextBoxColumn";
            this.grossAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // discDataGridViewTextBoxColumn
            // 
            this.discDataGridViewTextBoxColumn.DataPropertyName = "Disc";
            this.discDataGridViewTextBoxColumn.HeaderText = "Disc";
            this.discDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.discDataGridViewTextBoxColumn.Name = "discDataGridViewTextBoxColumn";
            this.discDataGridViewTextBoxColumn.ReadOnly = true;
            this.discDataGridViewTextBoxColumn.Width = 150;
            // 
            // discPerDataGridViewTextBoxColumn
            // 
            this.discPerDataGridViewTextBoxColumn.DataPropertyName = "DiscPer";
            this.discPerDataGridViewTextBoxColumn.HeaderText = "DiscPer";
            this.discPerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.discPerDataGridViewTextBoxColumn.Name = "discPerDataGridViewTextBoxColumn";
            this.discPerDataGridViewTextBoxColumn.ReadOnly = true;
            this.discPerDataGridViewTextBoxColumn.Width = 150;
            // 
            // sGSTDataGridViewTextBoxColumn
            // 
            this.sGSTDataGridViewTextBoxColumn.DataPropertyName = "SGST";
            this.sGSTDataGridViewTextBoxColumn.HeaderText = "SGST";
            this.sGSTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sGSTDataGridViewTextBoxColumn.Name = "sGSTDataGridViewTextBoxColumn";
            this.sGSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sGSTDataGridViewTextBoxColumn.Width = 150;
            // 
            // sGSTPerDataGridViewTextBoxColumn
            // 
            this.sGSTPerDataGridViewTextBoxColumn.DataPropertyName = "SGSTPer";
            this.sGSTPerDataGridViewTextBoxColumn.HeaderText = "SGSTPer";
            this.sGSTPerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sGSTPerDataGridViewTextBoxColumn.Name = "sGSTPerDataGridViewTextBoxColumn";
            this.sGSTPerDataGridViewTextBoxColumn.ReadOnly = true;
            this.sGSTPerDataGridViewTextBoxColumn.Width = 150;
            // 
            // cGSTDataGridViewTextBoxColumn
            // 
            this.cGSTDataGridViewTextBoxColumn.DataPropertyName = "CGST";
            this.cGSTDataGridViewTextBoxColumn.HeaderText = "CGST";
            this.cGSTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cGSTDataGridViewTextBoxColumn.Name = "cGSTDataGridViewTextBoxColumn";
            this.cGSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cGSTDataGridViewTextBoxColumn.Width = 150;
            // 
            // cGSTPerDataGridViewTextBoxColumn
            // 
            this.cGSTPerDataGridViewTextBoxColumn.DataPropertyName = "CGSTPer";
            this.cGSTPerDataGridViewTextBoxColumn.HeaderText = "CGSTPer";
            this.cGSTPerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cGSTPerDataGridViewTextBoxColumn.Name = "cGSTPerDataGridViewTextBoxColumn";
            this.cGSTPerDataGridViewTextBoxColumn.ReadOnly = true;
            this.cGSTPerDataGridViewTextBoxColumn.Width = 150;
            // 
            // iGSTDataGridViewTextBoxColumn
            // 
            this.iGSTDataGridViewTextBoxColumn.DataPropertyName = "IGST";
            this.iGSTDataGridViewTextBoxColumn.HeaderText = "IGST";
            this.iGSTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iGSTDataGridViewTextBoxColumn.Name = "iGSTDataGridViewTextBoxColumn";
            this.iGSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGSTDataGridViewTextBoxColumn.Width = 150;
            // 
            // iGSTPerDataGridViewTextBoxColumn
            // 
            this.iGSTPerDataGridViewTextBoxColumn.DataPropertyName = "IGSTPer";
            this.iGSTPerDataGridViewTextBoxColumn.HeaderText = "IGSTPer";
            this.iGSTPerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iGSTPerDataGridViewTextBoxColumn.Name = "iGSTPerDataGridViewTextBoxColumn";
            this.iGSTPerDataGridViewTextBoxColumn.ReadOnly = true;
            this.iGSTPerDataGridViewTextBoxColumn.Width = 150;
            // 
            // tCSDataGridViewTextBoxColumn
            // 
            this.tCSDataGridViewTextBoxColumn.DataPropertyName = "TCS";
            this.tCSDataGridViewTextBoxColumn.HeaderText = "TCS";
            this.tCSDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tCSDataGridViewTextBoxColumn.Name = "tCSDataGridViewTextBoxColumn";
            this.tCSDataGridViewTextBoxColumn.ReadOnly = true;
            this.tCSDataGridViewTextBoxColumn.Width = 150;
            // 
            // tCSPerDataGridViewTextBoxColumn
            // 
            this.tCSPerDataGridViewTextBoxColumn.DataPropertyName = "TCSPer";
            this.tCSPerDataGridViewTextBoxColumn.HeaderText = "TCSPer";
            this.tCSPerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tCSPerDataGridViewTextBoxColumn.Name = "tCSPerDataGridViewTextBoxColumn";
            this.tCSPerDataGridViewTextBoxColumn.ReadOnly = true;
            this.tCSPerDataGridViewTextBoxColumn.Width = 150;
            // 
            // netAmountDataGridViewTextBoxColumn
            // 
            this.netAmountDataGridViewTextBoxColumn.DataPropertyName = "NetAmount";
            this.netAmountDataGridViewTextBoxColumn.HeaderText = "NetAmount";
            this.netAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.netAmountDataGridViewTextBoxColumn.Name = "netAmountDataGridViewTextBoxColumn";
            this.netAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.netAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // firmIDDataGridViewTextBoxColumn
            // 
            this.firmIDDataGridViewTextBoxColumn.DataPropertyName = "FirmID";
            this.firmIDDataGridViewTextBoxColumn.HeaderText = "FirmID";
            this.firmIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firmIDDataGridViewTextBoxColumn.Name = "firmIDDataGridViewTextBoxColumn";
            this.firmIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.firmIDDataGridViewTextBoxColumn.Visible = false;
            this.firmIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // partyIDDataGridViewTextBoxColumn
            // 
            this.partyIDDataGridViewTextBoxColumn.DataPropertyName = "PartyID";
            this.partyIDDataGridViewTextBoxColumn.HeaderText = "PartyID";
            this.partyIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partyIDDataGridViewTextBoxColumn.Name = "partyIDDataGridViewTextBoxColumn";
            this.partyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.partyIDDataGridViewTextBoxColumn.Visible = false;
            this.partyIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // challanNoDataGridViewTextBoxColumn
            // 
            this.challanNoDataGridViewTextBoxColumn.DataPropertyName = "ChallanNo";
            this.challanNoDataGridViewTextBoxColumn.HeaderText = "ChallanNo";
            this.challanNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.challanNoDataGridViewTextBoxColumn.Name = "challanNoDataGridViewTextBoxColumn";
            this.challanNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.challanNoDataGridViewTextBoxColumn.Visible = false;
            this.challanNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // challanDateDataGridViewTextBoxColumn
            // 
            this.challanDateDataGridViewTextBoxColumn.DataPropertyName = "ChallanDate";
            this.challanDateDataGridViewTextBoxColumn.HeaderText = "ChallanDate";
            this.challanDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.challanDateDataGridViewTextBoxColumn.Name = "challanDateDataGridViewTextBoxColumn";
            this.challanDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.challanDateDataGridViewTextBoxColumn.Visible = false;
            this.challanDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // brokerDataGridViewTextBoxColumn
            // 
            this.brokerDataGridViewTextBoxColumn.DataPropertyName = "Broker";
            this.brokerDataGridViewTextBoxColumn.HeaderText = "Broker";
            this.brokerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.brokerDataGridViewTextBoxColumn.Name = "brokerDataGridViewTextBoxColumn";
            this.brokerDataGridViewTextBoxColumn.ReadOnly = true;
            this.brokerDataGridViewTextBoxColumn.Visible = false;
            this.brokerDataGridViewTextBoxColumn.Width = 150;
            // 
            // delToDataGridViewTextBoxColumn
            // 
            this.delToDataGridViewTextBoxColumn.DataPropertyName = "DelTo";
            this.delToDataGridViewTextBoxColumn.HeaderText = "DelTo";
            this.delToDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.delToDataGridViewTextBoxColumn.Name = "delToDataGridViewTextBoxColumn";
            this.delToDataGridViewTextBoxColumn.ReadOnly = true;
            this.delToDataGridViewTextBoxColumn.Visible = false;
            this.delToDataGridViewTextBoxColumn.Width = 150;
            // 
            // delAddressDataGridViewTextBoxColumn
            // 
            this.delAddressDataGridViewTextBoxColumn.DataPropertyName = "DelAddress";
            this.delAddressDataGridViewTextBoxColumn.HeaderText = "DelAddress";
            this.delAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.delAddressDataGridViewTextBoxColumn.Name = "delAddressDataGridViewTextBoxColumn";
            this.delAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.delAddressDataGridViewTextBoxColumn.Visible = false;
            this.delAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // delMobileNoDataGridViewTextBoxColumn
            // 
            this.delMobileNoDataGridViewTextBoxColumn.DataPropertyName = "DelMobileNo";
            this.delMobileNoDataGridViewTextBoxColumn.HeaderText = "DelMobileNo";
            this.delMobileNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.delMobileNoDataGridViewTextBoxColumn.Name = "delMobileNoDataGridViewTextBoxColumn";
            this.delMobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.delMobileNoDataGridViewTextBoxColumn.Visible = false;
            this.delMobileNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // delStateDataGridViewTextBoxColumn
            // 
            this.delStateDataGridViewTextBoxColumn.DataPropertyName = "DelState";
            this.delStateDataGridViewTextBoxColumn.HeaderText = "DelState";
            this.delStateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.delStateDataGridViewTextBoxColumn.Name = "delStateDataGridViewTextBoxColumn";
            this.delStateDataGridViewTextBoxColumn.ReadOnly = true;
            this.delStateDataGridViewTextBoxColumn.Visible = false;
            this.delStateDataGridViewTextBoxColumn.Width = 150;
            // 
            // delGSTDataGridViewTextBoxColumn
            // 
            this.delGSTDataGridViewTextBoxColumn.DataPropertyName = "DelGST";
            this.delGSTDataGridViewTextBoxColumn.HeaderText = "DelGST";
            this.delGSTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.delGSTDataGridViewTextBoxColumn.Name = "delGSTDataGridViewTextBoxColumn";
            this.delGSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.delGSTDataGridViewTextBoxColumn.Visible = false;
            this.delGSTDataGridViewTextBoxColumn.Width = 150;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Visible = false;
            this.stateDataGridViewTextBoxColumn.Width = 150;
            // 
            // modeDataGridViewTextBoxColumn
            // 
            this.modeDataGridViewTextBoxColumn.DataPropertyName = "Mode";
            this.modeDataGridViewTextBoxColumn.HeaderText = "Mode";
            this.modeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            this.modeDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeDataGridViewTextBoxColumn.Visible = false;
            this.modeDataGridViewTextBoxColumn.Width = 150;
            // 
            // vehicleNoDataGridViewTextBoxColumn
            // 
            this.vehicleNoDataGridViewTextBoxColumn.DataPropertyName = "VehicleNo";
            this.vehicleNoDataGridViewTextBoxColumn.HeaderText = "VehicleNo";
            this.vehicleNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vehicleNoDataGridViewTextBoxColumn.Name = "vehicleNoDataGridViewTextBoxColumn";
            this.vehicleNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleNoDataGridViewTextBoxColumn.Visible = false;
            this.vehicleNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // supplyDateDataGridViewTextBoxColumn
            // 
            this.supplyDateDataGridViewTextBoxColumn.DataPropertyName = "SupplyDate";
            this.supplyDateDataGridViewTextBoxColumn.HeaderText = "SupplyDate";
            this.supplyDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplyDateDataGridViewTextBoxColumn.Name = "supplyDateDataGridViewTextBoxColumn";
            this.supplyDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplyDateDataGridViewTextBoxColumn.Visible = false;
            this.supplyDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // supplyPlaceDataGridViewTextBoxColumn
            // 
            this.supplyPlaceDataGridViewTextBoxColumn.DataPropertyName = "SupplyPlace";
            this.supplyPlaceDataGridViewTextBoxColumn.HeaderText = "SupplyPlace";
            this.supplyPlaceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplyPlaceDataGridViewTextBoxColumn.Name = "supplyPlaceDataGridViewTextBoxColumn";
            this.supplyPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplyPlaceDataGridViewTextBoxColumn.Visible = false;
            this.supplyPlaceDataGridViewTextBoxColumn.Width = 150;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dueDateDataGridViewTextBoxColumn.Visible = false;
            this.dueDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // bankDataGridViewTextBoxColumn
            // 
            this.bankDataGridViewTextBoxColumn.DataPropertyName = "Bank";
            this.bankDataGridViewTextBoxColumn.HeaderText = "Bank";
            this.bankDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bankDataGridViewTextBoxColumn.Name = "bankDataGridViewTextBoxColumn";
            this.bankDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankDataGridViewTextBoxColumn.Visible = false;
            this.bankDataGridViewTextBoxColumn.Width = 150;
            // 
            // chequeNoDataGridViewTextBoxColumn
            // 
            this.chequeNoDataGridViewTextBoxColumn.DataPropertyName = "ChequeNo";
            this.chequeNoDataGridViewTextBoxColumn.HeaderText = "ChequeNo";
            this.chequeNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chequeNoDataGridViewTextBoxColumn.Name = "chequeNoDataGridViewTextBoxColumn";
            this.chequeNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.chequeNoDataGridViewTextBoxColumn.Visible = false;
            this.chequeNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // salesIDDataGridViewTextBoxColumn
            // 
            this.salesIDDataGridViewTextBoxColumn.DataPropertyName = "SalesID";
            this.salesIDDataGridViewTextBoxColumn.HeaderText = "SalesID";
            this.salesIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salesIDDataGridViewTextBoxColumn.Name = "salesIDDataGridViewTextBoxColumn";
            this.salesIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesIDDataGridViewTextBoxColumn.Visible = false;
            this.salesIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // chequeDateDataGridViewTextBoxColumn
            // 
            this.chequeDateDataGridViewTextBoxColumn.DataPropertyName = "ChequeDate";
            this.chequeDateDataGridViewTextBoxColumn.HeaderText = "ChequeDate";
            this.chequeDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chequeDateDataGridViewTextBoxColumn.Name = "chequeDateDataGridViewTextBoxColumn";
            this.chequeDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.chequeDateDataGridViewTextBoxColumn.Visible = false;
            this.chequeDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // chequeAmountDataGridViewTextBoxColumn
            // 
            this.chequeAmountDataGridViewTextBoxColumn.DataPropertyName = "ChequeAmount";
            this.chequeAmountDataGridViewTextBoxColumn.HeaderText = "ChequeAmount";
            this.chequeAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chequeAmountDataGridViewTextBoxColumn.Name = "chequeAmountDataGridViewTextBoxColumn";
            this.chequeAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.chequeAmountDataGridViewTextBoxColumn.Visible = false;
            this.chequeAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // rptSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 923);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "rptSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rptSales";
            this.Load += new System.EventHandler(this.rptSales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rptSales_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAllFirmSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListAllFirmSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllPartySelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListAllPartySelect)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRptSales)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ComboBox ddlFirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlParty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtGrossTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalGST;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private DatasetList.dsListAllFirmSelect dsListAllFirmSelect;
        private System.Windows.Forms.BindingSource listAllFirmSelectBindingSource;
        private DatasetList.dsListAllFirmSelectTableAdapters.ListAllFirmSelectTableAdapter listAllFirmSelectTableAdapter;
        private DatasetList.dsListAllPartySelect dsListAllPartySelect;
        private System.Windows.Forms.BindingSource listAllPartySelectBindingSource;
        private DatasetList.dsListAllPartySelectTableAdapters.ListAllPartySelectTableAdapter listAllPartySelectTableAdapter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.BindingSource rptSalesBindingSource;
        private DatasetList.dsRptSales dsRptSales;
        private DatasetList.dsRptSalesTableAdapters.rptSalesTableAdapter rptSalesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSTINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discPerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTPerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTPerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGSTPerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCSPerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn challanNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn challanDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brokerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delMobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplyPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeAmountDataGridViewTextBoxColumn;
    }
}