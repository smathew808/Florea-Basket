namespace CS325_broadSword_flowerProject
{
    partial class EditUsers
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
            this.userListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accessLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userListView
            // 
            this.userListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.firstName,
            this.lastName,
            this.userName,
            this.accessLevel});
            this.userListView.FullRowSelect = true;
            this.userListView.GridLines = true;
            this.userListView.Location = new System.Drawing.Point(12, 12);
            this.userListView.MultiSelect = false;
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(823, 902);
            this.userListView.TabIndex = 0;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // firstName
            // 
            this.firstName.Text = "First";
            this.firstName.Width = 100;
            // 
            // lastName
            // 
            this.lastName.Text = "Last";
            this.lastName.Width = 100;
            // 
            // userName
            // 
            this.userName.Text = "User Name";
            this.userName.Width = 100;
            // 
            // accessLevel
            // 
            this.accessLevel.Text = "Level";
            this.accessLevel.Width = 68;
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(841, 12);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(437, 92);
            this.editUserButton.TabIndex = 1;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 924);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.userListView);
            this.Name = "EditUsers";
            this.Text = "EditUsers";
            this.Load += new System.EventHandler(this.EditUsers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader userName;
        private System.Windows.Forms.ColumnHeader accessLevel;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button editUserButton;
    }
}