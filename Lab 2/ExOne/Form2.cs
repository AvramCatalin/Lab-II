using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExOne
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label_username.Text = "Hello "+ Form1.UsernameGetter();
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
