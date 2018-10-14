namespace MakingLinqEasyMultipleJoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pAYMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARTICIPANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRIPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataModelSample = new MakingLinqEasyMultipleJoin.DataModelSample();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewLinqResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPAYMENT = new System.Windows.Forms.DataGridView();
            this.pAIDVALUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPARTICIPANTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPARTICIPANT = new System.Windows.Forms.DataGridView();
            this.iDTRIPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_OF_PARTICIPANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMBER_OF_PAYMENTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTRIP = new System.Windows.Forms.DataGridView();
            this.iDTRIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMBEROFPARTICIPANTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESTINATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTripleJoin = new System.Windows.Forms.Button();
            this.btnSimpleJoin = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataModelSample)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinqResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPAYMENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPARTICIPANT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTRIP)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.richTextBox1.Size = new System.Drawing.Size(800, 102);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pAYMENTBindingSource
            // 
            this.pAYMENTBindingSource.DataMember = "PARTICIPANT_PAYMENT";
            this.pAYMENTBindingSource.DataSource = this.pARTICIPANTBindingSource;
            // 
            // pARTICIPANTBindingSource
            // 
            this.pARTICIPANTBindingSource.DataMember = "TRIP_PARTICIPANT";
            this.pARTICIPANTBindingSource.DataSource = this.tRIPBindingSource;
            // 
            // tRIPBindingSource
            // 
            this.tRIPBindingSource.DataMember = "TRIP";
            this.tRIPBindingSource.DataSource = this.dataModelSample;
            this.tRIPBindingSource.Filter = "";
            // 
            // dataModelSample
            // 
            this.dataModelSample.DataSetName = "DataModelSample";
            this.dataModelSample.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 441);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewLinqResult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(334, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 62);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Linq results (use buttons to see results)";
            // 
            // dataGridViewLinqResult
            // 
            this.dataGridViewLinqResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLinqResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLinqResult.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewLinqResult.Name = "dataGridViewLinqResult";
            this.dataGridViewLinqResult.Size = new System.Drawing.Size(460, 43);
            this.dataGridViewLinqResult.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewPAYMENT);
            this.groupBox1.Controls.Add(this.dataGridViewPARTICIPANT);
            this.groupBox1.Controls.Add(this.dataGridViewTRIP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(334, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 379);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master/detail representation";
            // 
            // dataGridViewPAYMENT
            // 
            this.dataGridViewPAYMENT.AutoGenerateColumns = false;
            this.dataGridViewPAYMENT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPAYMENT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPAYMENT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pAIDVALUEDataGridViewTextBoxColumn,
            this.iDPARTICIPANTDataGridViewTextBoxColumn});
            this.dataGridViewPAYMENT.DataSource = this.pAYMENTBindingSource;
            this.dataGridViewPAYMENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPAYMENT.Location = new System.Drawing.Point(3, 256);
            this.dataGridViewPAYMENT.Name = "dataGridViewPAYMENT";
            this.dataGridViewPAYMENT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPAYMENT.Size = new System.Drawing.Size(460, 120);
            this.dataGridViewPAYMENT.TabIndex = 16;
            // 
            // pAIDVALUEDataGridViewTextBoxColumn
            // 
            this.pAIDVALUEDataGridViewTextBoxColumn.DataPropertyName = "PAID_VALUE";
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = "0";
            this.pAIDVALUEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.pAIDVALUEDataGridViewTextBoxColumn.HeaderText = "$ Paid Value";
            this.pAIDVALUEDataGridViewTextBoxColumn.Name = "pAIDVALUEDataGridViewTextBoxColumn";
            this.pAIDVALUEDataGridViewTextBoxColumn.Width = 92;
            // 
            // iDPARTICIPANTDataGridViewTextBoxColumn
            // 
            this.iDPARTICIPANTDataGridViewTextBoxColumn.DataPropertyName = "ID_PARTICIPANT";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iDPARTICIPANTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.iDPARTICIPANTDataGridViewTextBoxColumn.HeaderText = "Id Participant";
            this.iDPARTICIPANTDataGridViewTextBoxColumn.Name = "iDPARTICIPANTDataGridViewTextBoxColumn";
            this.iDPARTICIPANTDataGridViewTextBoxColumn.Width = 94;
            // 
            // dataGridViewPARTICIPANT
            // 
            this.dataGridViewPARTICIPANT.AutoGenerateColumns = false;
            this.dataGridViewPARTICIPANT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPARTICIPANT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPARTICIPANT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTRIPDataGridViewTextBoxColumn1,
            this.Column1,
            this.NAME_OF_PARTICIPANT,
            this.NUMBER_OF_PAYMENTS});
            this.dataGridViewPARTICIPANT.DataSource = this.pARTICIPANTBindingSource;
            this.dataGridViewPARTICIPANT.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewPARTICIPANT.Location = new System.Drawing.Point(3, 136);
            this.dataGridViewPARTICIPANT.Name = "dataGridViewPARTICIPANT";
            this.dataGridViewPARTICIPANT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewPARTICIPANT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPARTICIPANT.Size = new System.Drawing.Size(460, 120);
            this.dataGridViewPARTICIPANT.TabIndex = 15;
            // 
            // iDTRIPDataGridViewTextBoxColumn1
            // 
            this.iDTRIPDataGridViewTextBoxColumn1.DataPropertyName = "ID_TRIP";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iDTRIPDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            this.iDTRIPDataGridViewTextBoxColumn1.HeaderText = "Id Trip";
            this.iDTRIPDataGridViewTextBoxColumn1.Name = "iDTRIPDataGridViewTextBoxColumn1";
            this.iDTRIPDataGridViewTextBoxColumn1.Width = 58;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_PARTICIPANT";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column1.HeaderText = "Id Participant";
            this.Column1.Name = "Column1";
            this.Column1.Width = 87;
            // 
            // NAME_OF_PARTICIPANT
            // 
            this.NAME_OF_PARTICIPANT.DataPropertyName = "NAME_OF_PARTICIPANT";
            this.NAME_OF_PARTICIPANT.HeaderText = "Participant name";
            this.NAME_OF_PARTICIPANT.Name = "NAME_OF_PARTICIPANT";
            this.NAME_OF_PARTICIPANT.Width = 102;
            // 
            // NUMBER_OF_PAYMENTS
            // 
            this.NUMBER_OF_PAYMENTS.DataPropertyName = "NUMBER_OF_PAYMENTS";
            this.NUMBER_OF_PAYMENTS.HeaderText = "Number of Payments";
            this.NUMBER_OF_PAYMENTS.Name = "NUMBER_OF_PAYMENTS";
            this.NUMBER_OF_PAYMENTS.Width = 119;
            // 
            // dataGridViewTRIP
            // 
            this.dataGridViewTRIP.AutoGenerateColumns = false;
            this.dataGridViewTRIP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTRIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTRIP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTRIPDataGridViewTextBoxColumn,
            this.nUMBEROFPARTICIPANTSDataGridViewTextBoxColumn,
            this.DESTINATION});
            this.dataGridViewTRIP.DataSource = this.tRIPBindingSource;
            this.dataGridViewTRIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewTRIP.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewTRIP.Name = "dataGridViewTRIP";
            this.dataGridViewTRIP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewTRIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTRIP.Size = new System.Drawing.Size(460, 120);
            this.dataGridViewTRIP.TabIndex = 14;
            // 
            // iDTRIPDataGridViewTextBoxColumn
            // 
            this.iDTRIPDataGridViewTextBoxColumn.DataPropertyName = "ID_TRIP";
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iDTRIPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.iDTRIPDataGridViewTextBoxColumn.HeaderText = "Id Trip";
            this.iDTRIPDataGridViewTextBoxColumn.Name = "iDTRIPDataGridViewTextBoxColumn";
            this.iDTRIPDataGridViewTextBoxColumn.Width = 58;
            // 
            // nUMBEROFPARTICIPANTSDataGridViewTextBoxColumn
            // 
            this.nUMBEROFPARTICIPANTSDataGridViewTextBoxColumn.DataPropertyName = "NUMBER_OF_PARTICIPANTS";
            this.nUMBEROFPARTICIPANTSDataGridViewTextBoxColumn.HeaderText = "Number of Participants";
            this.nUMBEROFPARTICIPANTSDataGridViewTextBoxColumn.Name = "nUMBEROFPARTICIPANTSDataGridViewTextBoxColumn";
            this.nUMBEROFPARTICIPANTSDataGridViewTextBoxColumn.Width = 127;
            // 
            // DESTINATION
            // 
            this.DESTINATION.DataPropertyName = "DESTINATION";
            this.DESTINATION.HeaderText = "Destination";
            this.DESTINATION.Name = "DESTINATION";
            this.DESTINATION.Width = 85;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(331, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 441);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 441);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTripleJoin);
            this.panel3.Controls.Add(this.btnSimpleJoin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 83);
            this.panel3.TabIndex = 1;
            // 
            // btnTripleJoin
            // 
            this.btnTripleJoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTripleJoin.Location = new System.Drawing.Point(12, 43);
            this.btnTripleJoin.Name = "btnTripleJoin";
            this.btnTripleJoin.Size = new System.Drawing.Size(301, 23);
            this.btnTripleJoin.TabIndex = 4;
            this.btnTripleJoin.Text = "Join + Group By ( 3 tables )";
            this.btnTripleJoin.UseVisualStyleBackColor = true;
            this.btnTripleJoin.Click += new System.EventHandler(this.btnTripleJoin_Click);
            // 
            // btnSimpleJoin
            // 
            this.btnSimpleJoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSimpleJoin.Location = new System.Drawing.Point(12, 14);
            this.btnSimpleJoin.Name = "btnSimpleJoin";
            this.btnSimpleJoin.Size = new System.Drawing.Size(301, 23);
            this.btnSimpleJoin.TabIndex = 3;
            this.btnSimpleJoin.Text = "Simple Join ( 3 tables )";
            this.btnSimpleJoin.UseVisualStyleBackColor = true;
            this.btnSimpleJoin.Click += new System.EventHandler(this.btnSimpleJoin_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 358);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Model representation (picture)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 339);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FormMain";
            this.Text = "Making Linq Easy Multiple Join";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTICIPANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataModelSample)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinqResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPAYMENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPARTICIPANT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTRIP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DataModelSample dataModelSample;
        private System.Windows.Forms.BindingSource pARTICIPANTBindingSource;
        private System.Windows.Forms.BindingSource tRIPBindingSource;
        private System.Windows.Forms.BindingSource pAYMENTBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTripleJoin;
        private System.Windows.Forms.Button btnSimpleJoin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewLinqResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewPAYMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAIDVALUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPARTICIPANTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewPARTICIPANT;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTRIPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_OF_PARTICIPANT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMBER_OF_PAYMENTS;
        private System.Windows.Forms.DataGridView dataGridViewTRIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTRIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMBEROFPARTICIPANTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESTINATION;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

