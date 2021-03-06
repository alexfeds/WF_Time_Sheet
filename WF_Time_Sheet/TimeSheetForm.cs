using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Time_Sheet
{
    public partial class TimeSheetForm : MaterialSkin.Controls.MaterialForm
    {
        public TimeSheetForm()
        {

            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        public void TimeSheetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTimeSheetDataSetWF.timeSheet' table. You can move, or remove it, as needed.
            this.timeSheetTableAdapter.Fill(this.dbTimeSheetDataSetWF.timeSheet);

        }

        private void materialRaisedAddButton_Click(object sender, EventArgs e)
        {
            using (DialogForm dialogForm = new DialogForm())
            {
                dialogForm.ShowDialog();
            }

        }

  


    }
}
