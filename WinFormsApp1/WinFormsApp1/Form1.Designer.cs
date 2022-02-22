namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttons = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhotoRightArrow = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PhotoLeftArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.buttons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(64, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Visitor";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "NBA Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(742, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome to use this NBA Management system you can \r\nredirect to different pages a" +
    "ccording to your role by clicking the buttons bellow";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 112);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(309, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 64);
            this.button2.TabIndex = 5;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(294, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 112);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(514, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(197, 112);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(-1, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(802, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "The current season is 2016-2017, and the NBA already has a history of 71 years.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttons
            // 
            this.buttons.Controls.Add(this.button1);
            this.buttons.Controls.Add(this.button2);
            this.buttons.Location = new System.Drawing.Point(145, 208);
            this.buttons.Name = "buttons";
            this.buttons.Size = new System.Drawing.Size(505, 165);
            this.buttons.TabIndex = 9;
            this.buttons.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PhotoLeftArrow);
            this.groupBox1.Controls.Add(this.PhotoRightArrow);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 153);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // PhotoRightArrow
            // 
            this.PhotoRightArrow.BackColor = System.Drawing.SystemColors.Window;
            this.PhotoRightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PhotoRightArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhotoRightArrow.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhotoRightArrow.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PhotoRightArrow.Location = new System.Drawing.Point(717, 22);
            this.PhotoRightArrow.Name = "PhotoRightArrow";
            this.PhotoRightArrow.Size = new System.Drawing.Size(51, 112);
            this.PhotoRightArrow.TabIndex = 9;
            this.PhotoRightArrow.Text = ">";
            this.PhotoRightArrow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PhotoRightArrow.UseMnemonic = false;
            this.PhotoRightArrow.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(32, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 114);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // PhotoLeftArrow
            // 
            this.PhotoLeftArrow.BackColor = System.Drawing.SystemColors.Window;
            this.PhotoLeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PhotoLeftArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhotoLeftArrow.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhotoLeftArrow.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PhotoLeftArrow.Location = new System.Drawing.Point(9, 22);
            this.PhotoLeftArrow.Name = "PhotoLeftArrow";
            this.PhotoLeftArrow.Size = new System.Drawing.Size(51, 112);
            this.PhotoLeftArrow.TabIndex = 10;
            this.PhotoLeftArrow.Text = "<";
            this.PhotoLeftArrow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PhotoLeftArrow.UseMnemonic = false;
            this.PhotoLeftArrow.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttons);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.buttons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private GroupBox buttons;
        private GroupBox groupBox1;
        private Button PhotoLeftArrow;
        private Button PhotoRightArrow;
        private PictureBox pictureBox4;
    }
}