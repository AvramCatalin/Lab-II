using System;
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
    public partial class Form2 : Form
    {
        Client.ServiceReference1.WebService1SoapClient service = new Client.ServiceReference1.WebService1SoapClient();
        DataTable table = new DataTable() { TableName = "MyClientTable" };
        public Form2()
        {
            InitializeComponent();
            table = service.ShowDatabase();
            dataGridView1.DataSource = table;
            //Hides the first column, (PizzaId)
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            String message;
            message = service.UpdateDatabase(table);
            MessageBox.Show(message);
            this.Close();
        }
    }
}
