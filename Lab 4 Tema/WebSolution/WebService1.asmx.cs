﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Hosting;

namespace WebSolution
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        DataSet dsPizza;
        static string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=|DataDirectory|Database1.mdf;
                                        Integrated Security = True";
        static SqlConnection DataConnection = new SqlConnection(Connection);

        [WebMethod]
        public List<String> ShowMenu()
        {
            DataConnection.Open();
            dsPizza = new DataSet();

            var names = new List<String>();
            SqlDataAdapter daPizza = new SqlDataAdapter("SELECT * FROM Pizza", DataConnection);
            daPizza.Fill(dsPizza, "Pizza");
            foreach (DataRow dr in dsPizza.Tables["Pizza"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                names.Add(name);
            }
            DataConnection.Close();
            return names;
        }
        [WebMethod]
        public float ShowWeight(String PizzaSelected)
        {
            dsPizza = new DataSet();
            SqlDataAdapter daPizza = new SqlDataAdapter("SELECT * FROM Pizza", DataConnection);
            daPizza.Fill(dsPizza, "Pizza");
            foreach (DataRow dr in dsPizza.Tables["Pizza"].Rows)
            {
                if (PizzaSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    return Convert.ToInt16(dr.ItemArray.GetValue(3));
                }
            }
            return 0f;
        }
        [WebMethod]
        public float ShowPrice(String PizzaSelected)
        {
            dsPizza = new DataSet();
            SqlDataAdapter daPizza = new SqlDataAdapter("SELECT * FROM Pizza", DataConnection);
            daPizza.Fill(dsPizza, "Pizza");
            foreach (DataRow dr in dsPizza.Tables["Pizza"].Rows)
            {
                if (PizzaSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    return (float)(dr.ItemArray.GetValue(4));
                }
            }
            return 0f;
        }
        [WebMethod]
        public String ShowDetails(String PizzaSelected)
        {
            dsPizza = new DataSet();
            SqlDataAdapter daPizza = new SqlDataAdapter("SELECT * FROM Pizza", DataConnection);
            daPizza.Fill(dsPizza, "Pizza");
            foreach (DataRow dr in dsPizza.Tables["Pizza"].Rows)
            {
                if (PizzaSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    return dr.ItemArray.GetValue(2).ToString();
                }
            }
            return "error occured";
        }
        DataTable table = new DataTable() { TableName = "MyServerTable" };
        [WebMethod]
        public DataTable ShowDatabase()
        {
            DataConnection.Open();
            //Creating the Data adapter
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pizza", DataConnection))
            {
                adapter.Fill(table);
                DataConnection.Close();
                return table;
            }
        }
        [WebMethod]
        public String UpdateDatabase(DataTable newTable)
        {
            table = newTable;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Pizza", DataConnection);
            try
            {
                SqlCommandBuilder cmdbl = new SqlCommandBuilder(adapter);
                adapter.Update(table);
            }
            catch (Exception)
            {
                return "There was an error proccesing the command!";
            }
            return "Done!";
        }
    }
}