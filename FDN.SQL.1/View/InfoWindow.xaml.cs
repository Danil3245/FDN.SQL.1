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
using System.Windows.Shapes;

namespace FDN.SQL._1.View
{
    public partial class InfoWindow : Window
    {
        private UserInfoEntities _db = new UserInfoEntities();
        public InfoWindow()
        {
            InitializeComponent();

            DGInfo.ItemsSource = _db.Users.ToList();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
    }
}


