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

namespace Tema
{
    public partial class Form1 : Form
    {
        List<string> photoList = new List<string>();
        static string workingDirectory = Environment.CurrentDirectory;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
        public Form1()
        {
            InitializeComponent();
            string[] lines = System.IO.File.ReadAllLines(@projectDirectory + @"\List.txt");
            foreach (string line in lines)
            {
                photoList.Add(line);
            }
            listBox1.DataSource = photoList;
            progressBar1.Value += 25;
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
            Controls.Add(pictureBox1);
        }
        private bool BoxChecker()
        {
            bool boxCheker = false;
            foreach (RadioButton rdbtn in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rdbtn.Checked)
                {
                    boxCheker = true;
                    break;
                }
            }
            return boxCheker;
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = listBox1.SelectedItem.ToString();
            DisplayImage(selection);
        }
        bool jammer1 = true;
        bool jammer2 = true;
        bool accessGranted = false;
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime comparisonDate = DateTime.Now;
            comparisonDate = comparisonDate.AddYears(-18);
            DateTime selectedDate = dateTimePicker1.Value;

            int result = DateTime.Compare(selectedDate, comparisonDate);
            string age;
            if (result > 0)
            {
                age = "You Are Under 18!\nAccess Denied";
            }
            else 
            {
                if (result == 0)
                {
                    age = "You Are Exactly 18\nAccess Granted";
                }
                else
                {
                    age = "You Are over 18!\nAccess Granted";
                    accessGranted = true;
                }
            }
            label3.Text = age;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if(BoxChecker() && jammer1)
            {
                progressBar1.Value += 25;
                jammer1 = false;
            }
            if(accessGranted)
            {
                accessGranted = false;
                dateTimePicker1.Enabled = false;
                progressBar1.Value += 25;
            }
            if(checkBox1.Checked && jammer2)
            {
                jammer2 = false;
                checkBox1.Enabled = false;
                progressBar1.Value += 25;
            }
            if(progressBar1.Value == 100)
            {
                button2.Enabled = true;
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile created!");
        }
        
    }
}
