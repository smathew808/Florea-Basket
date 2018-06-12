namespace CS325_broadSword_flowerProject
{
    partial class mainmenuGUI
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutAndExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDeleteFlowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchAddUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.mainMenuStatusStrip = new System.Windows.Forms.StatusStrip();
            this.loginStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.searchTypeBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.imageSearchBox = new System.Windows.Forms.GroupBox();
            this.dragDropLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dragDropLabel = new System.Windows.Forms.Label();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.imageSearchPanel = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewResultsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewDetailsButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.mainMenuStatusStrip.SuspendLayout();
            this.imageSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            this.imageSearchPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.flowersToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(494, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.logOutAndExitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // logOutAndExitToolStripMenuItem
            // 
            this.logOutAndExitToolStripMenuItem.Name = "logOutAndExitToolStripMenuItem";
            this.logOutAndExitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutAndExitToolStripMenuItem.Text = "Exit";
            this.logOutAndExitToolStripMenuItem.Click += new System.EventHandler(this.logOutAndExitToolStripMenuItem_Click);
            // 
            // flowersToolStripMenuItem
            // 
            this.flowersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFlowerToolStripMenuItem,
            this.editDeleteFlowerToolStripMenuItem,
            this.viewHistogramToolStripMenuItem});
            this.flowersToolStripMenuItem.Name = "flowersToolStripMenuItem";
            this.flowersToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.flowersToolStripMenuItem.Text = "Flowers";
            // 
            // addFlowerToolStripMenuItem
            // 
            this.addFlowerToolStripMenuItem.Name = "addFlowerToolStripMenuItem";
            this.addFlowerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addFlowerToolStripMenuItem.Text = "Add flower";
            this.addFlowerToolStripMenuItem.Click += new System.EventHandler(this.addFlowerToolStripMenuItem_Click);
            // 
            // editDeleteFlowerToolStripMenuItem
            // 
            this.editDeleteFlowerToolStripMenuItem.Name = "editDeleteFlowerToolStripMenuItem";
            this.editDeleteFlowerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editDeleteFlowerToolStripMenuItem.Text = "Edit/Delete flower";
            this.editDeleteFlowerToolStripMenuItem.Click += new System.EventHandler(this.editDeleteFlowerToolStripMenuItem_Click);
            // 
            // viewHistogramToolStripMenuItem
            // 
            this.viewHistogramToolStripMenuItem.Name = "viewHistogramToolStripMenuItem";
            this.viewHistogramToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.viewHistogramToolStripMenuItem.Text = "View Histogram";
            this.viewHistogramToolStripMenuItem.Click += new System.EventHandler(this.viewHistogramToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.batchAddUsersToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addUserToolStripMenuItem.Text = "Add user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // batchAddUsersToolStripMenuItem
            // 
            this.batchAddUsersToolStripMenuItem.Name = "batchAddUsersToolStripMenuItem";
            this.batchAddUsersToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.batchAddUsersToolStripMenuItem.Text = "Batch add users";
            this.batchAddUsersToolStripMenuItem.Click += new System.EventHandler(this.batchAddUsersToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.editUserToolStripMenuItem.Text = "Edit user";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete user";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(155, 34);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(231, 20);
            this.searchBox.TabIndex = 1;
            // 
            // mainMenuStatusStrip
            // 
            this.mainMenuStatusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainMenuStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginStatusLabel,
            this.toolStripStatusLabel1});
            this.mainMenuStatusStrip.Location = new System.Drawing.Point(0, 661);
            this.mainMenuStatusStrip.Name = "mainMenuStatusStrip";
            this.mainMenuStatusStrip.Size = new System.Drawing.Size(494, 22);
            this.mainMenuStatusStrip.SizingGrip = false;
            this.mainMenuStatusStrip.TabIndex = 2;
            this.mainMenuStatusStrip.Text = "statusStrip1";
            // 
            // loginStatusLabel
            // 
            this.loginStatusLabel.Name = "loginStatusLabel";
            this.loginStatusLabel.Size = new System.Drawing.Size(77, 17);
            this.loginStatusLabel.Text = "Logged in as ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // searchTypeBox
            // 
            this.searchTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchTypeBox.FormattingEnabled = true;
            this.searchTypeBox.Items.AddRange(new object[] {
            "Latin Name",
            "English Name",
            "Botanical Family"});
            this.searchTypeBox.Location = new System.Drawing.Point(28, 34);
            this.searchTypeBox.Name = "searchTypeBox";
            this.searchTypeBox.Size = new System.Drawing.Size(121, 21);
            this.searchTypeBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(392, 32);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // imageSearchBox
            // 
            this.imageSearchBox.Controls.Add(this.dragDropLinkLabel);
            this.imageSearchBox.Controls.Add(this.dragDropLabel);
            this.imageSearchBox.Controls.Add(this.searchPictureBox);
            this.imageSearchBox.Location = new System.Drawing.Point(3, 3);
            this.imageSearchBox.Name = "imageSearchBox";
            this.imageSearchBox.Size = new System.Drawing.Size(433, 99);
            this.imageSearchBox.TabIndex = 5;
            this.imageSearchBox.TabStop = false;
            this.imageSearchBox.Text = "Search by picture";
            // 
            // dragDropLinkLabel
            // 
            this.dragDropLinkLabel.AutoSize = true;
            this.dragDropLinkLabel.Location = new System.Drawing.Point(265, 43);
            this.dragDropLinkLabel.Name = "dragDropLinkLabel";
            this.dragDropLinkLabel.Size = new System.Drawing.Size(79, 13);
            this.dragDropLinkLabel.TabIndex = 1;
            this.dragDropLinkLabel.TabStop = true;
            this.dragDropLinkLabel.Text = "select manually";
            this.dragDropLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dragDropLabel
            // 
            this.dragDropLabel.AutoSize = true;
            this.dragDropLabel.Location = new System.Drawing.Point(91, 43);
            this.dragDropLabel.Name = "dragDropLabel";
            this.dragDropLabel.Size = new System.Drawing.Size(181, 13);
            this.dragDropLabel.TabIndex = 0;
            this.dragDropLabel.Text = "Drag and drop a picture to search or ";
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.Enabled = false;
            this.searchPictureBox.Location = new System.Drawing.Point(6, 19);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(421, 74);
            this.searchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPictureBox.TabIndex = 2;
            this.searchPictureBox.TabStop = false;
            this.searchPictureBox.Visible = false;
            // 
            // imageSearchPanel
            // 
            this.imageSearchPanel.AllowDrop = true;
            this.imageSearchPanel.Controls.Add(this.imageSearchBox);
            this.imageSearchPanel.Location = new System.Drawing.Point(28, 61);
            this.imageSearchPanel.Name = "imageSearchPanel";
            this.imageSearchPanel.Size = new System.Drawing.Size(439, 105);
            this.imageSearchPanel.TabIndex = 2;
            this.imageSearchPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageSearchPanel_DragDrop);
            this.imageSearchPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageSearchPanel_DragEnter);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JPEG Images (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG Images (*.png)|*.png|GIF Images (*.g" +
    "if)|*.gif|All files|*.*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewResultsList);
            this.groupBox1.Location = new System.Drawing.Point(28, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(439, 435);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Results";
            // 
            // viewResultsList
            // 
            this.viewResultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.viewResultsList.FullRowSelect = true;
            this.viewResultsList.GridLines = true;
            this.viewResultsList.Location = new System.Drawing.Point(4, 17);
            this.viewResultsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewResultsList.MultiSelect = false;
            this.viewResultsList.Name = "viewResultsList";
            this.viewResultsList.Size = new System.Drawing.Size(432, 410);
            this.viewResultsList.TabIndex = 0;
            this.viewResultsList.UseCompatibleStateImageBehavior = false;
            this.viewResultsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Make PDF";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "English Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Latin Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Botanical Family";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Flower Id";
            // 
            // viewDetailsButton
            // 
            this.viewDetailsButton.Location = new System.Drawing.Point(363, 614);
            this.viewDetailsButton.Name = "viewDetailsButton";
            this.viewDetailsButton.Size = new System.Drawing.Size(101, 27);
            this.viewDetailsButton.TabIndex = 7;
            this.viewDetailsButton.Text = "View Details";
            this.viewDetailsButton.UseVisualStyleBackColor = true;
            this.viewDetailsButton.Click += new System.EventHandler(this.viewDetailsButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(353, 644);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Print to PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "pdf";
            this.saveFileDialog1.ShowHelp = true;
            // 
            // mainmenuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 683);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.viewDetailsButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageSearchPanel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTypeBox);
            this.Controls.Add(this.mainMenuStatusStrip);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "mainmenuGUI";
            this.Text = "Flowers";
            this.Load += new System.EventHandler(this.mainmenuGUI_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainMenuStatusStrip.ResumeLayout(false);
            this.mainMenuStatusStrip.PerformLayout();
            this.imageSearchBox.ResumeLayout(false);
            this.imageSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            this.imageSearchPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem flowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDeleteFlowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutAndExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHistogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchAddUsersToolStripMenuItem;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.StatusStrip mainMenuStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel loginStatusLabel;
        private System.Windows.Forms.ComboBox searchTypeBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox imageSearchBox;
        private System.Windows.Forms.LinkLabel dragDropLinkLabel;
        private System.Windows.Forms.Label dragDropLabel;
        private System.Windows.Forms.Panel imageSearchPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView viewResultsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button viewDetailsButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}