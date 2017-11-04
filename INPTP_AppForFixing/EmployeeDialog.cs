using System;
using System.Windows.Forms;

namespace INPTP_AppForFixing
{
    public partial class EmployeeDialog : Form
    {
        private MainForm main;
        private bool isEmployee;
        private Boss bossForEmployee;
        private Employee employee;
        private Operation operation;

        public EmployeeDialog(MainForm main, bool isEmployee, Operation operation)
        {
            InitializeComponent();
            bossForEmployee = main.GetSelectedBoss();
            employee = main.GetSelectedEmployee();
            this.operation = operation;
            this.isEmployee = isEmployee;
            Init(main);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckValidInputForm())
            {
                if (isEmployee)
                {
                    Employee newEmployee = new Employee(int.Parse(tBID.Text), tBFirstName.Text, tBLastName.Text, tBJob.Text, dateTimePickerBirthDate.Value, Double.Parse(tBSalary.Text));

                    if (operation == Operation.ADD)
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

                    if (operation == Operation.ADD)
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

        private void Init(MainForm main)
        {
            this.main = main;
            if (isEmployee)
            {
                if (operation == Operation.ADD)
                {
                    tBID.Text = main.getNextEmployeeId().ToString();
                }
                else
                {
                    tBID.Text = employee.Id.ToString();
                    tBFirstName.Text = employee.FirstName;
                    tBLastName.Text = employee.LastName;
                    tBJob.Text = employee.Job;
                    tBSalary.Text = employee.MonthlySalaryCZK.ToString();
                }

                lbDep.Visible = false;
                lbDpName.Visible = false;
                tBDpName.Visible = false;
            }
            else
            {
                if (operation == Operation.ADD)
                {
                    tBID.Text = main.getNextEmployeeId().ToString();
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
