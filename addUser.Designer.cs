namespace CS325_broadSword_flowerProject
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.firstLabel = new System.Windows.Forms.Label();
            this.lastLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.firstInput = new System.Windows.Forms.TextBox();
            this.lastInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accessSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.submitButton.Location = new System.Drawing.Point(142, 275);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(135, 60);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.cancelButton.Location = new System.Drawing.Point(283, 275);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 60);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(65, 48);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(60, 25);
            this.firstLabel.TabIndex = 2;
            this.firstLabel.Text = "First:";
            this.firstLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Location = new System.Drawing.Point(65, 93);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(59, 25);
            this.lastLabel.TabIndex = 3;
            this.lastLabel.Text = "Last:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(9, 138);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(116, 25);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Username:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(13, 183);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(112, 25);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "Password:";
            // 
            // firstInput
            // 
            this.firstInput.Location = new System.Drawing.Point(134, 45);
            this.firstInput.Name = "firstInput";
            this.firstInput.Size = new System.Drawing.Size(284, 31);
            this.firstInput.TabIndex = 6;
            // 
            // lastInput
            // 
            this.lastInput.Location = new System.Drawing.Point(134, 90);
            this.lastInput.Name = "lastInput";
            this.lastInput.Size = new System.Drawing.Size(284, 31);
            this.lastInput.TabIndex = 7;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(134, 138);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(284, 31);
            this.usernameInput.TabIndex = 8;
            // 
            // passInput
            // 
            this.passInput.Location = new System.Drawing.Point(134, 180);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(284, 31);
            this.passInput.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Level:";
            // 
            // accessSelect
            // 
            this.accessSelect.DisplayMember = "1";
            this.accessSelect.FormattingEnabled = true;
            this.accessSelect.Items.AddRange(new object[] {
            "Student",
            "Administrator",
            "Researcher"});
            this.accessSelect.Location = new System.Drawing.Point(134, 226);
            this.accessSelect.Name = "accessSelect";
            this.accessSelect.Size = new System.Drawing.Size(284, 33);
            this.accessSelect.TabIndex = 11;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 356);
            this.Controls.Add(this.accessSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.lastInput);
            this.Controls.Add(this.firstInput);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.lastLabel);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.addUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox firstInput;
        private System.Windows.Forms.TextBox lastInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox accessSelect;
    }
}