namespace CS325_broadSword_flowerProject
{
    partial class AddFlower
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
            this.components = new System.ComponentModel.Container();
            this.latinNameLabel = new System.Windows.Forms.Label();
            this.latinNameTB = new System.Windows.Forms.TextBox();
            this.englishNameLabel = new System.Windows.Forms.Label();
            this.englishNameTB = new System.Windows.Forms.TextBox();
            this.botanicalFamilyTB = new System.Windows.Forms.TextBox();
            this.botanicalFamilyLabel = new System.Windows.Forms.Label();
            this.divLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTB = new System.Windows.Forms.TextBox();
            this.divLabel2 = new System.Windows.Forms.Label();
            this.picturesLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pictureListView = new System.Windows.Forms.ListView();
            this.picturesList = new System.Windows.Forms.ImageList(this.components);
            this.addPictureButton = new System.Windows.Forms.Button();
            this.deletePictureButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.noteDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dragToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // latinNameLabel
            // 
            this.latinNameLabel.AutoSize = true;
            this.latinNameLabel.Location = new System.Drawing.Point(13, 13);
            this.latinNameLabel.Name = "latinNameLabel";
            this.latinNameLabel.Size = new System.Drawing.Size(61, 13);
            this.latinNameLabel.TabIndex = 0;
            this.latinNameLabel.Text = "Latin Name";
            // 
            // latinNameTB
            // 
            this.latinNameTB.Location = new System.Drawing.Point(80, 10);
            this.latinNameTB.Name = "latinNameTB";
            this.latinNameTB.Size = new System.Drawing.Size(317, 20);
            this.latinNameTB.TabIndex = 1;
            // 
            // englishNameLabel
            // 
            this.englishNameLabel.AutoSize = true;
            this.englishNameLabel.Location = new System.Drawing.Point(13, 39);
            this.englishNameLabel.Name = "englishNameLabel";
            this.englishNameLabel.Size = new System.Drawing.Size(72, 13);
            this.englishNameLabel.TabIndex = 2;
            this.englishNameLabel.Text = "English Name";
            // 
            // englishNameTB
            // 
            this.englishNameTB.Location = new System.Drawing.Point(91, 36);
            this.englishNameTB.Name = "englishNameTB";
            this.englishNameTB.Size = new System.Drawing.Size(306, 20);
            this.englishNameTB.TabIndex = 3;
            // 
            // botanicalFamilyTB
            // 
            this.botanicalFamilyTB.Location = new System.Drawing.Point(102, 62);
            this.botanicalFamilyTB.Name = "botanicalFamilyTB";
            this.botanicalFamilyTB.Size = new System.Drawing.Size(295, 20);
            this.botanicalFamilyTB.TabIndex = 4;
            // 
            // botanicalFamilyLabel
            // 
            this.botanicalFamilyLabel.AutoSize = true;
            this.botanicalFamilyLabel.Location = new System.Drawing.Point(13, 65);
            this.botanicalFamilyLabel.Name = "botanicalFamilyLabel";
            this.botanicalFamilyLabel.Size = new System.Drawing.Size(83, 13);
            this.botanicalFamilyLabel.TabIndex = 5;
            this.botanicalFamilyLabel.Text = "Botanical Family";
            // 
            // divLabel
            // 
            this.divLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divLabel.Location = new System.Drawing.Point(12, 94);
            this.divLabel.Name = "divLabel";
            this.divLabel.Size = new System.Drawing.Size(385, 2);
            this.divLabel.TabIndex = 6;
            this.divLabel.Text = "label1";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(12, 102);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 7;
            this.notesLabel.Text = "Notes";
            // 
            // notesTB
            // 
            this.notesTB.Location = new System.Drawing.Point(12, 125);
            this.notesTB.Multiline = true;
            this.notesTB.Name = "notesTB";
            this.notesTB.Size = new System.Drawing.Size(385, 126);
            this.notesTB.TabIndex = 8;
            // 
            // divLabel2
            // 
            this.divLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divLabel2.Location = new System.Drawing.Point(12, 264);
            this.divLabel2.Name = "divLabel2";
            this.divLabel2.Size = new System.Drawing.Size(385, 2);
            this.divLabel2.TabIndex = 9;
            this.divLabel2.Text = "label2";
            // 
            // picturesLabel
            // 
            this.picturesLabel.AutoSize = true;
            this.picturesLabel.Location = new System.Drawing.Point(9, 272);
            this.picturesLabel.Name = "picturesLabel";
            this.picturesLabel.Size = new System.Drawing.Size(45, 13);
            this.picturesLabel.TabIndex = 10;
            this.picturesLabel.Text = "Pictures";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(322, 485);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(241, 485);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pictureListView
            // 
            this.pictureListView.AllowDrop = true;
            this.pictureListView.LargeImageList = this.picturesList;
            this.pictureListView.Location = new System.Drawing.Point(12, 296);
            this.pictureListView.MultiSelect = false;
            this.pictureListView.Name = "pictureListView";
            this.pictureListView.Size = new System.Drawing.Size(385, 183);
            this.pictureListView.TabIndex = 11;
            this.dragToolTip.SetToolTip(this.pictureListView, "Drag an Image (jpg, png, or gif) to add it to the list of pictures.");
            this.pictureListView.UseCompatibleStateImageBehavior = false;
            this.pictureListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.pictureListView_ItemSelectionChanged);
            this.pictureListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.pictureListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // picturesList
            // 
            this.picturesList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.picturesList.ImageSize = new System.Drawing.Size(32, 32);
            this.picturesList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // addPictureButton
            // 
            this.addPictureButton.Location = new System.Drawing.Point(322, 267);
            this.addPictureButton.Name = "addPictureButton";
            this.addPictureButton.Size = new System.Drawing.Size(75, 23);
            this.addPictureButton.TabIndex = 14;
            this.addPictureButton.Text = "Add Picture";
            this.addPictureButton.UseVisualStyleBackColor = true;
            this.addPictureButton.Click += new System.EventHandler(this.addPictureButton_Click);
            // 
            // deletePictureButton
            // 
            this.deletePictureButton.Enabled = false;
            this.deletePictureButton.Location = new System.Drawing.Point(218, 267);
            this.deletePictureButton.Name = "deletePictureButton";
            this.deletePictureButton.Size = new System.Drawing.Size(98, 23);
            this.deletePictureButton.TabIndex = 15;
            this.deletePictureButton.Text = "Delete Picture";
            this.deletePictureButton.UseVisualStyleBackColor = true;
            this.deletePictureButton.Click += new System.EventHandler(this.deletePictureButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Enabled = false;
            this.modifyButton.Location = new System.Drawing.Point(137, 267);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 16;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JPEG Images (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG Images (*.png)|*.png|GIF Images (*.g" +
    "if)|*.gif|All files|*.*";
            this.openFileDialog.Multiselect = true;
            // 
            // noteDateTimePicker
            // 
            this.noteDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.noteDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.noteDateTimePicker.Location = new System.Drawing.Point(134, 99);
            this.noteDateTimePicker.Name = "noteDateTimePicker";
            this.noteDateTimePicker.Size = new System.Drawing.Size(263, 20);
            this.noteDateTimePicker.TabIndex = 17;
            // 
            // AddFlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 520);
            this.Controls.Add(this.noteDateTimePicker);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.deletePictureButton);
            this.Controls.Add(this.addPictureButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pictureListView);
            this.Controls.Add(this.picturesLabel);
            this.Controls.Add(this.divLabel2);
            this.Controls.Add(this.notesTB);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.divLabel);
            this.Controls.Add(this.botanicalFamilyLabel);
            this.Controls.Add(this.botanicalFamilyTB);
            this.Controls.Add(this.englishNameTB);
            this.Controls.Add(this.englishNameLabel);
            this.Controls.Add(this.latinNameTB);
            this.Controls.Add(this.latinNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFlower";
            this.ShowIcon = false;
            this.Text = "Add Flower";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label latinNameLabel;
        private System.Windows.Forms.TextBox latinNameTB;
        private System.Windows.Forms.Label englishNameLabel;
        private System.Windows.Forms.TextBox englishNameTB;
        private System.Windows.Forms.TextBox botanicalFamilyTB;
        private System.Windows.Forms.Label botanicalFamilyLabel;
        private System.Windows.Forms.Label divLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesTB;
        private System.Windows.Forms.Label divLabel2;
        private System.Windows.Forms.Label picturesLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListView pictureListView;
        private System.Windows.Forms.ImageList picturesList;
        private System.Windows.Forms.Button addPictureButton;
        private System.Windows.Forms.Button deletePictureButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DateTimePicker noteDateTimePicker;
        private System.Windows.Forms.ToolTip dragToolTip;
    }
}