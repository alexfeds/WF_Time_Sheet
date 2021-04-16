
namespace WF_Time_Sheet
{
    partial class TimeSheetForm 
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
            this.dbTimeSheetDataSet = new WF_Time_Sheet.dbTimeSheetDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horlyRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTimeSheetDataSetWF = new WF_Time_Sheet.dbTimeSheetDataSetWF();
            this.timeSheetTableAdapter = new WF_Time_Sheet.dbTimeSheetDataSetWFTableAdapters.timeSheetTableAdapter();
            this.materialRaisedAddButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelEntries = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Total = new MaterialSkin.Controls.MaterialLabel();
            this.btnRefresh = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dbTimeSheetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTimeSheetDataSetWF)).BeginInit();
            this.SuspendLayout();
            // 
            // dbTimeSheetDataSet
            // 
            this.dbTimeSheetDataSet.DataSetName = "dbTimeSheetDataSet";
            this.dbTimeSheetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.narrationDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.horlyRateDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.timeSheetBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(73, 156);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // narrationDataGridViewTextBoxColumn
            // 
            this.narrationDataGridViewTextBoxColumn.DataPropertyName = "Narration";
            this.narrationDataGridViewTextBoxColumn.HeaderText = "Narration";
            this.narrationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.narrationDataGridViewTextBoxColumn.Name = "narrationDataGridViewTextBoxColumn";
            this.narrationDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // horlyRateDataGridViewTextBoxColumn
            // 
            this.horlyRateDataGridViewTextBoxColumn.DataPropertyName = "HorlyRate";
            this.horlyRateDataGridViewTextBoxColumn.HeaderText = "HorlyRate";
            this.horlyRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horlyRateDataGridViewTextBoxColumn.Name = "horlyRateDataGridViewTextBoxColumn";
            this.horlyRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeSheetBindingSource
            // 
            this.timeSheetBindingSource.DataMember = "timeSheet";
            this.timeSheetBindingSource.DataSource = this.dbTimeSheetDataSetWF;
            // 
            // dbTimeSheetDataSetWF
            // 
            this.dbTimeSheetDataSetWF.DataSetName = "dbTimeSheetDataSetWF";
            this.dbTimeSheetDataSetWF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeSheetTableAdapter
            // 
            this.timeSheetTableAdapter.ClearBeforeFill = true;
            // 
            // materialRaisedAddButton
            // 
            this.materialRaisedAddButton.Depth = 0;
            this.materialRaisedAddButton.Location = new System.Drawing.Point(73, 545);
            this.materialRaisedAddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialRaisedAddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedAddButton.Name = "materialRaisedAddButton";
            this.materialRaisedAddButton.Primary = true;
            this.materialRaisedAddButton.Size = new System.Drawing.Size(124, 35);
            this.materialRaisedAddButton.TabIndex = 1;
            this.materialRaisedAddButton.Text = "Create";
            this.materialRaisedAddButton.UseVisualStyleBackColor = true;
            this.materialRaisedAddButton.Click += new System.EventHandler(this.OpenDialogRecordCreate_Click);
            // 
            // labelEntries
            // 
            this.labelEntries.AutoSize = true;
            this.labelEntries.Depth = 0;
            this.labelEntries.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEntries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEntries.Location = new System.Drawing.Point(69, 115);
            this.labelEntries.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEntries.Name = "labelEntries";
            this.labelEntries.Size = new System.Drawing.Size(168, 24);
            this.labelEntries.TabIndex = 2;
            this.labelEntries.Text = "Time Sheet Entries";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Depth = 0;
            this.lbl_Total.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Total.Location = new System.Drawing.Point(995, 556);
            this.lbl_Total.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(58, 24);
            this.lbl_Total.TabIndex = 3;
            this.lbl_Total.Text = "Total:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Depth = 0;
            this.btnRefresh.Location = new System.Drawing.Point(1024, 115);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Primary = true;
            this.btnRefresh.Size = new System.Drawing.Size(104, 33);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.RefreshTable_Click);
            // 
            // TimeSheetForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 648);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.labelEntries);
            this.Controls.Add(this.materialRaisedAddButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TimeSheetForm";
            this.Text = "Practice Evolve Time Sheet";
            this.Load += new System.EventHandler(this.TimeSheetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbTimeSheetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTimeSheetDataSetWF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbTimeSheetDataSet dbTimeSheetDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbTimeSheetDataSetWF dbTimeSheetDataSetWF;
        private System.Windows.Forms.BindingSource timeSheetBindingSource;
        private dbTimeSheetDataSetWFTableAdapters.timeSheetTableAdapter timeSheetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horlyRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedAddButton;
        private MaterialSkin.Controls.MaterialLabel labelEntries;
        private MaterialSkin.Controls.MaterialLabel lbl_Total;
        private MaterialSkin.Controls.MaterialRaisedButton btnRefresh;
    }
}

