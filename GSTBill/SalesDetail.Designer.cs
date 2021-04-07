namespace GSTBill
{
    partial class SalesDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDetail));
            this.ddlFirm = new System.Windows.Forms.ComboBox();
            this.listAllFirmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListAllFirm = new GSTBill.DatasetList.dsListAllFirm();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ddlBilledTo = new System.Windows.Forms.ComboBox();
            this.listAllPartyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListAllParty = new GSTBill.DatasetList.dsListAllParty();
            this.label6 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBillGST = new System.Windows.Forms.TextBox();
            this.dtpChallanDate = new System.Windows.Forms.DateTimePicker();
            this.txtDelTo = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDelGST = new System.Windows.Forms.TextBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBillState = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBroker = new System.Windows.Forms.TextBox();
            this.txtChallanNo = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtDelAdd = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBillMobNo = new System.Windows.Forms.TextBox();
            this.txtBillAdd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDelMobNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDelState = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtSupplyPlace = new System.Windows.Forms.TextBox();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.ddlMode = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.dtpSupplyDate = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label51 = new System.Windows.Forms.Label();
            this.txtChequeDate = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.listAllPartyTableAdapter = new GSTBill.DatasetList.dsListAllPartyTableAdapters.ListAllPartyTableAdapter();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listAllFirmTableAdapter = new GSTBill.DatasetList.dsListAllFirmTableAdapters.ListAllFirmTableAdapter();
            this.label40 = new System.Windows.Forms.Label();
            this.ddlSGST = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.ddlCGST = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.ddlIGST = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrossTotal = new System.Windows.Forms.TextBox();
            this.txtDiscAmt = new System.Windows.Forms.TextBox();
            this.txtDiscPer = new System.Windows.Forms.TextBox();
            this.txtNetTotal = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.METRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAKA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSNCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARTICULARS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.txtIGST = new System.Windows.Forms.TextBox();
            this.txtTCS = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label41 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.txtTCSPer = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtnMeter = new System.Windows.Forms.RadioButton();
            this.rbtnKG = new System.Windows.Forms.RadioButton();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.listAllFirmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListAllFirm)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAllPartyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListAllParty)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddlFirm
            // 
            this.ddlFirm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlFirm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlFirm.DataSource = this.listAllFirmBindingSource;
            this.ddlFirm.DisplayMember = "FirmName";
            this.ddlFirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlFirm.FormattingEnabled = true;
            this.ddlFirm.Location = new System.Drawing.Point(156, 15);
            this.ddlFirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlFirm.Name = "ddlFirm";
            this.ddlFirm.Size = new System.Drawing.Size(604, 30);
            this.ddlFirm.TabIndex = 0;
            this.ddlFirm.ValueMember = "FirmID";
            this.ddlFirm.SelectedIndexChanged += new System.EventHandler(this.ddlFirm_SelectedIndexChanged);
            // 
            // listAllFirmBindingSource
            // 
            this.listAllFirmBindingSource.DataMember = "ListAllFirm";
            this.listAllFirmBindingSource.DataSource = this.dsListAllFirm;
            // 
            // dsListAllFirm
            // 
            this.dsListAllFirm.DataSetName = "dsListAllFirm";
            this.dsListAllFirm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(153, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(610, 37);
            this.label4.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 69;
            this.label2.Text = "Firm";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUpdateAll);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ddlFirm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 67);
            this.panel1.TabIndex = 72;
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.Location = new System.Drawing.Point(807, 14);
            this.btnUpdateAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(112, 35);
            this.btnUpdateAll.TabIndex = 86;
            this.btnUpdateAll.Text = "Update All";
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            this.btnUpdateAll.Visible = false;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(426, 14);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 22);
            this.label17.TabIndex = 61;
            this.label17.Text = "Billed To";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ddlBilledTo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.txtBillGST);
            this.panel2.Controls.Add(this.dtpChallanDate);
            this.panel2.Controls.Add(this.txtDelTo);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.txtDelGST);
            this.panel2.Controls.Add(this.dtpInvoiceDate);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtBillState);
            this.panel2.Controls.Add(this.txtInvoiceNo);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtBroker);
            this.panel2.Controls.Add(this.txtChallanNo);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.txtDelAdd);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtBillMobNo);
            this.panel2.Controls.Add(this.txtBillAdd);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtDelMobNo);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtDelState);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 242);
            this.panel2.TabIndex = 72;
            // 
            // ddlBilledTo
            // 
            this.ddlBilledTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlBilledTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlBilledTo.DataSource = this.listAllPartyBindingSource;
            this.ddlBilledTo.DisplayMember = "PartyName";
            this.ddlBilledTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlBilledTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlBilledTo.FormattingEnabled = true;
            this.ddlBilledTo.Location = new System.Drawing.Point(564, 11);
            this.ddlBilledTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlBilledTo.Name = "ddlBilledTo";
            this.ddlBilledTo.Size = new System.Drawing.Size(222, 30);
            this.ddlBilledTo.TabIndex = 7;
            this.ddlBilledTo.ValueMember = "PartyID";
            this.ddlBilledTo.SelectedIndexChanged += new System.EventHandler(this.ddlBilledTo_SelectedIndexChanged);
            // 
            // listAllPartyBindingSource
            // 
            this.listAllPartyBindingSource.DataMember = "ListAllParty";
            this.listAllPartyBindingSource.DataSource = this.dsListAllParty;
            // 
            // dsListAllParty
            // 
            this.dsListAllParty.DataSetName = "dsListAllParty";
            this.dsListAllParty.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(561, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 37);
            this.label6.TabIndex = 85;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(20, 148);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(126, 22);
            this.label23.TabIndex = 82;
            this.label23.Text = "Challan Date";
            // 
            // txtBillGST
            // 
            this.txtBillGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillGST.Location = new System.Drawing.Point(561, 189);
            this.txtBillGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBillGST.Name = "txtBillGST";
            this.txtBillGST.ReadOnly = true;
            this.txtBillGST.Size = new System.Drawing.Size(227, 30);
            this.txtBillGST.TabIndex = 13;
            this.txtBillGST.TabStop = false;
            this.txtBillGST.TextChanged += new System.EventHandler(this.txtBillGST_TextChanged);
            // 
            // dtpChallanDate
            // 
            this.dtpChallanDate.CustomFormat = "dd/MM/yyyy";
            this.dtpChallanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChallanDate.Location = new System.Drawing.Point(160, 145);
            this.dtpChallanDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpChallanDate.Name = "dtpChallanDate";
            this.dtpChallanDate.Size = new System.Drawing.Size(127, 30);
            this.dtpChallanDate.TabIndex = 5;
            // 
            // txtDelTo
            // 
            this.txtDelTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelTo.Location = new System.Drawing.Point(928, 11);
            this.txtDelTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDelTo.Name = "txtDelTo";
            this.txtDelTo.Size = new System.Drawing.Size(227, 30);
            this.txtDelTo.TabIndex = 60;
            this.txtDelTo.TabStop = false;
            // 
            // label24
            // 
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Location = new System.Drawing.Point(159, 143);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(131, 39);
            this.label24.TabIndex = 83;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(794, 103);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 22);
            this.label15.TabIndex = 77;
            this.label15.Text = "Mobile No.";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(20, 58);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 22);
            this.label21.TabIndex = 79;
            this.label21.Text = "Invoice Date";
            // 
            // txtDelGST
            // 
            this.txtDelGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelGST.Location = new System.Drawing.Point(928, 189);
            this.txtDelGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDelGST.Name = "txtDelGST";
            this.txtDelGST.Size = new System.Drawing.Size(227, 30);
            this.txtDelGST.TabIndex = 60;
            this.txtDelGST.TabStop = false;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "dd/MM/yyyy h:mm tt";
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(160, 55);
            this.dtpInvoiceDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(248, 30);
            this.dtpInvoiceDate.TabIndex = 2;
            this.dtpInvoiceDate.ValueChanged += new System.EventHandler(this.dtpInvoiceDate_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(794, 58);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 22);
            this.label18.TabIndex = 74;
            this.label18.Text = "Address";
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(159, 54);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(252, 39);
            this.label22.TabIndex = 80;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(794, 148);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 22);
            this.label14.TabIndex = 77;
            this.label14.Text = "State";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(20, 14);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 22);
            this.label19.TabIndex = 61;
            this.label19.Text = "Invoice No.";
            // 
            // txtBillState
            // 
            this.txtBillState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillState.Location = new System.Drawing.Point(561, 145);
            this.txtBillState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBillState.Name = "txtBillState";
            this.txtBillState.ReadOnly = true;
            this.txtBillState.Size = new System.Drawing.Size(227, 30);
            this.txtBillState.TabIndex = 12;
            this.txtBillState.TabStop = false;
            this.txtBillState.TextChanged += new System.EventHandler(this.txtBillState_TextChanged);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(158, 11);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(131, 30);
            this.txtInvoiceNo.TabIndex = 1;
            this.txtInvoiceNo.TabStop = false;
            this.txtInvoiceNo.TextChanged += new System.EventHandler(this.txtInvoiceNo_TextChanged);
            this.txtInvoiceNo.Leave += new System.EventHandler(this.txtInvoiceNo_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(794, 14);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 22);
            this.label16.TabIndex = 61;
            this.label16.Text = "Delivery To";
            // 
            // txtBroker
            // 
            this.txtBroker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBroker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBroker.Location = new System.Drawing.Point(159, 189);
            this.txtBroker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBroker.Name = "txtBroker";
            this.txtBroker.Size = new System.Drawing.Size(131, 30);
            this.txtBroker.TabIndex = 6;
            // 
            // txtChallanNo
            // 
            this.txtChallanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChallanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallanNo.Location = new System.Drawing.Point(159, 100);
            this.txtChallanNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChallanNo.Name = "txtChallanNo";
            this.txtChallanNo.Size = new System.Drawing.Size(131, 30);
            this.txtChallanNo.TabIndex = 4;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(20, 192);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(69, 22);
            this.label28.TabIndex = 61;
            this.label28.Text = "Broker";
            // 
            // txtDelAdd
            // 
            this.txtDelAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelAdd.Location = new System.Drawing.Point(928, 55);
            this.txtDelAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDelAdd.Name = "txtDelAdd";
            this.txtDelAdd.Size = new System.Drawing.Size(227, 30);
            this.txtDelAdd.TabIndex = 60;
            this.txtDelAdd.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(20, 103);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 22);
            this.label20.TabIndex = 61;
            this.label20.Text = "Challan No.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(426, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 22);
            this.label9.TabIndex = 74;
            this.label9.Text = "Address";
            // 
            // txtBillMobNo
            // 
            this.txtBillMobNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillMobNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillMobNo.Location = new System.Drawing.Point(561, 100);
            this.txtBillMobNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBillMobNo.Name = "txtBillMobNo";
            this.txtBillMobNo.ReadOnly = true;
            this.txtBillMobNo.Size = new System.Drawing.Size(227, 30);
            this.txtBillMobNo.TabIndex = 11;
            this.txtBillMobNo.TabStop = false;
            this.txtBillMobNo.TextChanged += new System.EventHandler(this.txtBillMobNo_TextChanged);
            // 
            // txtBillAdd
            // 
            this.txtBillAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillAdd.Location = new System.Drawing.Point(561, 55);
            this.txtBillAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBillAdd.Name = "txtBillAdd";
            this.txtBillAdd.ReadOnly = true;
            this.txtBillAdd.Size = new System.Drawing.Size(227, 30);
            this.txtBillAdd.TabIndex = 10;
            this.txtBillAdd.TabStop = false;
            this.txtBillAdd.TextChanged += new System.EventHandler(this.txtBillAdd_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(426, 148);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 22);
            this.label11.TabIndex = 77;
            this.label11.Text = "State";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(426, 192);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 22);
            this.label12.TabIndex = 77;
            this.label12.Text = "Party GSTIN";
            // 
            // txtDelMobNo
            // 
            this.txtDelMobNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelMobNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelMobNo.Location = new System.Drawing.Point(928, 100);
            this.txtDelMobNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDelMobNo.Name = "txtDelMobNo";
            this.txtDelMobNo.Size = new System.Drawing.Size(227, 30);
            this.txtDelMobNo.TabIndex = 60;
            this.txtDelMobNo.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(794, 192);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 22);
            this.label13.TabIndex = 77;
            this.label13.Text = "Party GSTIN";
            // 
            // txtDelState
            // 
            this.txtDelState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelState.Location = new System.Drawing.Point(928, 145);
            this.txtDelState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDelState.Name = "txtDelState";
            this.txtDelState.Size = new System.Drawing.Size(227, 30);
            this.txtDelState.TabIndex = 60;
            this.txtDelState.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(426, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 22);
            this.label10.TabIndex = 77;
            this.label10.Text = "Mobile No.";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbtnKG);
            this.panel3.Controls.Add(this.rbtnMeter);
            this.panel3.Controls.Add(this.label37);
            this.panel3.Controls.Add(this.label36);
            this.panel3.Controls.Add(this.txtSupplyPlace);
            this.panel3.Controls.Add(this.txtVehicle);
            this.panel3.Controls.Add(this.label35);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.ddlMode);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.dtpSupplyDate);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.txtState);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.grpUnit);
            this.panel3.Location = new System.Drawing.Point(0, 360);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1174, 107);
            this.panel3.TabIndex = 72;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(921, 34);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(60, 22);
            this.label37.TabIndex = 84;
            this.label37.Text = "Place";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(676, 34);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(52, 22);
            this.label36.TabIndex = 84;
            this.label36.Text = "Date";
            // 
            // txtSupplyPlace
            // 
            this.txtSupplyPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplyPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplyPlace.Location = new System.Drawing.Point(1010, 17);
            this.txtSupplyPlace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupplyPlace.Name = "txtSupplyPlace";
            this.txtSupplyPlace.Size = new System.Drawing.Size(119, 30);
            this.txtSupplyPlace.TabIndex = 60;
            this.txtSupplyPlace.TabStop = false;
            // 
            // txtVehicle
            // 
            this.txtVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicle.Location = new System.Drawing.Point(546, 14);
            this.txtVehicle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(119, 30);
            this.txtVehicle.TabIndex = 60;
            this.txtVehicle.TabStop = false;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(920, 9);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 22);
            this.label35.TabIndex = 61;
            this.label35.Text = "Supply";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(675, 11);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(71, 22);
            this.label34.TabIndex = 82;
            this.label34.Text = "Supply";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(417, 17);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(113, 22);
            this.label31.TabIndex = 61;
            this.label31.Text = "Vehicle No.";
            // 
            // ddlMode
            // 
            this.ddlMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlMode.FormattingEnabled = true;
            this.ddlMode.Items.AddRange(new object[] {
            "ROAD",
            "RAIL"});
            this.ddlMode.Location = new System.Drawing.Point(291, 12);
            this.ddlMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlMode.Name = "ddlMode";
            this.ddlMode.Size = new System.Drawing.Size(114, 30);
            this.ddlMode.TabIndex = 78;
            this.ddlMode.TabStop = false;
            // 
            // label32
            // 
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label32.Location = new System.Drawing.Point(288, 11);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(119, 37);
            this.label32.TabIndex = 79;
            // 
            // dtpSupplyDate
            // 
            this.dtpSupplyDate.CustomFormat = "dd/MM/yyyy";
            this.dtpSupplyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSupplyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSupplyDate.Location = new System.Drawing.Point(759, 17);
            this.dtpSupplyDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpSupplyDate.Name = "dtpSupplyDate";
            this.dtpSupplyDate.Size = new System.Drawing.Size(150, 30);
            this.dtpSupplyDate.TabIndex = 81;
            this.dtpSupplyDate.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(218, 17);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 22);
            this.label30.TabIndex = 61;
            this.label30.Text = "Mode";
            // 
            // label33
            // 
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label33.Location = new System.Drawing.Point(758, 15);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(154, 37);
            this.label33.TabIndex = 83;
            // 
            // txtState
            // 
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(88, 12);
            this.txtState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(119, 30);
            this.txtState.TabIndex = 60;
            this.txtState.TabStop = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(20, 17);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 22);
            this.label29.TabIndex = 61;
            this.label29.Text = "State";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 2);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 20);
            this.label25.TabIndex = 80;
            this.label25.Text = "Firm Details";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 91);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(98, 20);
            this.label26.TabIndex = 84;
            this.label26.Text = "Party Details";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(8, 348);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(130, 20);
            this.label27.TabIndex = 84;
            this.label27.Text = "Transport Details";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(8, 474);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(110, 20);
            this.label47.TabIndex = 84;
            this.label47.Text = "Goods Details";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label51);
            this.panel5.Controls.Add(this.txtChequeDate);
            this.panel5.Controls.Add(this.txtAmount);
            this.panel5.Controls.Add(this.label52);
            this.panel5.Controls.Add(this.txtChequeNo);
            this.panel5.Controls.Add(this.label50);
            this.panel5.Controls.Add(this.txtBank);
            this.panel5.Controls.Add(this.label58);
            this.panel5.Location = new System.Drawing.Point(0, 949);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1174, 56);
            this.panel5.TabIndex = 72;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.Black;
            this.label51.Location = new System.Drawing.Point(706, 18);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(52, 22);
            this.label51.TabIndex = 84;
            this.label51.Text = "Date";
            // 
            // txtChequeDate
            // 
            this.txtChequeDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChequeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeDate.Location = new System.Drawing.Point(771, 15);
            this.txtChequeDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChequeDate.Name = "txtChequeDate";
            this.txtChequeDate.Size = new System.Drawing.Size(119, 30);
            this.txtChequeDate.TabIndex = 60;
            this.txtChequeDate.TabStop = false;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(1004, 15);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(119, 30);
            this.txtAmount.TabIndex = 60;
            this.txtAmount.TabStop = false;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.Black;
            this.label52.Location = new System.Drawing.Point(912, 18);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(77, 22);
            this.label52.TabIndex = 61;
            this.label52.Text = "Amount";
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChequeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeNo.Location = new System.Drawing.Point(459, 15);
            this.txtChequeNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(224, 30);
            this.txtChequeNo.TabIndex = 60;
            this.txtChequeNo.TabStop = false;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.Black;
            this.label50.Location = new System.Drawing.Point(363, 18);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(83, 22);
            this.label50.TabIndex = 61;
            this.label50.Text = "Chq No.";
            // 
            // txtBank
            // 
            this.txtBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.Location = new System.Drawing.Point(110, 15);
            this.txtBank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(224, 30);
            this.txtBank.TabIndex = 60;
            this.txtBank.TabStop = false;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.Black;
            this.label58.Location = new System.Drawing.Point(42, 18);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(55, 22);
            this.label58.TabIndex = 61;
            this.label58.Text = "Bank";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(8, 939);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(99, 20);
            this.label59.TabIndex = 85;
            this.label59.Text = "Bank Details";
            // 
            // listAllPartyTableAdapter
            // 
            this.listAllPartyTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrint.Location = new System.Drawing.Point(375, 1011);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(200, 35);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "Save Print(Ctrl+A)";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(584, 1011);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save Only(Ctrl+S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listAllFirmTableAdapter
            // 
            this.listAllFirmTableAdapter.ClearBeforeFill = true;
            // 
            // label40
            // 
            this.label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label40.Location = new System.Drawing.Point(112, 275);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(84, 37);
            this.label40.TabIndex = 79;
            // 
            // ddlSGST
            // 
            this.ddlSGST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSGST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlSGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSGST.FormattingEnabled = true;
            this.ddlSGST.Items.AddRange(new object[] {
            "0",
            "2.5",
            "5",
            "6",
            "9",
            "12",
            "14",
            "18"});
            this.ddlSGST.Location = new System.Drawing.Point(115, 279);
            this.ddlSGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlSGST.Name = "ddlSGST";
            this.ddlSGST.Size = new System.Drawing.Size(79, 30);
            this.ddlSGST.TabIndex = 15;
            this.ddlSGST.TabStop = false;
            this.ddlSGST.SelectedIndexChanged += new System.EventHandler(this.ddlSGST_SelectedIndexChanged);
            // 
            // label42
            // 
            this.label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label42.Location = new System.Drawing.Point(112, 320);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(84, 37);
            this.label42.TabIndex = 79;
            // 
            // ddlCGST
            // 
            this.ddlCGST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCGST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlCGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCGST.FormattingEnabled = true;
            this.ddlCGST.Items.AddRange(new object[] {
            "0",
            "2.5",
            "5",
            "6",
            "9",
            "12",
            "14",
            "18"});
            this.ddlCGST.Location = new System.Drawing.Point(115, 323);
            this.ddlCGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlCGST.Name = "ddlCGST";
            this.ddlCGST.Size = new System.Drawing.Size(79, 30);
            this.ddlCGST.TabIndex = 16;
            this.ddlCGST.TabStop = false;
            this.ddlCGST.SelectedIndexChanged += new System.EventHandler(this.ddlCGST_SelectedIndexChanged);
            // 
            // label45
            // 
            this.label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label45.Location = new System.Drawing.Point(112, 364);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(84, 37);
            this.label45.TabIndex = 79;
            // 
            // ddlIGST
            // 
            this.ddlIGST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlIGST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlIGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlIGST.FormattingEnabled = true;
            this.ddlIGST.Items.AddRange(new object[] {
            "0",
            "2.5",
            "5",
            "6",
            "9",
            "12",
            "14",
            "18"});
            this.ddlIGST.Location = new System.Drawing.Point(115, 368);
            this.ddlIGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlIGST.Name = "ddlIGST";
            this.ddlIGST.Size = new System.Drawing.Size(79, 30);
            this.ddlIGST.TabIndex = 17;
            this.ddlIGST.TabStop = false;
            this.ddlIGST.SelectedIndexChanged += new System.EventHandler(this.ddlIGST_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(112, 409);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 37);
            this.label1.TabIndex = 79;
            // 
            // txtGrossTotal
            // 
            this.txtGrossTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtGrossTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrossTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossTotal.ForeColor = System.Drawing.Color.Black;
            this.txtGrossTotal.Location = new System.Drawing.Point(1029, 277);
            this.txtGrossTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGrossTotal.Name = "txtGrossTotal";
            this.txtGrossTotal.ReadOnly = true;
            this.txtGrossTotal.Size = new System.Drawing.Size(128, 30);
            this.txtGrossTotal.TabIndex = 85;
            this.txtGrossTotal.TabStop = false;
            this.txtGrossTotal.Text = "0";
            // 
            // txtDiscAmt
            // 
            this.txtDiscAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDiscAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscAmt.ForeColor = System.Drawing.Color.Black;
            this.txtDiscAmt.Location = new System.Drawing.Point(1029, 322);
            this.txtDiscAmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiscAmt.Name = "txtDiscAmt";
            this.txtDiscAmt.ReadOnly = true;
            this.txtDiscAmt.Size = new System.Drawing.Size(128, 30);
            this.txtDiscAmt.TabIndex = 85;
            this.txtDiscAmt.TabStop = false;
            this.txtDiscAmt.Text = "0";
            // 
            // txtDiscPer
            // 
            this.txtDiscPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDiscPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscPer.ForeColor = System.Drawing.Color.Black;
            this.txtDiscPer.Location = new System.Drawing.Point(951, 320);
            this.txtDiscPer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiscPer.Name = "txtDiscPer";
            this.txtDiscPer.Size = new System.Drawing.Size(68, 30);
            this.txtDiscPer.TabIndex = 111;
            this.txtDiscPer.TabStop = false;
            this.txtDiscPer.Text = "0";
            this.txtDiscPer.TextChanged += new System.EventHandler(this.txtDiscPer_TextChanged);
            this.txtDiscPer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscPer_KeyPress);
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.BackColor = System.Drawing.Color.LightGreen;
            this.txtNetTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetTotal.ForeColor = System.Drawing.Color.Black;
            this.txtNetTotal.Location = new System.Drawing.Point(1029, 365);
            this.txtNetTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.ReadOnly = true;
            this.txtNetTotal.Size = new System.Drawing.Size(128, 30);
            this.txtNetTotal.TabIndex = 85;
            this.txtNetTotal.TabStop = false;
            this.txtNetTotal.Text = "0";
            // 
            // dgv
            // 
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNO,
            this.PARTICULARS,
            this.HSNCODE,
            this.TAKA,
            this.METRES,
            this.RATE,
            this.AMOUNT});
            this.dgv.Location = new System.Drawing.Point(18, 24);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(1138, 243);
            this.dgv.TabIndex = 8;
            this.dgv.TabStop = false;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            this.dgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_EditingControlShowing);
            this.dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowEnter);
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            // 
            // AMOUNT
            // 
            this.AMOUNT.HeaderText = "AMOUNT";
            this.AMOUNT.MinimumWidth = 8;
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.Width = 150;
            // 
            // RATE
            // 
            this.RATE.HeaderText = "RATE";
            this.RATE.MinimumWidth = 8;
            this.RATE.Name = "RATE";
            this.RATE.Width = 70;
            // 
            // METRES
            // 
            this.METRES.HeaderText = "METRES/KGS";
            this.METRES.MinimumWidth = 8;
            this.METRES.Name = "METRES";
            this.METRES.Width = 70;
            // 
            // TAKA
            // 
            this.TAKA.HeaderText = "TAKA";
            this.TAKA.MinimumWidth = 8;
            this.TAKA.Name = "TAKA";
            this.TAKA.Width = 70;
            // 
            // HSNCODE
            // 
            this.HSNCODE.HeaderText = "HSNCODE";
            this.HSNCODE.MinimumWidth = 8;
            this.HSNCODE.Name = "HSNCODE";
            this.HSNCODE.Width = 150;
            // 
            // PARTICULARS
            // 
            this.PARTICULARS.HeaderText = "PARTICULARS";
            this.PARTICULARS.MinimumWidth = 8;
            this.PARTICULARS.Name = "PARTICULARS";
            this.PARTICULARS.Width = 300;
            // 
            // SNO
            // 
            this.SNO.HeaderText = "SNO";
            this.SNO.MinimumWidth = 8;
            this.SNO.Name = "SNO";
            this.SNO.ReadOnly = true;
            this.SNO.Width = 40;
            // 
            // txtSGST
            // 
            this.txtSGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGST.Location = new System.Drawing.Point(242, 277);
            this.txtSGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.ReadOnly = true;
            this.txtSGST.Size = new System.Drawing.Size(128, 30);
            this.txtSGST.TabIndex = 60;
            this.txtSGST.TabStop = false;
            this.txtSGST.Text = "0";
            // 
            // txtCGST
            // 
            this.txtCGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGST.Location = new System.Drawing.Point(242, 321);
            this.txtCGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.ReadOnly = true;
            this.txtCGST.Size = new System.Drawing.Size(128, 30);
            this.txtCGST.TabIndex = 60;
            this.txtCGST.TabStop = false;
            this.txtCGST.Text = "0";
            // 
            // txtIGST
            // 
            this.txtIGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGST.Location = new System.Drawing.Point(242, 366);
            this.txtIGST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIGST.Name = "txtIGST";
            this.txtIGST.ReadOnly = true;
            this.txtIGST.Size = new System.Drawing.Size(128, 30);
            this.txtIGST.TabIndex = 60;
            this.txtIGST.TabStop = false;
            this.txtIGST.Text = "0";
            // 
            // txtTCS
            // 
            this.txtTCS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCS.Location = new System.Drawing.Point(242, 409);
            this.txtTCS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTCS.Name = "txtTCS";
            this.txtTCS.ReadOnly = true;
            this.txtTCS.Size = new System.Drawing.Size(128, 30);
            this.txtTCS.TabIndex = 60;
            this.txtTCS.TabStop = false;
            this.txtTCS.Text = "0";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(876, 282);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(136, 22);
            this.label38.TabIndex = 86;
            this.label38.Text = "Gross Amount";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(876, 325);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(62, 22);
            this.label55.TabIndex = 86;
            this.label55.Text = "- Disc";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(876, 369);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(114, 22);
            this.label49.TabIndex = 86;
            this.label49.Text = "Net Amount";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(24, 280);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(82, 22);
            this.label39.TabIndex = 86;
            this.label39.Text = "+ SGST";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(24, 324);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(83, 22);
            this.label43.TabIndex = 86;
            this.label43.Text = "+ CGST";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.Black;
            this.label46.Location = new System.Drawing.Point(24, 369);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(74, 22);
            this.label46.TabIndex = 86;
            this.label46.Text = "+ IGST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 86;
            this.label3.Text = "+ TCS";
            // 
            // label53
            // 
            this.label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label53.Location = new System.Drawing.Point(1028, 408);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(130, 37);
            this.label53.TabIndex = 83;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(1029, 409);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(126, 30);
            this.dtpDueDate.TabIndex = 81;
            this.dtpDueDate.TabStop = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(206, 281);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(27, 22);
            this.label41.TabIndex = 86;
            this.label41.Text = "%";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(206, 326);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(27, 22);
            this.label44.TabIndex = 86;
            this.label44.Text = "%";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Location = new System.Drawing.Point(206, 370);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(27, 22);
            this.label48.TabIndex = 86;
            this.label48.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(204, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 22);
            this.label5.TabIndex = 86;
            this.label5.Text = "%";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.Black;
            this.label54.Location = new System.Drawing.Point(876, 415);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(94, 22);
            this.label54.TabIndex = 84;
            this.label54.Text = "Due Date";
            // 
            // txtTCSPer
            // 
            this.txtTCSPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTCSPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCSPer.Location = new System.Drawing.Point(112, 411);
            this.txtTCSPer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTCSPer.Name = "txtTCSPer";
            this.txtTCSPer.Size = new System.Drawing.Size(84, 30);
            this.txtTCSPer.TabIndex = 85;
            this.txtTCSPer.TabStop = false;
            this.txtTCSPer.Text = "0";
            this.txtTCSPer.TextChanged += new System.EventHandler(this.txtTCSPer_TextChanged);
            this.txtTCSPer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTCSPer_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtTCSPer);
            this.panel4.Controls.Add(this.label54);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label48);
            this.panel4.Controls.Add(this.label44);
            this.panel4.Controls.Add(this.label41);
            this.panel4.Controls.Add(this.dtpDueDate);
            this.panel4.Controls.Add(this.label53);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label46);
            this.panel4.Controls.Add(this.label43);
            this.panel4.Controls.Add(this.label39);
            this.panel4.Controls.Add(this.label49);
            this.panel4.Controls.Add(this.label55);
            this.panel4.Controls.Add(this.label38);
            this.panel4.Controls.Add(this.txtTCS);
            this.panel4.Controls.Add(this.txtIGST);
            this.panel4.Controls.Add(this.txtCGST);
            this.panel4.Controls.Add(this.txtSGST);
            this.panel4.Controls.Add(this.dgv);
            this.panel4.Controls.Add(this.txtNetTotal);
            this.panel4.Controls.Add(this.txtDiscPer);
            this.panel4.Controls.Add(this.txtDiscAmt);
            this.panel4.Controls.Add(this.txtGrossTotal);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.ddlIGST);
            this.panel4.Controls.Add(this.label45);
            this.panel4.Controls.Add(this.ddlCGST);
            this.panel4.Controls.Add(this.label42);
            this.panel4.Controls.Add(this.ddlSGST);
            this.panel4.Controls.Add(this.label40);
            this.panel4.Location = new System.Drawing.Point(0, 477);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1174, 459);
            this.panel4.TabIndex = 72;
            // 
            // rbtnMeter
            // 
            this.rbtnMeter.AutoSize = true;
            this.rbtnMeter.Checked = true;
            this.rbtnMeter.Location = new System.Drawing.Point(84, 65);
            this.rbtnMeter.Name = "rbtnMeter";
            this.rbtnMeter.Size = new System.Drawing.Size(83, 24);
            this.rbtnMeter.TabIndex = 85;
            this.rbtnMeter.TabStop = true;
            this.rbtnMeter.Text = "Meters";
            this.rbtnMeter.UseVisualStyleBackColor = true;
            // 
            // rbtnKG
            // 
            this.rbtnKG.AutoSize = true;
            this.rbtnKG.Location = new System.Drawing.Point(206, 65);
            this.rbtnKG.Name = "rbtnKG";
            this.rbtnKG.Size = new System.Drawing.Size(65, 24);
            this.rbtnKG.TabIndex = 85;
            this.rbtnKG.Text = "KGs";
            this.rbtnKG.UseVisualStyleBackColor = true;
            // 
            // grpUnit
            // 
            this.grpUnit.Location = new System.Drawing.Point(24, 50);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Size = new System.Drawing.Size(274, 51);
            this.grpUnit.TabIndex = 86;
            this.grpUnit.TabStop = false;
            this.grpUnit.Text = "Unit";
            // 
            // SalesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1176, 1049);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SalesDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GST Billing Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.listAllFirmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListAllFirm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAllPartyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListAllParty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlFirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpChallanDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBillGST;
        private System.Windows.Forms.TextBox txtBillState;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBillAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChallanNo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDelGST;
        private System.Windows.Forms.TextBox txtDelState;
        private System.Windows.Forms.TextBox txtDelMobNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDelAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDelTo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtBroker;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtSupplyPlace;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox ddlMode;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DateTimePicker dtpSupplyDate;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox txtBillMobNo;
        private System.Windows.Forms.TextBox txtChequeDate;
        private DatasetList.dsListAllParty dsListAllParty;
        private System.Windows.Forms.BindingSource listAllPartyBindingSource;
        private DatasetList.dsListAllPartyTableAdapters.ListAllPartyTableAdapter listAllPartyTableAdapter;
        private System.Windows.Forms.ComboBox ddlBilledTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private DatasetList.dsListAllFirm dsListAllFirm;
        private System.Windows.Forms.BindingSource listAllFirmBindingSource;
        private DatasetList.dsListAllFirmTableAdapters.ListAllFirmTableAdapter listAllFirmTableAdapter;
        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.RadioButton rbtnKG;
        private System.Windows.Forms.RadioButton rbtnMeter;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox ddlSGST;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox ddlCGST;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox ddlIGST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrossTotal;
        private System.Windows.Forms.TextBox txtDiscAmt;
        private System.Windows.Forms.TextBox txtDiscPer;
        private System.Windows.Forms.TextBox txtNetTotal;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARTICULARS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSNCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAKA;
        private System.Windows.Forms.DataGridViewTextBoxColumn METRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn RATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT;
        private System.Windows.Forms.TextBox txtSGST;
        private System.Windows.Forms.TextBox txtCGST;
        private System.Windows.Forms.TextBox txtIGST;
        private System.Windows.Forms.TextBox txtTCS;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txtTCSPer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox grpUnit;
    }
}
