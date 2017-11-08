using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace INPTP_AppForFixing
{
    public partial class MainForm : Form
    {  
        private HashSet<Boss> bosses;      
        public HashSet<Boss> Bosses { get => bosses; set => bosses = value; }

        public MainForm()
        {
            InitializeComponent();
            bosses = new HashSet<Boss>();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            openAddDialog(true, "Create employee");
        }

        private void btnAddBoss_Click(object sender, EventArgs e)
        {
            openAddDialog(false, "Create boss");            
        }

        private void openAddDialog(bool addEmployee, string text, Boss bossToEdit = null)
        {
            EmployeeDialog addDialog = new EmployeeDialog(this, addEmployee, bossToEdit);
            addDialog.Text = text;
            addDialog.Show();            
        }

        public void OnBossesChange() {
            listBoxOfBosses.Items.Clear();
            foreach (Boss boss in bosses) {
                listBoxOfBosses.Items.Add(boss);
            }
        }

        public void OnEmployeeChange()
        {
            if (CheckSelectedBoss())
            {
                Boss temp = listBoxOfBosses.SelectedItem as Boss;
                if (temp.GetEmployees().Count > 0)
                {
                    listBoxEmpl.DataSource = new List<Employee>(temp.GetEmployees());
                }                
            }            
        }

        private void btnDelBoss_Click(object sender, EventArgs e)
        {
            if (listBoxOfBosses.SelectedItem == null) showError("Choose a boss!");
            else {
                bosses.Remove((Boss)listBoxOfBosses.SelectedItem);
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
                openAddDialog(false, "Edit boss", listBoxOfBosses.SelectedItem as Boss);                
                OnBossesChange();
            }
        }

        private void btnEmplAdd_Click(object sender, EventArgs e)
        {
            if (CheckSelectedBoss())
            {
                openAddDialog(true, "Add employee", listBoxOfBosses.SelectedItem as Boss);                
            }
            else
            {
                showWarning("First you must select a boss!");
            }
        }

        private bool CheckSelectedBoss()
        {
            return listBoxOfBosses.SelectedItem == null ? false : true;
        }

        private void listBoxOfBosses_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnEmployeeChange();
        }

        private void btnExportBoss_Click(object sender, EventArgs e)
        {
            if (CheckSelectedBoss())
            {
                Boss selectedBoss = listBoxOfBosses.SelectedItem as Boss;
                ExportUtils.Instance.SerializeBossToFile(selectedBoss);
            }
            else
            {
                showWarning("Select boss for export first!");
            }
        }
    }
}
