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

namespace Cdc.Covid.WebScraper.UI
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

        private void ReportsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ReportViewModel vm = this.DataContext as ReportViewModel;
            if (vm != null)
            {
                var state = e.AddedItems[0] as StateReport;
                vm.SelectedReport = state;
            }
        }
    }
}
