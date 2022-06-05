namespace Personnel_Accounting_WF
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSourceMain = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMain = new Personnel_Accounting_WF.DataSetMain();
            this.tableAdapterJobPositions = new Personnel_Accounting_WF.DataSetMainTableAdapters.JobPositionsTableAdapter();
            this.bindingSourceStaffTable = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterStaff = new Personnel_Accounting_WF.DataSetMainTableAdapters.StaffTableAdapter();
            this.bindingSourceJobPositionsTable = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxAddInfoFindField = new System.Windows.Forms.TextBox();
            this.labelAddinfoFind = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.labelStaffPositionsTable = new System.Windows.Forms.Label();
            this.labelStaffTable = new System.Windows.Forms.Label();
            this.labelJobPositionsTable = new System.Windows.Forms.Label();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.ColumnSId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewJobPositions = new System.Windows.Forms.DataGridView();
            this.ColumnJPId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJP_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJPAddInfoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDataEditMessages = new System.Windows.Forms.Label();
            this.panelStaffPositions = new System.Windows.Forms.Panel();
            this.buttonResetSPData = new System.Windows.Forms.Button();
            this.buttonCommitChangesSP = new System.Windows.Forms.Button();
            this.dataGridViewStaffPositions = new System.Windows.Forms.DataGridView();
            this.bindingSourceStaffPositionsTable = new System.Windows.Forms.BindingSource(this.components);
            this.panelStaff = new System.Windows.Forms.Panel();
            this.buttonResetSData = new System.Windows.Forms.Button();
            this.buttonCommitChangesS = new System.Windows.Forms.Button();
            this.panelJobPositions = new System.Windows.Forms.Panel();
            this.buttonResetJBData = new System.Windows.Forms.Button();
            this.buttonCommitChangesJP = new System.Windows.Forms.Button();
            this.labelJobPositionFind = new System.Windows.Forms.Label();
            this.panelFind = new System.Windows.Forms.Panel();
            this.comboBoxJobPositionFindField = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonResetFilter = new System.Windows.Forms.Button();
            this.tableAdapterStaffPositions = new Personnel_Accounting_WF.DataSetMainTableAdapters.StaffPositionsTableAdapter();
            this.ColumnSPId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSPStaffId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnSPJobPositionsId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnSPAddInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStaffTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceJobPositionsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobPositions)).BeginInit();
            this.panelStaffPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStaffPositionsTable)).BeginInit();
            this.panelStaff.SuspendLayout();
            this.panelJobPositions.SuspendLayout();
            this.panelFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSourceMain
            // 
            this.bindingSourceMain.DataSource = this.dataSetMain;
            this.bindingSourceMain.Position = 0;
            // 
            // dataSetMain
            // 
            this.dataSetMain.DataSetName = "DataSetMain";
            this.dataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterJobPositions
            // 
            this.tableAdapterJobPositions.ClearBeforeFill = true;
            // 
            // bindingSourceStaffTable
            // 
            this.bindingSourceStaffTable.DataMember = "Staff";
            this.bindingSourceStaffTable.DataSource = this.bindingSourceMain;
            // 
            // tableAdapterStaff
            // 
            this.tableAdapterStaff.ClearBeforeFill = true;
            // 
            // bindingSourceJobPositionsTable
            // 
            this.bindingSourceJobPositionsTable.DataMember = "JobPositions";
            this.bindingSourceJobPositionsTable.DataSource = this.bindingSourceMain;
            // 
            // textBoxAddInfoFindField
            // 
            this.textBoxAddInfoFindField.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBoxAddInfoFindField.Location = new System.Drawing.Point(153, 142);
            this.textBoxAddInfoFindField.Name = "textBoxAddInfoFindField";
            this.textBoxAddInfoFindField.Size = new System.Drawing.Size(147, 26);
            this.textBoxAddInfoFindField.TabIndex = 5;
            // 
            // labelAddinfoFind
            // 
            this.labelAddinfoFind.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddinfoFind.Location = new System.Drawing.Point(3, 145);
            this.labelAddinfoFind.Name = "labelAddinfoFind";
            this.labelAddinfoFind.Size = new System.Drawing.Size(304, 21);
            this.labelAddinfoFind.TabIndex = 6;
            this.labelAddinfoFind.Text = "Additional info";
            // 
            // buttonFind
            // 
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFind.Location = new System.Drawing.Point(7, 187);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(293, 42);
            this.buttonFind.TabIndex = 8;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // labelStaffPositionsTable
            // 
            this.labelStaffPositionsTable.AutoSize = true;
            this.labelStaffPositionsTable.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.labelStaffPositionsTable.Location = new System.Drawing.Point(2, 2);
            this.labelStaffPositionsTable.Name = "labelStaffPositionsTable";
            this.labelStaffPositionsTable.Size = new System.Drawing.Size(190, 22);
            this.labelStaffPositionsTable.TabIndex = 9;
            this.labelStaffPositionsTable.Text = "Staff by positions";
            // 
            // labelStaffTable
            // 
            this.labelStaffTable.AutoSize = true;
            this.labelStaffTable.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.labelStaffTable.Location = new System.Drawing.Point(2, 2);
            this.labelStaffTable.Name = "labelStaffTable";
            this.labelStaffTable.Size = new System.Drawing.Size(60, 22);
            this.labelStaffTable.TabIndex = 9;
            this.labelStaffTable.Text = "Staff";
            // 
            // labelJobPositionsTable
            // 
            this.labelJobPositionsTable.AutoSize = true;
            this.labelJobPositionsTable.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.labelJobPositionsTable.Location = new System.Drawing.Point(3, 2);
            this.labelJobPositionsTable.Name = "labelJobPositionsTable";
            this.labelJobPositionsTable.Size = new System.Drawing.Size(140, 22);
            this.labelJobPositionsTable.TabIndex = 9;
            this.labelJobPositionsTable.Text = "Job positions";
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.AllowUserToOrderColumns = true;
            this.dataGridViewStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStaff.AutoGenerateColumns = false;
            this.dataGridViewStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStaff.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSId,
            this.ColumnSFullName,
            this.ColumnSBirthDate,
            this.ColumnSGender});
            this.dataGridViewStaff.DataSource = this.bindingSourceStaffTable;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStaff.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStaff.Location = new System.Drawing.Point(6, 24);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewStaff.Size = new System.Drawing.Size(499, 241);
            this.dataGridViewStaff.TabIndex = 0;
            // 
            // ColumnSId
            // 
            this.ColumnSId.DataPropertyName = "Id";
            this.ColumnSId.FillWeight = 20F;
            this.ColumnSId.HeaderText = "Id";
            this.ColumnSId.Name = "ColumnSId";
            this.ColumnSId.ReadOnly = true;
            this.ColumnSId.Visible = false;
            // 
            // ColumnSFullName
            // 
            this.ColumnSFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSFullName.DataPropertyName = "FullName";
            this.ColumnSFullName.HeaderText = "FullName";
            this.ColumnSFullName.Name = "ColumnSFullName";
            this.ColumnSFullName.Width = 106;
            // 
            // ColumnSBirthDate
            // 
            this.ColumnSBirthDate.DataPropertyName = "BirthDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.ColumnSBirthDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnSBirthDate.FillWeight = 35F;
            this.ColumnSBirthDate.HeaderText = "BirthDate";
            this.ColumnSBirthDate.Name = "ColumnSBirthDate";
            // 
            // ColumnSGender
            // 
            this.ColumnSGender.DataPropertyName = "Gender";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColumnSGender.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnSGender.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnSGender.DisplayStyleForCurrentCellOnly = true;
            this.ColumnSGender.FillWeight = 35F;
            this.ColumnSGender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColumnSGender.HeaderText = "Gender";
            this.ColumnSGender.Items.AddRange(new object[] {
            "M",
            "W"});
            this.ColumnSGender.Name = "ColumnSGender";
            this.ColumnSGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewJobPositions
            // 
            this.dataGridViewJobPositions.AllowUserToOrderColumns = true;
            this.dataGridViewJobPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewJobPositions.AutoGenerateColumns = false;
            this.dataGridViewJobPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJobPositions.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewJobPositions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJobPositions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewJobPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnJPId,
            this.ColumnJP_name,
            this.ColumnJPAddInfoName});
            this.dataGridViewJobPositions.DataSource = this.bindingSourceJobPositionsTable;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewJobPositions.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewJobPositions.Location = new System.Drawing.Point(7, 24);
            this.dataGridViewJobPositions.Name = "dataGridViewJobPositions";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJobPositions.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewJobPositions.Size = new System.Drawing.Size(460, 241);
            this.dataGridViewJobPositions.TabIndex = 0;
            // 
            // ColumnJPId
            // 
            this.ColumnJPId.DataPropertyName = "Id";
            this.ColumnJPId.FillWeight = 18F;
            this.ColumnJPId.HeaderText = "Id";
            this.ColumnJPId.Name = "ColumnJPId";
            this.ColumnJPId.ReadOnly = true;
            this.ColumnJPId.Visible = false;
            // 
            // ColumnJP_name
            // 
            this.ColumnJP_name.DataPropertyName = "_name";
            this.ColumnJP_name.HeaderText = "Job Positions";
            this.ColumnJP_name.Name = "ColumnJP_name";
            // 
            // ColumnJPAddInfoName
            // 
            this.ColumnJPAddInfoName.DataPropertyName = "AddInfoName";
            this.ColumnJPAddInfoName.HeaderText = "Additional Info Name";
            this.ColumnJPAddInfoName.Name = "ColumnJPAddInfoName";
            // 
            // labelDataEditMessages
            // 
            this.labelDataEditMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDataEditMessages.AutoSize = true;
            this.labelDataEditMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDataEditMessages.Location = new System.Drawing.Point(840, 606);
            this.labelDataEditMessages.Name = "labelDataEditMessages";
            this.labelDataEditMessages.Size = new System.Drawing.Size(0, 17);
            this.labelDataEditMessages.TabIndex = 10;
            // 
            // panelStaffPositions
            // 
            this.panelStaffPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStaffPositions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStaffPositions.Controls.Add(this.buttonResetSPData);
            this.panelStaffPositions.Controls.Add(this.buttonCommitChangesSP);
            this.panelStaffPositions.Controls.Add(this.labelStaffPositionsTable);
            this.panelStaffPositions.Controls.Add(this.dataGridViewStaffPositions);
            this.panelStaffPositions.Location = new System.Drawing.Point(12, 12);
            this.panelStaffPositions.Name = "panelStaffPositions";
            this.panelStaffPositions.Size = new System.Drawing.Size(683, 273);
            this.panelStaffPositions.TabIndex = 11;
            // 
            // buttonResetSPData
            // 
            this.buttonResetSPData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetSPData.BackgroundImage = global::Personnel_Accounting_WF.Properties.Resources.reset;
            this.buttonResetSPData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonResetSPData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetSPData.FlatAppearance.BorderSize = 0;
            this.buttonResetSPData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetSPData.Image = global::Personnel_Accounting_WF.Properties.Resources.reset;
            this.buttonResetSPData.Location = new System.Drawing.Point(647, 2);
            this.buttonResetSPData.Name = "buttonResetSPData";
            this.buttonResetSPData.Size = new System.Drawing.Size(28, 21);
            this.buttonResetSPData.TabIndex = 11;
            this.buttonResetSPData.TabStop = false;
            this.buttonResetSPData.UseVisualStyleBackColor = true;
            this.buttonResetSPData.Click += new System.EventHandler(this.buttonResetSPData_Click);
            // 
            // buttonCommitChangesSP
            // 
            this.buttonCommitChangesSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCommitChangesSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCommitChangesSP.Location = new System.Drawing.Point(554, 238);
            this.buttonCommitChangesSP.Name = "buttonCommitChangesSP";
            this.buttonCommitChangesSP.Size = new System.Drawing.Size(121, 23);
            this.buttonCommitChangesSP.TabIndex = 10;
            this.buttonCommitChangesSP.Text = "Commit changes";
            this.buttonCommitChangesSP.UseVisualStyleBackColor = true;
            this.buttonCommitChangesSP.Click += new System.EventHandler(this.buttonCommitChangesSP_Click);
            // 
            // dataGridViewStaffPositions
            // 
            this.dataGridViewStaffPositions.AllowUserToOrderColumns = true;
            this.dataGridViewStaffPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStaffPositions.AutoGenerateColumns = false;
            this.dataGridViewStaffPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStaffPositions.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewStaffPositions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStaffPositions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewStaffPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaffPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSPId,
            this.ColumnSPStaffId,
            this.ColumnSPJobPositionsId,
            this.ColumnSPAddInfo});
            this.dataGridViewStaffPositions.DataSource = this.bindingSourceStaffPositionsTable;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStaffPositions.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewStaffPositions.Location = new System.Drawing.Point(6, 27);
            this.dataGridViewStaffPositions.Name = "dataGridViewStaffPositions";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStaffPositions.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewStaffPositions.Size = new System.Drawing.Size(669, 205);
            this.dataGridViewStaffPositions.TabIndex = 0;
            // 
            // bindingSourceStaffPositionsTable
            // 
            this.bindingSourceStaffPositionsTable.DataMember = "StaffPositions";
            this.bindingSourceStaffPositionsTable.DataSource = this.bindingSourceMain;
            // 
            // panelStaff
            // 
            this.panelStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStaff.Controls.Add(this.buttonResetSData);
            this.panelStaff.Controls.Add(this.buttonCommitChangesS);
            this.panelStaff.Controls.Add(this.dataGridViewStaff);
            this.panelStaff.Controls.Add(this.labelStaffTable);
            this.panelStaff.Location = new System.Drawing.Point(12, 296);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(515, 304);
            this.panelStaff.TabIndex = 12;
            // 
            // buttonResetSData
            // 
            this.buttonResetSData.BackgroundImage = global::Personnel_Accounting_WF.Properties.Resources.reset;
            this.buttonResetSData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonResetSData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetSData.FlatAppearance.BorderSize = 0;
            this.buttonResetSData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetSData.Image = global::Personnel_Accounting_WF.Properties.Resources.reset;
            this.buttonResetSData.Location = new System.Drawing.Point(474, 2);
            this.buttonResetSData.Name = "buttonResetSData";
            this.buttonResetSData.Size = new System.Drawing.Size(31, 21);
            this.buttonResetSData.TabIndex = 11;
            this.buttonResetSData.TabStop = false;
            this.buttonResetSData.UseVisualStyleBackColor = true;
            this.buttonResetSData.Click += new System.EventHandler(this.buttonResetSData_Click);
            // 
            // buttonCommitChangesS
            // 
            this.buttonCommitChangesS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCommitChangesS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCommitChangesS.Location = new System.Drawing.Point(384, 271);
            this.buttonCommitChangesS.Name = "buttonCommitChangesS";
            this.buttonCommitChangesS.Size = new System.Drawing.Size(121, 23);
            this.buttonCommitChangesS.TabIndex = 10;
            this.buttonCommitChangesS.Text = "Commit changes";
            this.buttonCommitChangesS.UseVisualStyleBackColor = true;
            this.buttonCommitChangesS.Click += new System.EventHandler(this.buttonCommitChangesS_Click);
            // 
            // panelJobPositions
            // 
            this.panelJobPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelJobPositions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelJobPositions.Controls.Add(this.buttonResetJBData);
            this.panelJobPositions.Controls.Add(this.buttonCommitChangesJP);
            this.panelJobPositions.Controls.Add(this.labelJobPositionsTable);
            this.panelJobPositions.Controls.Add(this.dataGridViewJobPositions);
            this.panelJobPositions.Location = new System.Drawing.Point(539, 296);
            this.panelJobPositions.Name = "panelJobPositions";
            this.panelJobPositions.Size = new System.Drawing.Size(477, 304);
            this.panelJobPositions.TabIndex = 13;
            // 
            // buttonResetJBData
            // 
            this.buttonResetJBData.BackgroundImage = global::Personnel_Accounting_WF.Properties.Resources.reset;
            this.buttonResetJBData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonResetJBData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetJBData.FlatAppearance.BorderSize = 0;
            this.buttonResetJBData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetJBData.Image = global::Personnel_Accounting_WF.Properties.Resources.reset;
            this.buttonResetJBData.Location = new System.Drawing.Point(439, 2);
            this.buttonResetJBData.Name = "buttonResetJBData";
            this.buttonResetJBData.Size = new System.Drawing.Size(28, 21);
            this.buttonResetJBData.TabIndex = 11;
            this.buttonResetJBData.TabStop = false;
            this.buttonResetJBData.UseVisualStyleBackColor = true;
            this.buttonResetJBData.Click += new System.EventHandler(this.buttonResetJBData_Click);
            // 
            // buttonCommitChangesJP
            // 
            this.buttonCommitChangesJP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCommitChangesJP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCommitChangesJP.Location = new System.Drawing.Point(346, 271);
            this.buttonCommitChangesJP.Name = "buttonCommitChangesJP";
            this.buttonCommitChangesJP.Size = new System.Drawing.Size(121, 23);
            this.buttonCommitChangesJP.TabIndex = 10;
            this.buttonCommitChangesJP.Text = "Commit changes";
            this.buttonCommitChangesJP.UseVisualStyleBackColor = true;
            this.buttonCommitChangesJP.Click += new System.EventHandler(this.buttonCommitChangesJP_Click);
            // 
            // labelJobPositionFind
            // 
            this.labelJobPositionFind.AutoSize = true;
            this.labelJobPositionFind.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJobPositionFind.Location = new System.Drawing.Point(3, 107);
            this.labelJobPositionFind.Name = "labelJobPositionFind";
            this.labelJobPositionFind.Size = new System.Drawing.Size(117, 19);
            this.labelJobPositionFind.TabIndex = 6;
            this.labelJobPositionFind.Text = "Job position";
            // 
            // panelFind
            // 
            this.panelFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFind.Controls.Add(this.comboBoxJobPositionFindField);
            this.panelFind.Controls.Add(this.label4);
            this.panelFind.Controls.Add(this.buttonResetFilter);
            this.panelFind.Controls.Add(this.buttonFind);
            this.panelFind.Controls.Add(this.textBoxAddInfoFindField);
            this.panelFind.Controls.Add(this.labelAddinfoFind);
            this.panelFind.Controls.Add(this.labelJobPositionFind);
            this.panelFind.Location = new System.Drawing.Point(706, 12);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(310, 273);
            this.panelFind.TabIndex = 14;
            // 
            // comboBoxJobPositionFindField
            // 
            this.comboBoxJobPositionFindField.BackColor = System.Drawing.Color.Azure;
            this.comboBoxJobPositionFindField.DataSource = this.bindingSourceJobPositionsTable;
            this.comboBoxJobPositionFindField.DisplayMember = "_name";
            this.comboBoxJobPositionFindField.Font = new System.Drawing.Font("Consolas", 12F);
            this.comboBoxJobPositionFindField.FormattingEnabled = true;
            this.comboBoxJobPositionFindField.Location = new System.Drawing.Point(153, 104);
            this.comboBoxJobPositionFindField.Name = "comboBoxJobPositionFindField";
            this.comboBoxJobPositionFindField.Size = new System.Drawing.Size(147, 27);
            this.comboBoxJobPositionFindField.TabIndex = 10;
            this.comboBoxJobPositionFindField.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 56);
            this.label4.TabIndex = 9;
            this.label4.Text = "Find Staff by Positions and additional info";
            // 
            // buttonResetFilter
            // 
            this.buttonResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetFilter.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.buttonResetFilter.Location = new System.Drawing.Point(7, 235);
            this.buttonResetFilter.Name = "buttonResetFilter";
            this.buttonResetFilter.Size = new System.Drawing.Size(293, 23);
            this.buttonResetFilter.TabIndex = 8;
            this.buttonResetFilter.Text = "reset";
            this.buttonResetFilter.UseVisualStyleBackColor = true;
            this.buttonResetFilter.Click += new System.EventHandler(this.buttonResetFilter_Click);
            // 
            // tableAdapterStaffPositions
            // 
            this.tableAdapterStaffPositions.ClearBeforeFill = true;
            // 
            // ColumnSPId
            // 
            this.ColumnSPId.DataPropertyName = "Id";
            this.ColumnSPId.HeaderText = "Id";
            this.ColumnSPId.Name = "ColumnSPId";
            this.ColumnSPId.ReadOnly = true;
            this.ColumnSPId.Visible = false;
            // 
            // ColumnSPStaffId
            // 
            this.ColumnSPStaffId.DataPropertyName = "StaffId";
            this.ColumnSPStaffId.DataSource = this.bindingSourceStaffTable;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnSPStaffId.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnSPStaffId.DisplayMember = "FullName";
            this.ColumnSPStaffId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnSPStaffId.DisplayStyleForCurrentCellOnly = true;
            this.ColumnSPStaffId.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColumnSPStaffId.HeaderText = "Staff";
            this.ColumnSPStaffId.Name = "ColumnSPStaffId";
            this.ColumnSPStaffId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSPStaffId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnSPStaffId.ValueMember = "Id";
            // 
            // ColumnSPJobPositionsId
            // 
            this.ColumnSPJobPositionsId.DataPropertyName = "JobPositionsId";
            this.ColumnSPJobPositionsId.DataSource = this.bindingSourceJobPositionsTable;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnSPJobPositionsId.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnSPJobPositionsId.DisplayMember = "_name";
            this.ColumnSPJobPositionsId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnSPJobPositionsId.DisplayStyleForCurrentCellOnly = true;
            this.ColumnSPJobPositionsId.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColumnSPJobPositionsId.HeaderText = "Job Position";
            this.ColumnSPJobPositionsId.Name = "ColumnSPJobPositionsId";
            this.ColumnSPJobPositionsId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSPJobPositionsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnSPJobPositionsId.ValueMember = "Id";
            // 
            // ColumnSPAddInfo
            // 
            this.ColumnSPAddInfo.DataPropertyName = "AddInfo";
            this.ColumnSPAddInfo.HeaderText = "Additional Info";
            this.ColumnSPAddInfo.Name = "ColumnSPAddInfo";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1028, 626);
            this.Controls.Add(this.panelFind);
            this.Controls.Add(this.panelJobPositions);
            this.Controls.Add(this.panelStaff);
            this.Controls.Add(this.panelStaffPositions);
            this.Controls.Add(this.labelDataEditMessages);
            this.Name = "FormMain";
            this.Text = "Personnel Accounting";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStaffTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceJobPositionsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobPositions)).EndInit();
            this.panelStaffPositions.ResumeLayout(false);
            this.panelStaffPositions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStaffPositionsTable)).EndInit();
            this.panelStaff.ResumeLayout(false);
            this.panelStaff.PerformLayout();
            this.panelJobPositions.ResumeLayout(false);
            this.panelJobPositions.PerformLayout();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceMain;
        private DataSetMain dataSetMain;
        private DataSetMainTableAdapters.TableAdapterDataTableFormMain tableAdapterDataTableFormMain;
        private DataSetMainTableAdapters.JobPositionsTableAdapter tableAdapterJobPositions;
        private System.Windows.Forms.BindingSource bindingSourceStaffTable;
        private DataSetMainTableAdapters.StaffTableAdapter tableAdapterStaff;
        private System.Windows.Forms.BindingSource bindingSourceJobPositionsTable;
        private System.Windows.Forms.TextBox textBoxAddInfoFindField;
        private System.Windows.Forms.Label labelAddinfoFind;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label labelStaffPositionsTable;
        private System.Windows.Forms.Label labelStaffTable;
        private System.Windows.Forms.Label labelJobPositionsTable;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewJobPositions;
        private System.Windows.Forms.Label labelDataEditMessages;
        private System.Windows.Forms.Panel panelStaffPositions;
        private System.Windows.Forms.Panel panelStaff;
        private System.Windows.Forms.Panel panelJobPositions;
        private System.Windows.Forms.Label labelJobPositionFind;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.Label label4;
        private DataSetMainTableAdapters.StaffPositionsTableAdapter tableAdapterStaffPositions;
        private System.Windows.Forms.ComboBox comboBoxJobPositionFindField;
        private System.Windows.Forms.Button buttonResetFilter;
        private System.Windows.Forms.Button buttonCommitChangesS;
        private System.Windows.Forms.Button buttonCommitChangesJP;
        private System.Windows.Forms.Button buttonResetSPData;
        private System.Windows.Forms.Button buttonResetSData;
        private System.Windows.Forms.Button buttonResetJBData;
        private System.Windows.Forms.DataGridView dataGridViewStaffPositions;
        private System.Windows.Forms.BindingSource bindingSourceStaffPositionsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSBirthDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnSGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJPId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJP_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJPAddInfoName;
        private System.Windows.Forms.Button buttonCommitChangesSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSPId;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnSPStaffId;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnSPJobPositionsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSPAddInfo;
    }
}

