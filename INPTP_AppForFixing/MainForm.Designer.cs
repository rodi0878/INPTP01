namespace INPTP_AppForFixing
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
            this.btnEditBoss = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxOfBosses
            // 
            this.listBoxOfBosses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOfBosses.FormattingEnabled = true;
            this.listBoxOfBosses.ItemHeight = 16;
            this.listBoxOfBosses.Location = new System.Drawing.Point(7, 22);
            this.listBoxOfBosses.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxOfBosses.Name = "listBoxOfBosses";
            this.listBoxOfBosses.Size = new System.Drawing.Size(440, 404);
            this.listBoxOfBosses.TabIndex = 0;
            // 
            // btnAddBoss
            // 
            this.btnAddBoss.Location = new System.Drawing.Point(7, 42);
            this.btnAddBoss.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBoss.Name = "btnAddBoss";
            this.btnAddBoss.Size = new System.Drawing.Size(135, 34);
            this.btnAddBoss.TabIndex = 2;
            this.btnAddBoss.Text = "Add boss";
            this.btnAddBoss.UseVisualStyleBackColor = true;
            this.btnAddBoss.Click += new System.EventHandler(this.btnAddBoss_Click);
            // 
            // btnDelBoss
            // 
            this.btnDelBoss.Location = new System.Drawing.Point(323, 42);
            this.btnDelBoss.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelBoss.Name = "btnDelBoss";
            this.btnDelBoss.Size = new System.Drawing.Size(124, 34);
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
            this.listBoxEmpl.ItemHeight = 16;
            this.listBoxEmpl.Location = new System.Drawing.Point(6, 21);
            this.listBoxEmpl.Name = "listBoxEmpl";
            this.listBoxEmpl.Size = new System.Drawing.Size(440, 404);
            this.listBoxEmpl.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxOfBosses);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 457);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Bosses";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listBoxEmpl);
            this.groupBox2.Location = new System.Drawing.Point(476, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 457);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Employes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditBoss);
            this.groupBox3.Controls.Add(this.btnAddBoss);
            this.groupBox3.Controls.Add(this.btnDelBoss);
            this.groupBox3.Location = new System.Drawing.Point(12, 475);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 83);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Boss control";
            // 
            // btnEditBoss
            // 
            this.btnEditBoss.Location = new System.Drawing.Point(168, 42);
            this.btnEditBoss.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditBoss.Name = "btnEditBoss";
            this.btnEditBoss.Size = new System.Drawing.Size(135, 34);
            this.btnEditBoss.TabIndex = 4;
            this.btnEditBoss.Text = "Edit boss";
            this.btnEditBoss.UseVisualStyleBackColor = true;
            this.btnEditBoss.Click += new System.EventHandler(this.btnEditBoss_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 570);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

