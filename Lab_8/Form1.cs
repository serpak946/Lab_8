using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        int[][] arr = new int[15][];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15;
            dataGridView1.ColumnCount = 15;
            
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                int [] temp_arr = new int[15];
                for (int j = 0; j < 15; j++)
                {
                    arr[i] = new int[15];
                    temp_arr[j] = random.Next(-20,20);
                    arr[i] = temp_arr;
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].GetLength(0); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[i][j];
                }
            }
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            dataGridView2.RowCount = 15;
            dataGridView2.ColumnCount = 2;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = i+1;
                dataGridView2.Rows[i].Cells[1].Value = Math.Round(arr[i].Average(), 3);
            }
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoResizeRows();
        }
    }
}
