using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form3 : Form
    {
        Operations operations = new Operations();
        Matrix matrix;
        /// <summary>
        /// constructor with parameters for the range and size of the matrix
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Form3(int n, int a, int b)
        {
            InitializeComponent();
            matrix = new Matrix(n, a, b);
            matrix.mas = operations.generate_matrix(n, a, b);
        }
        /// <summary>
        /// metrod for loading third form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3_Load(object sender, EventArgs e)
        {
            numericUpDown_i.Enabled = false;
            numericUpDown_j.Enabled = false;
            numericUpDown_g.Enabled = false;
            button_read_matrix.Enabled = false;
            button_save_results.Enabled = false;
            button_read_results.Enabled = false;
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = matrix.n;
            dataGridView1.RowCount = matrix.n;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Width = 30;
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    dataGridView1.Rows[i].Cells[j].Value = matrix.mas[i, j];
        }
        /// <summary>
        /// button "read matrix" click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_read_matrix_Click(object sender, EventArgs e)
        {
            matrix.mas = operations.read_matrix(matrix.n);
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = matrix.n;
            dataGridView1.RowCount = matrix.n;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Width = 30;
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    dataGridView1.Rows[i].Cells[j].Value = matrix.mas[i, j];
        }
        /// <summary>
        /// button "calculate" click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_calculate_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (checkBox1.Checked)
            {
                matrix.res1 = operations.sort_rows((int[,])matrix.mas.Clone(), matrix.n);
                richTextBox1.Text += "Matrix with ascending sorted rows:" + "\n";
                for(int i = 0; i < matrix.n; i++)
                {
                    for (int j = 0; j < matrix.n; j++)
                    {
                        richTextBox1.Text += matrix.res1[i,j].ToString() + " ";
                    }
                    richTextBox1.Text +="\n";
                }
            }
            if (checkBox2.Checked)
            {
                if (((int)numericUpDown_i.Value < matrix.n) && ((int)numericUpDown_j.Value < matrix.n) && ((int)numericUpDown_i.Value >= 0) && ((int)numericUpDown_j.Value >= 0))
                {
                    matrix.res2 = operations.determine_element((int[,])matrix.mas.Clone(), (int)numericUpDown_i.Value, (int)numericUpDown_j.Value);
                    richTextBox1.Text += "Element at the (" + numericUpDown_i.Value.ToString() + "," + numericUpDown_j.Value.ToString() + ")-th place:" + matrix.res2.ToString() + "\n";
                }
                else MessageBox.Show("Incorrect value! (0 < i < " + matrix.n.ToString() + ") (0 < j < " + matrix.n.ToString() + ")");
            }
            if(checkBox3.Checked)
            {
                matrix.res3 = operations.sum_indexes_devisible_3((int[,])matrix.mas.Clone(), (int)numericUpDown_g.Value, matrix.n);
                richTextBox1.Text += "Matrix with elements, with sum of indices divisible by 3, multiplied by (-g):" + "\n";
                for (int i = 0; i < matrix.n; i++)
                {
                    for (int j = 0; j < matrix.n; j++)
                    {
                        richTextBox1.Text += matrix.res3[i, j].ToString() + " ";
                    }
                    richTextBox1.Text += "\n";
                }
            }
            button_save_results.Enabled = true;
        }
        /// <summary>
        /// button "save matrix" click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_save_matrix_Click(object sender, EventArgs e)
        {
            if (operations.save_matrix(matrix.mas, matrix.n))
            {
                MessageBox.Show("Matrix was succesfully saved", "Message");
                button_read_matrix.Enabled = true;
            }
            else MessageBox.Show("Matrix wasn't saved! Check data and try again!", "Error!");
        }
        /// <summary>
        /// button "save results" click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_save_results_Click(object sender, EventArgs e)
        {
            if (operations.save_results(matrix.res1, matrix.res2, matrix.res3, matrix.n))
            {
                MessageBox.Show("Results was succesfully saved", "Message");
                button_read_results.Enabled = true;
            }
            else MessageBox.Show("Results wasn't saved! Check data and try again!", "Error!");
        }
        /// <summary>
        /// button "read results" click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_read_results_Click(object sender, EventArgs e)
        {
            if (operations.read_results(ref matrix.res1, ref matrix.res2, ref matrix.res3, matrix.n))
            {
                richTextBox1.Clear();
                richTextBox1.Text += "Matrix with ascending sorted rows:" + "\n";
                for (int i = 0; i < matrix.n; i++)
                {
                    for (int j = 0; j < matrix.n; j++)
                    {
                        richTextBox1.Text += matrix.res1[i, j].ToString() + " ";
                    }
                    richTextBox1.Text += "\n";
                }
                richTextBox1.Text += "Element at the (" + numericUpDown_i.Value.ToString() + "," + numericUpDown_j.Value.ToString() + ")-th place:" + matrix.res2.ToString() + "\n";
                richTextBox1.Text += "Matrix with elements, with sum of indices divisible by 3, multiplied by (-g):" + "\n";
                for (int i = 0; i < matrix.n; i++)
                {
                    for (int j = 0; j < matrix.n; j++)
                    {
                        richTextBox1.Text += matrix.res3[i, j].ToString() + " ";
                    }
                    richTextBox1.Text += "\n";
                }
                MessageBox.Show("Results was read", "Message");
            }
            else MessageBox.Show("Results wasn't read! Check data and try again!", "Error!");
        }
        /// <summary>
        /// checkBox2 CheckChanged event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                numericUpDown_i.Enabled = true;
                numericUpDown_j.Enabled = true;
            }
            else
            {
                numericUpDown_i.Enabled = false;
                numericUpDown_j.Enabled = false;
            }
        }
        /// <summary>
        /// checkbox3 CheckChanged event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) numericUpDown_g.Enabled = true;
            else numericUpDown_g.Enabled = false;
        }
    }
}
