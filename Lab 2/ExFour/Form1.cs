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

namespace ExFour
{
    public partial class Form1 : Form
    {
        List<string> fruitList = new List<string>();
        static string workingDirectory = Environment.CurrentDirectory;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
        public Form1()
        {
            InitializeComponent();
            string[] lines = System.IO.File.ReadAllLines(@projectDirectory + @"\List.txt");
            foreach (string line in lines)
            {
                fruitList.Add(line);
            }
            listBox1.DataSource = fruitList;
        }
        private void DisplayImage(string picName)
        {
            pictureBox1.Width = 300;
            pictureBox1.Height = 300;
            Bitmap image = null;
            try
            {
                image = new Bitmap(projectDirectory + @"\pics\" + picName + ".jpg");
            }
            catch (Exception)
            {
                MessageBox.Show("Image not found!");
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = (Image)image;
            tabControl.TabPages[0].Controls.Add(pictureBox1);
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = listBox1.SelectedItem.ToString();
            DisplayImage(selection);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            bool adjectiveCheck = false;
            string adjective = null;
            foreach (RadioButton rdbtn in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rdbtn.Checked)
                {
                    adjectiveCheck = true;
                    adjective = rdbtn.Text;
                    break;
                }
            }
            if (!adjectiveCheck)
            {
                MessageBox.Show("No option selected from the Adjective column!");
            }
            bool nounCheck = false;
            string noun = null;
            foreach (RadioButton rdbtn in groupBox2.Controls.OfType<RadioButton>())
            {
                if (rdbtn.Checked)
                {
                    nounCheck = true;
                    noun = rdbtn.Text;
                    break;
                }
            }
            if (!nounCheck)
            {
                MessageBox.Show("No option selected from the Noun column!");
            }
            if(nounCheck && adjectiveCheck)
            {
                MessageBox.Show("Hello " + adjective + " " + noun);
            }

        }
    }
}
