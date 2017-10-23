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
            this.SuspendLayout();
            // 
            // listBoxOfBosses
            // 
            this.listBoxOfBosses.FormattingEnabled = true;
            this.listBoxOfBosses.Location = new System.Drawing.Point(12, 12);
            this.listBoxOfBosses.Name = "listBoxOfBosses";
            this.listBoxOfBosses.Size = new System.Drawing.Size(681, 407);
            this.listBoxOfBosses.TabIndex = 0;
            // 
            // btnAddBoss
            // 
            this.btnAddBoss.Location = new System.Drawing.Point(13, 426);
            this.btnAddBoss.Name = "btnAddBoss";
            this.btnAddBoss.Size = new System.Drawing.Size(101, 28);
            this.btnAddBoss.TabIndex = 2;
            this.btnAddBoss.Text = "Add boss";
            this.btnAddBoss.UseVisualStyleBackColor = true;
            this.btnAddBoss.Click += new System.EventHandler(this.btnAddBoss_Click);
            // 
            // btnDelBoss
            // 
            this.btnDelBoss.Location = new System.Drawing.Point(121, 426);
            this.btnDelBoss.Name = "btnDelBoss";
            this.btnDelBoss.Size = new System.Drawing.Size(93, 28);
            this.btnDelBoss.TabIndex = 3;
            this.btnDelBoss.Text = "Delete boss";
            this.btnDelBoss.UseVisualStyleBackColor = true;
            this.btnDelBoss.Click += new System.EventHandler(this.btnDelBoss_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 463);
            this.Controls.Add(this.btnDelBoss);
            this.Controls.Add(this.btnAddBoss);
            this.Controls.Add(this.listBoxOfBosses);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOfBosses;
        private System.Windows.Forms.Button btnAddBoss;
        private System.Windows.Forms.Button btnDelBoss;
    }
}

