using System;
using System.Windows.Forms;
using System.IO;

namespace lab4
{
    public class Operations
    {
        /// <summary>
        /// method for generating matrix
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int[,] generate_matrix(int n, int a, int b)
        {
            Random rd = new Random();
            int[,] mt = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    mt[i, j] = rd.Next(a, b);
            return mt;
        }
        /// <summary>
        /// method for saving matrix
        /// </summary>
        /// <param name="mt"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool save_matrix(int[,] mt, int n)
        {
            string fname;
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Сохранить файл";
            save.InitialDirectory = "C:\\Users\\stass\\source\\repos\\lab4";
            save.Filter = "txt files (*.txt)|*.txt";
            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    fname = save.FileName;
                    FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter wr = new StreamWriter(fs);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            wr.WriteLine(mt[i, j]);
                    wr.Flush();
                    wr.Close();
                    fs.Close();
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение");
                return false;
            }
        }
        /// <summary>
        /// method for reading matrix
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[,] read_matrix(int n)
        {
            string fname = "";
            string[] s = new string[n * n];
            int[,] mt = new int[n, n];
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Открыть файл";
            open.InitialDirectory = "C:\\Users\\stass\\source\\repos\\lab4";
            open.Filter = "txt files (*.txt)|*.txt";
            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    fname = open.FileName;
                    s = File.ReadAllLines(fname);
                    int k = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            mt[i, j] = Convert.ToInt32(s[k]);
                            k++;
                        }
                    }
                    MessageBox.Show("Matrix was succesfully read", "Message");
                }
                else
                {
                    MessageBox.Show("Matrix wasn't read! Check data and try again!", "Error!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение");
            }
            return mt;
        }
        /// <summary>
        /// method for saving results
        /// </summary>
        /// <param name="res1"></param>
        /// <param name="res2"></param>
        /// <param name="res3"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool save_results(int[,] res1, int res2, int[,] res3, int n)
        {
            string fname;
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Сохранить файл";
            save.InitialDirectory = "C:\\Users\\stass\\source\\repos\\lab4";
            save.Filter = "txt files (*.txt)|*.txt";
            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    fname = save.FileName;
                    FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter wr = new StreamWriter(fs);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            wr.WriteLine(res1[i, j]);
                    wr.WriteLine(res2);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            wr.WriteLine(res3[i, j]);
                    wr.Flush();
                    wr.Close();
                    fs.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение");
                return false;
            }
        }
        /// <summary>
        /// method for reading results
        /// </summary>
        /// <param name="res1"></param>
        /// <param name="res2"></param>
        /// <param name="res3"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool read_results(ref int[,] res1, ref int res2, ref int[,] res3, int n)
        {
            string fname = "";
            string[] s = new string[n];
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Открыть файл";
            open.InitialDirectory = "C:\\Users\\stass\\source\\repos\\lab4";
            open.Filter = "txt files (*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.OK) fname = open.FileName;
            try
            {
                s = File.ReadAllLines(fname);
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        res1[i, j] = Convert.ToInt32(s[k]);
                        k++;
                    }
                }
                res2 = Convert.ToInt32(s[k]);
                k++;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        res3[i, j] = Convert.ToInt32(s[k]);
                        k++;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Сообщение");
                return false;
            }
        }
        /// <summary>
        /// method for sorting elements in rows of matrix
        /// </summary>
        /// <param name="mt"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[,] sort_rows(int[,] mt, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    for(int k = j + 1; k < n; k++)
                    {
                        if (mt[i, j] > mt[i, k])
                        {
                            int a = mt[i, j];
                            mt[i, j] = mt[i, k];
                            mt[i, k] = a;
                        }
                    }
                }
            }
            return mt;
        }
        /// <summary>
        /// method for searching element matrix by index
        /// </summary>
        /// <param name="mt"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public int determine_element(int [,] mt, int i, int j)
        {
            return mt[i, j];
        }
        /// <summary>
        /// method for calculating the sum of the elements of a matrix with the sum of indices divisible by 3
        /// </summary>
        /// <param name="mt"></param>
        /// <param name="g"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[,] sum_indexes_devisible_3(int [,] mt, int g, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if ((i + j) % 3 == 0) mt[i, j] *= g;
            return mt;
        }
    }
}
