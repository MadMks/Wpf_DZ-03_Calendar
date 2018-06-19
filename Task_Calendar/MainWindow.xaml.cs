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

namespace Task_Calendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int currentMonth = DateTime.Today.Month;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void treeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

            switch ((treeView.SelectedItem as TreeViewItem).Header.ToString())
            {
                case "Декабрь":
                    currentMonth = 12;
                    break;
                case "Январь":
                    currentMonth = 1;
                    break;
                case "Февраль":
                    currentMonth = 2;
                    break;
                case "Март":
                    currentMonth = 3;
                    break;
                case "Апрель":
                    currentMonth = 4;
                    break;
                case "Май":
                    currentMonth = 5;
                    break;
                case "Июнь":
                    currentMonth = 6;
                    break;
                case "Июль":
                    currentMonth = 7;
                    break;
                case "Август":
                    currentMonth = 8;
                    break;
                case "Сентябрь":
                    currentMonth = 9;
                    break;
                case "Октябрь":
                    currentMonth = 10;
                    break;
                case "Ноябрь":
                    currentMonth = 11;
                    break;
                default:
                    break;
            }

            this.calendarListView.DisplayDate = new DateTime(DateTime.Today.Year, currentMonth, DateTime.Today.Day);
        }
    }
}
