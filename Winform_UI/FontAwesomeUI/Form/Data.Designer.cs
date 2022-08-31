namespace FontAwesomeUI
{
    partial class Data
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.ObjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExperimentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1688, 952);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grdData, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1688, 952);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grdData
            // 
            this.grdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObjectID,
            this.Datetime,
            this.ExperimentName,
            this.value1,
            this.value2,
            this.value3,
            this.value4,
            this.value5,
            this.value6,
            this.value7,
            this.value8,
            this.value9,
            this.value10,
            this.value11,
            this.value12});
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.grdData.Location = new System.Drawing.Point(3, 145);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowTemplate.Height = 23;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(1682, 804);
            this.grdData.TabIndex = 0;
            // 
            // ObjectID
            // 
            this.ObjectID.HeaderText = "식별번호";
            this.ObjectID.Name = "ObjectID";
            this.ObjectID.ReadOnly = true;
            this.ObjectID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ObjectID.Visible = false;
            // 
            // Datetime
            // 
            this.Datetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Datetime.HeaderText = "시간";
            this.Datetime.Name = "Datetime";
            this.Datetime.ReadOnly = true;
            this.Datetime.Width = 54;
            // 
            // ExperimentName
            // 
            this.ExperimentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ExperimentName.HeaderText = "실험명";
            this.ExperimentName.Name = "ExperimentName";
            this.ExperimentName.ReadOnly = true;
            this.ExperimentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ExperimentName.Width = 47;
            // 
            // value1
            // 
            this.value1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value1.HeaderText = "용탕온도";
            this.value1.Name = "value1";
            this.value1.ReadOnly = true;
            this.value1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // value2
            // 
            this.value2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value2.HeaderText = "턴디쉬온도";
            this.value2.Name = "value2";
            this.value2.ReadOnly = true;
            this.value2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // value3
            // 
            this.value3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value3.HeaderText = "상부챔버온도";
            this.value3.Name = "value3";
            this.value3.ReadOnly = true;
            this.value3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // value4
            // 
            this.value4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value4.HeaderText = "하부챔버온도";
            this.value4.Name = "value4";
            this.value4.ReadOnly = true;
            this.value4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // value5
            // 
            this.value5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value5.HeaderText = "배기라인온도";
            this.value5.Name = "value5";
            this.value5.ReadOnly = true;
            this.value5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // value6
            // 
            this.value6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value6.HeaderText = "고압압력";
            this.value6.Name = "value6";
            this.value6.ReadOnly = true;
            this.value6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // value7
            // 
            this.value7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value7.HeaderText = "상부챔버압력";
            this.value7.Name = "value7";
            this.value7.ReadOnly = true;
            this.value7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // value8
            // 
            this.value8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value8.HeaderText = "하부챔버압력";
            this.value8.Name = "value8";
            this.value8.ReadOnly = true;
            this.value8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // value9
            // 
            this.value9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value9.HeaderText = "배기라인압력";
            this.value9.Name = "value9";
            this.value9.ReadOnly = true;
            this.value9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // value10
            // 
            this.value10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value10.HeaderText = "고진공";
            this.value10.Name = "value10";
            this.value10.ReadOnly = true;
            this.value10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // value11
            // 
            this.value11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value11.HeaderText = "상부진공";
            this.value11.Name = "value11";
            this.value11.ReadOnly = true;
            this.value11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // value12
            // 
            this.value12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value12.HeaderText = "하부진공";
            this.value12.Name = "value12";
            this.value12.ReadOnly = true;
            this.value12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 952);
            this.Controls.Add(this.panel1);
            this.Name = "Data";
            this.Text = "Data";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExperimentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn value1;
        private System.Windows.Forms.DataGridViewTextBoxColumn value2;
        private System.Windows.Forms.DataGridViewTextBoxColumn value3;
        private System.Windows.Forms.DataGridViewTextBoxColumn value4;
        private System.Windows.Forms.DataGridViewTextBoxColumn value5;
        private System.Windows.Forms.DataGridViewTextBoxColumn value6;
        private System.Windows.Forms.DataGridViewTextBoxColumn value7;
        private System.Windows.Forms.DataGridViewTextBoxColumn value8;
        private System.Windows.Forms.DataGridViewTextBoxColumn value9;
        private System.Windows.Forms.DataGridViewTextBoxColumn value10;
        private System.Windows.Forms.DataGridViewTextBoxColumn value11;
        private System.Windows.Forms.DataGridViewTextBoxColumn value12;
    }
}