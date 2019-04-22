using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyDatabase
{
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsUniv;
        DataSet dsFac;

        int numberOfFields=0;
        public Form1()
        {
            InitializeComponent();
            myCon.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=C:\Users\Catalin\Documents\GitHub\Lab-II\Lab 3\MyDatabase\Database1.mdf;
                                        Integrated Security = True";
            MyDataGridView();
            ListRefresh();
        }
        public void ListRefresh()
        {
            numberOfFields = 0;
            listBox_Univ.Items.Clear();
            textBox_City.Clear();
            textBox_CodeUniv.Clear();

            myCon.Open();
            dsUniv = new DataSet();
            dsFac = new DataSet();

            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            daFac.Fill(dsFac, "Facultati");
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                numberOfFields++;
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox_Univ.Items.Add(name);
            }

            myCon.Close();
        }
        DataTable table = new DataTable();
        public void MyDataGridView()
        {
            myCon.Open();
            //Creating the Data adapter
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Facultati", myCon))
            {
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            
            myCon.Close();
        }
        private void Button_update_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            try
            {
                SqlCommandBuilder cmdbl = new SqlCommandBuilder(adapter);
                adapter.Update(table);
            }
            catch (Exception)
            {
                MessageBox.Show("Cod invalid!");
            }
            ListRefresh();
        }
        
        private void ListBox_Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Fac.Items.Clear();
            textBox_City.Clear();
            int code = 0;
            String UnivSelected = null;
            try
            {
                    UnivSelected = listBox_Univ.SelectedItem.ToString();
            }
            catch (Exception)
            {

            }
            if(UnivSelected != null)
            {
                foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
                {
                    if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                    {
                        textBox_City.Text = dr.ItemArray.GetValue(2).ToString();
                        code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                        textBox_CodeUniv.Text = code.ToString();
                    }
                }
                foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
                {
                    if (code == Convert.ToInt16(dr.ItemArray.GetValue(1)))
                    {
                        String nameFac = dr.ItemArray.GetValue(2).ToString();
                        listBox_Fac.Items.Add(nameFac);
                    }
                }
            }
        }
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            myCon.Open();

            // Create the DeleteCommand.
            SqlCommand command = new SqlCommand("DELETE FROM Universitati WHERE [NameUniv] LIKE @name", myCon);

            String UnivSelected = null;
            try
            {
                UnivSelected = listBox_Univ.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecteaza o universitate!");
            }
            if(UnivSelected != null)
            {
                // Add the parameters for the DeleteCommand.
                SqlParameter parameter = command.Parameters.AddWithValue("@name", UnivSelected);
                parameter.SourceVersion = DataRowVersion.Original;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Universitatea are facultati, nu poate fi stearsa!\n");
                }
            }
            myCon.Close();

            ListRefresh();
        }
        private void Button_Modify_Click(object sender, EventArgs e)
        {
            myCon.Open();

            SqlCommand command = new SqlCommand("UPDATE Universitati SET NameUniv = @name, City = @city , Code = @code " +
                                                 "WHERE NameUniv LIKE @oldName", myCon);

            // Add the parameters for the UpdateCommand.
            command.Parameters.AddWithValue("@name", textBox_Name.Text);
            command.Parameters.AddWithValue("@city", textBox_ModCity.Text);
            command.Parameters.AddWithValue("@code", textBox_ModCodeUniv.Text);

            String UnivSelected = null;
            try
            {
                UnivSelected = listBox_Univ.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecteaza o universitate!");
            }
            if (UnivSelected != null)
            {
                SqlParameter parameter = command.Parameters.AddWithValue("@oldName", UnivSelected);
                parameter.SourceVersion = DataRowVersion.Original;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Optiune invalida");
                }
            }
            myCon.Close();

            ListRefresh();
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            myCon.Open();
            // Create the InsertCommand.
            SqlCommand command = new SqlCommand("INSERT into Universitati([Id],[NameUniv],[City],[Code]) values(@id, @name, @city, @code)", myCon);

            // Add the parameters for the InsertCommand.

            command.Parameters.AddWithValue("@id", numberOfFields);
            command.Parameters.AddWithValue("@name", textBox_Name.Text);
            command.Parameters.AddWithValue("@city", textBox_ModCity.Text);
            command.Parameters.AddWithValue("@code", textBox_ModCodeUniv.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Cod universitar invalid!");
            }
            
            myCon.Close();

            ListRefresh();
        }
    }
}