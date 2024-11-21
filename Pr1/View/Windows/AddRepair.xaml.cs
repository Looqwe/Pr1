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

namespace Pr1.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddRepair.xaml
    /// </summary>
    public partial class AddRepair : Window
    {
        public AddRepair()
        {
            InitializeComponent();
        }

        private void AddSize_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order()
            {
                Number = Convert.ToInt32(NumberOrderTb.Text),
                Date = DateTime.Now,
                PlanDate = (DateTime)DateDp.SelectedDate,
                TitleOrder = NameOrdertb.Text,
                СustomerId = 3,
                StatusId = 1,
                ResponsibleManagerId = 1,
                Sceheme = null,
                ProductOrder = orderProd.Select(sp => new ProductOrder
                {
                    ProductId = sp.Product.Id,
                    Size = sp.Size,

                }
               ).ToList(),

            };

            App.context.Order.Add(order);
            App.context.SaveChanges();

            Feedback.Information("Заказ добавлен");

            DialogResult = true;
            Close();
        }
    }
}
