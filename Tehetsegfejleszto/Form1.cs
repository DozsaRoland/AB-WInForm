using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehetsegfejleszto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.szakmak' table. You can move, or remove it, as needed.
            this.szakmakTableAdapter.Fill(this.database1DataSet.szakmak);
            // TODO: This line of code loads data into the 'database1DataSet.gyermekek' table. You can move, or remove it, as needed.
            this.gyermekekTableAdapter.Fill(this.database1DataSet.gyermekek);
            // TODO: This line of code loads data into the 'database1DataSet.foglalkozasok' table. You can move, or remove it, as needed.
            this.foglalkozasokTableAdapter.Fill(this.database1DataSet.foglalkozasok);
            // TODO: This line of code loads data into the 'database1DataSet.fejlesztok' table. You can move, or remove it, as needed.
            this.fejlesztokTableAdapter.Fill(this.database1DataSet.fejlesztok);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = Path.Combine(
                folderBrowserDialog1.SelectedPath,
                $"tehetseg-{DateTime.Now:yyyy-MM-dd_HH-mm}.csv");
            File.WriteAllLines(fileName,
                database1DataSet.fejlesztok.Select(x => String.Join(";", x.ItemArray))
                );
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

