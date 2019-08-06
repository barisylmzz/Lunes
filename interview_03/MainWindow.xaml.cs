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

namespace interview_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GelirGiderLunesEntities1 db;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new GelirGiderLunesEntities1();
            lstv.ItemsSource = db.GelirGiders.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GelirGider gelirGider = new GelirGider();
            gelirGider.GelirGiderİsmi = txtIsim.Text;
            decimal _tutar;
            bool result = decimal.TryParse(txtTutar.Text, out _tutar);
            if(result)
            {
                gelirGider.Tutar = _tutar;
            }
            else
            {
                throw new Exception();
            }

            if(cbgelir.IsChecked==true && cbgider.IsChecked==false)
            {
                gelirGider.Tip = false;
            }
            else if(cbgelir.IsChecked == false && cbgider.IsChecked == true)
            {
                gelirGider.Tutar = (-1) * gelirGider.Tutar;  
                gelirGider.Tip = true;
            }
            else
            {
                throw new Exception();
            }
            db.GelirGiders.Add(gelirGider);
            db.SaveChanges();
            lstv.ItemsSource = db.GelirGiders.ToList();
        }

        private void TxtTutar_Error(object sender, ValidationErrorEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var silinecek = db.GelirGiders.Where(a => a.GelirGiderİsmi == txtIsim.Text).FirstOrDefault();
            db.GelirGiders.Remove(silinecek);
            db.SaveChanges();
            lstv.ItemsSource = db.GelirGiders.ToList();
        }

        
    }
}
