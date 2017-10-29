using System;
using System.Windows.Forms;

namespace INPTP_AppForFixing
{
    public partial class EmployeeDialog : Form
    {
        private MainForm main;
        private bool employee = false;
        private Boss bossForEmployee;
        private Employee emp;
        private Action action;

        public EmployeeDialog(MainForm main, bool employee, Action action)
        {
            InitializeComponent();
            bossForEmployee = main.GetSelectedBoss();
            emp = main.GetSelectedEmployee();
            this.action = action;
            Init(main, employee);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckValidInputForm())
            {
                if (employee)
                {
                    Employee newEmployee = new Employee(int.Parse(tBID.Text), tBFirstName.Text, tBLastName.Text, tBJob.Text, dateTimePickerBirthDate.Value, Double.Parse(tBSalary.Text));

                    if (action == Action.ADD)
                    {
                        bossForEmployee.InsertEmpl(newEmployee);
                    }
                    else
                    {
                        bossForEmployee.PurgeEmpl(main.GetSelectedEmployee());
                        bossForEmployee.InsertEmpl(newEmployee);
                    }

                    main.OnEmployeeChange();
                }
                else
                {
                    Boss newBoss = new Boss(int.Parse(tBID.Text), tBFirstName.Text, tBLastName.Text, tBJob.Text, dateTimePickerBirthDate.Value, Double.Parse(tBSalary.Text), new Department(tBDpName.Text));

                    if (action == Action.ADD)
                    {
                        main.Bosses.Add(newBoss);
                    }
                    else
                    {
                        main.Bosses.RemoveWhere(x => x.Id == newBoss.Id);
                        main.Bosses.Add(newBoss);
                    }
                    main.OnBossesChange();
                }

                Close();
            }
            else
            {
                MessageBox.Show("Bad entry data inserted.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckValidInputForm()
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
                if (action == Action.ADD)
                {
                    tBID.Text = bossForEmployee.GetNextEmployeeId().ToString();
                }
                else
                {
                    tBID.Text = emp.Id.ToString();
                    tBFirstName.Text = emp.FirstName;
                    tBLastName.Text = emp.LastName;
                    tBJob.Text = emp.Job;
                    tBSalary.Text = emp.MonthlySalaryCZK.ToString();
                }

                lbDep.Visible = false;
                lbDpName.Visible = false;
                tBDpName.Visible = false;
            }
            else
            {
                if (action == Action.ADD)
                {
                    tBID.Text = main.getNextBossId().ToString();
                }
                else
                {
                    tBID.Text = bossForEmployee.Id.ToString();
                    tBFirstName.Text = bossForEmployee.FirstName;
                    tBLastName.Text = bossForEmployee.LastName;
                    tBJob.Text = bossForEmployee.Job;
                    tBSalary.Text = bossForEmployee.MonthlySalaryCZK.ToString();
                    dateTimePickerBirthDate.Value = bossForEmployee.OurBirthDate;
                }
            }

        }
    }
}
