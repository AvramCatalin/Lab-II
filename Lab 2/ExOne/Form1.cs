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

namespace ExOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static String username;
        private void Button_login_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string[] lines = System.IO.File.ReadAllLines(@projectDirectory+@"\login.txt");
            if(textBox_user.Text == lines[0] && textBox_pass.Text == lines[1])
            {
                username = textBox_user.Text;
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login!");
            }
        }
        public static String UsernameGetter()
        {
            return username;
        }
    }
}
