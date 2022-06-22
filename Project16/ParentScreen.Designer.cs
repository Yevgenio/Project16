namespace Project16
{
    partial class ParentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentScreen));
            this.Questionnaire_ParScreen = new System.Windows.Forms.Button();
            this.Attendance_ParScreen = new System.Windows.Forms.Button();
            this.Quit_ParScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Questionnaire_ParScreen
            // 
            this.Questionnaire_ParScreen.Location = new System.Drawing.Point(327, 44);
            this.Questionnaire_ParScreen.Name = "Questionnaire_ParScreen";
            this.Questionnaire_ParScreen.Size = new System.Drawing.Size(75, 23);
            this.Questionnaire_ParScreen.TabIndex = 0;
            this.Questionnaire_ParScreen.Text = "שאלונים";
            this.Questionnaire_ParScreen.UseVisualStyleBackColor = true;
            // 
            // Attendance_ParScreen
            // 
            this.Attendance_ParScreen.Location = new System.Drawing.Point(176, 44);
            this.Attendance_ParScreen.Name = "Attendance_ParScreen";
            this.Attendance_ParScreen.Size = new System.Drawing.Size(75, 23);
            this.Attendance_ParScreen.TabIndex = 1;
            this.Attendance_ParScreen.Text = "נוכחות ";
            this.Attendance_ParScreen.UseVisualStyleBackColor = true;
            // 
            // Quit_ParScreen
            // 
            this.Quit_ParScreen.Location = new System.Drawing.Point(36, 203);
            this.Quit_ParScreen.Name = "Quit_ParScreen";
            this.Quit_ParScreen.Size = new System.Drawing.Size(72, 26);
            this.Quit_ParScreen.TabIndex = 2;
            this.Quit_ParScreen.Text = "התנתק";
            this.Quit_ParScreen.UseVisualStyleBackColor = true;
            // 
            // ParentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 251);
            this.Controls.Add(this.Quit_ParScreen);
            this.Controls.Add(this.Attendance_ParScreen);
            this.Controls.Add(this.Questionnaire_ParScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParentScreen";
            this.Text = "ParentScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Questionnaire_ParScreen;
        private System.Windows.Forms.Button Attendance_ParScreen;
        private System.Windows.Forms.Button Quit_ParScreen;
    }
}