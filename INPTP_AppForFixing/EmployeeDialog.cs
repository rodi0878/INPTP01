using System;
using System.Linq;
using System.Windows.Forms;

namespace INPTP_AppForFixing
{
    public partial class EmployeeDialog : Form
    {
        private MainForm main;
        private bool employee = false;

        public EmployeeDialog(MainForm main, bool employee, Boss boss = null)
        {
            InitializeComponent();
            Init(main, employee);

            if (boss != null)
            {
                tBID.Text = boss.Id.ToString();
                tBID.Enabled = false;
                tBFirstName.Text = boss.FirstName;
                tBLastName.Text = boss.LastName;
                tBJob.Text = boss.Job;
                tBSalary.Text = boss.MonthlySalaryCZK.ToString();
                dateTimePickerBirthDate.Value = boss.OurBirthDate;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (testOfValues())
            {
                int Id = Int32.Parse(tBID.Text);
                Boss newB = new Boss(Id, tBFirstName.Text, tBLastName.Text, tBJob.Text, dateTimePickerBirthDate.Value, Double.Parse(tBSalary.Text), new Department(tBDpName.Text));
                Boss b = main.Bosses.FirstOrDefault(x => x.Id == Id);
                if (b == null)
                {
                    main.Bosses.Add(newB);
                }
                else
                {
                    main.Bosses.RemoveWhere(x => x.Id == newB.Id);
                    main.Bosses.Add(newB);
                    b = newB;
                }
                main.OnBossesChange();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bad entry data inserted.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool testOfValues()
        {
            int id;
            double salary;

            if (Int32.TryParse(tBID.Text, out id) && Double.TryParse(tBSalary.Text, out salary) && tBID.Text.Length > 0 &&
                tBFirstName.Text.Length > 0 && tBJob.Text.Length > 0 && tBLastName.Text.Length > 0) return true;
            return false;
        }

        private void Init(MainForm main, bool employee)
        {
            this.main = main;
            this.employee = employee;
            if (employee)
            {
                lbDep.Visible = false;
                lbDpName.Visible = false;
                tBDpName.Visible = false;
            }
        }
    }
}
