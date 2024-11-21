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
    /// Логика взаимодействия для Verificationv.xaml
    /// </summary>
    public partial class Verificationv : Page
    {
        public Verificationv()
        {
            InitializeComponent();
            VerLv.ItemsSource = App.pr1Entities.Verification.ToList();
        }

        private void VerAddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddVerification  addVerification = new AddVerification();
            addVerification.Show();
        }
    }
}
