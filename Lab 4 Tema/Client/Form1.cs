﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        Client.ServiceReference1.WebService1SoapClient service = new Client.ServiceReference1.WebService1SoapClient();
        public Form1()
        {
            InitializeComponent();
            listBox_nume.DataSource = service.ShowDatabase();
        }
        private void ListBox_nume_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_weight.Clear();
            textBox_price.Clear();
            String PizzaSelected = null;
            try
            {
                PizzaSelected = listBox_nume.SelectedItem.ToString();
            }
            catch (Exception)
            {

            }
            if (PizzaSelected != null)
            {
                textBox_weight.Text = service.ShowWeight(PizzaSelected).ToString()+"g";
                textBox_price.Text = service.ShowPrice(PizzaSelected).ToString()+" lei";
                richTextBox_details.Text = service.ShowDetails(PizzaSelected).ToString();
            }
        }
    }
}
