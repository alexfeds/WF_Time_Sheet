using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Time_Sheet
{
    public partial class DialogForm : MaterialSkin.Controls.MaterialForm
    {
        double hours;
        double hourlyRate;

        TimeSheetForm obj = (TimeSheetForm)Application.OpenForms["TimeSheetForm"];

        public DialogForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void btnCancelDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            try
            {

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-H32BFQKK\SQLEXPRESS;Initial Catalog=dbTimeSheet;Integrated Security=True");
            SqlCommand chk = new SqlCommand("Insert into timeSheet (Status, Date, Hours, Narration, Customer, HorlyRate, Total )  VALUES  (@Status, @Date, @Hours, @Narration, @Customer, @HourlyRate, @Total )", conn);
            chk.CommandType = CommandType.Text;
            chk.Parameters.AddWithValue("@Status", this.comboBoxStatus.SelectedItem);
            chk.Parameters.AddWithValue("@Date", this.datePicker.Value);
            chk.Parameters.AddWithValue("@Hours", this.timePicker.Value);
            chk.Parameters.AddWithValue("@Narration", this.TextBoxNarration.Text);
            chk.Parameters.AddWithValue("@Customer", this.TextBoxCustomer.Text);
            chk.Parameters.AddWithValue("@HourlyRate", this.TextBoxHourlyRate.Text);
            chk.Parameters.AddWithValue("@Total", labelTotal.Text);


            conn.Open();
            chk.ExecuteNonQuery();
            conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            obj.TimeSheetForm_Load(sender, e);
     
        }

        private void TextBoxHourlyRate_LostFocus(object sender, EventArgs e)
        {
            hourlyRate = Convert.ToDouble(this.TextBoxHourlyRate.Text);

            var total = caclualteRate.calculateRate(hours, hourlyRate);

            labelTotal.Text = total.ToString();
        }

        private void timePicker_LostFocus(object sender, EventArgs e)
        {

            var time = this.timePicker.Text;
            var now = DateTime.Parse(time);
            var ts = now.TimeOfDay; // ts is your timespan
            hours = ts.TotalHours;
            Console.WriteLine(ts.TotalHours); // will print 0.5


            var total = caclualteRate.calculateRate(hours, hourlyRate);


            labelTotal.Text = total.ToString();

            // TODO: This line of code loads data into the 'dbTimeSheetDataSetWF.timeSheet' table. You can move, or remove it, as needed.
         
        }

        public static class caclualteRate
        {

            //static fields  
            public static double result;
            public static double calculateRate(double hours, double hourRate)
            {
                result = hours * hourRate;
                return result;
            }

        }

     
    }
}
