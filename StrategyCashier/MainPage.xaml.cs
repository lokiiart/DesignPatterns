using StrategyCashier.StrategyCashContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StrategyCashier
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string cashType;
        private double total;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void UnitAdd(object sender, RoutedEventArgs e)
        {
            CashContext cc = null;
            switch(cashType)
            {
                case "CashNormal":
                    cc = new CashContext(new CashNormal());
                    break;

            }


            double totalPrice = 0d;
            totalPrice = cc.GetResult(Convert.ToDouble(UnitPrice.Text) * Convert.ToDouble(Quantity.Text));
            total = total + totalPrice;
            ShoppingList.Items.Add("单价" + UnitPrice.Text + " 数量" + Quantity.Text + cashType + "总计: " + totalPrice.ToString());
            TotalCost.Text = total.ToString();
        }

        private void CashWay_Checked(object sender, RoutedEventArgs e)
        {

            if (sender is RadioButton rb)
            {
                cashType = rb.Tag.ToString();
            }

        }
    }
}
