using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// constructor with default parameters
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ToolTip tip = new ToolTip();
            tip.SetToolTip(button_about_author, "Show information about developer");
            tip.SetToolTip(button_generate, "Open separate form to work with matrix");
        }
        /// <summary>
        /// method for loading first form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        /// <summary>
        /// button "about author" click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_about_author_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        /// <summary>
        /// button "generate" click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_generate_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown_size.Value < 1 || (int)numericUpDown_a.Value > (int)numericUpDown_b.Value)
            {
                MessageBox.Show("Incorrect input data. Please, check data and try again!", "Error!");
            }
            else
            {
                Form3 f3 = new Form3((int)numericUpDown_size.Value, (int)numericUpDown_a.Value, (int)numericUpDown_b.Value);
                f3.ShowDialog();
            }
        }
    }
}
