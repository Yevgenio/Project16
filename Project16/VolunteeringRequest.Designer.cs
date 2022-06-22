namespace Project16
{
    partial class VolunteerRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolunteerRequest));
            this.ApplyNewRequest = new System.Windows.Forms.Button();
            this.InsertRecruitmentAssignment = new System.Windows.Forms.Button();
            this.Quit_VolReqScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApplyNewRequest
            // 
            this.ApplyNewRequest.Location = new System.Drawing.Point(92, 61);
            this.ApplyNewRequest.Name = "ApplyNewRequest";
            this.ApplyNewRequest.Size = new System.Drawing.Size(121, 57);
            this.ApplyNewRequest.TabIndex = 0;
            this.ApplyNewRequest.Text = "הגש בקשה חדשה ";
            this.ApplyNewRequest.UseVisualStyleBackColor = true;
            // 
            // InsertRecruitmentAssignment
            // 
            this.InsertRecruitmentAssignment.Location = new System.Drawing.Point(268, 61);
            this.InsertRecruitmentAssignment.Name = "InsertRecruitmentAssignment";
            this.InsertRecruitmentAssignment.Size = new System.Drawing.Size(119, 57);
            this.InsertRecruitmentAssignment.TabIndex = 1;
            this.InsertRecruitmentAssignment.Text = "הזן משימה חינוכית לבקשה קיימת ";
            this.InsertRecruitmentAssignment.UseVisualStyleBackColor = true;
            // 
            // Quit_VolReqScreen
            // 
            this.Quit_VolReqScreen.Location = new System.Drawing.Point(12, 170);
            this.Quit_VolReqScreen.Name = "Quit_VolReqScreen";
            this.Quit_VolReqScreen.Size = new System.Drawing.Size(111, 23);
            this.Quit_VolReqScreen.TabIndex = 2;
            this.Quit_VolReqScreen.Text = "חזרה למסך ראשי ";
            this.Quit_VolReqScreen.UseVisualStyleBackColor = true;
            // 
            // VolunteerRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 205);
            this.Controls.Add(this.Quit_VolReqScreen);
            this.Controls.Add(this.InsertRecruitmentAssignment);
            this.Controls.Add(this.ApplyNewRequest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VolunteerRequest";
            this.Text = "VolunteerRequest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ApplyNewRequest;
        private System.Windows.Forms.Button InsertRecruitmentAssignment;
        private System.Windows.Forms.Button Quit_VolReqScreen;
    }
}