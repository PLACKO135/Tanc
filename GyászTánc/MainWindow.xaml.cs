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

namespace GyászTánc
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

        private void txtferfi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
            {
                lbferfi.Items.Add(txtferfi.Text);
                txtferfi.Text = "";
            }
        }

        private void txtno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                lbno.Items.Add(txtno.Text);
                txtno.Text = "";
            }
           
        }

        private void btnmix_Click(object sender, RoutedEventArgs e)
        {
            int tancparok=0;
            if (lbferfi.Items.Count > lbno.Items.Count)
            {
                 tancparok = lbno.Items.Count;
            }
            else
            {
                tancparok = lbferfi.Items.Count;
            }

            Random r = new Random();

            for (int i = 0; i < tancparok; i++)
            {
                int ferfi=r.Next(0,tancparok-1);
                int no =r.Next(0,tancparok-1);

                lberedmeny.Items.Add($"{lbferfi.Items[ferfi]} + {lbno.Items[no]}");
                lbferfi.Items.RemoveAt(ferfi);
                lbno.Items.RemoveAt(no);
            }
           
        }
    }
}
