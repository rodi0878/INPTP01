﻿using System;
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
                        selectedBoss.InsertEmpl(newEmployee);
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
            if (employee)
            {
                if (operation == Operation.ADD)
                {
                    tBID.Text = main.getNextEmployeeId().ToString();
                }
                else
                {
                    tBID.Text = selectedEmployee.Id.ToString();
                    tBFirstName.Text = selectedEmployee.FirstName;
                    tBLastName.Text = selectedEmployee.LastName;
                    tBJob.Text = selectedEmployee.Job;
                    tBSalary.Text = selectedEmployee.MonthlySalaryCZK.ToString();
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
                    tBID.Text = selectedBoss.Id.ToString();
                    tBFirstName.Text = selectedBoss.FirstName;
                    tBLastName.Text = selectedBoss.LastName;
                    tBJob.Text = selectedBoss.Job;
                    tBSalary.Text = selectedBoss.MonthlySalaryCZK.ToString();
                    dateTimePickerBirthDate.Value = selectedBoss.OurBirthDate;
                }
            }

        }
    }
}
