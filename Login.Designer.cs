namespace CS325_broadSword_flowerProject
{
    partial class Login
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
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(665, 731);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(210, 31);
            this.UserNameInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(665, 782);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(210, 31);
            this.PasswordInput.TabIndex = 1;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(549, 734);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(110, 25);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Username";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(549, 785);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(106, 25);
            this.PassLabel.TabIndex = 3;
            this.PassLabel.Text = "Password";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(706, 829);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(131, 50);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CS325_broadSword_flowerProject.Properties.Resources.theBest;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1384, 716);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(881, 737);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username = jared";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(881, 782);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password = pass";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 955);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UserNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}