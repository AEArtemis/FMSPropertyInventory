
namespace FMSPropertyInventory
{
    partial class frmLandInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgLandInventory = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxPropertyKind = new System.Windows.Forms.ComboBox();
            this.cboxModeOfProcurement = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPropertyDescription = new System.Windows.Forms.TextBox();
            this.dgLandInventorySupplementary = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDateAcquired = new System.Windows.Forms.Label();
            this.lbAppraisedValue = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbRemarks = new System.Windows.Forms.Label();
            this.lbDonor = new System.Windows.Forms.Label();
            this.txtBoxPropertyLocation = new System.Windows.Forms.TextBox();
            this.lbNameTag = new System.Windows.Forms.Label();
            this.lbPurpose = new System.Windows.Forms.Label();
            this.txtBoxPropertyArea = new System.Windows.Forms.TextBox();
            this.txtBoxDateAcquired = new System.Windows.Forms.TextBox();
            this.txtBoxPurpose = new System.Windows.Forms.TextBox();
            this.txtBoxRemarks = new System.Windows.Forms.TextBox();
            this.txtBoxAppraisedValue = new System.Windows.Forms.TextBox();
            this.cboxStatus = new System.Windows.Forms.ComboBox();
            this.cboxNameTag = new System.Windows.Forms.ComboBox();
            this.txtBoxDonor = new System.Windows.Forms.TextBox();
            this.lbPropValue = new System.Windows.Forms.Label();
            this.lb2ndRemarks = new System.Windows.Forms.Label();
            this.txtBoxPropValue = new System.Windows.Forms.TextBox();
            this.txtBox2ndRemarks = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSEdit = new System.Windows.Forms.Button();
            this.btnSAdd = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionOfProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAcquired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppraisedValuePerSqm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLandInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLandInventorySupplementary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLandInventory
            // 
            this.dgLandInventory.AllowUserToAddRows = false;
            this.dgLandInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLandInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLandInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLandInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Kind,
            this.DescriptionOfProperty,
            this.Location,
            this.Area,
            this.name,
            this.DateAcquired,
            this.mop,
            this.Purpose,
            this.AppraisedValuePerSqm,
            this.status,
            this.nametag,
            this.Remarks});
            this.dgLandInventory.Location = new System.Drawing.Point(15, 16);
            this.dgLandInventory.Name = "dgLandInventory";
            this.dgLandInventory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLandInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgLandInventory.RowHeadersVisible = false;
            this.dgLandInventory.Size = new System.Drawing.Size(640, 343);
            this.dgLandInventory.TabIndex = 100;
            this.dgLandInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLandInventory_CellClick);
            this.dgLandInventory.SelectionChanged += new System.EventHandler(this.dgLandInventory_SelectionChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(557, 582);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 40);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(239, 582);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 40);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(345, 582);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 40);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(451, 582);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 40);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 149;
            this.label3.Text = "Property Kind";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 150;
            this.label4.Text = "Mode of Procurement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 151;
            // 
            // cboxPropertyKind
            // 
            this.cboxPropertyKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPropertyKind.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPropertyKind.FormattingEnabled = true;
            this.cboxPropertyKind.Location = new System.Drawing.Point(162, 373);
            this.cboxPropertyKind.Name = "cboxPropertyKind";
            this.cboxPropertyKind.Size = new System.Drawing.Size(162, 26);
            this.cboxPropertyKind.TabIndex = 1;
            this.cboxPropertyKind.SelectedIndexChanged += new System.EventHandler(this.cboxPropertyKind_SelectedIndexChanged);
            // 
            // cboxModeOfProcurement
            // 
            this.cboxModeOfProcurement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxModeOfProcurement.Enabled = false;
            this.cboxModeOfProcurement.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxModeOfProcurement.FormattingEnabled = true;
            this.cboxModeOfProcurement.Location = new System.Drawing.Point(162, 406);
            this.cboxModeOfProcurement.Name = "cboxModeOfProcurement";
            this.cboxModeOfProcurement.Size = new System.Drawing.Size(162, 26);
            this.cboxModeOfProcurement.TabIndex = 2;
            this.cboxModeOfProcurement.SelectedIndexChanged += new System.EventHandler(this.cboxModeOfProcurement_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 154;
            this.label1.Text = "Property Description";
            // 
            // txtBoxPropertyDescription
            // 
            this.txtBoxPropertyDescription.Enabled = false;
            this.txtBoxPropertyDescription.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPropertyDescription.Location = new System.Drawing.Point(162, 439);
            this.txtBoxPropertyDescription.Name = "txtBoxPropertyDescription";
            this.txtBoxPropertyDescription.Size = new System.Drawing.Size(493, 26);
            this.txtBoxPropertyDescription.TabIndex = 3;
            // 
            // dgLandInventorySupplementary
            // 
            this.dgLandInventorySupplementary.AllowUserToAddRows = false;
            this.dgLandInventorySupplementary.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLandInventorySupplementary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgLandInventorySupplementary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLandInventorySupplementary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgLandInventorySupplementary.Location = new System.Drawing.Point(692, 16);
            this.dgLandInventorySupplementary.Name = "dgLandInventorySupplementary";
            this.dgLandInventorySupplementary.ReadOnly = true;
            this.dgLandInventorySupplementary.RowHeadersVisible = false;
            this.dgLandInventorySupplementary.Size = new System.Drawing.Size(280, 343);
            this.dgLandInventorySupplementary.TabIndex = 101;
            this.dgLandInventorySupplementary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLandInventorySupplementary_CellClick);
            this.dgLandInventorySupplementary.SelectionChanged += new System.EventHandler(this.dgLandInventorySupplementary_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 157;
            this.label6.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(352, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 158;
            this.label7.Text = "Area (Sq.m)";
            // 
            // lbDateAcquired
            // 
            this.lbDateAcquired.AutoSize = true;
            this.lbDateAcquired.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateAcquired.Location = new System.Drawing.Point(352, 409);
            this.lbDateAcquired.Name = "lbDateAcquired";
            this.lbDateAcquired.Size = new System.Drawing.Size(96, 18);
            this.lbDateAcquired.TabIndex = 159;
            this.lbDateAcquired.Text = "Date Acquired";
            // 
            // lbAppraisedValue
            // 
            this.lbAppraisedValue.AutoSize = true;
            this.lbAppraisedValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppraisedValue.Location = new System.Drawing.Point(308, 506);
            this.lbAppraisedValue.Name = "lbAppraisedValue";
            this.lbAppraisedValue.Size = new System.Drawing.Size(161, 18);
            this.lbAppraisedValue.TabIndex = 161;
            this.lbAppraisedValue.Text = "Appraised value per sqm";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(12, 506);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(46, 18);
            this.lbStatus.TabIndex = 162;
            this.lbStatus.Text = "Status";
            // 
            // lbRemarks
            // 
            this.lbRemarks.AutoSize = true;
            this.lbRemarks.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemarks.Location = new System.Drawing.Point(308, 538);
            this.lbRemarks.Name = "lbRemarks";
            this.lbRemarks.Size = new System.Drawing.Size(61, 18);
            this.lbRemarks.TabIndex = 163;
            this.lbRemarks.Text = "Remarks";
            // 
            // lbDonor
            // 
            this.lbDonor.AutoSize = true;
            this.lbDonor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonor.Location = new System.Drawing.Point(352, 409);
            this.lbDonor.Name = "lbDonor";
            this.lbDonor.Size = new System.Drawing.Size(46, 18);
            this.lbDonor.TabIndex = 164;
            this.lbDonor.Text = "Donor";
            this.lbDonor.Visible = false;
            // 
            // txtBoxPropertyLocation
            // 
            this.txtBoxPropertyLocation.Enabled = false;
            this.txtBoxPropertyLocation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPropertyLocation.Location = new System.Drawing.Point(93, 471);
            this.txtBoxPropertyLocation.Name = "txtBoxPropertyLocation";
            this.txtBoxPropertyLocation.Size = new System.Drawing.Size(562, 26);
            this.txtBoxPropertyLocation.TabIndex = 4;
            // 
            // lbNameTag
            // 
            this.lbNameTag.AutoSize = true;
            this.lbNameTag.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameTag.Location = new System.Drawing.Point(308, 506);
            this.lbNameTag.Name = "lbNameTag";
            this.lbNameTag.Size = new System.Drawing.Size(68, 18);
            this.lbNameTag.TabIndex = 166;
            this.lbNameTag.Text = "Name Tag";
            this.lbNameTag.Visible = false;
            // 
            // lbPurpose
            // 
            this.lbPurpose.AutoSize = true;
            this.lbPurpose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPurpose.Location = new System.Drawing.Point(12, 538);
            this.lbPurpose.Name = "lbPurpose";
            this.lbPurpose.Size = new System.Drawing.Size(59, 18);
            this.lbPurpose.TabIndex = 167;
            this.lbPurpose.Text = "Purpose";
            // 
            // txtBoxPropertyArea
            // 
            this.txtBoxPropertyArea.Enabled = false;
            this.txtBoxPropertyArea.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPropertyArea.Location = new System.Drawing.Point(454, 373);
            this.txtBoxPropertyArea.Name = "txtBoxPropertyArea";
            this.txtBoxPropertyArea.Size = new System.Drawing.Size(201, 26);
            this.txtBoxPropertyArea.TabIndex = 5;
            // 
            // txtBoxDateAcquired
            // 
            this.txtBoxDateAcquired.Enabled = false;
            this.txtBoxDateAcquired.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDateAcquired.Location = new System.Drawing.Point(463, 406);
            this.txtBoxDateAcquired.Name = "txtBoxDateAcquired";
            this.txtBoxDateAcquired.Size = new System.Drawing.Size(162, 26);
            this.txtBoxDateAcquired.TabIndex = 7;
            // 
            // txtBoxPurpose
            // 
            this.txtBoxPurpose.Enabled = false;
            this.txtBoxPurpose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPurpose.Location = new System.Drawing.Point(93, 535);
            this.txtBoxPurpose.Name = "txtBoxPurpose";
            this.txtBoxPurpose.Size = new System.Drawing.Size(209, 26);
            this.txtBoxPurpose.TabIndex = 11;
            // 
            // txtBoxRemarks
            // 
            this.txtBoxRemarks.Enabled = false;
            this.txtBoxRemarks.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRemarks.Location = new System.Drawing.Point(392, 535);
            this.txtBoxRemarks.Name = "txtBoxRemarks";
            this.txtBoxRemarks.Size = new System.Drawing.Size(263, 26);
            this.txtBoxRemarks.TabIndex = 12;
            // 
            // txtBoxAppraisedValue
            // 
            this.txtBoxAppraisedValue.Enabled = false;
            this.txtBoxAppraisedValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAppraisedValue.Location = new System.Drawing.Point(475, 503);
            this.txtBoxAppraisedValue.Name = "txtBoxAppraisedValue";
            this.txtBoxAppraisedValue.Size = new System.Drawing.Size(180, 26);
            this.txtBoxAppraisedValue.TabIndex = 10;
            // 
            // cboxStatus
            // 
            this.cboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStatus.Enabled = false;
            this.cboxStatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxStatus.FormattingEnabled = true;
            this.cboxStatus.Location = new System.Drawing.Point(93, 503);
            this.cboxStatus.Name = "cboxStatus";
            this.cboxStatus.Size = new System.Drawing.Size(209, 26);
            this.cboxStatus.TabIndex = 8;
            // 
            // cboxNameTag
            // 
            this.cboxNameTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNameTag.Enabled = false;
            this.cboxNameTag.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNameTag.FormattingEnabled = true;
            this.cboxNameTag.Location = new System.Drawing.Point(392, 503);
            this.cboxNameTag.Name = "cboxNameTag";
            this.cboxNameTag.Size = new System.Drawing.Size(263, 26);
            this.cboxNameTag.TabIndex = 9;
            this.cboxNameTag.Visible = false;
            // 
            // txtBoxDonor
            // 
            this.txtBoxDonor.Enabled = false;
            this.txtBoxDonor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDonor.Location = new System.Drawing.Point(454, 406);
            this.txtBoxDonor.Name = "txtBoxDonor";
            this.txtBoxDonor.Size = new System.Drawing.Size(201, 26);
            this.txtBoxDonor.TabIndex = 6;
            // 
            // lbPropValue
            // 
            this.lbPropValue.AutoSize = true;
            this.lbPropValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPropValue.Location = new System.Drawing.Point(689, 376);
            this.lbPropValue.Name = "lbPropValue";
            this.lbPropValue.Size = new System.Drawing.Size(100, 18);
            this.lbPropValue.TabIndex = 179;
            this.lbPropValue.Text = "Property Value";
            // 
            // lb2ndRemarks
            // 
            this.lb2ndRemarks.AutoSize = true;
            this.lb2ndRemarks.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2ndRemarks.Location = new System.Drawing.Point(689, 409);
            this.lb2ndRemarks.Name = "lb2ndRemarks";
            this.lb2ndRemarks.Size = new System.Drawing.Size(61, 18);
            this.lb2ndRemarks.TabIndex = 180;
            this.lb2ndRemarks.Text = "Remarks";
            // 
            // txtBoxPropValue
            // 
            this.txtBoxPropValue.Enabled = false;
            this.txtBoxPropValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPropValue.Location = new System.Drawing.Point(793, 373);
            this.txtBoxPropValue.Name = "txtBoxPropValue";
            this.txtBoxPropValue.Size = new System.Drawing.Size(178, 26);
            this.txtBoxPropValue.TabIndex = 14;
            // 
            // txtBox2ndRemarks
            // 
            this.txtBox2ndRemarks.Enabled = false;
            this.txtBox2ndRemarks.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2ndRemarks.Location = new System.Drawing.Point(767, 406);
            this.txtBox2ndRemarks.Name = "txtBox2ndRemarks";
            this.txtBox2ndRemarks.Size = new System.Drawing.Size(204, 26);
            this.txtBox2ndRemarks.TabIndex = 15;
            // 
            // btnSDelete
            // 
            this.btnSDelete.Enabled = false;
            this.btnSDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.btnSDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSDelete.Location = new System.Drawing.Point(891, 452);
            this.btnSDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnSDelete.Name = "btnSDelete";
            this.btnSDelete.Size = new System.Drawing.Size(80, 40);
            this.btnSDelete.TabIndex = 183;
            this.btnSDelete.Text = "Delete";
            this.btnSDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSDelete.UseVisualStyleBackColor = true;
            this.btnSDelete.Click += new System.EventHandler(this.btnSDelete_Click);
            // 
            // btnSEdit
            // 
            this.btnSEdit.Enabled = false;
            this.btnSEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSEdit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.btnSEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSEdit.Location = new System.Drawing.Point(803, 452);
            this.btnSEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSEdit.Name = "btnSEdit";
            this.btnSEdit.Size = new System.Drawing.Size(80, 40);
            this.btnSEdit.TabIndex = 182;
            this.btnSEdit.Text = "Edit";
            this.btnSEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSEdit.UseVisualStyleBackColor = true;
            this.btnSEdit.Click += new System.EventHandler(this.btnSEdit_Click);
            // 
            // btnSAdd
            // 
            this.btnSAdd.Enabled = false;
            this.btnSAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.btnSAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSAdd.Location = new System.Drawing.Point(715, 452);
            this.btnSAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnSAdd.Name = "btnSAdd";
            this.btnSAdd.Size = new System.Drawing.Size(80, 40);
            this.btnSAdd.TabIndex = 181;
            this.btnSAdd.Text = "Add";
            this.btnSAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSAdd.UseVisualStyleBackColor = true;
            this.btnSAdd.Click += new System.EventHandler(this.btnSAdd_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // Kind
            // 
            this.Kind.HeaderText = "KIND";
            this.Kind.Name = "Kind";
            this.Kind.ReadOnly = true;
            this.Kind.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Kind.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DescriptionOfProperty
            // 
            this.DescriptionOfProperty.HeaderText = "DESCRIPTION OF PROPERTY";
            this.DescriptionOfProperty.Name = "DescriptionOfProperty";
            this.DescriptionOfProperty.ReadOnly = true;
            this.DescriptionOfProperty.Width = 200;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Area
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Area.DefaultCellStyle = dataGridViewCellStyle2;
            this.Area.HeaderText = "AREA (Sq.m.)";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // DateAcquired
            // 
            this.DateAcquired.HeaderText = "Date Acquired";
            this.DateAcquired.Name = "DateAcquired";
            this.DateAcquired.ReadOnly = true;
            // 
            // mop
            // 
            this.mop.HeaderText = "MODE OF PROCUREMENT";
            this.mop.Name = "mop";
            this.mop.ReadOnly = true;
            this.mop.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Purpose
            // 
            this.Purpose.HeaderText = "Purpose";
            this.Purpose.Name = "Purpose";
            this.Purpose.ReadOnly = true;
            // 
            // AppraisedValuePerSqm
            // 
            this.AppraisedValuePerSqm.HeaderText = "Appraised value per sqm";
            this.AppraisedValuePerSqm.Name = "AppraisedValuePerSqm";
            this.AppraisedValuePerSqm.ReadOnly = true;
            this.AppraisedValuePerSqm.Width = 120;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nametag
            // 
            this.nametag.HeaderText = "NAME_TAG";
            this.nametag.Name = "nametag";
            this.nametag.ReadOnly = true;
            this.nametag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nametag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "prop_inv_id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Book Value";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Remarks";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // frmLandInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 635);
            this.Controls.Add(this.btnSDelete);
            this.Controls.Add(this.btnSEdit);
            this.Controls.Add(this.btnSAdd);
            this.Controls.Add(this.txtBox2ndRemarks);
            this.Controls.Add(this.txtBoxPropValue);
            this.Controls.Add(this.lb2ndRemarks);
            this.Controls.Add(this.lbPropValue);
            this.Controls.Add(this.txtBoxDonor);
            this.Controls.Add(this.cboxNameTag);
            this.Controls.Add(this.cboxStatus);
            this.Controls.Add(this.txtBoxAppraisedValue);
            this.Controls.Add(this.txtBoxRemarks);
            this.Controls.Add(this.txtBoxPurpose);
            this.Controls.Add(this.txtBoxDateAcquired);
            this.Controls.Add(this.txtBoxPropertyArea);
            this.Controls.Add(this.lbPurpose);
            this.Controls.Add(this.lbNameTag);
            this.Controls.Add(this.txtBoxPropertyLocation);
            this.Controls.Add(this.lbDonor);
            this.Controls.Add(this.lbRemarks);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbAppraisedValue);
            this.Controls.Add(this.lbDateAcquired);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgLandInventorySupplementary);
            this.Controls.Add(this.txtBoxPropertyDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxModeOfProcurement);
            this.Controls.Add(this.cboxPropertyKind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgLandInventory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLandInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real Property Inventory";
            this.Load += new System.EventHandler(this.frmLandInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLandInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLandInventorySupplementary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgLandInventory;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxPropertyKind;
        private System.Windows.Forms.ComboBox cboxModeOfProcurement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPropertyDescription;
        private System.Windows.Forms.DataGridView dgLandInventorySupplementary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDateAcquired;
        private System.Windows.Forms.Label lbAppraisedValue;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbRemarks;
        private System.Windows.Forms.Label lbDonor;
        private System.Windows.Forms.TextBox txtBoxPropertyLocation;
        private System.Windows.Forms.Label lbNameTag;
        private System.Windows.Forms.Label lbPurpose;
        private System.Windows.Forms.TextBox txtBoxPropertyArea;
        private System.Windows.Forms.TextBox txtBoxDateAcquired;
        private System.Windows.Forms.TextBox txtBoxPurpose;
        private System.Windows.Forms.TextBox txtBoxRemarks;
        private System.Windows.Forms.TextBox txtBoxAppraisedValue;
        private System.Windows.Forms.ComboBox cboxStatus;
        private System.Windows.Forms.ComboBox cboxNameTag;
        private System.Windows.Forms.TextBox txtBoxDonor;
        private System.Windows.Forms.Label lbPropValue;
        private System.Windows.Forms.Label lb2ndRemarks;
        private System.Windows.Forms.TextBox txtBoxPropValue;
        private System.Windows.Forms.TextBox txtBox2ndRemarks;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSEdit;
        private System.Windows.Forms.Button btnSAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionOfProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAcquired;
        private System.Windows.Forms.DataGridViewTextBoxColumn mop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppraisedValuePerSqm;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

