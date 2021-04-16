
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewRecord = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelDialog = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.TextBoxNarration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxHourlyRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePicker.Location = new System.Drawing.Point(241, 370);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(129, 25);
            this.datePicker.TabIndex = 5;
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(61, 461);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(90, 25);
            this.timePicker.TabIndex = 6;
            this.timePicker.LostFocus += new System.EventHandler(this.TimePicker_LostFocus);
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.Depth = 0;
            this.btnAddNewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnAddNewRecord.Location = new System.Drawing.Point(64, 638);
            this.btnAddNewRecord.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.Primary = true;
            this.btnAddNewRecord.Size = new System.Drawing.Size(127, 38);
            this.btnAddNewRecord.TabIndex = 9;
            this.btnAddNewRecord.Text = "Add";
            this.btnAddNewRecord.UseVisualStyleBackColor = true;
            this.btnAddNewRecord.Click += new System.EventHandler(this.AddNewRecordToDB_Click);
            // 
            // btnCancelDialog
            // 
            this.btnCancelDialog.Depth = 0;
            this.btnCancelDialog.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnCancelDialog.Location = new System.Drawing.Point(229, 638);
            this.btnCancelDialog.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelDialog.Name = "btnCancelDialog";
            this.btnCancelDialog.Primary = true;
            this.btnCancelDialog.Size = new System.Drawing.Size(138, 38);
            this.btnCancelDialog.TabIndex = 10;
            this.btnCancelDialog.Text = "Cancel";
            this.btnCancelDialog.UseVisualStyleBackColor = true;
            this.btnCancelDialog.Click += new System.EventHandler(this.CancelDialog_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Finalised",
            "Pending"});
            this.comboBoxStatus.Location = new System.Drawing.Point(63, 131);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(171, 28);
            this.comboBoxStatus.TabIndex = 4;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.materialDivider1.Location = new System.Drawing.Point(60, 509);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(307, 10);
            this.materialDivider1.TabIndex = 15;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // TextBoxNarration
            // 
            this.TextBoxNarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.TextBoxNarration.Location = new System.Drawing.Point(63, 210);
            this.TextBoxNarration.Name = "TextBoxNarration";
            this.TextBoxNarration.Size = new System.Drawing.Size(307, 25);
            this.TextBoxNarration.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label1.Location = new System.Drawing.Point(60, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Narration";
            // 
            // TextBoxCustomer
            // 
            this.TextBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.TextBoxCustomer.Location = new System.Drawing.Point(61, 289);
            this.TextBoxCustomer.Name = "TextBoxCustomer";
            this.TextBoxCustomer.Size = new System.Drawing.Size(309, 25);
            this.TextBoxCustomer.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label2.Location = new System.Drawing.Point(58, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Customer";
            // 
            // TextBoxHourlyRate
            // 
            this.TextBoxHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.TextBoxHourlyRate.Location = new System.Drawing.Point(63, 370);
            this.TextBoxHourlyRate.Name = "TextBoxHourlyRate";
            this.TextBoxHourlyRate.Size = new System.Drawing.Size(88, 25);
            this.TextBoxHourlyRate.TabIndex = 20;
            this.TextBoxHourlyRate.LostFocus += new System.EventHandler(this.TextBoxHourlyRate_LostFocus);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label3.Location = new System.Drawing.Point(61, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Hourly Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(58, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label5.Location = new System.Drawing.Point(242, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label6.Location = new System.Drawing.Point(58, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Hours";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.labelTotal.Location = new System.Drawing.Point(60, 555);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(55, 25);
            this.labelTotal.TabIndex = 25;
            this.labelTotal.Text = "Total";
            // 
            // DialogForm
            // 
            this.AcceptButton = this.btnAddNewRecord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelDialog;
            this.ClientSize = new System.Drawing.Size(431, 756);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxHourlyRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxNarration);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnCancelDialog);
            this.Controls.Add(this.btnAddNewRecord);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.comboBoxStatus);
            this.Name = "DialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddNewRecord;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelDialog;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.TextBox TextBoxNarration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxHourlyRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTotal;
    }
}