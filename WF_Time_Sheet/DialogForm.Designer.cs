
namespace WF_Time_Sheet
{
    partial class DialogForm
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
            this.TextBoxHourlyRate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.TextBoxNarration = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextBoxCustomer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddNewRecord = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelDialog = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // TextBoxHourlyRate
            // 
            this.TextBoxHourlyRate.Depth = 0;
            this.TextBoxHourlyRate.Hint = "";
            this.TextBoxHourlyRate.Location = new System.Drawing.Point(72, 339);
            this.TextBoxHourlyRate.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxHourlyRate.Name = "TextBoxHourlyRate";
            this.TextBoxHourlyRate.PasswordChar = '\0';
            this.TextBoxHourlyRate.SelectedText = "";
            this.TextBoxHourlyRate.SelectionLength = 0;
            this.TextBoxHourlyRate.SelectionStart = 0;
            this.TextBoxHourlyRate.Size = new System.Drawing.Size(334, 28);
            this.TextBoxHourlyRate.TabIndex = 3;
            this.TextBoxHourlyRate.UseSystemPasswordChar = false;
            this.TextBoxHourlyRate.LostFocus += new System.EventHandler(this.TextBoxHourlyRate_LostFocus);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Finalised",
            "Pending"});
            this.comboBoxStatus.Location = new System.Drawing.Point(72, 125);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(309, 24);
            this.comboBoxStatus.TabIndex = 4;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(72, 428);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 5;
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(72, 502);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(79, 22);
            this.timePicker.TabIndex = 6;
            this.timePicker.LostFocus += new System.EventHandler(this.timePicker_LostFocus);
            // 
            // TextBoxNarration
            // 
            this.TextBoxNarration.Depth = 0;
            this.TextBoxNarration.Hint = "";
            this.TextBoxNarration.Location = new System.Drawing.Point(72, 200);
            this.TextBoxNarration.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxNarration.Name = "TextBoxNarration";
            this.TextBoxNarration.PasswordChar = '\0';
            this.TextBoxNarration.SelectedText = "";
            this.TextBoxNarration.SelectionLength = 0;
            this.TextBoxNarration.SelectionStart = 0;
            this.TextBoxNarration.Size = new System.Drawing.Size(334, 28);
            this.TextBoxNarration.TabIndex = 7;
            this.TextBoxNarration.UseSystemPasswordChar = false;
            // 
            // TextBoxCustomer
            // 
            this.TextBoxCustomer.Depth = 0;
            this.TextBoxCustomer.Hint = "";
            this.TextBoxCustomer.Location = new System.Drawing.Point(72, 274);
            this.TextBoxCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxCustomer.Name = "TextBoxCustomer";
            this.TextBoxCustomer.PasswordChar = '\0';
            this.TextBoxCustomer.SelectedText = "";
            this.TextBoxCustomer.SelectionLength = 0;
            this.TextBoxCustomer.SelectionStart = 0;
            this.TextBoxCustomer.Size = new System.Drawing.Size(334, 28);
            this.TextBoxCustomer.TabIndex = 8;
            this.TextBoxCustomer.Text = "Customer";
            this.TextBoxCustomer.UseSystemPasswordChar = false;
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.Depth = 0;
            this.btnAddNewRecord.Location = new System.Drawing.Point(197, 785);
            this.btnAddNewRecord.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.Primary = true;
            this.btnAddNewRecord.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewRecord.TabIndex = 9;
            this.btnAddNewRecord.Text = "Add";
            this.btnAddNewRecord.UseVisualStyleBackColor = true;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewRecord_Click);
            // 
            // btnCancelDialog
            // 
            this.btnCancelDialog.Depth = 0;
            this.btnCancelDialog.Location = new System.Drawing.Point(321, 785);
            this.btnCancelDialog.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelDialog.Name = "btnCancelDialog";
            this.btnCancelDialog.Primary = true;
            this.btnCancelDialog.Size = new System.Drawing.Size(75, 23);
            this.btnCancelDialog.TabIndex = 10;
            this.btnCancelDialog.Text = "Cancel";
            this.btnCancelDialog.UseVisualStyleBackColor = true;
            this.btnCancelDialog.Click += new System.EventHandler(this.btnCancelDialog_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Depth = 0;
            this.labelTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTotal.Location = new System.Drawing.Point(80, 602);
            this.labelTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(52, 23);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(72, 545);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(334, 23);
            this.materialDivider1.TabIndex = 12;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 896);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.btnCancelDialog);
            this.Controls.Add(this.btnAddNewRecord);
            this.Controls.Add(this.TextBoxCustomer);
            this.Controls.Add(this.TextBoxNarration);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.TextBoxHourlyRate);
            this.Name = "DialogForm";
            this.Text = "DialogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxHourlyRate;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxNarration;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxCustomer;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddNewRecord;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelDialog;
        private MaterialSkin.Controls.MaterialLabel labelTotal;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}