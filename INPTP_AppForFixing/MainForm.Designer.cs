﻿namespace INPTP_AppForFixing
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxOfBosses = new System.Windows.Forms.ListBox();
            this.btnAddBoss = new System.Windows.Forms.Button();
            this.btnDelBoss = new System.Windows.Forms.Button();
            this.listBoxEmpl = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnImportBoss = new System.Windows.Forms.Button();
            this.btnExportBoss = new System.Windows.Forms.Button();
            this.btnEditBoss = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.butt_change_boss = new System.Windows.Forms.Button();
            this.btnEmplEdit = new System.Windows.Forms.Button();
            this.btnEmplAdd = new System.Windows.Forms.Button();
            this.btnEmplDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnGenerateSampleData = new System.Windows.Forms.Button();
            this.groupBoxGenerator = new System.Windows.Forms.GroupBox();
            this.rBtnBoth = new System.Windows.Forms.RadioButton();
            this.rBtnEmployee = new System.Windows.Forms.RadioButton();
            this.countLabel = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.rBtnBoss = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxGenerator.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxOfBosses
            // 
            this.listBoxOfBosses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOfBosses.FormattingEnabled = true;
            this.listBoxOfBosses.Location = new System.Drawing.Point(5, 18);
            this.listBoxOfBosses.Name = "listBoxOfBosses";
            this.listBoxOfBosses.Size = new System.Drawing.Size(331, 329);
            this.listBoxOfBosses.TabIndex = 0;
            this.listBoxOfBosses.SelectedIndexChanged += new System.EventHandler(this.listBoxOfBosses_SelectedIndexChanged);
            this.listBoxOfBosses.DoubleClick += new System.EventHandler(this.listBoxOfBosses_DoubleClick);
            // 
            // btnAddBoss
            // 
            this.btnAddBoss.Location = new System.Drawing.Point(5, 34);
            this.btnAddBoss.Name = "btnAddBoss";
            this.btnAddBoss.Size = new System.Drawing.Size(101, 28);
            this.btnAddBoss.TabIndex = 2;
            this.btnAddBoss.Text = "Add boss";
            this.btnAddBoss.UseVisualStyleBackColor = true;
            this.btnAddBoss.Click += new System.EventHandler(this.btnAddBoss_Click);
            // 
            // btnDelBoss
            // 
            this.btnDelBoss.Location = new System.Drawing.Point(242, 34);
            this.btnDelBoss.Name = "btnDelBoss";
            this.btnDelBoss.Size = new System.Drawing.Size(93, 28);
            this.btnDelBoss.TabIndex = 3;
            this.btnDelBoss.Text = "Delete boss";
            this.btnDelBoss.UseVisualStyleBackColor = true;
            this.btnDelBoss.Click += new System.EventHandler(this.btnDelBoss_Click);
            // 
            // listBoxEmpl
            // 
            this.listBoxEmpl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEmpl.FormattingEnabled = true;
            this.listBoxEmpl.Location = new System.Drawing.Point(4, 17);
            this.listBoxEmpl.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxEmpl.Name = "listBoxEmpl";
            this.listBoxEmpl.Size = new System.Drawing.Size(331, 329);
            this.listBoxEmpl.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxOfBosses);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(344, 371);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Bosses";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listBoxEmpl);
            this.groupBox2.Location = new System.Drawing.Point(359, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(339, 371);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Employes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnImportBoss);
            this.groupBox3.Controls.Add(this.btnExportBoss);
            this.groupBox3.Controls.Add(this.btnEditBoss);
            this.groupBox3.Controls.Add(this.btnAddBoss);
            this.groupBox3.Controls.Add(this.btnDelBoss);
            this.groupBox3.Location = new System.Drawing.Point(11, 387);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(344, 108);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Boss control";
            // 
            // btnImportBoss
            // 
            this.btnImportBoss.Location = new System.Drawing.Point(5, 68);
            this.btnImportBoss.Name = "btnImportBoss";
            this.btnImportBoss.Size = new System.Drawing.Size(101, 28);
            this.btnImportBoss.TabIndex = 6;
            this.btnImportBoss.Text = "Import boss";
            this.btnImportBoss.UseVisualStyleBackColor = true;
            this.btnImportBoss.Click += new System.EventHandler(this.btnImportBoss_Click);
            // 
            // btnExportBoss
            // 
            this.btnExportBoss.Location = new System.Drawing.Point(126, 68);
            this.btnExportBoss.Name = "btnExportBoss";
            this.btnExportBoss.Size = new System.Drawing.Size(101, 28);
            this.btnExportBoss.TabIndex = 5;
            this.btnExportBoss.Text = "Export boss";
            this.btnExportBoss.UseVisualStyleBackColor = true;
            this.btnExportBoss.Click += new System.EventHandler(this.btnExportBoss_Click);
            // 
            // btnEditBoss
            // 
            this.btnEditBoss.Location = new System.Drawing.Point(126, 34);
            this.btnEditBoss.Name = "btnEditBoss";
            this.btnEditBoss.Size = new System.Drawing.Size(101, 28);
            this.btnEditBoss.TabIndex = 4;
            this.btnEditBoss.Text = "Edit boss";
            this.btnEditBoss.UseVisualStyleBackColor = true;
            this.btnEditBoss.Click += new System.EventHandler(this.btnEditBoss_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.butt_change_boss);
            this.groupBox4.Controls.Add(this.btnEmplEdit);
            this.groupBox4.Controls.Add(this.btnEmplAdd);
            this.groupBox4.Controls.Add(this.btnEmplDelete);
            this.groupBox4.Location = new System.Drawing.Point(359, 387);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(339, 108);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Employee control";
            // 
            // butt_change_boss
            // 
            this.butt_change_boss.Location = new System.Drawing.Point(5, 68);
            this.butt_change_boss.Name = "butt_change_boss";
            this.butt_change_boss.Size = new System.Drawing.Size(101, 28);
            this.butt_change_boss.TabIndex = 5;
            this.butt_change_boss.Text = "Change boss";
            this.butt_change_boss.UseVisualStyleBackColor = true;
            this.butt_change_boss.Click += new System.EventHandler(this.Butt_change_boss_Click);
            // 
            // btnEmplEdit
            // 
            this.btnEmplEdit.Location = new System.Drawing.Point(126, 34);
            this.btnEmplEdit.Name = "btnEmplEdit";
            this.btnEmplEdit.Size = new System.Drawing.Size(101, 28);
            this.btnEmplEdit.TabIndex = 4;
            this.btnEmplEdit.Text = "Edit empl";
            this.btnEmplEdit.UseVisualStyleBackColor = true;
            this.btnEmplEdit.Click += new System.EventHandler(this.btnEmplEdit_Click);
            // 
            // btnEmplAdd
            // 
            this.btnEmplAdd.Location = new System.Drawing.Point(5, 34);
            this.btnEmplAdd.Name = "btnEmplAdd";
            this.btnEmplAdd.Size = new System.Drawing.Size(101, 28);
            this.btnEmplAdd.TabIndex = 2;
            this.btnEmplAdd.Text = "Add empl";
            this.btnEmplAdd.UseVisualStyleBackColor = true;
            this.btnEmplAdd.Click += new System.EventHandler(this.btnEmplAdd_Click);
            // 
            // btnEmplDelete
            // 
            this.btnEmplDelete.Location = new System.Drawing.Point(242, 34);
            this.btnEmplDelete.Name = "btnEmplDelete";
            this.btnEmplDelete.Size = new System.Drawing.Size(93, 28);
            this.btnEmplDelete.TabIndex = 3;
            this.btnEmplDelete.Text = "Delete empl";
            this.btnEmplDelete.UseVisualStyleBackColor = true;
            this.btnEmplDelete.Click += new System.EventHandler(this.btnEmplDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnGenerateSampleData
            // 
            this.btnGenerateSampleData.Location = new System.Drawing.Point(25, 122);
            this.btnGenerateSampleData.Name = "btnGenerateSampleData";
            this.btnGenerateSampleData.Size = new System.Drawing.Size(101, 28);
            this.btnGenerateSampleData.TabIndex = 10;
            this.btnGenerateSampleData.Text = "Generate";
            this.btnGenerateSampleData.UseVisualStyleBackColor = true;
            this.btnGenerateSampleData.Click += new System.EventHandler(this.btnGenerateSampleData_Click);
            // 
            // groupBoxGenerator
            // 
            this.groupBoxGenerator.Controls.Add(this.rBtnBoth);
            this.groupBoxGenerator.Controls.Add(this.rBtnEmployee);
            this.groupBoxGenerator.Controls.Add(this.countLabel);
            this.groupBoxGenerator.Controls.Add(this.btnGenerateSampleData);
            this.groupBoxGenerator.Controls.Add(this.txtCount);
            this.groupBoxGenerator.Controls.Add(this.rBtnBoss);
            this.groupBoxGenerator.Location = new System.Drawing.Point(11, 500);
            this.groupBoxGenerator.Name = "groupBoxGenerator";
            this.groupBoxGenerator.Size = new System.Drawing.Size(156, 158);
            this.groupBoxGenerator.TabIndex = 11;
            this.groupBoxGenerator.TabStop = false;
            this.groupBoxGenerator.Text = "Boss / Employee generator";
            // 
            // rBtnBoth
            // 
            this.rBtnBoth.AutoSize = true;
            this.rBtnBoth.Checked = true;
            this.rBtnBoth.Location = new System.Drawing.Point(6, 66);
            this.rBtnBoth.Name = "rBtnBoth";
            this.rBtnBoth.Size = new System.Drawing.Size(118, 17);
            this.rBtnBoth.TabIndex = 11;
            this.rBtnBoth.TabStop = true;
            this.rBtnBoth.Text = "Boss and Employee";
            this.rBtnBoth.UseVisualStyleBackColor = true;
            // 
            // rBtnEmployee
            // 
            this.rBtnEmployee.AutoSize = true;
            this.rBtnEmployee.Location = new System.Drawing.Point(6, 43);
            this.rBtnEmployee.Name = "rBtnEmployee";
            this.rBtnEmployee.Size = new System.Drawing.Size(71, 17);
            this.rBtnEmployee.TabIndex = 1;
            this.rBtnEmployee.Text = "Employee";
            this.rBtnEmployee.UseVisualStyleBackColor = true;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(6, 92);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(38, 13);
            this.countLabel.TabIndex = 3;
            this.countLabel.Text = "Count:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(50, 89);
            this.txtCount.MaxLength = 3;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(56, 20);
            this.txtCount.TabIndex = 2;
            this.txtCount.Text = "0";
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // rBtnBoss
            // 
            this.rBtnBoss.AutoSize = true;
            this.rBtnBoss.Location = new System.Drawing.Point(6, 20);
            this.rBtnBoss.Name = "rBtnBoss";
            this.rBtnBoss.Size = new System.Drawing.Size(48, 17);
            this.rBtnBoss.TabIndex = 0;
            this.rBtnBoss.Text = "Boss";
            this.rBtnBoss.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 668);
            this.Controls.Add(this.groupBoxGenerator);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBoxGenerator.ResumeLayout(false);
            this.groupBoxGenerator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOfBosses;
        private System.Windows.Forms.Button btnAddBoss;
        private System.Windows.Forms.Button btnDelBoss;
        private System.Windows.Forms.ListBox listBoxEmpl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditBoss;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEmplEdit;
        private System.Windows.Forms.Button btnEmplAdd;
        private System.Windows.Forms.Button btnEmplDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnGenerateSampleData;
        private System.Windows.Forms.Button btnExportBoss;
        private System.Windows.Forms.Button btnImportBoss;
        private System.Windows.Forms.Button butt_change_boss;
        private System.Windows.Forms.GroupBox groupBoxGenerator;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.RadioButton rBtnEmployee;
        private System.Windows.Forms.RadioButton rBtnBoss;
        private System.Windows.Forms.RadioButton rBtnBoth;
    }
}

