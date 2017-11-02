using System;
using System.Linq;
using System.Windows.Forms;

namespace INPTP_AppForFixing
{
    public partial class EmployeeDialog : Form
    {
        private MainForm main;
        private bool employee = false;
        private Boss bossForEmployee;

        public EmployeeDialog(MainForm main, bool employee, Boss selectedBoss = null)
        {
            InitializeComponent();
            Init(main, employee);
            bossForEmployee = selectedBoss;
            if (selectedBoss != null && employee == false)
            {
                tBID.Text = selectedBoss.Id.ToString();
                tBID.Enabled = false;
                tBFirstName.Text = selectedBoss.FirstName;
                tBLastName.Text = selectedBoss.LastName;
                tBJob.Text = selectedBoss.Job;
                tBSalary.Text = selectedBoss.MonthlySalaryCZK.ToString();
                dateTimePickerBirthDate.Value = selectedBoss.OurBirthDate;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckValidInputForm())
            {
                if (employee)
                {
                    if (isIdUniqui())
                    {
                        Employee newEmployee = new Employee(int.Parse(tBID.Text), tBFirstName.Text, tBLastName.Text, tBJob.Text, dateTimePickerBirthDate.Value, Double.Parse(tBSalary.Text));
                        bossForEmployee.InsertEmpl(newEmployee);
                        main.OnEmployeeChange();
                    }
                    else
                    {
                        MessageBox.Show("Id is not unique.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    Boss newBoss = new Boss(int.Parse(tBID.Text), tBFirstName.Text, tBLastName.Text, tBJob.Text, dateTimePickerBirthDate.Value, Double.Parse(tBSalary.Text), new Department(tBDpName.Text));

                    // Check if boss exist
                    Boss bossToEdit = main.Bosses.FirstOrDefault(x => x.Id == newBoss.Id);

                    if (bossToEdit == null)
                    {
                        if (isIdUniqui())
                        {
                            main.Bosses.Add(newBoss);
                        }
                        else
                        { 
                            MessageBox.Show("Id is not unique.", "Error",
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                }
                    else
                    {
                        bossToEdit = newBoss;
                        main.Bosses.RemoveWhere(x => x.Id == newBoss.Id);
                        main.Bosses.Add(bossToEdit);
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

            return Int32.TryParse(tBID.Text, out id) && 
                Double.TryParse(tBSalary.Text, out salary) && 
                tBID.Text.Length > 0 &&
                tBFirstName.Text.Length > 0 && 
                tBJob.Text.Length > 0 && 
                tBLastName.Text.Length > 0;
           
        }

        private bool isIdUniqui()
        {
            int id = Int32.Parse(tBID.Text);

            foreach (var Boss in main.Bosses)
            {
                foreach (var Employee in Boss.GetEmployees())
                {
                    if (Employee.Id == id)
                        return false;
                }
                if (Boss.Id == id)
                    return false;
            }
            return true;
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
