using System;
using System.Windows.Forms;

namespace INPTP_AppForFixing
{
    public partial class EmployeeDialog : Form
    {
        private MainForm main;
        private bool employee;
        private Boss selectedBoss;
        private Employee selectedEmployee;
        private Operation operation;

        public EmployeeDialog(MainForm main, bool employee, Operation operation)
        {
            InitializeComponent();
            selectedBoss = main.GetSelectedBoss();
            selectedEmployee = main.GetSelectedEmployee();
            this.operation = operation;
            this.employee = employee;
            Init(main);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckValidInputForm())
            {
                if (employee)
                {
                    Employee newEmployee = new Employee(int.Parse(tBID.Text), tBFirstName.Text, tBLastName.Text, tBJob.Text, dateTimePickerBirthDate.Value, Double.Parse(tBSalary.Text));

                    if (operation == Operation.ADD)
                    {
                        selectedBoss.InsertEmpl(newEmployee);
                    }
                    else
                    {
                        selectedBoss.PurgeEmpl(main.GetSelectedEmployee());
                        Boss selectedBossNew = main.GetSelecteBossID(int.Parse(tBIdBoss.Text));
                        if (main.ControlhHierarchy(main.GetSelectedEmployee(), selectedBossNew))
                        {
                            selectedBossNew.InsertEmpl(newEmployee);
                        }
                        else
                        {
                            selectedBoss.InsertEmpl(newEmployee);
                        }
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

            if (tBFirstName.Text.Length > 0 && tBJob.Text.Length > 0 && tBLastName.Text.Length > 0 && Int32.TryParse(tBIdBoss.Text, out id)) return true;
            return false;
        }

        private void Init(MainForm main)
        {
            this.main = main;
            if (employee)
            {
                if (operation == Operation.ADD)
                {
                    tBID.Text = main.getNextEmployeeId().ToString();
                    tBIdBoss.Text = "0";
                    label7.Visible = false;
                    tBIdBoss.Visible = false;
                }
                else
                {
                    tBID.Text = selectedEmployee.Id.ToString();
                    tBFirstName.Text = selectedEmployee.FirstName;
                    tBLastName.Text = selectedEmployee.LastName;
                    tBJob.Text = selectedEmployee.JobTitle;
                    tBSalary.Text = selectedEmployee.MonthlySalaryCZK.ToString();
                    tBIdBoss.Text = selectedBoss.Id.ToString();
                }

                lbDep.Visible = false;
                lbDpName.Visible = false;
                tBDpName.Visible = false;
            }
            else
            {
                tBIdBoss.Text = "0";
                if (operation == Operation.ADD)
                {
                    tBID.Text = main.getNextEmployeeId().ToString();
                }
                else
                {
                    tBID.Text = selectedBoss.Id.ToString();
                    tBFirstName.Text = selectedBoss.FirstName;
                    tBLastName.Text = selectedBoss.LastName;
                    tBJob.Text = selectedBoss.JobTitle;
                    tBSalary.Text = selectedBoss.MonthlySalaryCZK.ToString();
                    dateTimePickerBirthDate.Value = selectedBoss.BirthDate;
                }
                label7.Visible = false;
                tBIdBoss.Visible = false;
            }

        }
    }
}
