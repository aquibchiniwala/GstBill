namespace GSTBill
{
    partial class PurchaseDetail
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
            this.label23 = new System.Windows.Forms.Label();
            this.dtpChallanDate = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtChallanNo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlSupplier = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label48 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtIGST = new System.Windows.Forms.TextBox();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtNetTotal = new System.Windows.Forms.TextBox();
            this.txtDiscPer = new System.Windows.Forms.TextBox();
            this.txtDiscAmt = new System.Windows.Forms.TextBox();
            this.txtGrossTotal = new System.Windows.Forms.TextBox();
            this.ddlIGST = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.ddlCGST = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.ddlSGST = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARTICULARS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSNCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BALE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.METRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsListAllSupplier = new GSTBill.DatasetList.dsListAllSupplier();
            this.listAllSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listAllSupplierTableAdapter = new GSTBill.DatasetList.dsListAllSupplierTableAdapters.ListAllSupplierTableAdapter();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListAllSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllSupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(569, 56);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 15);
            this.label23.TabIndex = 95;
            this.label23.Text = "Challan Date";
            // 
            // dtpChallanDate
            // 
            this.dtpChallanDate.CustomFormat = "dd/MM/yyyy";
            this.dtpChallanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChallanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChallanDate.Location = new System.Drawing.Point(663, 54);
            this.dtpChallanDate.Name = "dtpChallanDate";
            this.dtpChallanDate.Size = new System.Drawing.Size(86, 23);
            this.dtpChallanDate.TabIndex = 87;
            // 
            // label24
            // 
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Location = new System.Drawing.Point(662, 53);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 26);
            this.label24.TabIndex = 96;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(195, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 15);
            this.label21.TabIndex = 93;
            this.label21.Text = "Invoice Date";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(289, 54);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(86, 23);
            this.dtpInvoiceDate.TabIndex = 85;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(288, 53);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 26);
            this.label22.TabIndex = 94;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(12, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 15);
            this.label19.TabIndex = 89;
            this.label19.Text = "Invoice No.";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(101, 54);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(88, 23);
            this.txtInvoiceNo.TabIndex = 84;
            this.txtInvoiceNo.TextChanged += new System.EventHandler(this.txtInvoiceNo_TextChanged);
            // 
            // txtChallanNo
            // 
            this.txtChallanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChallanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallanNo.Location = new System.Drawing.Point(475, 54);
            this.txtChallanNo.Name = "txtChallanNo";
            this.txtChallanNo.Size = new System.Drawing.Size(88, 23);
            this.txtChallanNo.TabIndex = 86;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(382, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 15);
            this.label20.TabIndex = 91;
            this.label20.Text = "Challan No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 69;
            this.label2.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(101, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(649, 25);
            this.label4.TabIndex = 71;
            // 
            // ddlSupplier
            // 
            this.ddlSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlSupplier.DataSource = this.listAllSupplierBindingSource;
            this.ddlSupplier.DisplayMember = "SupplierName";
            this.ddlSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSupplier.FormattingEnabled = true;
            this.ddlSupplier.Location = new System.Drawing.Point(103, 21);
            this.ddlSupplier.Name = "ddlSupplier";
            this.ddlSupplier.Size = new System.Drawing.Size(646, 23);
            this.ddlSupplier.TabIndex = 0;
            this.ddlSupplier.ValueMember = "SupplierID";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(5, 98);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(73, 13);
            this.label47.TabIndex = 98;
            this.label47.Text = "Goods Details";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label48);
            this.panel4.Controls.Add(this.label44);
            this.panel4.Controls.Add(this.label41);
            this.panel4.Controls.Add(this.label46);
            this.panel4.Controls.Add(this.label43);
            this.panel4.Controls.Add(this.label39);
            this.panel4.Controls.Add(this.label49);
            this.panel4.Controls.Add(this.label55);
            this.panel4.Controls.Add(this.label38);
            this.panel4.Controls.Add(this.txtIGST);
            this.panel4.Controls.Add(this.txtCGST);
            this.panel4.Controls.Add(this.txtSGST);
            this.panel4.Controls.Add(this.dgv);
            this.panel4.Controls.Add(this.txtNetTotal);
            this.panel4.Controls.Add(this.txtDiscPer);
            this.panel4.Controls.Add(this.txtDiscAmt);
            this.panel4.Controls.Add(this.txtGrossTotal);
            this.panel4.Controls.Add(this.ddlIGST);
            this.panel4.Controls.Add(this.label45);
            this.panel4.Controls.Add(this.ddlCGST);
            this.panel4.Controls.Add(this.label42);
            this.panel4.Controls.Add(this.ddlSGST);
            this.panel4.Controls.Add(this.label40);
            this.panel4.Location = new System.Drawing.Point(0, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(783, 299);
            this.panel4.TabIndex = 97;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Location = new System.Drawing.Point(137, 270);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(19, 15);
            this.label48.TabIndex = 86;
            this.label48.Text = "%";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(137, 241);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(19, 15);
            this.label44.TabIndex = 86;
            this.label44.Text = "%";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(137, 212);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(19, 15);
            this.label41.TabIndex = 86;
            this.label41.Text = "%";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.Black;
            this.label46.Location = new System.Drawing.Point(16, 269);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(50, 15);
            this.label46.TabIndex = 86;
            this.label46.Text = "+ IGST";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(16, 240);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(55, 15);
            this.label43.TabIndex = 86;
            this.label43.Text = "+ CGST";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(16, 211);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(55, 15);
            this.label39.TabIndex = 86;
            this.label39.Text = "+ SGST";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(583, 271);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(81, 15);
            this.label49.TabIndex = 86;
            this.label49.Text = "Net Amount";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(583, 242);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(44, 15);
            this.label55.TabIndex = 86;
            this.label55.Text = "- Disc";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(583, 214);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(96, 15);
            this.label38.TabIndex = 86;
            this.label38.Text = "Gross Amount";
            // 
            // txtIGST
            // 
            this.txtIGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGST.Location = new System.Drawing.Point(161, 267);
            this.txtIGST.Name = "txtIGST";
            this.txtIGST.ReadOnly = true;
            this.txtIGST.Size = new System.Drawing.Size(86, 23);
            this.txtIGST.TabIndex = 60;
            this.txtIGST.TabStop = false;
            this.txtIGST.Text = "0";
            // 
            // txtCGST
            // 
            this.txtCGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGST.Location = new System.Drawing.Point(161, 238);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.ReadOnly = true;
            this.txtCGST.Size = new System.Drawing.Size(86, 23);
            this.txtCGST.TabIndex = 60;
            this.txtCGST.TabStop = false;
            this.txtCGST.Text = "0";
            // 
            // txtSGST
            // 
            this.txtSGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGST.Location = new System.Drawing.Point(161, 209);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.ReadOnly = true;
            this.txtSGST.Size = new System.Drawing.Size(86, 23);
            this.txtSGST.TabIndex = 60;
            this.txtSGST.TabStop = false;
            this.txtSGST.Text = "0";
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
            this.UOM,
            this.GRADE,
            this.BALE,
            this.METRES,
            this.RATE,
            this.AMOUNT});
            this.dgv.Location = new System.Drawing.Point(12, 8);
            this.dgv.Name = "dgv";
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(759, 195);
            this.dgv.TabIndex = 8;
            this.dgv.TabStop = false;
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.BackColor = System.Drawing.Color.LightGreen;
            this.txtNetTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetTotal.ForeColor = System.Drawing.Color.Black;
            this.txtNetTotal.Location = new System.Drawing.Point(685, 268);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.ReadOnly = true;
            this.txtNetTotal.Size = new System.Drawing.Size(86, 23);
            this.txtNetTotal.TabIndex = 85;
            this.txtNetTotal.TabStop = false;
            this.txtNetTotal.Text = "0";
            // 
            // txtDiscPer
            // 
            this.txtDiscPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDiscPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscPer.ForeColor = System.Drawing.Color.Black;
            this.txtDiscPer.Location = new System.Drawing.Point(633, 239);
            this.txtDiscPer.Name = "txtDiscPer";
            this.txtDiscPer.Size = new System.Drawing.Size(46, 23);
            this.txtDiscPer.TabIndex = 111;
            this.txtDiscPer.TabStop = false;
            this.txtDiscPer.Text = "0";
            this.txtDiscPer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscPer_KeyPress);
            // 
            // txtDiscAmt
            // 
            this.txtDiscAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDiscAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscAmt.ForeColor = System.Drawing.Color.Black;
            this.txtDiscAmt.Location = new System.Drawing.Point(685, 240);
            this.txtDiscAmt.Name = "txtDiscAmt";
            this.txtDiscAmt.ReadOnly = true;
            this.txtDiscAmt.Size = new System.Drawing.Size(86, 23);
            this.txtDiscAmt.TabIndex = 85;
            this.txtDiscAmt.TabStop = false;
            this.txtDiscAmt.Text = "0";
            // 
            // txtGrossTotal
            // 
            this.txtGrossTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtGrossTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrossTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossTotal.ForeColor = System.Drawing.Color.Black;
            this.txtGrossTotal.Location = new System.Drawing.Point(685, 211);
            this.txtGrossTotal.Name = "txtGrossTotal";
            this.txtGrossTotal.ReadOnly = true;
            this.txtGrossTotal.Size = new System.Drawing.Size(86, 23);
            this.txtGrossTotal.TabIndex = 85;
            this.txtGrossTotal.TabStop = false;
            this.txtGrossTotal.Text = "0";
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
            "9",
            "12",
            "18"});
            this.ddlIGST.Location = new System.Drawing.Point(77, 267);
            this.ddlIGST.Name = "ddlIGST";
            this.ddlIGST.Size = new System.Drawing.Size(54, 23);
            this.ddlIGST.TabIndex = 17;
            this.ddlIGST.TabStop = false;
            // 
            // label45
            // 
            this.label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label45.Location = new System.Drawing.Point(75, 266);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(57, 25);
            this.label45.TabIndex = 79;
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
            "9",
            "12",
            "18"});
            this.ddlCGST.Location = new System.Drawing.Point(77, 238);
            this.ddlCGST.Name = "ddlCGST";
            this.ddlCGST.Size = new System.Drawing.Size(54, 23);
            this.ddlCGST.TabIndex = 16;
            this.ddlCGST.TabStop = false;
            // 
            // label42
            // 
            this.label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label42.Location = new System.Drawing.Point(75, 237);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(57, 25);
            this.label42.TabIndex = 79;
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
            "9",
            "12",
            "18"});
            this.ddlSGST.Location = new System.Drawing.Point(77, 209);
            this.ddlSGST.Name = "ddlSGST";
            this.ddlSGST.Size = new System.Drawing.Size(54, 23);
            this.ddlSGST.TabIndex = 15;
            this.ddlSGST.TabStop = false;
            // 
            // label40
            // 
            this.label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label40.Location = new System.Drawing.Point(75, 208);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(57, 25);
            this.label40.TabIndex = 79;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 80);
            this.panel1.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Supplier Details";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrint.Location = new System.Drawing.Point(246, 411);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(133, 23);
            this.btnPrint.TabIndex = 113;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "Save Print(Ctrl+A)";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(385, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 23);
            this.btnSave.TabIndex = 114;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save Only(Ctrl+S)";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // SNO
            // 
            this.SNO.HeaderText = "SNO";
            this.SNO.Name = "SNO";
            this.SNO.ReadOnly = true;
            this.SNO.Width = 40;
            // 
            // PARTICULARS
            // 
            this.PARTICULARS.HeaderText = "PARTICULARS";
            this.PARTICULARS.Name = "PARTICULARS";
            this.PARTICULARS.Width = 280;
            // 
            // HSNCODE
            // 
            this.HSNCODE.HeaderText = "HSNCODE";
            this.HSNCODE.Name = "HSNCODE";
            // 
            // UOM
            // 
            this.UOM.HeaderText = "UOM";
            this.UOM.Name = "UOM";
            this.UOM.Width = 50;
            // 
            // GRADE
            // 
            this.GRADE.HeaderText = "GRADE";
            this.GRADE.Name = "GRADE";
            this.GRADE.Width = 70;
            // 
            // BALE
            // 
            this.BALE.HeaderText = "NO & DESC OF BALE";
            this.BALE.Name = "BALE";
            this.BALE.Width = 50;
            // 
            // METRES
            // 
            this.METRES.HeaderText = "TOTAL QTY";
            this.METRES.Name = "METRES";
            this.METRES.Width = 70;
            // 
            // RATE
            // 
            this.RATE.HeaderText = "RATE";
            this.RATE.Name = "RATE";
            this.RATE.Width = 70;
            // 
            // AMOUNT
            // 
            this.AMOUNT.HeaderText = "AMOUNT";
            this.AMOUNT.Name = "AMOUNT";
            // 
            // dsListAllSupplier
            // 
            this.dsListAllSupplier.DataSetName = "dsListAllSupplier";
            this.dsListAllSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listAllSupplierBindingSource
            // 
            this.listAllSupplierBindingSource.DataMember = "ListAllSupplier";
            this.listAllSupplierBindingSource.DataSource = this.dsListAllSupplier;
            // 
            // listAllSupplierTableAdapter
            // 
            this.listAllSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // PurchaseDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(784, 434);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.ddlSupplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpChallanDate);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.txtChallanNo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseDetail";
            this.Text = "PurchaseDetail";
            this.Load += new System.EventHandler(this.PurchaseDetail_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListAllSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAllSupplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpChallanDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.TextBox txtChallanNo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlSupplier;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtIGST;
        private System.Windows.Forms.TextBox txtCGST;
        private System.Windows.Forms.TextBox txtSGST;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtNetTotal;
        private System.Windows.Forms.TextBox txtDiscPer;
        private System.Windows.Forms.TextBox txtDiscAmt;
        private System.Windows.Forms.TextBox txtGrossTotal;
        private System.Windows.Forms.ComboBox ddlIGST;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox ddlCGST;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox ddlSGST;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARTICULARS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSNCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BALE;
        private System.Windows.Forms.DataGridViewTextBoxColumn METRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn RATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT;
        private DatasetList.dsListAllSupplier dsListAllSupplier;
        private System.Windows.Forms.BindingSource listAllSupplierBindingSource;
        private DatasetList.dsListAllSupplierTableAdapters.ListAllSupplierTableAdapter listAllSupplierTableAdapter;
    }
}