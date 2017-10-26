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

        private void openAddDialog(bool emp, string text, Boss bossToEdit = null)
        {
            EmployeeDialog createWin = new EmployeeDialog(this, emp, bossToEdit);
            createWin.Text = text;
            createWin.Show();            
        }

        public void OnBossesChange() {
            listBoxOfBosses.Items.Clear();
            foreach (Boss boss in bosses) {
                listBoxOfBosses.Items.Add(boss);
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

        private void btnEditBoss_Click(object sender, EventArgs e)
        {
            if (listBoxOfBosses.SelectedItem == null) showError("Choose a boss!");
            else
            {
                openAddDialog(false, "Edit boss", listBoxOfBosses.SelectedItem as Boss);                
                OnBossesChange();
            }
        }        
    }
}
