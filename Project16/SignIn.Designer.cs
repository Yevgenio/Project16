namespace Project16
{
    public partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.InsertID = new System.Windows.Forms.Label();
            this.InsertIDTable = new System.Windows.Forms.TextBox();
            this.InsertPasswordTable = new System.Windows.Forms.TextBox();
            this.InsertPassword = new System.Windows.Forms.Label();
            this.OpeningScreen = new System.Windows.Forms.Label();
            this.insertVolenteeringRequest = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InsertID
            // 
            this.InsertID.AutoSize = true;
            this.InsertID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.InsertID.Location = new System.Drawing.Point(285, 94);
            this.InsertID.Name = "InsertID";
            this.InsertID.Size = new System.Drawing.Size(152, 24);
            this.InsertID.TabIndex = 2;
            this.InsertID.Text = "הכנס תעודת זהות ";
            this.InsertID.Click += new System.EventHandler(this.label1_Click);
            // 
            // InsertIDTable
            // 
            this.InsertIDTable.Location = new System.Drawing.Point(82, 94);
            this.InsertIDTable.Name = "InsertIDTable";
            this.InsertIDTable.Size = new System.Drawing.Size(100, 20);
            this.InsertIDTable.TabIndex = 3;
            this.InsertIDTable.TextChanged += new System.EventHandler(this.InsertIDTable_TextChanged);
            // 
            // InsertPasswordTable
            // 
            this.InsertPasswordTable.Location = new System.Drawing.Point(82, 161);
            this.InsertPasswordTable.Name = "InsertPasswordTable";
            this.InsertPasswordTable.Size = new System.Drawing.Size(100, 20);
            this.InsertPasswordTable.TabIndex = 4;
            this.InsertPasswordTable.TextChanged += new System.EventHandler(this.InsertPasswordTable_TextChanged);
            // 
            // InsertPassword
            // 
            this.InsertPassword.AutoSize = true;
            this.InsertPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.InsertPassword.Location = new System.Drawing.Point(305, 156);
            this.InsertPassword.Name = "InsertPassword";
            this.InsertPassword.Size = new System.Drawing.Size(110, 24);
            this.InsertPassword.TabIndex = 5;
            this.InsertPassword.Text = "הכנס סיסמא ";
            this.InsertPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // OpeningScreen
            // 
            this.OpeningScreen.AutoSize = true;
            this.OpeningScreen.Font = new System.Drawing.Font("Adobe Gothic Std B", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OpeningScreen.Location = new System.Drawing.Point(195, 36);
            this.OpeningScreen.Name = "OpeningScreen";
            this.OpeningScreen.Size = new System.Drawing.Size(148, 35);
            this.OpeningScreen.TabIndex = 6;
            this.OpeningScreen.Text = "מסך כניסה ";
            // 
            // insertVolenteeringRequest
            // 
            this.insertVolenteeringRequest.Location = new System.Drawing.Point(170, 240);
            this.insertVolenteeringRequest.Name = "insertVolenteeringRequest";
            this.insertVolenteeringRequest.Size = new System.Drawing.Size(144, 23);
            this.insertVolenteeringRequest.TabIndex = 7;
            this.insertVolenteeringRequest.Text = "הגש בקשה להתנדבות ";
            this.insertVolenteeringRequest.UseVisualStyleBackColor = true;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(201, 197);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 8;
            this.Insert.Text = "הכנס";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // SignIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(545, 283);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.insertVolenteeringRequest);
            this.Controls.Add(this.OpeningScreen);
            this.Controls.Add(this.InsertPassword);
            this.Controls.Add(this.InsertPasswordTable);
            this.Controls.Add(this.InsertIDTable);
            this.Controls.Add(this.InsertID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InsertID;
        private System.Windows.Forms.TextBox InsertIDTable;
        private System.Windows.Forms.Label InsertPassword;
        private System.Windows.Forms.TextBox InsertPasswordTable;
        private System.Windows.Forms.Label OpeningScreen;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button insertVolenteeringRequest;
    }

    private void Insert_btn_Click()
    {
        this.hide();

    }
}

