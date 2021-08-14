
namespace lab4
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_i = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_j = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_g = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button_save_matrix = new System.Windows.Forms.Button();
            this.button_read_matrix = new System.Windows.Forms.Button();
            this.button_save_results = new System.Windows.Forms.Button();
            this.button_read_results = new System.Windows.Forms.Button();
            this.button_calculate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_j)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_g)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(27, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source matrix";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(206, 174);
            this.dataGridView1.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(27, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(5, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(365, 23);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Determine the element of the array located at the (i, j) -th place";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(5, 69);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(390, 23);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Array elements with the sum of indices divisible by 3 multiply by (-g)";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(5, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(278, 23);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Sort array elements in ascending order in rows";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(5, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(206, 174);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(360, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 198);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(433, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "i :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(504, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "j :";
            // 
            // numericUpDown_i
            // 
            this.numericUpDown_i.Location = new System.Drawing.Point(448, 272);
            this.numericUpDown_i.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_i.Name = "numericUpDown_i";
            this.numericUpDown_i.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_i.TabIndex = 8;
            // 
            // numericUpDown_j
            // 
            this.numericUpDown_j.Location = new System.Drawing.Point(518, 272);
            this.numericUpDown_j.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_j.Name = "numericUpDown_j";
            this.numericUpDown_j.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_j.TabIndex = 9;
            // 
            // numericUpDown_g
            // 
            this.numericUpDown_g.Location = new System.Drawing.Point(448, 302);
            this.numericUpDown_g.Name = "numericUpDown_g";
            this.numericUpDown_g.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_g.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(431, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "g :";
            // 
            // button_save_matrix
            // 
            this.button_save_matrix.BackColor = System.Drawing.Color.Brown;
            this.button_save_matrix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_save_matrix.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.button_save_matrix.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_save_matrix.Location = new System.Drawing.Point(10, 23);
            this.button_save_matrix.Name = "button_save_matrix";
            this.button_save_matrix.Size = new System.Drawing.Size(86, 28);
            this.button_save_matrix.TabIndex = 12;
            this.button_save_matrix.Text = "Save matrix";
            this.button_save_matrix.UseVisualStyleBackColor = false;
            this.button_save_matrix.Click += new System.EventHandler(this.button_save_matrix_Click);
            // 
            // button_read_matrix
            // 
            this.button_read_matrix.BackColor = System.Drawing.Color.Brown;
            this.button_read_matrix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_read_matrix.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.button_read_matrix.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_read_matrix.Location = new System.Drawing.Point(10, 56);
            this.button_read_matrix.Name = "button_read_matrix";
            this.button_read_matrix.Size = new System.Drawing.Size(86, 28);
            this.button_read_matrix.TabIndex = 13;
            this.button_read_matrix.Text = "Read matrix";
            this.button_read_matrix.UseVisualStyleBackColor = false;
            this.button_read_matrix.Click += new System.EventHandler(this.button_read_matrix_Click);
            // 
            // button_save_results
            // 
            this.button_save_results.BackColor = System.Drawing.Color.Brown;
            this.button_save_results.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_save_results.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.button_save_results.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_save_results.Location = new System.Drawing.Point(10, 89);
            this.button_save_results.Name = "button_save_results";
            this.button_save_results.Size = new System.Drawing.Size(86, 28);
            this.button_save_results.TabIndex = 14;
            this.button_save_results.Text = "Save results";
            this.button_save_results.UseVisualStyleBackColor = false;
            this.button_save_results.Click += new System.EventHandler(this.button_save_results_Click);
            // 
            // button_read_results
            // 
            this.button_read_results.BackColor = System.Drawing.Color.Brown;
            this.button_read_results.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_read_results.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.button_read_results.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_read_results.Location = new System.Drawing.Point(10, 122);
            this.button_read_results.Name = "button_read_results";
            this.button_read_results.Size = new System.Drawing.Size(86, 28);
            this.button_read_results.TabIndex = 15;
            this.button_read_results.Text = "Read results";
            this.button_read_results.UseVisualStyleBackColor = false;
            this.button_read_results.Click += new System.EventHandler(this.button_read_results_Click);
            // 
            // button_calculate
            // 
            this.button_calculate.BackColor = System.Drawing.Color.Brown;
            this.button_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_calculate.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.button_calculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_calculate.Location = new System.Drawing.Point(10, 155);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(86, 28);
            this.button_calculate.TabIndex = 16;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = false;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_calculate);
            this.groupBox4.Controls.Add(this.button_read_results);
            this.groupBox4.Controls.Add(this.button_save_results);
            this.groupBox4.Controls.Add(this.button_read_matrix);
            this.groupBox4.Controls.Add(this.button_save_matrix);
            this.groupBox4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(248, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(106, 197);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(663, 390);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.numericUpDown_g);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_j);
            this.Controls.Add(this.numericUpDown_i);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_j)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_g)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_i;
        private System.Windows.Forms.NumericUpDown numericUpDown_j;
        private System.Windows.Forms.NumericUpDown numericUpDown_g;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_save_matrix;
        private System.Windows.Forms.Button button_read_matrix;
        private System.Windows.Forms.Button button_save_results;
        private System.Windows.Forms.Button button_read_results;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}