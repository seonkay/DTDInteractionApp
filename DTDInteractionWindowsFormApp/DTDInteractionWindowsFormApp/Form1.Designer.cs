using System;

namespace DTDInteractionWindowsFormApp
{
    partial class Form1
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
            this.rxNormCodesBox = new System.Windows.Forms.TextBox();
            this.responseBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.medicationListBox = new System.Windows.Forms.TextBox();
            this.patientIDBox = new System.Windows.Forms.TextBox();
            this.findDTDIAllButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fIRSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRTHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEATHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRIVERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSPORTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREFIXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUFFIXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAIDENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARITALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rACEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTHNICITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRTHPLACEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.syntheticMassDataSet = new DTDInteractionWindowsFormApp.SyntheticMassDataSet();
            this.patientsTableAdapter = new DTDInteractionWindowsFormApp.SyntheticMassDataSetTableAdapters.patientsTableAdapter();
            this.displayQueryResultLabel = new System.Windows.Forms.Label();
            this.totalNumberLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rxNormCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugInteractionExist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syntheticMassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // rxNormCodesBox
            // 
            this.rxNormCodesBox.Location = new System.Drawing.Point(182, 603);
            this.rxNormCodesBox.Name = "rxNormCodesBox";
            this.rxNormCodesBox.Size = new System.Drawing.Size(355, 20);
            this.rxNormCodesBox.TabIndex = 0;
            // 
            // responseBox
            // 
            this.responseBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.responseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseBox.Location = new System.Drawing.Point(182, 633);
            this.responseBox.Multiline = true;
            this.responseBox.Name = "responseBox";
            this.responseBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.responseBox.Size = new System.Drawing.Size(710, 111);
            this.responseBox.TabIndex = 1;
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.Location = new System.Drawing.Point(558, 597);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(209, 30);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Drung Interaction Check!";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "RxNorm Code(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 631);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Response";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Medications";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patient ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(377, 460);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(108, 26);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search!";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // medicationListBox
            // 
            this.medicationListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationListBox.Location = new System.Drawing.Point(182, 494);
            this.medicationListBox.Multiline = true;
            this.medicationListBox.Name = "medicationListBox";
            this.medicationListBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.medicationListBox.Size = new System.Drawing.Size(428, 80);
            this.medicationListBox.TabIndex = 6;
            this.medicationListBox.WordWrap = false;
            // 
            // patientIDBox
            // 
            this.patientIDBox.Location = new System.Drawing.Point(182, 466);
            this.patientIDBox.Name = "patientIDBox";
            this.patientIDBox.Size = new System.Drawing.Size(174, 20);
            this.patientIDBox.TabIndex = 5;
            // 
            // findDTDIAllButton
            // 
            this.findDTDIAllButton.Location = new System.Drawing.Point(39, 19);
            this.findDTDIAllButton.Name = "findDTDIAllButton";
            this.findDTDIAllButton.Size = new System.Drawing.Size(185, 26);
            this.findDTDIAllButton.TabIndex = 11;
            this.findDTDIAllButton.Text = "Find DTD Interaction";
            this.findDTDIAllButton.UseVisualStyleBackColor = true;
            this.findDTDIAllButton.Click += new System.EventHandler(this.findDTDIAllButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIRSTDataGridViewTextBoxColumn,
            this.lASTDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.bIRTHDATEDataGridViewTextBoxColumn,
            this.dEATHDATEDataGridViewTextBoxColumn,
            this.sSNDataGridViewTextBoxColumn,
            this.dRIVERSDataGridViewTextBoxColumn,
            this.pASSPORTDataGridViewTextBoxColumn,
            this.pREFIXDataGridViewTextBoxColumn,
            this.sUFFIXDataGridViewTextBoxColumn,
            this.mAIDENDataGridViewTextBoxColumn,
            this.mARITALDataGridViewTextBoxColumn,
            this.rACEDataGridViewTextBoxColumn,
            this.eTHNICITYDataGridViewTextBoxColumn,
            this.gENDERDataGridViewTextBoxColumn,
            this.bIRTHPLACEDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // fIRSTDataGridViewTextBoxColumn
            // 
            this.fIRSTDataGridViewTextBoxColumn.DataPropertyName = "FIRST";
            this.fIRSTDataGridViewTextBoxColumn.HeaderText = "FIRST";
            this.fIRSTDataGridViewTextBoxColumn.Name = "fIRSTDataGridViewTextBoxColumn";
            // 
            // lASTDataGridViewTextBoxColumn
            // 
            this.lASTDataGridViewTextBoxColumn.DataPropertyName = "LAST";
            this.lASTDataGridViewTextBoxColumn.HeaderText = "LAST";
            this.lASTDataGridViewTextBoxColumn.Name = "lASTDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // bIRTHDATEDataGridViewTextBoxColumn
            // 
            this.bIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "BIRTHDATE";
            this.bIRTHDATEDataGridViewTextBoxColumn.HeaderText = "BIRTHDATE";
            this.bIRTHDATEDataGridViewTextBoxColumn.Name = "bIRTHDATEDataGridViewTextBoxColumn";
            // 
            // dEATHDATEDataGridViewTextBoxColumn
            // 
            this.dEATHDATEDataGridViewTextBoxColumn.DataPropertyName = "DEATHDATE";
            this.dEATHDATEDataGridViewTextBoxColumn.HeaderText = "DEATHDATE";
            this.dEATHDATEDataGridViewTextBoxColumn.Name = "dEATHDATEDataGridViewTextBoxColumn";
            // 
            // sSNDataGridViewTextBoxColumn
            // 
            this.sSNDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn.Name = "sSNDataGridViewTextBoxColumn";
            // 
            // dRIVERSDataGridViewTextBoxColumn
            // 
            this.dRIVERSDataGridViewTextBoxColumn.DataPropertyName = "DRIVERS";
            this.dRIVERSDataGridViewTextBoxColumn.HeaderText = "DRIVERS";
            this.dRIVERSDataGridViewTextBoxColumn.Name = "dRIVERSDataGridViewTextBoxColumn";
            // 
            // pASSPORTDataGridViewTextBoxColumn
            // 
            this.pASSPORTDataGridViewTextBoxColumn.DataPropertyName = "PASSPORT";
            this.pASSPORTDataGridViewTextBoxColumn.HeaderText = "PASSPORT";
            this.pASSPORTDataGridViewTextBoxColumn.Name = "pASSPORTDataGridViewTextBoxColumn";
            // 
            // pREFIXDataGridViewTextBoxColumn
            // 
            this.pREFIXDataGridViewTextBoxColumn.DataPropertyName = "PREFIX";
            this.pREFIXDataGridViewTextBoxColumn.HeaderText = "PREFIX";
            this.pREFIXDataGridViewTextBoxColumn.Name = "pREFIXDataGridViewTextBoxColumn";
            // 
            // sUFFIXDataGridViewTextBoxColumn
            // 
            this.sUFFIXDataGridViewTextBoxColumn.DataPropertyName = "SUFFIX";
            this.sUFFIXDataGridViewTextBoxColumn.HeaderText = "SUFFIX";
            this.sUFFIXDataGridViewTextBoxColumn.Name = "sUFFIXDataGridViewTextBoxColumn";
            // 
            // mAIDENDataGridViewTextBoxColumn
            // 
            this.mAIDENDataGridViewTextBoxColumn.DataPropertyName = "MAIDEN";
            this.mAIDENDataGridViewTextBoxColumn.HeaderText = "MAIDEN";
            this.mAIDENDataGridViewTextBoxColumn.Name = "mAIDENDataGridViewTextBoxColumn";
            // 
            // mARITALDataGridViewTextBoxColumn
            // 
            this.mARITALDataGridViewTextBoxColumn.DataPropertyName = "MARITAL";
            this.mARITALDataGridViewTextBoxColumn.HeaderText = "MARITAL";
            this.mARITALDataGridViewTextBoxColumn.Name = "mARITALDataGridViewTextBoxColumn";
            // 
            // rACEDataGridViewTextBoxColumn
            // 
            this.rACEDataGridViewTextBoxColumn.DataPropertyName = "RACE";
            this.rACEDataGridViewTextBoxColumn.HeaderText = "RACE";
            this.rACEDataGridViewTextBoxColumn.Name = "rACEDataGridViewTextBoxColumn";
            // 
            // eTHNICITYDataGridViewTextBoxColumn
            // 
            this.eTHNICITYDataGridViewTextBoxColumn.DataPropertyName = "ETHNICITY";
            this.eTHNICITYDataGridViewTextBoxColumn.HeaderText = "ETHNICITY";
            this.eTHNICITYDataGridViewTextBoxColumn.Name = "eTHNICITYDataGridViewTextBoxColumn";
            // 
            // gENDERDataGridViewTextBoxColumn
            // 
            this.gENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.HeaderText = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.Name = "gENDERDataGridViewTextBoxColumn";
            // 
            // bIRTHPLACEDataGridViewTextBoxColumn
            // 
            this.bIRTHPLACEDataGridViewTextBoxColumn.DataPropertyName = "BIRTHPLACE";
            this.bIRTHPLACEDataGridViewTextBoxColumn.HeaderText = "BIRTHPLACE";
            this.bIRTHPLACEDataGridViewTextBoxColumn.Name = "bIRTHPLACEDataGridViewTextBoxColumn";
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.syntheticMassDataSet;
            // 
            // syntheticMassDataSet
            // 
            this.syntheticMassDataSet.DataSetName = "SyntheticMassDataSet";
            this.syntheticMassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // displayQueryResultLabel
            // 
            this.displayQueryResultLabel.AutoSize = true;
            this.displayQueryResultLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.displayQueryResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayQueryResultLabel.Location = new System.Drawing.Point(40, 240);
            this.displayQueryResultLabel.Name = "displayQueryResultLabel";
            this.displayQueryResultLabel.Size = new System.Drawing.Size(390, 16);
            this.displayQueryResultLabel.TabIndex = 13;
            this.displayQueryResultLabel.Text = "Total Number of Patients with Drug To Drug Interactions";
            // 
            // totalNumberLabel
            // 
            this.totalNumberLabel.AutoSize = true;
            this.totalNumberLabel.BackColor = System.Drawing.SystemColors.Info;
            this.totalNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumberLabel.Location = new System.Drawing.Point(448, 240);
            this.totalNumberLabel.Name = "totalNumberLabel";
            this.totalNumberLabel.Size = new System.Drawing.Size(102, 16);
            this.totalNumberLabel.TabIndex = 14;
            this.totalNumberLabel.Text = "Total Number";
            this.totalNumberLabel.Click += new System.EventHandler(this.totalNumberLable_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.pID,
            this.rxNormCode,
            this.drugInteractionExist});
            this.dataGridView2.Location = new System.Drawing.Point(39, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(850, 177);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // index
            // 
            this.index.HeaderText = "ID";
            this.index.Name = "index";
            this.index.Width = 40;
            // 
            // pID
            // 
            this.pID.HeaderText = "Patient ID";
            this.pID.Name = "pID";
            this.pID.Width = 280;
            // 
            // rxNormCode
            // 
            this.rxNormCode.HeaderText = "RxNorm Code";
            this.rxNormCode.Name = "rxNormCode";
            this.rxNormCode.Width = 280;
            // 
            // drugInteractionExist
            // 
            this.drugInteractionExist.HeaderText = "Drug Interaction";
            this.drugInteractionExist.Name = "drugInteractionExist";
            this.drugInteractionExist.Width = 190;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(501, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Please click the button to chek drug to drug interaction for whole patients in th" +
    "e SyntheticMass Data Set ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Drug Interactions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 756);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.totalNumberLabel);
            this.Controls.Add(this.displayQueryResultLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.findDTDIAllButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.medicationListBox);
            this.Controls.Add(this.patientIDBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.rxNormCodesBox);
            this.Name = "Form1";
            this.Text = "Drug To Drug Interaction Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syntheticMassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox rxNormCodesBox;
        private System.Windows.Forms.TextBox responseBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox medicationListBox;
        private System.Windows.Forms.TextBox patientIDBox;
        private System.Windows.Forms.Button findDTDIAllButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SyntheticMassDataSet syntheticMassDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private SyntheticMassDataSetTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRTHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEATHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRIVERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSPORTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREFIXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUFFIXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAIDENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARITALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTHNICITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRTHPLACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label displayQueryResultLabel;
        private System.Windows.Forms.Label totalNumberLabel;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn pID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rxNormCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugInteractionExist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

