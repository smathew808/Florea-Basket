namespace CS325_broadSword_flowerProject
{
    partial class batchAddUsersGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(batchAddUsersGui));
            this.batchUserListView = new System.Windows.Forms.ListView();
            this.firstCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accessCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectedFileText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileUploadButton = new System.Windows.Forms.Button();
            this.cofirmButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // batchUserListView
            // 
            this.batchUserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstCol,
            this.lastCol,
            this.userCol,
            this.passCol,
            this.accessCol});
            this.batchUserListView.GridLines = true;
            this.batchUserListView.Location = new System.Drawing.Point(12, 12);
            this.batchUserListView.Name = "batchUserListView";
            this.batchUserListView.Size = new System.Drawing.Size(550, 503);
            this.batchUserListView.TabIndex = 0;
            this.batchUserListView.UseCompatibleStateImageBehavior = false;
            this.batchUserListView.View = System.Windows.Forms.View.Details;
            // 
            // firstCol
            // 
            this.firstCol.Text = "First Name";
            this.firstCol.Width = 100;
            // 
            // lastCol
            // 
            this.lastCol.Text = "Last Name";
            this.lastCol.Width = 100;
            // 
            // userCol
            // 
            this.userCol.Text = "User Name";
            this.userCol.Width = 100;
            // 
            // passCol
            // 
            this.passCol.Text = "Password";
            this.passCol.Width = 150;
            // 
            // accessCol
            // 
            this.accessCol.Text = "Access Level";
            this.accessCol.Width = 50;
            // 
            // selectedFileText
            // 
            this.selectedFileText.Location = new System.Drawing.Point(696, 25);
            this.selectedFileText.Name = "selectedFileText";
            this.selectedFileText.Size = new System.Drawing.Size(326, 31);
            this.selectedFileText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Excel File:";
            // 
            // fileUploadButton
            // 
            this.fileUploadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileUploadButton.BackgroundImage")));
            this.fileUploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fileUploadButton.Location = new System.Drawing.Point(1027, 12);
            this.fileUploadButton.Name = "fileUploadButton";
            this.fileUploadButton.Size = new System.Drawing.Size(70, 57);
            this.fileUploadButton.TabIndex = 3;
            this.fileUploadButton.UseVisualStyleBackColor = true;
            this.fileUploadButton.Click += new System.EventHandler(this.fileUploadButton_Click);
            // 
            // cofirmButton
            // 
            this.cofirmButton.Location = new System.Drawing.Point(696, 75);
            this.cofirmButton.Name = "cofirmButton";
            this.cofirmButton.Size = new System.Drawing.Size(401, 62);
            this.cofirmButton.TabIndex = 4;
            this.cofirmButton.Text = "Confirm Add Users";
            this.cofirmButton.UseVisualStyleBackColor = true;
            this.cofirmButton.Click += new System.EventHandler(this.cofirmButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(893, 453);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(204, 62);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // batchAddUsersGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 527);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cofirmButton);
            this.Controls.Add(this.fileUploadButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedFileText);
            this.Controls.Add(this.batchUserListView);
            this.Name = "batchAddUsersGui";
            this.Text = "batchAddUsersGui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView batchUserListView;
        private System.Windows.Forms.ColumnHeader firstCol;
        private System.Windows.Forms.ColumnHeader lastCol;
        private System.Windows.Forms.ColumnHeader userCol;
        private System.Windows.Forms.ColumnHeader passCol;
        private System.Windows.Forms.ColumnHeader accessCol;
        private System.Windows.Forms.TextBox selectedFileText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fileUploadButton;
        private System.Windows.Forms.Button cofirmButton;
        private System.Windows.Forms.Button exitButton;
    }
}