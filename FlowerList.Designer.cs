namespace CS325_broadSword_flowerProject
{
    partial class FlowerList
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
            this.editFlowerButton = new System.Windows.Forms.Button();
            this.deleteFlowerButton = new System.Windows.Forms.Button();
            this.flowerListView = new System.Windows.Forms.ListView();
            this.latinNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.englishNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.botanicalFamilyCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // editFlowerButton
            // 
            this.editFlowerButton.Enabled = false;
            this.editFlowerButton.Location = new System.Drawing.Point(231, 485);
            this.editFlowerButton.Name = "editFlowerButton";
            this.editFlowerButton.Size = new System.Drawing.Size(75, 23);
            this.editFlowerButton.TabIndex = 0;
            this.editFlowerButton.Text = "Edit flower";
            this.editFlowerButton.UseVisualStyleBackColor = true;
            this.editFlowerButton.Click += new System.EventHandler(this.editFlowerButton_Click);
            // 
            // deleteFlowerButton
            // 
            this.deleteFlowerButton.Enabled = false;
            this.deleteFlowerButton.Location = new System.Drawing.Point(312, 485);
            this.deleteFlowerButton.Name = "deleteFlowerButton";
            this.deleteFlowerButton.Size = new System.Drawing.Size(85, 23);
            this.deleteFlowerButton.TabIndex = 1;
            this.deleteFlowerButton.Text = "Delete flower";
            this.deleteFlowerButton.UseVisualStyleBackColor = true;
            this.deleteFlowerButton.Click += new System.EventHandler(this.deleteFlowerButton_Click);
            // 
            // flowerListView
            // 
            this.flowerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.latinNameCol,
            this.englishNameCol,
            this.botanicalFamilyCol});
            this.flowerListView.FullRowSelect = true;
            this.flowerListView.Location = new System.Drawing.Point(13, 13);
            this.flowerListView.MultiSelect = false;
            this.flowerListView.Name = "flowerListView";
            this.flowerListView.Size = new System.Drawing.Size(384, 466);
            this.flowerListView.TabIndex = 2;
            this.flowerListView.UseCompatibleStateImageBehavior = false;
            this.flowerListView.View = System.Windows.Forms.View.Details;
            this.flowerListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.flowerListView_ItemSelectionChanged);
            // 
            // latinNameCol
            // 
            this.latinNameCol.Text = "Latin Name";
            this.latinNameCol.Width = 125;
            // 
            // englishNameCol
            // 
            this.englishNameCol.Text = "English Name";
            this.englishNameCol.Width = 126;
            // 
            // botanicalFamilyCol
            // 
            this.botanicalFamilyCol.Text = "Botanical Family";
            this.botanicalFamilyCol.Width = 129;
            // 
            // FlowerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 520);
            this.Controls.Add(this.flowerListView);
            this.Controls.Add(this.deleteFlowerButton);
            this.Controls.Add(this.editFlowerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlowerList";
            this.Text = "Flower List";
            this.Load += new System.EventHandler(this.FlowerList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editFlowerButton;
        private System.Windows.Forms.Button deleteFlowerButton;
        private System.Windows.Forms.ListView flowerListView;
        private System.Windows.Forms.ColumnHeader latinNameCol;
        private System.Windows.Forms.ColumnHeader englishNameCol;
        private System.Windows.Forms.ColumnHeader botanicalFamilyCol;
    }
}