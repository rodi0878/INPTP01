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
    public partial class ChangeBossDialog : Form
    {
        private MainForm main;
        private Boss selectedBoss;
        private Employee selectedEmployee;
        private Boss newBoss;
        
        public ChangeBossDialog(MainForm main)
        {
            this.main = main;
            InitializeComponent();
            selectedBoss = main.GetSelectedBoss();
            selectedEmployee = main.GetSelectedEmployee();
            newBoss = null;
            Init();
        }

        public void Init()
        {
            //fill actualy boss info
            textBossId.Text = selectedBoss.Id.ToString();
            textFirstName.Text = selectedBoss.FirstName;
            textLastName.Text = selectedBoss.LastName;

            //fill ComboBox
            foreach(Boss boss in main.Bosses)
            {
                comboListBoss.Items.Add(boss);
            }
        }

        private void ButtSave_Click(object sender, EventArgs e)
        {
            if (newBoss != null)
            {
                selectedBoss.Remove(selectedEmployee);
                newBoss.Add(selectedEmployee);
                main.OnEmployeeChange();
                Close();
            }
            else
            {
                MessageBox.Show("You must choose new boss.", "Warning",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ComboListBoss_SelectedIndexChanged(object sender, EventArgs e)
        {
            newBoss = (Boss)comboListBoss.SelectedItem;
            textnewBossID.Text = newBoss.Id.ToString();
            textnewBossFirst.Text = newBoss.FirstName;
            textNewBossLast.Text = newBoss.LastName;
        }
    }
}
