namespace Anagram
{
    partial class formV2
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
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblChars = new System.Windows.Forms.Label();
            this.tbChars = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lboxWords = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.Location = new System.Drawing.Point(24, 941);
            this.lblTimeTaken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(130, 25);
            this.lblTimeTaken.TabIndex = 15;
            this.lblTimeTaken.Text = "Time taken: ";
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.Color.Black;
            this.btnRandom.Location = new System.Drawing.Point(482, 220);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(6);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(266, 75);
            this.btnRandom.TabIndex = 14;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Location = new System.Drawing.Point(760, 220);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(266, 75);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblChars
            // 
            this.lblChars.AutoSize = true;
            this.lblChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChars.Location = new System.Drawing.Point(20, 155);
            this.lblChars.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblChars.Name = "lblChars";
            this.lblChars.Size = new System.Drawing.Size(236, 48);
            this.lblChars.TabIndex = 12;
            this.lblChars.Text = "Characters:";
            // 
            // tbChars
            // 
            this.tbChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChars.Location = new System.Drawing.Point(278, 149);
            this.tbChars.Margin = new System.Windows.Forms.Padding(6);
            this.tbChars.Name = "tbChars";
            this.tbChars.Size = new System.Drawing.Size(744, 55);
            this.tbChars.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(42, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(506, 73);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Anagram Solver";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1072, 112);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lboxWords
            // 
            this.lboxWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxWords.FormattingEnabled = true;
            this.lboxWords.ItemHeight = 48;
            this.lboxWords.Location = new System.Drawing.Point(30, 305);
            this.lboxWords.Margin = new System.Windows.Forms.Padding(4);
            this.lboxWords.Name = "lboxWords";
            this.lboxWords.Size = new System.Drawing.Size(992, 628);
            this.lboxWords.TabIndex = 8;
            // 
            // formV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 992);
            this.Controls.Add(this.lblTimeTaken);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblChars);
            this.Controls.Add(this.tbChars);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lboxWords);
            this.Name = "formV2";
            this.Text = "formV2";
            this.Load += new System.EventHandler(this.formV2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeTaken;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblChars;
        private System.Windows.Forms.TextBox tbChars;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lboxWords;
    }
}