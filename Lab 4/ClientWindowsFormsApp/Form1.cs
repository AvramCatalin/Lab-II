using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_AddList_Click(object sender, EventArgs e)
        {
            ClientWindowsFormsApp.ServiceReference1.WebService1SoapClient service = new ClientWindowsFormsApp.ServiceReference1.WebService1SoapClient();
            var list = new List<int>();
            list = service.ReturnList();
            listBox1.DataSource = list;
        }
        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            ClientWindowsFormsApp.ServiceReference1.WebService1SoapClient service = new ClientWindowsFormsApp.ServiceReference1.WebService1SoapClient();
            label_Data.Text = service.CurrentDateTime();
        }
        private void Button_Exchange_Click(object sender, EventArgs e)
        {
            ClientWindowsFormsApp.ServiceReference1.WebService1SoapClient service = new ClientWindowsFormsApp.ServiceReference1.WebService1SoapClient();
            float sum = 0f;
            bool option = true;
            try
            {
                sum = float.Parse(textBox_ExchangeInput.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Valoarea data nu este valida!");
                option = false;
            }
            if(option)
            {
                sum = service.ConvertMoney(sum, 'R');
                textBox_ExchangeOutput.Text = sum.ToString("N3");
            }
        }
        private void Button_CtoF_Click(object sender, EventArgs e)
        {
            ClientWindowsFormsApp.ServiceReference1.WebService1SoapClient service = new ClientWindowsFormsApp.ServiceReference1.WebService1SoapClient();
            float temp = 0f;
            bool option = true;
            try
            {
                temp = float.Parse(textBox_TempC.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Valoarea data nu este valida!");
                option = false;
            }
            if (option)
            {
                temp = service.ConvertDegrees(temp, 'F');
                textBox_TempRezultat.Text = (temp.ToString("N3") + " F\u00B0");
            }
        }
        private void Button_FtoC_Click(object sender, EventArgs e)
        {
            ClientWindowsFormsApp.ServiceReference1.WebService1SoapClient service = new ClientWindowsFormsApp.ServiceReference1.WebService1SoapClient();
            float temp = 0f;
            bool option = true;
            try
            {
                temp = float.Parse(textBox_TempF.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Valoarea data nu este valida!");
                option = false;
            }
            if (option)
            {
                temp = service.ConvertDegrees(temp, 'C');
                textBox_TempRezultat.Text = (temp.ToString("N3") + " C\u00B0");
            }
        }
    }
}
