using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"Login.txt");
            string username = lines[0];
            string password = lines[1];
            if(username==textBox_username.Text && password == passwordBox_password.Password)
            {
                Welcome welcome = new Welcome(username);
                welcome.Show();
                this.Close();
            }
        }
    }
}
