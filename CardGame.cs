using System;

namespace CardGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDirections = new System.Windows.Forms.Label();
            this.labelCardName = new System.Windows.Forms.Label();
            this.pictureBoxBottom5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBottom4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBottom3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBottom2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBottom1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(175, 300);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(464, 300);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // labelDirections
            // 
            this.labelDirections.AutoSize = true;
            this.labelDirections.Location = new System.Drawing.Point(310, 30);
            this.labelDirections.Name = "labelDirections";
            this.labelDirections.Size = new System.Drawing.Size(110, 13);
            this.labelDirections.TabIndex = 12;
            this.labelDirections.Text = "Click Card to reveal it.";
            // 
            // labelCardName
            // 
            this.labelCardName.AutoSize = true;
            this.labelCardName.Location = new System.Drawing.Point(310, 310);
            this.labelCardName.Name = "labelCardName";
            this.labelCardName.Size = new System.Drawing.Size(60, 13);
            this.labelCardName.TabIndex = 13;
            this.labelCardName.Text = "Card Name";
            this.labelCardName.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBoxBottom5
            // 
            this.pictureBoxBottom5.Image = global::M2Form.Properties.Resources.Backface_Red;
            this.pictureBoxBottom5.Location = new System.Drawing.Point(561, 83);
            this.pictureBoxBottom5.Name = "pictureBoxBottom5";
            this.pictureBoxBottom5.Size = new System.Drawing.Size(100, 125);
            this.pictureBoxBottom5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBottom5.TabIndex = 9;
            this.pictureBoxBottom5.TabStop = false;
            // 
            // pictureBoxTop5
            // 
            this.pictureBoxTop5.Image = global::M2Form.Properties.Resources.Ace_Spades;
            this.pictureBoxTop5.Location = new System.Drawing.Point(561, 83);
            this.pictureBoxTop5.Name = "pictureBoxTop5";
            this.pictureBoxTop5.Size = new System.Drawing.Size(100, 125);
            this.pictureBoxTop5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTop5.TabIndex = 8;
            this.pictureBoxTop5.TabStop = false;
            // 
            // pictureBoxBottom4
            // 
            this.pictureBoxBottom4.Image = global::M2Form.Properties.Resources.Backface_Red;
            this.pictureBoxBottom4.Location = new System.Drawing.Point(439, 83);
            this.pictureBoxBottom4.Name = "pictureBoxBottom4";
            this.pictureBoxBottom4.Size = new System.Drawing.Size(100, 125);
            this.pictureBoxBottom4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBottom4.TabIndex = 7;
            this.pictureBoxBottom4.TabStop = false;
            this.pictureBoxBottom4.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBoxTop4
            // 
            this.pictureBoxTop4.Image = global::M2Form.Properties.Resources.Queen_Hearts;
            this.pictureBoxTop4.Location = new System.Drawing.Point(439, 83);
            this.pictureBoxTop4.Name = "pictureBoxTop4";
            this.pictureBoxTop4.Size = new System.Drawing.Size(100, 125);
            this.pictureBoxTop4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTop4.TabIndex = 6;
            this.pictureBoxTop4.TabStop = false;
            // 
            // pictureBoxBottom3
            // 
            this.pictureBoxBottom3.Image = global::M2Form.Properties.Resources.Backface_Red;
            this.pictureBoxBottom3.Location = new System.Drawing.Point(313, 83);
            this.pictureBoxBottom3.Name = "pictureBoxBottom3";
            this.pictureBoxBottom3.Size = new System.Drawing.Size(92, 125);
            this.pictureBoxBottom3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBottom3.TabIndex = 5;
            this.pictureBoxBottom3.TabStop = false;
            // 
            // pictureBoxTop3
            // 
            this.pictureBoxTop3.Image = global::M2Form.Properties.Resources.King_Diamonds;
            this.pictureBoxTop3.Location = new System.Drawing.Point(313, 83);
            this.pictureBoxTop3.Name = "pictureBoxTop3";
            this.pictureBoxTop3.Size = new System.Drawing.Size(92, 125);
            this.pictureBoxTop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTop3.TabIndex = 4;
            this.pictureBoxTop3.TabStop = false;
            // 
            // pictureBoxBottom2
            // 
            this.pictureBoxBottom2.Image = global::M2Form.Properties.Resources.Backface_Red;
            this.pictureBoxBottom2.Location = new System.Drawing.Point(176, 83);
            this.pictureBoxBottom2.Name = "pictureBoxBottom2";
            this.pictureBoxBottom2.Size = new System.Drawing.Size(91, 125);
            this.pictureBoxBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBottom2.TabIndex = 3;
            this.pictureBoxBottom2.TabStop = false;
            this.pictureBoxBottom2.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBoxTop2
            // 
            this.pictureBoxTop2.Image = global::M2Form.Properties.Resources._7_Clubs;
            this.pictureBoxTop2.Location = new System.Drawing.Point(175, 83);
            this.pictureBoxTop2.Name = "pictureBoxTop2";
            this.pictureBoxTop2.Size = new System.Drawing.Size(92, 125);
            this.pictureBoxTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTop2.TabIndex = 2;
            this.pictureBoxTop2.TabStop = false;
            // 
            // pictureBoxBottom1
            // 
            this.pictureBoxBottom1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBottom1.Image")));
            this.pictureBoxBottom1.Location = new System.Drawing.Point(40, 83);
            this.pictureBoxBottom1.Name = "pictureBoxBottom1";
            this.pictureBoxBottom1.Size = new System.Drawing.Size(86, 125);
            this.pictureBoxBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBottom1.TabIndex = 1;
            this.pictureBoxBottom1.TabStop = false;
            this.pictureBoxBottom1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxTop1
            // 
            this.pictureBoxTop1.Image = global::M2Form.Properties.Resources._3_Spades;
            this.pictureBoxTop1.Location = new System.Drawing.Point(40, 83);
            this.pictureBoxTop1.Name = "pictureBoxTop1";
            this.pictureBoxTop1.Size = new System.Drawing.Size(86, 125);
            this.pictureBoxTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTop1.TabIndex = 0;
            this.pictureBoxTop1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M2Form.Properties.Resources._20231001;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.labelCardName);
            this.Controls.Add(this.labelDirections);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.pictureBoxBottom5);
            this.Controls.Add(this.pictureBoxTop5);
            this.Controls.Add(this.pictureBoxBottom4);
            this.Controls.Add(this.pictureBoxTop4);
            this.Controls.Add(this.pictureBoxBottom3);
            this.Controls.Add(this.pictureBoxTop3);
            this.Controls.Add(this.pictureBoxBottom2);
            this.Controls.Add(this.pictureBoxTop2);
            this.Controls.Add(this.pictureBoxBottom1);
            this.Controls.Add(this.pictureBoxTop1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTop1;
        private System.Windows.Forms.PictureBox pictureBoxBottom1;
        private System.Windows.Forms.PictureBox pictureBoxTop2;
        private System.Windows.Forms.PictureBox pictureBoxBottom2;
        private System.Windows.Forms.PictureBox pictureBoxTop3;
        private System.Windows.Forms.PictureBox pictureBoxBottom3;
        private System.Windows.Forms.PictureBox pictureBoxTop4;
        private System.Windows.Forms.PictureBox pictureBoxBottom4;
        private System.Windows.Forms.PictureBox pictureBoxTop5;
        private System.Windows.Forms.PictureBox pictureBoxBottom5;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelDirections;
        private System.Windows.Forms.Label labelCardName;
    }
}







cardImages = new List<Image>
{
    M2Form.Properties.Resources.Ace_Spades,    // Add your actual card images here
    M2Form.Properties.Resources.Queen_Hearts,
    M2Form.Properties.Resources._3_Spades,
    M2Form.Properties.Resources._7_Clubs,
    M2Form.Properties.Resources.Queen_Hearts,
    M2Form.Properties.Resources._7_Clubs,
    M2Form.Properties.Resources._3_Spades,
    M2Form.Properties.Resources.Ace_Spades,
    M2Form.Properties.Resources.King_Diamonds,
    M2Form.Properties.Resources.King_Diamonds
};