namespace CS325_broadSword_flowerProject
{
    partial class ViewHistogram
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
            this.Title = new System.Windows.Forms.Label();
            this.LabelBound1 = new System.Windows.Forms.Label();
            this.LabelBound2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Yaxis0 = new System.Windows.Forms.Label();
            this.Yaxis5 = new System.Windows.Forms.Label();
            this.Yaxis10 = new System.Windows.Forms.Label();
            this.Yaxis15 = new System.Windows.Forms.Label();
            this.HistogramPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(155, 21);
            this.Title.TabIndex = 1;
            this.Title.Text = "RGB Histogram";
            // 
            // LabelBound1
            // 
            this.LabelBound1.AutoSize = true;
            this.LabelBound1.Location = new System.Drawing.Point(276, 328);
            this.LabelBound1.Name = "LabelBound1";
            this.LabelBound1.Size = new System.Drawing.Size(28, 13);
            this.LabelBound1.TabIndex = 2;
            this.LabelBound1.Text = "0-63";
            // 
            // LabelBound2
            // 
            this.LabelBound2.AutoSize = true;
            this.LabelBound2.Location = new System.Drawing.Point(400, 328);
            this.LabelBound2.Name = "LabelBound2";
            this.LabelBound2.Size = new System.Drawing.Size(40, 13);
            this.LabelBound2.TabIndex = 3;
            this.LabelBound2.Text = "64-127";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "128-191";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "192-255";
            // 
            // Yaxis0
            // 
            this.Yaxis0.AutoSize = true;
            this.Yaxis0.Location = new System.Drawing.Point(201, 312);
            this.Yaxis0.Name = "Yaxis0";
            this.Yaxis0.Size = new System.Drawing.Size(13, 13);
            this.Yaxis0.TabIndex = 6;
            this.Yaxis0.Text = "0";
            // 
            // Yaxis5
            // 
            this.Yaxis5.AutoSize = true;
            this.Yaxis5.Location = new System.Drawing.Point(183, 203);
            this.Yaxis5.Name = "Yaxis5";
            this.Yaxis5.Size = new System.Drawing.Size(31, 13);
            this.Yaxis5.TabIndex = 7;
            this.Yaxis5.Text = "7500";
            // 
            // Yaxis10
            // 
            this.Yaxis10.AutoSize = true;
            this.Yaxis10.Location = new System.Drawing.Point(177, 112);
            this.Yaxis10.Name = "Yaxis10";
            this.Yaxis10.Size = new System.Drawing.Size(37, 13);
            this.Yaxis10.TabIndex = 8;
            this.Yaxis10.Text = "15000";
            // 
            // Yaxis15
            // 
            this.Yaxis15.AutoSize = true;
            this.Yaxis15.Location = new System.Drawing.Point(177, 25);
            this.Yaxis15.Name = "Yaxis15";
            this.Yaxis15.Size = new System.Drawing.Size(37, 13);
            this.Yaxis15.TabIndex = 9;
            this.Yaxis15.Text = "25000";
            // 
            // HistogramPicture
            // 
            this.HistogramPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HistogramPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistogramPicture.Location = new System.Drawing.Point(220, 0);
            this.HistogramPicture.Name = "HistogramPicture";
            this.HistogramPicture.Size = new System.Drawing.Size(551, 325);
            this.HistogramPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.HistogramPicture.TabIndex = 0;
            this.HistogramPicture.TabStop = false;
            this.HistogramPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.picHisto_Paint);
            // 
            // ViewHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(774, 381);
            this.Controls.Add(this.Yaxis15);
            this.Controls.Add(this.Yaxis10);
            this.Controls.Add(this.Yaxis5);
            this.Controls.Add(this.Yaxis0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelBound2);
            this.Controls.Add(this.LabelBound1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.HistogramPicture);
            this.Name = "ViewHistogram";
            this.Text = "Histogram";
            this.SizeChanged += new System.EventHandler(this.picHisto_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.HistogramPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label LabelBound1;
        private System.Windows.Forms.Label LabelBound2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Yaxis0;
        private System.Windows.Forms.Label Yaxis5;
        private System.Windows.Forms.Label Yaxis10;
        private System.Windows.Forms.Label Yaxis15;
        private System.Windows.Forms.PictureBox HistogramPicture;
    }
}