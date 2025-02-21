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

namespace jogging_feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Text = openFileDialog1.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public List<string[]>Lista = new List<string[]>();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox1.Text = "Afrika";
                listBox1.Items.Clear();
                Lista.Clear();
                StreamReader sr = new StreamReader("forras_afrika.txt");
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    Lista.Add(sor);
                    listBox1.Items.Add(sor[0]);
                }
                sr.Close();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                comboBox1.Text = "Ázsia";
                listBox1.Items.Clear();
                Lista.Clear();
                StreamReader sr = new StreamReader("forras_azsia.txt");
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor1 = sr.ReadLine().Split(';');
                    Lista.Add(sor1);
                    listBox1.Items.Add(sor1[0]);
                }
                sr.Close();
            }
            else if (comboBox1.SelectedIndex == 2) 
            {
                comboBox1.Text = "Európa";
                listBox1.Items.Clear();
                Lista.Clear();
                StreamReader sr = new StreamReader("forras_europa.txt");
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor2 = sr.ReadLine().Split(';');
                    Lista.Add(sor2);
                    listBox1.Items.Add(sor2[0]);
                }
                sr.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = $"Ország: {Lista[listBox1.SelectedIndex][0]} \nFőváros: {Lista[listBox1.SelectedIndex][1]} \nTerület (km2): {Lista[listBox1.SelectedIndex][2]} \nNépesség: {Lista[listBox1.SelectedIndex][3]} \nNépsűrűség (fő/km): {Lista[listBox1.SelectedIndex][4]}";
        }
    }
}
