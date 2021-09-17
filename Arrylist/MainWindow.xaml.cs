using System;
using System.Collections;
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

namespace Arrylist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ArrayList Arr_lis;
        public MainWindow()
        {
            InitializeComponent();
            mainTextBox.Text = "";
            Arr_lis = new ArrayList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int data_in = Convert.ToInt32(mainTextBox.Text);
            Arr_lis.Add(data_in);
            mainTextBox.Text = "";
            //MessageBox.Show(Convert.ToString(data_in));
            //###################################################

            //Arr_lis.Add(10);
            //Arr_lis.Add(11);
            //Arr_lis.Add(12);
            //Arr_lis.Add(13);
            //Arr_lis.Add(99); 
            //Arr_lis.Add(33); 
            //Arr_lis.Add(50);
            ////Show data 

            //// foreach (int data in Arr_lis) MessageBox.Show(data.ToString());

            ////  count
            //MessageBox.Show(Arr_lis.Count.ToString());

            ////Remove ใส่ Object 
            ////Arr_lis.Remove(11);
            ////foreach (int data in Arr_lis) MessageBox.Show(data.ToString());

            ////Removeat ใส่ Index 
            ////Arr_lis.RemoveAt(2);
            ////foreach (int data in Arr_lis) MessageBox.Show(data.ToString());

            ////Array list sort   น้อยไป มาก 
            ////Arr_lis.Sort();
            ////foreach (int data in Arr_lis) MessageBox.Show(data.ToString());


            ////Array list Clear
            //Arr_lis.Clear();
            //foreach (int data in Arr_lis) MessageBox.Show(data.ToString());

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Show_all();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            int data_in = Convert.ToInt32(mainTextBox.Text);          
            Arr_lis.RemoveAt(data_in);
            Show_all();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int data_in = Convert.ToInt32(mainTextBox.Text);
            Arr_lis.Remove(data_in);
            Show_all();
        }
        public void Show_all()
        {
            mainTextBox.Text = "";
            string data_out = "";
            foreach (int data in Arr_lis)
            {
                data_out = data_out + " " + data.ToString() + "\n";
            }
            mainTextBox.Text = data_out;
        }

    }
}
