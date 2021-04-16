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
        double total;

        TimeSheetForm obj = (TimeSheetForm)Application.OpenForms["TimeSheetForm"];

        public DialogForm()
        {
            // Initialize component 
            InitializeComponent();

            // Set default text for combobox
            this.comboBoxStatus.Text = "--Select Status--";

            // set material design skin
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }


        /*******************START******************************** Saving data to sql server database ******************************************START************/

        private void AddNewRecordToDB_Click(object sender, EventArgs e)
        {
            try
            {
                // Sets connection string (please replace the connection string to match your machine, check you local sql server for connection string)
                //Also need to create a table 

                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-H32BFQKK\SQLEXPRESS;Initial Catalog=dbTimeSheet;Integrated Security=True");

                // Insert command
                SqlCommand chk = new SqlCommand("Insert into timeSheet (Status, Date, Hours, Narration, Customer, HorlyRate, Total )  VALUES  (@Status, @Date, @Hours, @Narration, @Customer, @HourlyRate, @Total )", conn);
                chk.CommandType = CommandType.Text;
                chk.Parameters.AddWithValue("@Status", this.comboBoxStatus.SelectedItem);
                chk.Parameters.AddWithValue("@Date", this.datePicker.Value);
                chk.Parameters.AddWithValue("@Hours", this.timePicker.Value);
                chk.Parameters.AddWithValue("@Narration", this.TextBoxNarration.Text);
                chk.Parameters.AddWithValue("@Customer", this.TextBoxCustomer.Text);
                chk.Parameters.AddWithValue("@HourlyRate", this.TextBoxHourlyRate.Text);
                chk.Parameters.AddWithValue("@Total", total);


                conn.Open();
                chk.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Success, added new record");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Could not save to database, try again");
            }

            // Refresh table after saving to databse
            obj.TimeSheetForm_Load(sender, e);

        }

        /*******************END******************************** Saving data to sql server database ********************************************END************/



        /***********************************START*********** Listen for texbox events and perform actions ****************START*******************************/

        //Gets executed when timepicker looses focus in the form
        private void TimePicker_LostFocus(object sender, EventArgs e) 
        {

            var time = this.timePicker.Text;
            //convert string date to real date
            var now = DateTime.Parse(time);
            var ts = now.TimeOfDay; // ts is your timespan
            //sets hours to decimal
            hours = ts.TotalHours;

            //calcualte
            total = Utility.CalculateRate(hours, hourlyRate);

            //Displays total record above table
            labelTotal.Text = $"Total: {total.ToString()}";

        }

        //Gets executed when timepicker looses focus in the form
        private void TextBoxHourlyRate_LostFocus(object sender, EventArgs e) 
        {
            var hourText = this.TextBoxHourlyRate.Text;

            // Checks if empty or null
            if (hourText != null && hourText != "")
            {
                //Validate to enter only numbers
                if (System.Text.RegularExpressions.Regex.IsMatch(hourText, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    TextBoxHourlyRate.Text = TextBoxHourlyRate.Text.Remove(TextBoxHourlyRate.Text.Length - TextBoxHourlyRate.Text.Length); // remove letters entered

                }
                else
                {
                    hourlyRate = Convert.ToDouble(hourText);

                    total = Utility.CalculateRate(hours, hourlyRate);

                    //Displays total record above table
                    labelTotal.Text = $"Total: {total.ToString()}";
                }

            }

        }

        /****************END************* Listen for texbox events and perform actions ******************END**********/


        //Close the dialog
        private void CancelDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
