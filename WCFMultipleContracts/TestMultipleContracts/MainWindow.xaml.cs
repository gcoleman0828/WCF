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

namespace TestMultipleContracts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ConsumeService1();
            ConsumedService2();
        }

        public void ConsumeService1()
        {
            using (ConsumedService.GetDataClient client = new ConsumedService.GetDataClient())
            {
                string returnedData = client.GetSomeData(5);
                
                MessageBox.Show(returnedData);
            }
        }

        public void ConsumedService2()
        {
            using (ConsumedService.DoMoreWorkClient client = new ConsumedService.DoMoreWorkClient())
            {
                string returnedData = client.DoMoreWork();

                MessageBox.Show(returnedData);
            }

        }

    }
}
