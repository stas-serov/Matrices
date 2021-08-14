
namespace lab4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_size = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_b = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_a = new System.Windows.Forms.NumericUpDown();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_about_author = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_size);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_b);
            this.groupBox1.Controls.Add(this.numericUpDown_a);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrix range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Size:";
            // 
            // numericUpDown_size
            // 
            this.numericUpDown_size.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F);
            this.numericUpDown_size.Location = new System.Drawing.Point(39, 23);
            this.numericUpDown_size.Name = "numericUpDown_size";
            this.numericUpDown_size.Size = new System.Drawing.Size(57, 23);
            this.numericUpDown_size.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label2.Location = new System.Drawing.Point(5, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "A:";
            // 
            // numericUpDown_b
            // 
            this.numericUpDown_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_b.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F);
            this.numericUpDown_b.Location = new System.Drawing.Point(39, 90);
            this.numericUpDown_b.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_b.Name = "numericUpDown_b";
            this.numericUpDown_b.Size = new System.Drawing.Size(57, 23);
            this.numericUpDown_b.TabIndex = 2;
            // 
            // numericUpDown_a
            // 
            this.numericUpDown_a.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F);
            this.numericUpDown_a.Location = new System.Drawing.Point(39, 55);
            this.numericUpDown_a.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_a.Name = "numericUpDown_a";
            this.numericUpDown_a.Size = new System.Drawing.Size(57, 23);
            this.numericUpDown_a.TabIndex = 1;
            // 
            // button_generate
            // 
            this.button_generate.BackColor = System.Drawing.Color.Brown;
            this.button_generate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_generate.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.button_generate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_generate.Location = new System.Drawing.Point(145, 79);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(100, 34);
            this.button_generate.TabIndex = 2;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = false;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // button_about_author
            // 
            this.button_about_author.BackColor = System.Drawing.Color.Brown;
            this.button_about_author.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_about_author.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.button_about_author.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_about_author.Location = new System.Drawing.Point(145, 33);
            this.button_about_author.Name = "button_about_author";
            this.button_about_author.Size = new System.Drawing.Size(100, 34);
            this.button_about_author.TabIndex = 3;
            this.button_about_author.Text = "About_author";
            this.button_about_author.UseVisualStyleBackColor = false;
            this.button_about_author.Click += new System.EventHandler(this.button_about_author_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(253, 147);
            this.Controls.Add(this.button_about_author);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generating";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_a)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_b;
        private System.Windows.Forms.NumericUpDown numericUpDown_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_size;
        private System.Windows.Forms.Button button_about_author;
    }
}

