namespace CS325_broadSword_flowerProject
{
    partial class editUserDialog
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
            this.firstText = new System.Windows.Forms.TextBox();
            this.lastText = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.levelCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstText
            // 
            this.firstText.Location = new System.Drawing.Point(153, 22);
            this.firstText.Name = "firstText";
            this.firstText.Size = new System.Drawing.Size(270, 31);
            this.firstText.TabIndex = 0;
            // 
            // lastText
            // 
            this.lastText.Location = new System.Drawing.Point(153, 69);
            this.lastText.Name = "lastText";
            this.lastText.Size = new System.Drawing.Size(270, 31);
            this.lastText.TabIndex = 1;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(153, 118);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(270, 31);
            this.userText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "First:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(153, 164);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(270, 31);
            this.passText.TabIndex = 6;
            // 
            // levelCombo
            // 
            this.levelCombo.FormattingEnabled = true;
            this.levelCombo.Items.AddRange(new object[] {
            "User",
            "Administrator",
            "Researcher"});
            this.levelCombo.Location = new System.Drawing.Point(153, 214);
            this.levelCombo.Name = "levelCombo";
            this.levelCombo.Size = new System.Drawing.Size(270, 33);
            this.levelCombo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Access Level:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "Edit Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editUserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.levelCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.lastText);
            this.Controls.Add(this.firstText);
            this.Name = "editUserDialog";
            this.Text = "editUserDialog";
            this.Load += new System.EventHandler(this.editUserDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstText;
        private System.Windows.Forms.TextBox lastText;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.ComboBox levelCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}