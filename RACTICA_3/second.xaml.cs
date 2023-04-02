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
using System.Windows.Shapes;
using System.Xml.Linq;
using RACTICA_3.libraryDataSetTableAdapters;

namespace RACTICA_3
{

    public partial class second : Window
    {
        booksTableAdapter books = new booksTableAdapter();
        public second()
        {
            InitializeComponent();
            datagrid2.ItemsSource = books.GetData();
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            object Original_book_id = (datagrid2.SelectedItem as DataRowView).Row[0];
            books.DeleteQuery(Convert.ToInt32(Original_book_id));
            datagrid2.ItemsSource = books.GetData();
        }
    }
}