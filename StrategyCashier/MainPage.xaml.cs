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

//策略模式和简单工厂模式很相似，两者得主要区别在于用途不一样。
//工厂是创建型模式，他的主要作用是创建对象，也就是在比如做界面和逻辑分离时，减少耦合，在界面相关的类中一两行代码就把条件判断啊，算法实现啊，业务啊全扔到工厂去搞，界面只管界面的事情。其它的减少耦合可能都是这种创建型模式的专利。
//策略模式是行为型模式，他的主要作用在于你可以随意选择一种行为，什么个意思，比如我针对这个算总价设计了两个按钮，我按第一个按钮是打折，按第二个按钮是返现。这没办法去分离吧，我肯定有两个Click事件，当然都用工厂搞也可以，但是代码重复了，就显得不高端，我在这也createFactory一下，在那个方法里也createFactory一下。而且，我还要去工厂里判断一下，这样增加运算成本。第三，我在界面代码里还没办法直接看出我这个算法用了哪个类，时间久了我还得自己去工厂里看一下我怎么判断的。这时候策略模式就高端了。你不要小看高端这个词，设计模式大都时候就是为了让你的代码看起来高端的。

