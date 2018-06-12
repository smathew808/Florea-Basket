namespace CS325_broadSword_flowerProject
{
    partial class SearchFlowerGUI
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
            this.SearchEntryBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SearchTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.MessageToUser = new System.Windows.Forms.Label();
            this.addPictureButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchEntryBox
            // 
            this.SearchEntryBox.Location = new System.Drawing.Point(139, 110);
            this.SearchEntryBox.Name = "SearchEntryBox";
            this.SearchEntryBox.Size = new System.Drawing.Size(100, 20);
            this.SearchEntryBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(347, 107);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchTypeBox
            // 
            this.SearchTypeBox.FormattingEnabled = true;
            this.SearchTypeBox.Items.AddRange(new object[] {
            "LatinName",
            "EnglishName",
            "Botanical Family",
            "Picture"});
            this.SearchTypeBox.Location = new System.Drawing.Point(12, 109);
            this.SearchTypeBox.Name = "SearchTypeBox";
            this.SearchTypeBox.Size = new System.Drawing.Size(121, 21);
            this.SearchTypeBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SearchType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SearchEntry";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(258, 109);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MessageToUser
            // 
            this.MessageToUser.AutoSize = true;
            this.MessageToUser.Location = new System.Drawing.Point(115, 66);
            this.MessageToUser.Name = "MessageToUser";
            this.MessageToUser.Size = new System.Drawing.Size(152, 13);
            this.MessageToUser.TabIndex = 6;
            this.MessageToUser.Text = "All entries must be lower-cased";
            // 
            // addPictureButton
            // 
            this.addPictureButton.Location = new System.Drawing.Point(258, 331);
            this.addPictureButton.Name = "addPictureButton";
            this.addPictureButton.Size = new System.Drawing.Size(75, 23);
            this.addPictureButton.TabIndex = 15;
            this.addPictureButton.Text = "Add Picture";
            this.addPictureButton.UseVisualStyleBackColor = true;
            this.addPictureButton.Click += new System.EventHandler(this.addPictureButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.Location = new System.Drawing.Point(12, 136);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(217, 218);
            this.searchPictureBox.TabIndex = 18;
            this.searchPictureBox.TabStop = false;
            // 
            // SearchFlowerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 383);
            this.Controls.Add(this.searchPictureBox);
            this.Controls.Add(this.addPictureButton);
            this.Controls.Add(this.MessageToUser);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTypeBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.SearchEntryBox);
            this.Name = "SearchFlowerGUI";
            this.Text = "SearchByName";
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchEntryBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox SearchTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label MessageToUser;
        private System.Windows.Forms.Button addPictureButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox searchPictureBox;
    }
}