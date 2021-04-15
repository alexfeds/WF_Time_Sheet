
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
            this.dbTimeSheetDataSetWF = new WF_Time_Sheet.dbTimeSheetDataSetWF();
            this.timeSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeSheetTableAdapter = new WF_Time_Sheet.dbTimeSheetDataSetWFTableAdapters.timeSheetTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horlyRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialRaisedAddButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dbTimeSheetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTimeSheetDataSetWF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(55, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbTimeSheetDataSetWF
            // 
            this.dbTimeSheetDataSetWF.DataSetName = "dbTimeSheetDataSetWF";
            this.dbTimeSheetDataSetWF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeSheetBindingSource
            // 
            this.timeSheetBindingSource.DataMember = "timeSheet";
            this.timeSheetBindingSource.DataSource = this.dbTimeSheetDataSetWF;
            // 
            // timeSheetTableAdapter
            // 
            this.timeSheetTableAdapter.ClearBeforeFill = true;
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
            // materialRaisedAddButton
            // 
            this.materialRaisedAddButton.Depth = 0;
            this.materialRaisedAddButton.Location = new System.Drawing.Point(424, 517);
            this.materialRaisedAddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedAddButton.Name = "materialRaisedAddButton";
            this.materialRaisedAddButton.Primary = true;
            this.materialRaisedAddButton.Size = new System.Drawing.Size(96, 23);
            this.materialRaisedAddButton.TabIndex = 1;
            this.materialRaisedAddButton.Text = "Add";
            this.materialRaisedAddButton.UseVisualStyleBackColor = true;
            this.materialRaisedAddButton.Click += new System.EventHandler(this.materialRaisedAddButton_Click);
            // 
            // TimeSheetForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 699);
            this.Controls.Add(this.materialRaisedAddButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TimeSheetForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TimeSheetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbTimeSheetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTimeSheetDataSetWF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}

