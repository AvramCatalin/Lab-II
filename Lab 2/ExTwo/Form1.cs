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

namespace ExTwo
{
    public partial class Form1 : Form
    {
        List<string> fruitList = new List<string>();
        List<string> fruitList2 = new List<string>();
        public Form1()
        {
            InitializeComponent();
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string[] lines = System.IO.File.ReadAllLines(@projectDirectory + @"\List.txt");
            foreach(string line in lines)
            {
                fruitList.Add(line);
            }
            listBox1.DataSource = fruitList;
        }
        private void Button_copy_Click(object sender, EventArgs e)
        {
            //copy the contents of the first List to the second
            fruitList2 = listBox1.SelectedItems.Cast<string>().ToList();
            //link fruitList2 to the listBox2 data source
            listBox2.DataSource = fruitList2;
        }
        private void Button_sterge_Click(object sender, EventArgs e)
        {
            //clear the List
            fruitList2.Clear();
            //clear the ListBox
            listBox2.DataSource = null;
        }
        private void Button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
