using Pr1.View.Windows;
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


namespace Pr1.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Device.xaml
    /// </summary>
    public partial class Device : Page
    {
        public Device()
        {
            InitializeComponent();
            DeviceLv.ItemsSource = App.pr1Entities.Device.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
           AddDevice addDevice = new AddDevice();
           addDevice.Show();

        }
    }
}
