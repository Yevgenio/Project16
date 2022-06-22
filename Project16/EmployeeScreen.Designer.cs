namespace Project16
{
    partial class EmployeeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeScreen));
            this.ManagePositionAmounts = new System.Windows.Forms.Button();
            this.NewVolunteersRecruitment = new System.Windows.Forms.Button();
            this.Questionnaires_EmpScreen = new System.Windows.Forms.Button();
            this.Attandance_EmpScreen = new System.Windows.Forms.Button();
            this.CadetAssignments_EmpScreen = new System.Windows.Forms.Button();
            this.AddUser_EmpScreen = new System.Windows.Forms.Button();
            this.Quit_EmpScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManagePositionAmounts
            // 
            this.ManagePositionAmounts.Location = new System.Drawing.Point(179, 42);
            this.ManagePositionAmounts.Name = "ManagePositionAmounts";
            this.ManagePositionAmounts.Size = new System.Drawing.Size(75, 42);
            this.ManagePositionAmounts.TabIndex = 0;
            this.ManagePositionAmounts.Text = "ניהול תקנים";
            this.ManagePositionAmounts.UseVisualStyleBackColor = true;
            this.ManagePositionAmounts.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewVolunteersRecruitment
            // 
            this.NewVolunteersRecruitment.Location = new System.Drawing.Point(307, 43);
            this.NewVolunteersRecruitment.Name = "NewVolunteersRecruitment";
            this.NewVolunteersRecruitment.Size = new System.Drawing.Size(77, 41);
            this.NewVolunteersRecruitment.TabIndex = 1;
            this.NewVolunteersRecruitment.Text = "גיוס מתנדבים ";
            this.NewVolunteersRecruitment.UseVisualStyleBackColor = true;
            this.NewVolunteersRecruitment.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Questionnaires_EmpScreen
            // 
            this.Questionnaires_EmpScreen.Location = new System.Drawing.Point(53, 42);
            this.Questionnaires_EmpScreen.Name = "Questionnaires_EmpScreen";
            this.Questionnaires_EmpScreen.Size = new System.Drawing.Size(77, 41);
            this.Questionnaires_EmpScreen.TabIndex = 2;
            this.Questionnaires_EmpScreen.Text = "שאלונים";
            this.Questionnaires_EmpScreen.UseVisualStyleBackColor = true;
            // 
            // Attandance_EmpScreen
            // 
            this.Attandance_EmpScreen.Location = new System.Drawing.Point(435, 138);
            this.Attandance_EmpScreen.Name = "Attandance_EmpScreen";
            this.Attandance_EmpScreen.Size = new System.Drawing.Size(77, 41);
            this.Attandance_EmpScreen.TabIndex = 3;
            this.Attandance_EmpScreen.Text = "נוכחות ";
            this.Attandance_EmpScreen.UseVisualStyleBackColor = true;
            // 
            // CadetAssignments_EmpScreen
            // 
            this.CadetAssignments_EmpScreen.Location = new System.Drawing.Point(307, 138);
            this.CadetAssignments_EmpScreen.Name = "CadetAssignments_EmpScreen";
            this.CadetAssignments_EmpScreen.Size = new System.Drawing.Size(77, 41);
            this.CadetAssignments_EmpScreen.TabIndex = 4;
            this.CadetAssignments_EmpScreen.Text = "משימות חניכים";
            this.CadetAssignments_EmpScreen.UseVisualStyleBackColor = true;
            this.CadetAssignments_EmpScreen.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // AddUser_EmpScreen
            // 
            this.AddUser_EmpScreen.Location = new System.Drawing.Point(435, 44);
            this.AddUser_EmpScreen.Name = "AddUser_EmpScreen";
            this.AddUser_EmpScreen.Size = new System.Drawing.Size(77, 41);
            this.AddUser_EmpScreen.TabIndex = 5;
            this.AddUser_EmpScreen.Text = "הוספת משתמש";
            this.AddUser_EmpScreen.UseVisualStyleBackColor = true;
            this.AddUser_EmpScreen.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Quit_EmpScreen
            // 
            this.Quit_EmpScreen.Location = new System.Drawing.Point(12, 252);
            this.Quit_EmpScreen.Name = "Quit_EmpScreen";
            this.Quit_EmpScreen.Size = new System.Drawing.Size(75, 23);
            this.Quit_EmpScreen.TabIndex = 6;
            this.Quit_EmpScreen.Text = "התנתק";
            this.Quit_EmpScreen.UseVisualStyleBackColor = true;
            // 
            // EmployeeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 287);
            this.Controls.Add(this.Quit_EmpScreen);
            this.Controls.Add(this.AddUser_EmpScreen);
            this.Controls.Add(this.CadetAssignments_EmpScreen);
            this.Controls.Add(this.Attandance_EmpScreen);
            this.Controls.Add(this.Questionnaires_EmpScreen);
            this.Controls.Add(this.NewVolunteersRecruitment);
            this.Controls.Add(this.ManagePositionAmounts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeScreen";
            this.Text = "Employee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManagePositionAmounts;
        private System.Windows.Forms.Button NewVolunteersRecruitment;
        private System.Windows.Forms.Button Questionnaires_EmpScreen;
        private System.Windows.Forms.Button Attandance_EmpScreen;
        private System.Windows.Forms.Button CadetAssignments_EmpScreen;
        private System.Windows.Forms.Button AddUser_EmpScreen;
        private System.Windows.Forms.Button Quit_EmpScreen;
    }
}