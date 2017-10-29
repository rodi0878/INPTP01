using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace INPTP_AppForFixing
{
    public enum Action
    {
        ADD, EDIT
    }

    public partial class MainForm : Form
    {
        private HashSet<Boss> bosses;
        public HashSet<Boss> Bosses { get => bosses; set => bosses = value; }
        private const int FIRST_BOSS_ID = 0;

        public MainForm()
        {
            InitializeComponent();
            bosses = new HashSet<Boss>();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            openAddDialog(true, "Create employee", Action.ADD);
        }

        private void btnAddBoss_Click(object sender, EventArgs e)
        {
            openAddDialog(false, "Create boss", Action.ADD);
        }

        private void openAddDialog(bool addEmployee, string text, Action action)
        {
            EmployeeDialog addDialog = new EmployeeDialog(this, addEmployee, action);
            addDialog.Text = text;
            addDialog.ShowDialog();
        }

        public void OnBossesChange()
        {
            listBoxOfBosses.Items.Clear();
            foreach (Boss boss in bosses)
            {
                listBoxOfBosses.Items.Add(boss);
            }
        }

        public void OnEmployeeChange()
        {
            if (CheckSelectedBoss())
            {
                Boss temp = listBoxOfBosses.SelectedItem as Boss;
                if (temp.GetEmployees().Count >= 0)
                {
                    listBoxEmpl.DataSource = new List<Employee>(temp.GetEmployees());
                }
            }
        }

        public Boss GetSelectedBoss() => (Boss)listBoxOfBosses.SelectedItem;

        public Employee GetSelectedEmployee() => (Employee)listBoxEmpl.SelectedItem;


        public int getNextBossId()
        {
            try
            {
                return bosses.Max(b => b.Id) + 1;
            }
            catch (InvalidOperationException)
            {
                return FIRST_BOSS_ID;
            }

        }

        private void btnDelBoss_Click(object sender, EventArgs e)
        {
            if (GetSelectedBoss() == null) showError("Choose a boss!");
            else
            {
                bosses.Remove(GetSelectedBoss());
                OnBossesChange();
            }
        }

        private void showError(string text)
        {
            MessageBox.Show(text, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void showWarning(string text)
        {
            MessageBox.Show(text, "Warning",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEditBoss_Click(object sender, EventArgs e)
        {
            if (listBoxOfBosses.SelectedItem == null) showError("Choose a boss!");
            else
            {
                openAddDialog(false, "Edit boss", Action.EDIT);
                OnBossesChange();
            }
        }

        private void btnEmplAdd_Click(object sender, EventArgs e)
        {
            if (CheckSelectedBoss())
            {
                openAddDialog(true, "Add employee", Action.ADD);
            }
            else
            {
                showWarning("First you must select a boss!");
            }
        }

        private bool CheckSelectedBoss()
        {
            return GetSelectedBoss() == null ? false : true;
        }

        private bool CheckSelectedEmp()
        {
            return GetSelectedEmployee() == null ? false : true;
        }

        private void listBoxOfBosses_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnEmployeeChange();
        }

        private void btnEmplDelete_Click(object sender, EventArgs e)
        {
            Boss boss = GetSelectedBoss();
            Employee emp = GetSelectedEmployee();
            if (CheckSelectedBoss() && CheckSelectedEmp())
            {
                boss.PurgeEmpl(emp);
                OnEmployeeChange();
            }
            else
            {
                showWarning("First you must select a boss and the employee which is about to be deleted!");
            }
        }

        private void btnEmplEdit_Click(object sender, EventArgs e)
        {
            if (CheckSelectedBoss() && CheckSelectedEmp())
            {
                openAddDialog(true, "Edit employee", Action.EDIT);
            }
            else
            {
                showWarning("First you must select a boss and the employee which is about to be altered!");
            }
        }
    }
}
