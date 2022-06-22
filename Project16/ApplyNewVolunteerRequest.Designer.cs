namespace Project16
{
    partial class ApplyNewVolunteerRequest
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
            System.Windows.Forms.ComboBox VolunteerPlaceEnum;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyNewVolunteerRequest));
            this.ApplyScreenTitle = new System.Windows.Forms.Label();
            this.InstractionTitle = new System.Windows.Forms.Label();
            this.CandidateIDTitle = new System.Windows.Forms.Label();
            this.candidateID = new System.Windows.Forms.TextBox();
            this.firstNameTitle = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastNameTitle = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.genderTitle = new System.Windows.Forms.Label();
            this.GenderEnum = new System.Windows.Forms.ComboBox();
            this.maritalStatusTitle = new System.Windows.Forms.Label();
            this.MaritalEnum = new System.Windows.Forms.ComboBox();
            this.emailTitle = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.phoneNumberTitle = new System.Windows.Forms.Label();
            this.phonNumber = new System.Windows.Forms.TextBox();
            this.cellphoneNumberTitle = new System.Windows.Forms.Label();
            this.cellphoneNumber = new System.Windows.Forms.TextBox();
            this.acacdemicInstitutionTitle = new System.Windows.Forms.Label();
            this.InstitutionEnum = new System.Windows.Forms.ComboBox();
            this.volunteeringPlacePreferenceTitle = new System.Windows.Forms.Label();
            VolunteerPlaceEnum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ApplyScreenTitle
            // 
            this.ApplyScreenTitle.AutoSize = true;
            this.ApplyScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ApplyScreenTitle.Location = new System.Drawing.Point(125, 23);
            this.ApplyScreenTitle.Name = "ApplyScreenTitle";
            this.ApplyScreenTitle.Size = new System.Drawing.Size(401, 36);
            this.ApplyScreenTitle.TabIndex = 0;
            this.ApplyScreenTitle.Text = "Apply new volunteer request ";
            this.ApplyScreenTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // InstractionTitle
            // 
            this.InstractionTitle.AutoSize = true;
            this.InstractionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.InstractionTitle.Location = new System.Drawing.Point(67, 95);
            this.InstractionTitle.Name = "InstractionTitle";
            this.InstractionTitle.Size = new System.Drawing.Size(207, 18);
            this.InstractionTitle.TabIndex = 1;
            this.InstractionTitle.Text = "please fill in the following fields";
            this.InstractionTitle.Click += new System.EventHandler(this.InstractionTitle_Click);
            // 
            // CandidateIDTitle
            // 
            this.CandidateIDTitle.AutoSize = true;
            this.CandidateIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CandidateIDTitle.Location = new System.Drawing.Point(67, 136);
            this.CandidateIDTitle.Name = "CandidateIDTitle";
            this.CandidateIDTitle.Size = new System.Drawing.Size(19, 15);
            this.CandidateIDTitle.TabIndex = 2;
            this.CandidateIDTitle.Text = "ID";
            this.CandidateIDTitle.Click += new System.EventHandler(this.CandidateIDTitle_Click);
            // 
            // candidateID
            // 
            this.candidateID.Location = new System.Drawing.Point(109, 136);
            this.candidateID.Name = "candidateID";
            this.candidateID.Size = new System.Drawing.Size(100, 20);
            this.candidateID.TabIndex = 3;
            // 
            // firstNameTitle
            // 
            this.firstNameTitle.AutoSize = true;
            this.firstNameTitle.Location = new System.Drawing.Point(67, 183);
            this.firstNameTitle.Name = "firstNameTitle";
            this.firstNameTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.firstNameTitle.Size = new System.Drawing.Size(55, 13);
            this.firstNameTitle.TabIndex = 4;
            this.firstNameTitle.Text = "First name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(131, 179);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 5;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // lastNameTitle
            // 
            this.lastNameTitle.AutoSize = true;
            this.lastNameTitle.Location = new System.Drawing.Point(352, 186);
            this.lastNameTitle.Name = "lastNameTitle";
            this.lastNameTitle.Size = new System.Drawing.Size(56, 13);
            this.lastNameTitle.TabIndex = 6;
            this.lastNameTitle.Text = "Last name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(462, 183);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 7;
            // 
            // genderTitle
            // 
            this.genderTitle.AutoSize = true;
            this.genderTitle.Location = new System.Drawing.Point(67, 229);
            this.genderTitle.Name = "genderTitle";
            this.genderTitle.Size = new System.Drawing.Size(42, 13);
            this.genderTitle.TabIndex = 8;
            this.genderTitle.Text = "Gender";
            // 
            // GenderEnum
            // 
            this.GenderEnum.FormattingEnabled = true;
            this.GenderEnum.Location = new System.Drawing.Point(131, 221);
            this.GenderEnum.Name = "GenderEnum";
            this.GenderEnum.Size = new System.Drawing.Size(121, 21);
            this.GenderEnum.TabIndex = 9;
            // 
            // maritalStatusTitle
            // 
            this.maritalStatusTitle.AutoSize = true;
            this.maritalStatusTitle.Location = new System.Drawing.Point(352, 233);
            this.maritalStatusTitle.Name = "maritalStatusTitle";
            this.maritalStatusTitle.Size = new System.Drawing.Size(69, 13);
            this.maritalStatusTitle.TabIndex = 10;
            this.maritalStatusTitle.Text = "Marital status";
            // 
            // MaritalEnum
            // 
            this.MaritalEnum.FormattingEnabled = true;
            this.MaritalEnum.Location = new System.Drawing.Point(462, 225);
            this.MaritalEnum.Name = "MaritalEnum";
            this.MaritalEnum.Size = new System.Drawing.Size(121, 21);
            this.MaritalEnum.TabIndex = 11;
            // 
            // emailTitle
            // 
            this.emailTitle.AutoSize = true;
            this.emailTitle.Location = new System.Drawing.Point(352, 144);
            this.emailTitle.Name = "emailTitle";
            this.emailTitle.Size = new System.Drawing.Size(35, 13);
            this.emailTitle.TabIndex = 12;
            this.emailTitle.Text = "E-mail";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(412, 136);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(167, 20);
            this.email.TabIndex = 13;
            // 
            // phoneNumberTitle
            // 
            this.phoneNumberTitle.AutoSize = true;
            this.phoneNumberTitle.Location = new System.Drawing.Point(67, 269);
            this.phoneNumberTitle.Name = "phoneNumberTitle";
            this.phoneNumberTitle.Size = new System.Drawing.Size(76, 13);
            this.phoneNumberTitle.TabIndex = 14;
            this.phoneNumberTitle.Text = "Phone number";
            // 
            // phonNumber
            // 
            this.phonNumber.Location = new System.Drawing.Point(152, 269);
            this.phonNumber.Name = "phonNumber";
            this.phonNumber.Size = new System.Drawing.Size(100, 20);
            this.phonNumber.TabIndex = 15;
            // 
            // cellphoneNumberTitle
            // 
            this.cellphoneNumberTitle.AutoSize = true;
            this.cellphoneNumberTitle.Location = new System.Drawing.Point(352, 276);
            this.cellphoneNumberTitle.Name = "cellphoneNumberTitle";
            this.cellphoneNumberTitle.Size = new System.Drawing.Size(92, 13);
            this.cellphoneNumberTitle.TabIndex = 16;
            this.cellphoneNumberTitle.Text = "Cellphone number";
            // 
            // cellphoneNumber
            // 
            this.cellphoneNumber.Location = new System.Drawing.Point(462, 273);
            this.cellphoneNumber.Name = "cellphoneNumber";
            this.cellphoneNumber.Size = new System.Drawing.Size(100, 20);
            this.cellphoneNumber.TabIndex = 17;
            // 
            // acacdemicInstitutionTitle
            // 
            this.acacdemicInstitutionTitle.AutoSize = true;
            this.acacdemicInstitutionTitle.Location = new System.Drawing.Point(67, 314);
            this.acacdemicInstitutionTitle.Name = "acacdemicInstitutionTitle";
            this.acacdemicInstitutionTitle.Size = new System.Drawing.Size(101, 13);
            this.acacdemicInstitutionTitle.TabIndex = 18;
            this.acacdemicInstitutionTitle.Text = "Academic institution";
            // 
            // InstitutionEnum
            // 
            this.InstitutionEnum.FormattingEnabled = true;
            this.InstitutionEnum.Location = new System.Drawing.Point(184, 316);
            this.InstitutionEnum.Name = "InstitutionEnum";
            this.InstitutionEnum.Size = new System.Drawing.Size(121, 21);
            this.InstitutionEnum.TabIndex = 19;
            // 
            // volunteeringPlacePreferenceTitle
            // 
            this.volunteeringPlacePreferenceTitle.AutoSize = true;
            this.volunteeringPlacePreferenceTitle.Location = new System.Drawing.Point(352, 324);
            this.volunteeringPlacePreferenceTitle.Name = "volunteeringPlacePreferenceTitle";
            this.volunteeringPlacePreferenceTitle.Size = new System.Drawing.Size(95, 13);
            this.volunteeringPlacePreferenceTitle.TabIndex = 20;
            this.volunteeringPlacePreferenceTitle.Text = "Volunteering place";
            // 
            // VolunteerPlaceEnum
            // 
            VolunteerPlaceEnum.FormattingEnabled = true;
            VolunteerPlaceEnum.Location = new System.Drawing.Point(480, 316);
            VolunteerPlaceEnum.Name = "VolunteerPlaceEnum";
            VolunteerPlaceEnum.Size = new System.Drawing.Size(121, 21);
            VolunteerPlaceEnum.TabIndex = 21;
            // 
            // ApplyNewVolunteerRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 493);
            this.Controls.Add(VolunteerPlaceEnum);
            this.Controls.Add(this.volunteeringPlacePreferenceTitle);
            this.Controls.Add(this.InstitutionEnum);
            this.Controls.Add(this.acacdemicInstitutionTitle);
            this.Controls.Add(this.cellphoneNumber);
            this.Controls.Add(this.cellphoneNumberTitle);
            this.Controls.Add(this.phonNumber);
            this.Controls.Add(this.phoneNumberTitle);
            this.Controls.Add(this.email);
            this.Controls.Add(this.emailTitle);
            this.Controls.Add(this.MaritalEnum);
            this.Controls.Add(this.maritalStatusTitle);
            this.Controls.Add(this.GenderEnum);
            this.Controls.Add(this.genderTitle);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.lastNameTitle);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.firstNameTitle);
            this.Controls.Add(this.candidateID);
            this.Controls.Add(this.CandidateIDTitle);
            this.Controls.Add(this.InstractionTitle);
            this.Controls.Add(this.ApplyScreenTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplyNewVolunteerRequest";
            this.Text = "ApplyNewVolunteerRequest";
            this.Load += new System.EventHandler(this.ApplyNewVolunteerRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ApplyScreenTitle;
        private System.Windows.Forms.Label InstractionTitle;
        private System.Windows.Forms.Label CandidateIDTitle;
        private System.Windows.Forms.TextBox candidateID;
        private System.Windows.Forms.Label firstNameTitle;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label lastNameTitle;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label genderTitle;
        private System.Windows.Forms.ComboBox GenderEnum;
        private System.Windows.Forms.Label maritalStatusTitle;
        private System.Windows.Forms.ComboBox MaritalEnum;
        private System.Windows.Forms.Label emailTitle;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label phoneNumberTitle;
        private System.Windows.Forms.TextBox phonNumber;
        private System.Windows.Forms.Label cellphoneNumberTitle;
        private System.Windows.Forms.TextBox cellphoneNumber;
        private System.Windows.Forms.Label acacdemicInstitutionTitle;
        private System.Windows.Forms.ComboBox InstitutionEnum;
        private System.Windows.Forms.Label volunteeringPlacePreferenceTitle;
    }
}