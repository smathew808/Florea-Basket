namespace CS325_broadSword_flowerProject
{
    partial class ModifyImage
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.photographerLabel = new System.Windows.Forms.Label();
            this.photographerTB = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTB = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.noteTB = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(249, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(267, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(575, 467);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // photographerLabel
            // 
            this.photographerLabel.AutoSize = true;
            this.photographerLabel.Location = new System.Drawing.Point(12, 45);
            this.photographerLabel.Name = "photographerLabel";
            this.photographerLabel.Size = new System.Drawing.Size(71, 13);
            this.photographerLabel.TabIndex = 2;
            this.photographerLabel.Text = "Photographer";
            // 
            // photographerTB
            // 
            this.photographerTB.Location = new System.Drawing.Point(12, 61);
            this.photographerTB.Name = "photographerTB";
            this.photographerTB.Size = new System.Drawing.Size(249, 20);
            this.photographerTB.TabIndex = 3;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(12, 94);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 4;
            this.locationLabel.Text = "Location";
            // 
            // locationTB
            // 
            this.locationTB.Location = new System.Drawing.Point(12, 111);
            this.locationTB.Name = "locationTB";
            this.locationTB.Size = new System.Drawing.Size(249, 20);
            this.locationTB.TabIndex = 5;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(12, 144);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(30, 13);
            this.noteLabel.TabIndex = 6;
            this.noteLabel.Text = "Note";
            // 
            // noteTB
            // 
            this.noteTB.Location = new System.Drawing.Point(13, 161);
            this.noteTB.Multiline = true;
            this.noteTB.Name = "noteTB";
            this.noteTB.Size = new System.Drawing.Size(248, 184);
            this.noteTB.TabIndex = 7;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 455);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(93, 455);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ModifyImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 491);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.noteTB);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.locationTB);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.photographerTB);
            this.Controls.Add(this.photographerLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyImage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Picture note";
            this.Load += new System.EventHandler(this.ModifyImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label photographerLabel;
        private System.Windows.Forms.TextBox photographerTB;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationTB;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.TextBox noteTB;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}