using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
using System.Xml.Linq;
using RACTICA_3.libraryDataSetTableAdapters;

namespace RACTICA_3
{

    public partial class MainWindow : Window
    {
        authorsTableAdapter authors = new authorsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            datagrid.ItemsSource = authors.GetData();
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            second window = new second();
            window.ShowDialog();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            object Athid = (datagrid.SelectedItem as DataRowView).Row[0];
            object AthName = (datagrid.SelectedItem as DataRowView).Row[1];
            object AthMail = (datagrid.SelectedItem as DataRowView).Row[2];
            authors.DeleteQuery(Convert.ToInt32(Athid), (string)AthName, (string)AthMail);
            datagrid.ItemsSource = authors.GetData();
        }
    }
}