namespace CS325_broadSword_flowerProject
{
    partial class deleteUser
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
            this.usersListView = new System.Windows.Forms.ListView();
            this.idCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accessColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshButton = new System.Windows.Forms.Button();
            this.delUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersListView
            // 
            this.usersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCol,
            this.firstCol,
            this.LastCol,
            this.userCol,
            this.accessColum});
            this.usersListView.FullRowSelect = true;
            this.usersListView.GridLines = true;
            this.usersListView.Location = new System.Drawing.Point(12, 12);
            this.usersListView.MultiSelect = false;
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(772, 612);
            this.usersListView.TabIndex = 0;
            this.usersListView.UseCompatibleStateImageBehavior = false;
            this.usersListView.View = System.Windows.Forms.View.Details;
            // 
            // idCol
            // 
            this.idCol.Text = "ID";
            this.idCol.Width = 41;
            // 
            // firstCol
            // 
            this.firstCol.Text = "First";
            this.firstCol.Width = 100;
            // 
            // LastCol
            // 
            this.LastCol.Text = "Last";
            this.LastCol.Width = 100;
            // 
            // userCol
            // 
            this.userCol.Text = "User Name";
            this.userCol.Width = 125;
            // 
            // accessColum
            // 
            this.accessColum.Text = "Access Level";
            this.accessColum.Width = 100;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(790, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(276, 75);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh User List";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // delUserButton
            // 
            this.delUserButton.Location = new System.Drawing.Point(790, 93);
            this.delUserButton.Name = "delUserButton";
            this.delUserButton.Size = new System.Drawing.Size(276, 75);
            this.delUserButton.TabIndex = 2;
            this.delUserButton.Text = "Delete User";
            this.delUserButton.UseVisualStyleBackColor = true;
            this.delUserButton.Click += new System.EventHandler(this.delUserButton_Click);
            // 
            // deleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 641);
            this.Controls.Add(this.delUserButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.usersListView);
            this.Name = "deleteUser";
            this.Text = "deleteUser";
            this.Load += new System.EventHandler(this.deleteUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView usersListView;
        private System.Windows.Forms.ColumnHeader firstCol;
        private System.Windows.Forms.ColumnHeader LastCol;
        private System.Windows.Forms.ColumnHeader userCol;
        private System.Windows.Forms.ColumnHeader accessColum;
        private System.Windows.Forms.ColumnHeader idCol;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button delUserButton;
    }
}