using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INPTP_AppForFixing
{
    public partial class EmployeeDialog : Form
    {
        private MainForm main;
        private bool employee=false;

        public EmployeeDialog(MainForm main, bool employee)
        {
            InitializeComponent();
            this.main = main;
            this.employee = employee;
            if (employee) {
                lbDep.Visible = false;
                lbDpName.Visible = false;
                tBDpName.Visible = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (testOfValues())
            {
                main.Bosses.Add(new Boss(Int32.Parse(tBID.Text), tBFirstName.Text, tBLastName.Text, tBJob.Text, dateTimePickerBirthDate.Value, Double.Parse(tBSalary.Text), new Department(tBDpName.Text)));
                main.OnBossesChange();
                Close();
            }
            else {
                
                    MessageBox.Show("Bad entry data inserted.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Enabled = true;
        }

        private bool testOfValues() {
            int id;
            double salary;

            if (Int32.TryParse(tBID.Text, out id) && Double.TryParse(tBSalary.Text, out salary) && tBID.Text.Length>0 &&
                tBFirstName.Text.Length > 0 && tBJob.Text.Length > 0 && tBLastName.Text.Length > 0) return true;
            return false;
        }
    }
}
